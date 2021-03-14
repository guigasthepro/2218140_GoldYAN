using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        List<Modelos> LerCodigos = new List<Modelos>();
        Modelos LerCodigo = new Modelos();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ModelosController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Modelos> GetAll()
        {
            LerCodigos = new List<Modelos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Modelos>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        [HttpGet]
        public List<Modelos> GetAllQuery(string id)
        {
            string query = $"SELECT * FROM `modelos` WHERE idmodelo = '{id}'";

            LerCodigos = new List<Modelos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Modelos>(query).ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }


        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Modelos Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Modelos>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public Modelos Post([FromBody] Modelos encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Modelos>(encomenda);
                var res = DBConn.Get<Modelos>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Modelos>(id);
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
