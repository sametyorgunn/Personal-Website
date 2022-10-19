using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SametYorgun.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SametYorgun.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(giris p)
        {
            if (ModelState.IsValid)
            {
                Context c = new Context();
                var login = c.girises.Where(x => x.Username == p.Username && x.Password == p.Password).FirstOrDefault();
                if (login != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, p.Username)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return Redirect("/Admin/Yonetim/Index");

                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
