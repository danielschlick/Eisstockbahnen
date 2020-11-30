using EisstockbahnenDatabase;
using EisstockbahnenDatabase.Entities;
using EisstockbahnenWebModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EisstockbahnenBusinessLogic
{
    public class ProductService
    {
        private readonly DatabaseContext context;

        public ProductService(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(string name, int unitId)
        {
            Unit unit = context.Units.Find(unitId);

            var product = new Product
            {
                Name = name,
                Unit = unit
            };

            context.Products.Add(product);
            context.SaveChanges();
        }

        public List<ProductModel> Get()
        {
            List<ProductModel> products = new List<ProductModel>();

            foreach (Product product in context.Products.Include(x => x.Unit))
            {
                products.Add(new ProductModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Unit = Mapper.ToUnitModel(product.Unit)
                });
            }

            return products;
        }
    }
}
