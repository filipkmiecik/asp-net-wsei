using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class FakeProductRepository: IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {name = "Shoes", price = 100},
            new Product {name = "Video game", price = 60},
            new Product {name = "Bike", price = 800},
            new Product {name = "Smartphone", price = 1600}
        }.AsQueryable<Product>();
    }
}
