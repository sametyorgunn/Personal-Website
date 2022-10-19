using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SametYorgun.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SametYorgun.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class YonetimController : Controller
    {
        private readonly IWebHostEnvironment _webhost;

        public YonetimController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult KisiselBilgiler()
        {
            using(var c = new Context())
            {
                var bilgiler = c.kisiselBilgis.FirstOrDefault();
                return View(bilgiler);
            }
         
        }
        [HttpPost]
        public async Task<IActionResult> KisiselBilgiler(KisiselBilgi bilgi)
        {
            Context c = new Context();
                          
            string wwwRootPath = _webhost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(bilgi.Cv.FileName);

            string extension = Path.GetExtension(bilgi.Cv.FileName);

            string filename0 = Path.GetFileNameWithoutExtension(bilgi.ProfilResim.FileName);
            string extension0 = Path.GetExtension(bilgi.ProfilResim.FileName);

            bilgi.CvYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            bilgi.ProfilResimYol = filename0 = filename0 + DateTime.Now.ToString("yymmssfff") + extension0;

            string path0 = Path.Combine(wwwRootPath + "/kisisel/images/cv", filename);
            string path = Path.Combine(wwwRootPath + "/kisisel/images/about", filename0);

            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await bilgi.ProfilResim.CopyToAsync(filestream);
            }
            using (var filestream = new FileStream(path0, FileMode.Create))
            {
                await bilgi.Cv.CopyToAsync(filestream);
            }
            c.kisiselBilgis.Update(bilgi);
            c.SaveChanges();
            //return RedirectToRoute(new { action = "KisiselBilgiler", controller = "Yonetim", area = "Admin" });

            //Response.Redirect("/Admin/Yonetim/Index", true);
            return Redirect("/Admin/Yonetim/KisiselBilgiler");
                
        
            
        }

        public IActionResult Blog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Blog(Blog blog)
        {
            using(var c = new Context())
            {
                string wwwRootPath = _webhost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(blog.BlogResim.FileName);
                string extension = Path.GetExtension(blog.BlogResim.FileName);
                blog.BlogResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/kisisel/images/blog_images/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await blog.BlogResim.CopyToAsync(filestream);
                }

                blog.Status = true;
                blog.BlogTarihi = DateTime.Now.ToShortDateString();

                c.blogs.Add(blog);
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/Blog");
            }
        }

        public IActionResult Hakkimda()
        {
            using(var c = new Context())
            {
                var hakkimda = c.hakkimdas.FirstOrDefault();
                return View(hakkimda);
            }
            
        }
        [HttpPost]
        public IActionResult Hakkimda(Hakkimda hak)
        {
            using (var c = new Context())
            {
                c.hakkimdas.Update(hak);
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/Hakkimda");
            }

        }

        public IActionResult Proje()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Proje(Projeler p)
        {
            using(var c = new Context())
            {
                string wwwRootPath = _webhost.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(p.ProjeResim.FileName);
                string extension = Path.GetExtension(p.ProjeResim.FileName);
                p.ProjeResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/kisisel/images/project", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await p.ProjeResim.CopyToAsync(filestream);
                }
                p.Status = true;
                
                c.projelers.Add(p);
                c.SaveChanges();
                return RedirectToAction("Proje", "Yonetim", new { Areas = "Admin" });

            }
        }

        public IActionResult BlogListele()
        {
            using (var c = new Context())
            {
                var blog = c.blogs.ToList();
                return View(blog);

            }
        }
        public IActionResult BlogPasifYap(int id)
        {
            using(var c = new Context())
            {
                var blog = c.blogs.Find(id);
                blog.Status = false;
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/BlogListele");
            }
        }
        public IActionResult BlogAktifYap(int id)
        {
            using (var c = new Context())
            {
                var blog = c.blogs.Find(id);
                blog.Status = true;
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/BlogListele");
            }

        }

       

        public IActionResult ProjeListele()
        {
            using (var c = new Context())
            {
                var projeler = c.projelers.ToList();
                return View(projeler);

            }
        }
        public IActionResult ProjePasifYap(int id)
        {
            using (var c = new Context())
            {
                var proje = c.projelers.Find(id);
                proje.Status = false;
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/ProjeListele");
            }
        }

        public IActionResult ProjeAktifYap(int id)
        {
            using (var c = new Context())
            {
                var proje = c.projelers.Find(id);
                proje.Status = true;
                c.SaveChanges();
                return Redirect("/Admin/Yonetim/ProjeListele");
            }
        }

    }
}
