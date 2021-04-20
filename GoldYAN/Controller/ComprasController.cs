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
    public class ComprasController : ControllerBase
    {
        // GET: api/<ComprasController>

        List<Compras> LerClassificacoes = new List<Compras>();
        Compras LerClassificao = new Compras();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ComprasController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }


        [HttpGet]
        public List<Compras> GetAll()
        {
            LerClassificacoes = new List<Compras>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Compras>().ToList();

                LerClassificacoes = res;
            }

            return LerClassificacoes;
        }

        // GET api/<ClassificacaoProdutosController>/5
        [HttpGet("{id}")]
        public Compras Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Compras>(id);

                return res;
            }
        }

        // POST api/<ClassificacaoProdutosController>
        [HttpPost]
        public Compras Post([FromBody] Compras classificacaoProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Compras>(classificacaoProdutos);

                var res = DBConn.Get<Compras>(idNewRec);

                return res;
            }

        }

        // PUT api/<ClassificacaoProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult<Compras> Put(int id, [FromBody] Compras classificacaoProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<Compras>(id);

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

        // DELETE api/<ClassificacaoProdutosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Compras>(id);
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
