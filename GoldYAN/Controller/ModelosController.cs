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

        [HttpGet("{id}")]
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


        [HttpGet("{id}")]
        public List<Modelos> GetSingleQuery(string id, int linha)
        {
            string query = $"SELECT * FROM `modelos` WHERE idmodelo = '{id}' AND linha = '{linha}'";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Modelos>(query).ToList();
                return res;
            }


        }


        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Modelos Get(string id)
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

        [HttpPut]
        public ActionResult<Modelos> Put(string id, int linha, [FromBody] Modelos cmodelos)
        {
            string getsql = $"SELECT* FROM `modelos` WHERE idmodelo = '{id}' AND linha = '{linha}';";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Query<Modelos>(getsql).ToList();

                if (recLido != null)
                {
                    

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
