using Microsoft.AspNetCore.Mvc;
using SametYorgun.Models;
using System.Linq;

namespace SametYorgun.ViewComponents.KisiselBilgiler
{
    public class KisiselBilgiler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var c = new Context())
            {
                var bilgiler = c.kisiselBilgis.FirstOrDefault();
                return View(bilgiler);
            }


        }
    }
}
