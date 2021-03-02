using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<PresentesController>
        /// <summary>
        /// Recebe os presentes
        /// </summary>
        /// <returns>Presentes</returns>
        List<Clientes> LerClientes = new List<Clientes>();
        Clientes LerCliente = new Clientes();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ClientesController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Clientes> Get()
        {

            LerClientes = new List<Clientes>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Clientes>().ToList();
                LerClientes = res;
            }

            return LerClientes;
        }
        [HttpGet]
        public List<Clientes> PesquisarClientes(string valor)
        {
            string sql = $"SELECT nome, telefone, email, morada FROM clientes WHERE nome LIKE '%{valor}%' OR telefone LIKE '%{valor}%' OR email LIKE '%{valor}%' OR morada LIKE '%{valor}%';";


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Clientes>(sql).ToList();
                return res;
            }
        }

        // GET api/<PresentesController>/
        /// <summary>
        /// Recebe apenas o presente daquele id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>O Presente</returns>
        [HttpGet("{id}")]
        public Clientes Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Clientes>(id);
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
        public Clientes Post([FromBody] Clientes cliente)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Clientes>(cliente);
                var res = DBConn.Get<Clientes>(idNewRec);
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
        public ActionResult<Clientes> Put(int id, [FromBody] Clientes cliente)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<Clientes>(id);

                if (recLido != null)
                {
                    //recLido.Nomes = presente.Nomes;
                    //recLido.Quantidade = presente.Quantidade;

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
                var res = DBConn.Get<Clientes>(id);
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
