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
    public class EncomendasController : ControllerBase
    {

        // GET: ServicosController
        List<Encomendas> LerCodigos = new List<Encomendas>();
        Encomendas LerCodigo = new Encomendas(); 
        List<EncomendasComputed> lerEncomendasComputed = new List<EncomendasComputed>();

        private readonly IConfiguration configuration;
        private string connectionString;
        public EncomendasController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Encomendas> Get()
        {
            LerCodigos = new List<Encomendas>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Encomendas>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        public List<EncomendasComputed> GetWithInner()
        {
            lerEncomendasComputed = new List<EncomendasComputed>();

            string sql = "SELECT e.*, ce.idcliente, ce.criadopor, ce.data, c.nome, c.telefone FROM encomendas e INNER JOIN cabecalhoencomenda ce ON ce.idencomenda = e.idencomenda INNER JOIN clientes c ON c.idcliente = ce.idcliente";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<EncomendasComputed>(sql).ToList();
                lerEncomendasComputed = res;
            }

            return lerEncomendasComputed;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Encomendas Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Encomendas>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public Encomendas Post([FromBody] Encomendas encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Encomendas>(encomenda);
                var res = DBConn.Get<Encomendas>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Encomendas>(id);
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
