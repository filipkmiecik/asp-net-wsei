using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;
using System.Linq;

namespace StoreProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        { 
            this.productRepository = productRepository; 
        }
        public ViewResult ListAll() => View(productRepository.Products);
        public ViewResult List(string category) => View(productRepository.Products.Where(p => p.category == category));
    }
}
