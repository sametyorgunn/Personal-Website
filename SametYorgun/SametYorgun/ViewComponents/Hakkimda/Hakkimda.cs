using Microsoft.AspNetCore.Mvc;
using SametYorgun.Models;
using System.Linq;

namespace SametYorgun.ViewComponents.Hakkimda
{
    public class Hakkimda:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using(var c = new Context())
            {
                var hakkimda = c.hakkimdas.FirstOrDefault();
                return View(hakkimda);
            }
            
        }
    }
}
