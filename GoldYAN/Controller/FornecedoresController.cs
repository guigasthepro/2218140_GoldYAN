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

    public class FornecedoresController : ControllerBase
    {
        // GET: api/<PresentesController>
        /// <summary>
        /// Recebe os presentes
        /// </summary>
        /// <returns>Presentes</returns>
        List<Fornecedores> LerClientes = new List<Fornecedores>();
        Fornecedores LerCliente = new Fornecedores();

        private readonly IConfiguration configuration;
        private string connectionString;
        public FornecedoresController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Fornecedores> GetAll()
        {

            LerClientes = new List<Fornecedores>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Fornecedores>().ToList();
                LerClientes = res;
            }

            return LerClientes;
        }
       

        // GET api/<PresentesController>/
        /// <summary>
        /// Recebe apenas o presente daquele id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>O Presente</returns>
        [HttpGet("{id}")]
        public Fornecedores Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Fornecedores>(id);
                return res;
            }
        }


        // POST api/<PresentesController>
        /// <summary>
        /// Cria um presente na base de dados
        /// </summary>
        /// <param name="presente"></param>
        /// <returns>O presente</returns>
        [HttpPost]
        public Fornecedores Post([FromBody] Fornecedores cliente)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Fornecedores>(cliente);
                var res = DBConn.Get<Fornecedores>(idNewRec);
                return res;
            }
        }
        /// <summary>
        /// Dá update ao id do presente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="presente"></param>
        /// <returns>O presente atualizado</returns>
        // PUT api/<PresentesController>/5
        [HttpPut("{id}")]
        public ActionResult<Fornecedores> Put(int id, [FromBody] Fornecedores fornecedores)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<Fornecedores>(id);

                if (recLido != null)
                {
                    recLido.codigo = fornecedores.codigo;
                    recLido.codigopostal = fornecedores.codigopostal;
                    recLido.contacto = fornecedores.contacto;
                    recLido.localizaçao = fornecedores.localizaçao;
                    recLido.morada = fornecedores.morada;
                    recLido.nome = fornecedores.nome;
                    recLido.nomevendedor = fornecedores.nomevendedor;
                    recLido.telefone = fornecedores.telefone;
                    recLido.telemovel = fornecedores.telemovel;
                    recLido.telemovelvendedor = fornecedores.telemovelvendedor;
                    recLido.nif = fornecedores.nif;


                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }
        /// <summary>
        /// Dá delete ao presente escolhido
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<PresentesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Fornecedores>(id);
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
}
