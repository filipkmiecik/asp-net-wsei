using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext ctx;
        public EFProductRepository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products => ctx.Products;

        public void SaveProduct(Product product)
        {
            if (product.id == 0)
            {
                ctx.Products.Add(product);
            }
            else
            {
                Product dbEntry = ctx.Products.FirstOrDefault(p => p.id == product.id);
                if(dbEntry != null)
                {
                    dbEntry.name = product.name;
                    dbEntry.description = product.description;
                    dbEntry.price = product.price;
                    dbEntry.category = product.category;
                }
            }
            ctx.SaveChanges();
        }

        public Product DeleteProduct(int productId)
        {
            Product dbEntry = ctx.Products.FirstOrDefault(p => p.id == productId);
            if(dbEntry != null)
            {
                ctx.Products.Remove(dbEntry);
                ctx.SaveChanges();
            }
            return dbEntry;
        }
    }
}
