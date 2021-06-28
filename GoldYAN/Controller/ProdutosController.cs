using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin, Dev, Atendimento, Oficina, Contabilidade")]

    public class ProdutosController : ControllerBase
    {
        // GET: api/<FamiliaProdutosController>

        List<Produtos> lerFamilias = new List<Produtos>();
        Produtos LerFamilia = new Produtos();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ProdutosController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Produtos> GetAll()
        {
            lerFamilias = new List<Produtos>();


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var res = DBConn.GetAll<Produtos>().ToList();
                lerFamilias = res;
            }
            return lerFamilias;
        }

        // GET api/<FamiliaProdutosController>/5
        [HttpGet("{id}")]
        public Produtos Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Produtos>(id);
                return res;
            }
        }

        [HttpGet]
        public List<Produtos> GetAllQuery(int id)
        {
            string query = $"SELECT * FROM `produtos` WHERE idproduto = '{id}'";

            lerFamilias = new List<Produtos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Produtos>(query).ToList();
                lerFamilias = res;
            }

            return lerFamilias;
        }

        [HttpGet("{id}")]
        public List<Produtos> GetProdutosWithFabric(int id, int idprodutos, int fabrico)
        {
            string query = $"SELECT * FROM `produtos` WHERE idproduto = {id} AND idprodutos = {idprodutos} AND idfabrico {fabrico}";

            lerFamilias = new List<Produtos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Produtos>(query).ToList();
                lerFamilias = res;
            }

            return lerFamilias;
        }

        public Produtos GetProdutoWithLinha(int id, int linha)
        {
            string query = $"SELECT * FROM `produtos` WHERE idproduto = '{id}' AND linha = '{linha}'";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.QueryFirstOrDefault<Produtos>(query);
                return res;
            }


        }

        // POST api/<FamiliaProdutosController>
        [HttpPost]
        public Produtos Post([FromBody] Produtos familiaProdutos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var idNewRec = DBConn.Insert<Produtos>(familiaProdutos);
                var res = DBConn.Get<Produtos>(idNewRec);
                return res;
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Produtos> Put(int id, int linha, [FromBody] Produtos familiaProdutos)
        {
            string getsql = $"SELECT* FROM `produtos` WHERE idproduto = '{id}' AND linha = '{linha}';";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.QuerySingle<Produtos>(getsql);

                if (recLido != null)
                {

                    recLido.idcolaborador = familiaProdutos.idcolaborador;
                    recLido.idprodutos = familiaProdutos.idprodutos;
                    recLido.idservico = familiaProdutos.idservico;
                    recLido.peso = familiaProdutos.peso;
                    recLido.custo = familiaProdutos.custo;
                    recLido.custototal = familiaProdutos.custototal;
                    recLido.customedio = familiaProdutos.customedio;
                    recLido.descricao = familiaProdutos.descricao;
                    recLido.quantidade = familiaProdutos.quantidade;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        //// PUT api/<FamiliaProdutosController>/5
        //[HttpPut("{id}")]
        //public ActionResult<Produtos> Put(int id, [FromBody] Produtos familiaProdutos)
        //{
        //    using (MySqlConnection DBConn = new MySqlConnection(connectionString))
        //    {

        //        var recLido = DBConn.Get<Produtos>(id);

        //        if (recLido != null)
        //        {
        //            recLido.idcolaborador = familiaProdutos.idcolaborador;
        //            recLido.idprodutos = familiaProdutos.idprodutos;
        //            recLido.idservico = familiaProdutos.idservico;
        //            recLido.peso = familiaProdutos.peso;
        //            recLido.custo = familiaProdutos.custo;
        //            recLido.custototal = familiaProdutos.custototal;
        //            recLido.customedio = familiaProdutos.customedio;
        //            recLido.descricao = familiaProdutos.descricao;
        //            recLido.quantidade = familiaProdutos.quantidade;          


        //            bool updated = DBConn.Update(recLido);

        //            return Ok(recLido);
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }
        //}

        // DELETE api/<FamiliaProdutosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<Produtos>(id);
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

        [HttpDelete("{id}")]
        public string DeleteProdutos(int id, int idfabrico)
        {

            string query = $" DELETE FROM `produtos` WHERE idprodutos = {id} AND idfabrico = {idfabrico} ";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Produtos>(id);
                if (res != null)
                {
                    DBConn.Query<Produtos>(query);
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
