using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissoesController : ControllerBase
    {
        // GET: api/<ProfissoesController>

        List<Profissoes> LerProfissoes = new List<Profissoes>();
        Profissoes LerProfissoe = new Profissoes();

        private readonly IConfiguration configuration;
        private string connectionString;
        public ProfissoesController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Profissoes> Get()
        {
            LerProfissoes = new List<Profissoes>();


            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Profissoes>().ToList();
                LerProfissoes = res;
            }

            return LerProfissoes;
        }

        // GET api/<ProfissoesController>/5
        [HttpGet("{id}")]
        public Profissoes Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Profissoes>(id);
                return res;
            }
        }

        // POST api/<ProfissoesController>
        [HttpPost]
        public Profissoes Post([FromBody] Profissoes profissoes)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Profissoes>(profissoes);
                var res = DBConn.Get<Profissoes>(idNewRec);
                return res;
            }
        }

        // PUT api/<ProfissoesController>/5
        [HttpPut("{id}")]
        public ActionResult<Profissoes> Put(int id, [FromBody] Profissoes profissoes)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Get<Profissoes>(id);

                if (recLido != null)
                {
                    recLido.codigo = profissoes.codigo;
                    recLido.nome = profissoes.nome;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        // DELETE api/<ProfissoesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Profissoes>(id);
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
