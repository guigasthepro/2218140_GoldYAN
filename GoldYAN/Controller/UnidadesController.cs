using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {
        // GET: api/<UnidadesController>


        List<Unidades> LerUnidades = new List<Unidades>();
        Unidades LerUnidade = new Unidades();


        [HttpGet]
        public List<Unidades> Get()
        {
            LerUnidades = new List<Unidades>();


            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<Unidades>().ToList();

            LerUnidades = res;

            return LerUnidades;
        }

        // GET api/<UnidadesController>/5
        [HttpGet("{id}")]
        public Unidades Get(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<Unidades>(id);

            return res;
        }

        // POST api/<UnidadesController>
        [HttpPost]
        public Unidades Post([FromBody] Unidades unidades)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<Unidades>(unidades);

            var res = DBConn.Get<Unidades>(idNewRec);

            return res;
        }

        // PUT api/<UnidadesController>/5
        [HttpPut("{id}")]
        public ActionResult<Unidades> Put(int id, [FromBody] Unidades unidade)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<Unidades>(id);

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

        // DELETE api/<UnidadesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<Unidades>(id);
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
