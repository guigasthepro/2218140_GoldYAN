using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin")]
    public class AspNetUsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        // GET: CabecalhoController
        List<aspnetusers> LerCodigos = new List<aspnetusers>();
        aspnetusers LerCodigo = new aspnetusers();

        private readonly IConfiguration configuration;
        private string connectionString;
        public AspNetUsersController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<aspnetusers> GetAll()
        {
            LerCodigos = new List<aspnetusers>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<aspnetusers>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public aspnetusers Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<aspnetusers>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public aspnetusers Post([FromBody] aspnetusers encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<aspnetusers>(encomenda);
                var res = DBConn.Get<aspnetusers>(idNewRec);
                return res;
            }
        }

        [HttpPut("{id}")]
        public ActionResult<aspnetusers> Put(int id, [FromBody] aspnetusers users)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<aspnetusers>(id);

                if (recLido != null)
                {
                    recLido.Email = users.Email;
                    recLido.PhoneNumber = users.PhoneNumber;
                    recLido.UserName = users.UserName;
                    recLido.NormalizedUserName = users.NormalizedUserName;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<aspnetusers>(id);
                if (res != null)
                {
                    DBConn.Delete(res);
                    return "Item foi apagado com sucesso";
                }
                else
                {
                    return "Item foi apagado com sucesso";
                }
            }
        }
    }
}

