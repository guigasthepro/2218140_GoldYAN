using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaProdutosController : ControllerBase
    {
        // GET: api/<FamiliaProdutosController>

        List<FamiliaProdutos> lerFamilias = new List<FamiliaProdutos>();
        FamiliaProdutos LerFamilia = new FamiliaProdutos();

        [HttpGet]
        public List<FamiliaProdutos> Get()
        {
            lerFamilias = new List<FamiliaProdutos>();


            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<FamiliaProdutos>().ToList();

            lerFamilias = res;

            return lerFamilias;
        }

        // GET api/<FamiliaProdutosController>/5
        [HttpGet("{id}")]
        public FamiliaProdutos Get(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<FamiliaProdutos>(id);

            return res;
        }

        // POST api/<FamiliaProdutosController>
        [HttpPost]
        public FamiliaProdutos Post([FromBody] FamiliaProdutos familiaProdutos)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<FamiliaProdutos>(familiaProdutos);

            var res = DBConn.Get<FamiliaProdutos>(idNewRec);

            return res;
        }

        // PUT api/<FamiliaProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult<FamiliaProdutos> Put(int id, [FromBody] FamiliaProdutos familiaProdutos)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<FamiliaProdutos>(id);

            if (recLido != null)
            {
                //recLido.Nomes = presente.Nomes;
                //recLido.Quantidade = presente.Quantidade;

                bool updated = DBConn.Update(recLido);

                return Ok(recLido);
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<FamiliaProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<FamiliaProdutos>(id);
            if (res != null)
            {
                DBConn.Delete(res);
            }
            else
            {

            }
        }
    }
}
