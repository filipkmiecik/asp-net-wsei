using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    [Route("api/[controller]")]
    public class ApiProductController : Controller
    {
        private readonly IProductRepository repository;

        public ApiProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Product>> Listc()
        {
            return Ok(repository.Products.Select(p => p));
        }

        [HttpGet("GetAllByCategory")]
        public ActionResult<IEnumerable<Product>> List(string category)
        {
            return Ok(repository.Products.Where(p => p.category == category));
        }

        [HttpGet("GetById")]
        public ActionResult<Product> GetById(int id)
        {
            var product = repository.Products.SingleOrDefault(product => product.id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            repository.SaveProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        public ActionResult<Product> DeleteProduct(int id)
        {
            repository.DeleteProduct(id);
            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateProduct(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (!repository.Products.Any(p => p.id == product.id))
                return NotFound();

            repository.SaveProduct(product);

            return NoContent();

        }
    }
}
