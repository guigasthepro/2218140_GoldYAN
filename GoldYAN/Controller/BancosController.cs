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

    public class BancosController : ControllerBase
    {
        // GET: api/<BancosController>

        List<Bancos> LerBancos = new List<Bancos>();
        Bancos LerBanco = new Bancos();

        [HttpGet]
        public List<Bancos> Get()
        {
            LerBancos = new List<Bancos>();


            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<Bancos>().ToList();

            LerBancos = res;

            return LerBancos;
        }

        // GET api/<BancosController>/5
        [HttpGet("{id}")]
        public Bancos Get(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");
            var res = DBConn.Get<Bancos>(id);

            return res;
        }

        // POST api/<BancosController>
        [HttpPost]
        public Bancos Post([FromBody] Bancos banco)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<Bancos>(banco);

            var res = DBConn.Get<Bancos>(idNewRec);

            return res;
        }

        // PUT api/<BancosController>/5
        [HttpPut("{id}")]
        public ActionResult<Bancos> Put(int id, [FromBody] Bancos banco)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<Bancos>(id);

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

        // DELETE api/<BancosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");
            var res = DBConn.Get<Bancos>(id);
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
