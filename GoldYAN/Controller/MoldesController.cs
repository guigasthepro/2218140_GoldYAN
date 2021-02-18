using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Mvc;
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


        // GET: api/<MoldesController>
        [HttpGet]
        public List<Moldes> Get()
        {
            LerMoldes = new List<Moldes>();

            string sql = "Select idproduto, familiaproduto, tipoproduto, codigo, descricao, gaveta, tempo, peso FROM produtos Where familiaproduto = 1 ";

            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Query<Moldes>(sql).ToList();

            LerMoldes = res;

            return LerMoldes;
        }

        [HttpGet]
        public List<TipoProduto> GetSelect()
        {
            lerProdutos = new List<TipoProduto>();
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<TipoProduto>().ToList();
            lerProdutos = res;
            return lerProdutos;
        }

        // GET api/<MoldesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoldesController>
        [HttpPost]
        public Moldes Post([FromBody] Moldes molde)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<Moldes>(molde);

            var res = DBConn.Get<Moldes>(idNewRec);

            return res;
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
