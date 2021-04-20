using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin")]
    public class ColaboradoresController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;

        // GET: CabecalhoController
        List<Colaboradores> LerCodigos = new List<Colaboradores>();
        Colaboradores LerCodigo = new Colaboradores();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ColaboradoresController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Colaboradores> GetAll()
        {
            LerCodigos = new List<Colaboradores>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Colaboradores>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Colaboradores Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Colaboradores>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public Colaboradores Post([FromBody] Colaboradores encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Colaboradores>(encomenda);
                var res = DBConn.Get<Colaboradores>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Colaboradores>(id);
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

        public async Task LockoutUser()
        {
            
           // _userManager.SetLockoutEndDateAsync();
        }
    }
}
