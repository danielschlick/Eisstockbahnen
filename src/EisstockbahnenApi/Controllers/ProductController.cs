using EisstockbahnenBusinessLogic;
using EisstockbahnenDatabase;
using EisstockbahnenWebModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EisstockbahnenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("customeSpecification")]
    public class ProductController : Controller
    {
        private readonly DatabaseContext context;

        public ProductController()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Data Source=dbbrpinf.database.windows.net;Initial Catalog=db_eistockbahnen;User ID=sdl;Password=wurmtreter66ecoWIN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False").Options;

            context = new DatabaseContext(options);
        }

        [HttpGet] 
        public IEnumerable<ProductModel> Get()
        {
            return new ProductService(context).Get();
        }
    }
}
