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
    public class MateriasController : ControllerBase
    {
        // GET: api/<MateriasController>

        List<Materias> LerMaterias = new List<Materias>();
        Materias LerMateria = new Materias();

        [HttpGet]
        public List<Materias> Get()
        {
            LerMaterias = new List<Materias>();


            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<Materias>().ToList();

            LerMaterias = res;

            return LerMaterias;
        }

        // GET api/<MateriasController>/5
        [HttpGet("{id}")]
        public Materias Get(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<Materias>(id);

            return res;
        }

        // POST api/<MateriasController>
        [HttpPost]
        public Materias Post([FromBody] Materias materias)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<Materias>(materias);

            var res = DBConn.Get<Materias>(idNewRec);

            return res;
        }

        // PUT api/<MateriasController>/5
        [HttpPut("{id}")]
        public ActionResult<Materias> Put(int id, [FromBody] Materias materias)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<Materias>(id);

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

        // DELETE api/<MateriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.Get<Materias>(id);
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
