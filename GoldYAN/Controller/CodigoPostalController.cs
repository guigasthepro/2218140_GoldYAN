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
    public class CodigoPostalController : ControllerBase
    {
        // GET: api/<CodigoPostalController>

        List<Codigopostal> LerCodigos = new List<Codigopostal>();
        Codigopostal LerCodigo = new Codigopostal();

        private readonly IConfiguration configuration;
        private string connectionString;
        public CodigoPostalController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<Codigopostal> Get()
        {
            LerCodigos = new List<Codigopostal>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Codigopostal>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Codigopostal Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Codigopostal>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public Codigopostal Post([FromBody] Codigopostal codigopostal)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<Codigopostal>(codigopostal);
                var res = DBConn.Get<Codigopostal>(idNewRec);
                return res;
            }
        }

        // PUT api/<CodigoPostalController>/5
        [HttpPut("{id}")]
        public ActionResult<Codigopostal> Put(int id, [FromBody] Codigopostal codigopostal)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Get<Codigopostal>(id);

                if (recLido != null)
                {
                    recLido.idcodigopostal = codigopostal.idcodigopostal;
                    recLido.descricao = codigopostal.descricao;

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
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Codigopostal>(id);
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