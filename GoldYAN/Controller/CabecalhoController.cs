using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabecalhoController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: CabecalhoController
        List<Cabecalho> LerCodigos = new List<Cabecalho>();
        Cabecalho LerCodigo = new Cabecalho();

        private readonly IConfiguration configuration;
        private string connectionString;
        public CabecalhoController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Cabecalho> GetAll()
        {
            LerCodigos = new List<Cabecalho>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Cabecalho>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Cabecalho Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Cabecalho>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public Cabecalho Post([FromBody] Cabecalho encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Cabecalho>(encomenda);
                var res = DBConn.Get<Cabecalho>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Cabecalho>(id);
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
