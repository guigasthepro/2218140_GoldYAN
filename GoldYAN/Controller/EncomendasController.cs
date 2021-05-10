using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin, Dev, Atendimento, Oficina, Contabilidade")]

    public class EncomendasController : ControllerBase
    {

        // GET: ServicosController
        List<Encomendas> LerCodigos = new List<Encomendas>();
        Encomendas LerCodigo = new Encomendas(); 
        List<EncomendasComputed> lerEncomendasComputed = new List<EncomendasComputed>();
        Data.Encomendas lerEncomendas = new Encomendas();

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
        [HttpGet]
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

        [HttpGet("{id}")]
        public Encomendas GetAllQuery(int id , int linha)
        {
            string query = $"SELECT * FROM `encomendas` WHERE idencomenda = '{id}' AND linha = {linha}";

            lerEncomendas = new Encomendas();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.QueryFirstOrDefault<Encomendas>(query);
                lerEncomendas = res;
            }

            return lerEncomendas;
        }

        [HttpGet("{id}")]
        public List<Cabecalho> InfoEncomendas(string valor)
        {
            string sql = $"SELECT * FROM cabecalhoencomenda WHERE data LIKE '%{valor}%' ";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Cabecalho>(sql).ToList();
                return res;
            }
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

        public ActionResult<Encomendas> LancarLocalizacoes(int id, int linha, [FromBody] string localizacoes)
        {
            string getsql = $"UPDATE `encomendas` SET `idlocalizacao` = '{localizacoes}' WHERE `encomendas`.`idencomenda` = {id} AND `encomendas`.`linha` = {linha};";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                try
                {
                    var recLido = DBConn.QuerySingle<Encomendas>(getsql);
                    return Ok(recLido);
                }
                catch (Exception e)
                {
                    return NotFound();
                }
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Encomendas> LancarEstado(int id, int linha, [FromBody] string estado)
        {
            string getsql = $"UPDATE `encomendas` SET `idestado` = '{estado}' WHERE `encomendas`.`idencomenda` = {id} AND `encomendas`.`linha` = {linha};";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                try
                {
                    var recLido = DBConn.QuerySingle<Encomendas>(getsql);
                    return Ok(recLido);
                }
                catch (Exception e)
                {
                    return NotFound();
                }
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Encomendas> UpdateProduto(int id, int linha, [FromBody] int produto)
        {
            string getsql = $"UPDATE `encomendas` SET `idproduto` = {produto} WHERE `encomendas`.`idencomenda` = {id} AND `encomendas`.`linha` = {linha};";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                try
                {
                    var recLido = DBConn.QuerySingle<Encomendas>(getsql);
                    return Ok(recLido);
                }
                catch (Exception e)
                {
                    return NotFound();
                }
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Encomendas> AtribuirColaborador(int id, int linha, [FromBody] string colaborador)
        {
            string getsql = $"UPDATE `encomendas` SET `colaboradoratribuido` = '{colaborador}' WHERE `encomendas`.`idencomenda` = {id} AND `encomendas`.`linha` = {linha};";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                try
                {
                    var recLido = DBConn.QuerySingle<Encomendas>(getsql);
                    return Ok(recLido);
                }
                catch (Exception e)
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
