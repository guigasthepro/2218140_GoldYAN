using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
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

    public class HistoricoStockController : ControllerBase
    {
        List<HistoricoStock> LerCodigos = new List<HistoricoStock>();
        HistoricoStock LerCodigo = new HistoricoStock();

        private readonly IConfiguration configuration;
        private string connectionString;
        public HistoricoStockController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<HistoricoStock> GetAll()
        {
            LerCodigos = new List<HistoricoStock>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<HistoricoStock>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public HistoricoStock Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<HistoricoStock>(id);
                return res;
            }
        }

        public List<HistoricoStock> GetAllQuery(int id,int id2)
        {
            string query = $"SELECT * FROM `historicostock` WHERE idcomponente = {id} AND idprodutoalterado  = {id2} ";

            LerCodigos = new List<HistoricoStock>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<HistoricoStock>(query).ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }
        public List<HistoricoStock> GetAllProdutoQuery(int id2)
        {
            string query = $"SELECT * FROM `historicostock` WHERE idprodutoalterado  = {id2} ";

            LerCodigos = new List<HistoricoStock>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<HistoricoStock>(query).ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public HistoricoStock Post([FromBody] HistoricoStock encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<HistoricoStock>(encomenda);
                var res = DBConn.Get<HistoricoStock>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/


        [HttpPut("{id}")]
        public ActionResult<HistoricoStock> Put(int id, [FromBody] HistoricoStock hstock)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<HistoricoStock>(id);

                if (recLido != null)
                {
                    recLido.stockadicionado = hstock.stockadicionado;
                    recLido.idprodutoalterado = hstock.idprodutoalterado;
                    recLido.tipo = hstock.tipo;
                    recLido.idcomponente = hstock.idcomponente;
                    recLido.stockfinal = hstock.stockfinal;
                    recLido.stockinicial = hstock.stockinicial;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<HistoricoStock>(id);
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

        [HttpDelete("{id}")]
        public void DeleteUsingFabricos(int idproduto, int idfabrico)
        {

            string query = $" DELETE FROM `historicostock` WHERE idcomponente = {idfabrico} AND idprodutoalterado = {idproduto} ";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                    DBConn.Query<HistoricoStock>(query);

            }
        }

    }
}
