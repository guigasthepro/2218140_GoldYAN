﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

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

        private readonly IConfiguration configuration;
        private string connectionString;
        public UnidadesController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Unidades> Get()
        {
            LerUnidades = new List<Unidades>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Unidades>().ToList();
                LerUnidades = res;
            }
            return LerUnidades;
        }

        // GET api/<UnidadesController>/5
        [HttpGet("{id}")]
        public Unidades Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Unidades>(id);
                return res;
            }
        }

        // POST api/<UnidadesController>
        [HttpPost]
        public Unidades Post([FromBody] Unidades unidades)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Unidades>(unidades);
                var res = DBConn.Get<Unidades>(idNewRec);
                return res;
            }
        }

        // PUT api/<UnidadesController>/5
        [HttpPut("{id}")]
        public ActionResult<Unidades> Put(int id, [FromBody] Unidades unidade)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Get<Unidades>(id);

                if (recLido != null)
                {
                    recLido.idunidade = unidade.idunidade;
                    recLido.indice = unidade.indice;
                    recLido.descricao = unidade.descricao;

                    bool updated = DBConn.Update(recLido);

                    return Ok(recLido);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        // DELETE api/<UnidadesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Unidades>(id);
                if (res != null)
                {
                    DBConn.Delete(res);
                    return "Sucesso!";
                }
                else
                {
                    return "Erro";
                }
            }
        }
    }
}
