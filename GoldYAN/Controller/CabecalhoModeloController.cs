using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabecalhoModeloController : ControllerBase
    {
        // GET: CabecalhoController
        List<CabecalhosModelos> LerCodigos = new List<CabecalhosModelos>();
        CabecalhosModelos LerCodigo = new CabecalhosModelos();

        private readonly IConfiguration configuration;
        private string connectionString;
        public CabecalhoModeloController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<CabecalhosModelos> GetAll()
        {
            LerCodigos = new List<CabecalhosModelos>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<CabecalhosModelos>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public CabecalhosModelos Get(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhosModelos>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public CabecalhosModelos Post([FromBody] CabecalhosModelos encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<CabecalhosModelos>(encomenda);
                var res = DBConn.Get<CabecalhosModelos>(idNewRec);
                return res;
            }
        }

        public ActionResult<CabecalhosModelos> Put(string id, [FromBody] CabecalhosModelos cmodelos)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Get<CabecalhosModelos>(id);

                if (recLido != null)
                {
                    recLido.idmodelo = cmodelos.idmodelo;
                    recLido.idtipodepeca = cmodelos.idtipodepeca;
                    recLido.idtipoproduto = cmodelos.idtipoproduto;
                    recLido.descricao = cmodelos.descricao;
                    recLido.datacriacao = cmodelos.datacriacao;

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
        public string Delete(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhosModelos>(id);
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
