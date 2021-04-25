using Dapper;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabecalhoProdutosController : ControllerBase
    {

        // GET: ServicosController
        List<CabecalhoProdutos> LerCodigos = new List<CabecalhoProdutos>();
        CabecalhoProdutos LerCodigo = new CabecalhoProdutos();
        List<CabecalhoProdutos> lerEncomendasComputed = new List<CabecalhoProdutos>();
        List<IDMaximo> lerIDMax = new List<IDMaximo>();

        private readonly IConfiguration configuration;
        private string connectionString;
        public CabecalhoProdutosController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<CabecalhoProdutos> GetAll()
        {
            LerCodigos = new List<CabecalhoProdutos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<CabecalhoProdutos>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }
        [HttpGet]
        public List<IDMaximo> GetMaxID()
        {


            string sql = "SELECT e.*, ce.idcliente, ce.criadopor, ce.data, c.nome, c.telefone FROM encomendas e INNER JOIN cabecalhoencomenda ce ON ce.idencomenda = e.idencomenda INNER JOIN clientes c ON c.idcliente = ce.idcliente";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<IDMaximo>(sql).ToList();
                lerIDMax = res;
            }

            return lerIDMax;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public CabecalhoProdutos Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhoProdutos>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public CabecalhoProdutos Post([FromBody] CabecalhoProdutos encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<CabecalhoProdutos>(encomenda);
                var res = DBConn.Get<CabecalhoProdutos>(idNewRec);
                return res;
            }
        }


        public ActionResult<CabecalhoProdutos> Put(int id, [FromBody] CabecalhoProdutos familiaProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<CabecalhoProdutos>(id);

                if (recLido != null)
                {
                    recLido.idfornecedor = familiaProdutos.idfornecedor;
                    recLido.idclassificação = familiaProdutos.idclassificação;
                    recLido.idunidade = familiaProdutos.idunidade;
                    recLido.idtipodeproduto = familiaProdutos.idtipodeproduto;
                    recLido.idtipodepeca = familiaProdutos.idtipodepeca;
                    recLido.idmodelo = familiaProdutos.idmodelo;
                    recLido.descricao = familiaProdutos.descricao;
                    recLido.preco = familiaProdutos.preco;
                    recLido.stock = familiaProdutos.stock;

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
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhoProdutos>(id);
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
