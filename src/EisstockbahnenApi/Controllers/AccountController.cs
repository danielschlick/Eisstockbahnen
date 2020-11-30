using System.Collections.Generic;
using EisstockbahnenBusinessLogic;
using EisstockbahnenDatabase;
using EisstockbahnenWebModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EisstockbahnenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("customeSpecification")]
    public class AccountController : ControllerBase
    {
        private readonly DatabaseContext context;

        public AccountController()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Data Source=dbbrpinf.database.windows.net;Initial Catalog=db_eistockbahnen;User ID=sdl;Password=wurmtreter66ecoWIN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False").Options;

            context = new DatabaseContext(options);
        }

        [HttpGet]
        public IEnumerable<AccountModel> Get()
        {
            return new AccountService(context).Get();
        }

        [HttpPost]
        public ActionResult Post(AccountModel value)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, AccountModel value)
        {
            if (value.Id != id)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }

            AccountService service = new AccountService(context);
            service.Remove(id);

            return Ok();
        }
    }
}