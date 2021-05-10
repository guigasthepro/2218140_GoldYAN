using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin, Dev, Atendimento, Oficina, Contabilidade")]

    public class FamiliaProdutosController : ControllerBase
    {
        // GET: api/<FamiliaProdutosController>

        List<FamiliaProdutos> lerFamilias = new List<FamiliaProdutos>();
        FamiliaProdutos LerFamilia = new FamiliaProdutos();

        private readonly IConfiguration configuration;
        private string connectionString;
        public FamiliaProdutosController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<FamiliaProdutos> Get()
        {
            lerFamilias = new List<FamiliaProdutos>();


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var res = DBConn.GetAll<FamiliaProdutos>().ToList();
                lerFamilias = res;
            }
            return lerFamilias;
        }

        // GET api/<FamiliaProdutosController>/5
        [HttpGet("{id}")]
        public FamiliaProdutos Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<FamiliaProdutos>(id);
                return res;
            }
        }

        // POST api/<FamiliaProdutosController>
        [HttpPost]
        public FamiliaProdutos Post([FromBody] FamiliaProdutos familiaProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var idNewRec = DBConn.Insert<FamiliaProdutos>(familiaProdutos);
                var res = DBConn.Get<FamiliaProdutos>(idNewRec);
                return res;
            }
        }

        // PUT api/<FamiliaProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult<FamiliaProdutos> Put(int id, [FromBody] FamiliaProdutos familiaProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<FamiliaProdutos>(id);

                if (recLido != null)
                {
                    recLido.idfproduto = familiaProdutos.idfproduto;
                    recLido.idunidade = familiaProdutos.idunidade;
                    recLido.tipo = familiaProdutos.tipo;
                    recLido.codigo = familiaProdutos.codigo;
                    recLido.nome = familiaProdutos.nome;
                    recLido.descricao = familiaProdutos.descricao;
                    recLido.descricaoeq = familiaProdutos.descricaoeq;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        // DELETE api/<FamiliaProdutosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<FamiliaProdutos>(id);
            if (res != null)
            {
                DBConn.Delete(res);
                return "Sucesso";
            }
            else
            {
                return "Erro";
            }
        }
    }
}
