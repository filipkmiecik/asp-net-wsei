using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;
using System.Collections.Generic;
using System.Linq;


namespace StoreProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IProductRepository productRepository;

        public NavigationMenuViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(productRepository.Products.Select(x =>
           x.category).Distinct().OrderBy(x => x));
        }

    }
}
