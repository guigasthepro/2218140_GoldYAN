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
    [Authorize("Admin, Dev, Atendimento, Oficina, Contabilidade")]

    public class CabecalhoComprasController : ControllerBase
    {
        // GET: api/<ComprasController>

        List<CabecalhoCompras> LerClassificacoes = new List<CabecalhoCompras>();
        CabecalhoCompras LerClassificao = new CabecalhoCompras();

        private readonly IConfiguration configuration;
        private string connectionString;
        public CabecalhoComprasController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }


        [HttpGet]
        public List<CabecalhoCompras> GetAll()
        {
            LerClassificacoes = new List<CabecalhoCompras>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<CabecalhoCompras>().ToList();

                LerClassificacoes = res;
            }

            return LerClassificacoes;
        }

        // GET api/<ClassificacaoProdutosController>/5
        [HttpGet("{id}")]
        public CabecalhoCompras Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhoCompras>(id);

                return res;
            }
        }

        // POST api/<ClassificacaoProdutosController>
        [HttpPost]
        public CabecalhoCompras Post([FromBody] CabecalhoCompras classificacaoProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<CabecalhoCompras>(classificacaoProdutos);

                var res = DBConn.Get<CabecalhoCompras>(idNewRec);

                return res;
            }

        }

        // PUT api/<ClassificacaoProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult<CabecalhoCompras> Put(int id, [FromBody] CabecalhoCompras compras)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<CabecalhoCompras>(id);

                if (recLido != null)
                {

                    recLido.idfornecedor = compras.idfornecedor;
                    recLido.idtipodecompra = compras.idtipodecompra;
                    recLido.numero = compras.numero;
                    recLido.datacriacao = compras.datacriacao;
                    recLido.apontamentos = compras.apontamentos;


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
                var res = DBConn.Get<CabecalhoCompras>(id);
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
