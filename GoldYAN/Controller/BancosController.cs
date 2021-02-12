using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.AspNetCore.Authorization;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

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
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
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
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<Bancos>(id);

            if (recLido != null)
            {
                recLido.codigobanco = banco.codigobanco;
                recLido.nome = banco.nome;

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
        public string Delete(int id)
        {
            try
            {
                MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");
                var res = DBConn.Get<Bancos>(id);
                if (res != null)
                {
                    DBConn.Delete(res);
                    return "Item foi apagado com sucesso";
                }
                else
                {
                    return "Não podes apagar o que não há para apagar!";
                }
            }
            catch (Exception e)
            {
                return "Ocorreu um erro ao tentar apagar";
            }
        }
    }
}
