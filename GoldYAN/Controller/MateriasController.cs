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

    public class MateriasController : ControllerBase
    {
        // GET: api/<MateriasController>

        List<Materias> LerMaterias = new List<Materias>();
        Materias LerMateria = new Materias();

        private readonly IConfiguration configuration;
        private string connectionString;
        public MateriasController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Materias> Get()
        {
            LerMaterias = new List<Materias>();


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Materias>().ToList();
                LerMaterias = res;
            }
            return LerMaterias;
        }

        // GET api/<MateriasController>/5
        [HttpGet("{id}")]
        public Materias Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Materias>(id);
                return res;
            }
        }

        // POST api/<MateriasController>
        [HttpPost]
        public Materias Post([FromBody] Materias materias)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Materias>(materias);
                var res = DBConn.Get<Materias>(idNewRec);
                return res;
            }
        }

        // PUT api/<MateriasController>/5
        [HttpPut("{id}")]
        public ActionResult<Materias> Put(int id, [FromBody] Materias materias)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Get<Materias>(id);

                if (recLido != null)
                {

                    recLido.idmateria = materias.idmateria;
                    recLido.nome = materias.nome;
                    recLido.alcunha = materias.alcunha;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        // DELETE api/<MateriasController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Materias>(id);
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
}
