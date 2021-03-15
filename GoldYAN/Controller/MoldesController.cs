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
    public class MoldesController : ControllerBase
    {
        List<TipoProduto> lerProdutos = new List<TipoProduto>();
        List<Moldes> LerMoldes = new List<Moldes>();
        Moldes LerMolde = new Moldes();

        private readonly IConfiguration configuration;
        private string connectionString;
        public MoldesController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }


        // GET: api/<MoldesController>
        [HttpGet]
        public List<Moldes> Get()
        {
            LerMoldes = new List<Moldes>();

            string sql = "Select idproduto,codigo, descricao, gaveta, tempo, peso FROM produtos Where tipoproduto = 1 ";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Moldes>().ToList();
                LerMoldes = res;
            }

            return LerMoldes;
        }

        [HttpGet]
        public List<TipoProduto> GetSelect()
        {
            lerProdutos = new List<TipoProduto>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<TipoProduto>().ToList();
                lerProdutos = res;
                return lerProdutos;
            }
        }

        // GET api/<MoldesController>/5
        [HttpGet("{id}")]
        public Moldes Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Moldes>(id);
                return res;
            }
        }

        // POST api/<MoldesController>
        [HttpPost]
        public Moldes Post([FromBody] Moldes molde)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Moldes>(molde);
                var res = DBConn.Get<Moldes>(idNewRec);
                return res;
            }
        }

        // PUT api/<MoldesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoldesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
