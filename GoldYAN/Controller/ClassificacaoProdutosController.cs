using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificacaoProdutosController : ControllerBase
    {
        // GET: api/<ClassificacaoProdutosController>

        List<ClassificacaoProdutos> LerClassificacoes = new List<ClassificacaoProdutos>();
        ClassificacaoProdutos LerClassificao = new ClassificacaoProdutos();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ClassificacaoProdutosController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }


        [HttpGet]
        public List<ClassificacaoProdutos> Get()
        {
            LerClassificacoes = new List<ClassificacaoProdutos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<ClassificacaoProdutos>().ToList();

                LerClassificacoes = res;
            }

            return LerClassificacoes;
        }

        // GET api/<ClassificacaoProdutosController>/5
        [HttpGet("{id}")]
        public ClassificacaoProdutos Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<ClassificacaoProdutos>(id);

                return res;
            }
        }

        // POST api/<ClassificacaoProdutosController>
        [HttpPost]
        public ClassificacaoProdutos Post([FromBody] ClassificacaoProdutos classificacaoProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<ClassificacaoProdutos>(classificacaoProdutos);

                var res = DBConn.Get<ClassificacaoProdutos>(idNewRec);

                return res;
            }
            
        }

        // PUT api/<ClassificacaoProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult<ClassificacaoProdutos> Put(int id, [FromBody] ClassificacaoProdutos classificacaoProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<ClassificacaoProdutos>(id);

                if (recLido != null)
                {
                    recLido.IDClassificacao = classificacaoProdutos.IDClassificacao;
                    recLido.codigo = classificacaoProdutos.codigo;
                    recLido.codigoat = classificacaoProdutos.codigoat;
                    recLido.descricao = classificacaoProdutos.descricao;
                    recLido.inventario = classificacaoProdutos.inventario;


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
                var res = DBConn.Get<ClassificacaoProdutos>(id);
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
