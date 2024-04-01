using ASP9.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP9.ViewComponents
{
    public class ShowTable : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }
}

