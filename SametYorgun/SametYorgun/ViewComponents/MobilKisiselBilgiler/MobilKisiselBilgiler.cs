using Microsoft.AspNetCore.Mvc;
using SametYorgun.Models;
using System.Linq;

namespace SametYorgun.ViewComponents.MobilKisiselBilgiler
{
    public class MobilKisiselBilgiler:ViewComponent
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
