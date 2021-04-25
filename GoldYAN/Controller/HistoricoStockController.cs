﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    public class HistoricoStockController : ControllerBase
    {
        List<HistoricoStock> LerCodigos = new List<HistoricoStock>();
        HistoricoStock LerCodigo = new HistoricoStock();

        private readonly IConfiguration configuration;
        private string connectionString;
        public HistoricoStockController(IConfiguration configRoot)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        [HttpGet]
        public List<HistoricoStock> GetAll()
        {
            LerCodigos = new List<HistoricoStock>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<HistoricoStock>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public HistoricoStock Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<HistoricoStock>(id);
                return res;
            }
        }

        // POST api/<CodigoPostalController>
        [HttpPost]
        public HistoricoStock Post([FromBody] HistoricoStock encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var idNewRec = DBConn.Insert<HistoricoStock>(encomenda);
                var res = DBConn.Get<HistoricoStock>(idNewRec);
                return res;
            }
        }

        // DELETE api/<CodigoPostalController>/5

        [HttpPut("{id}")]
        public ActionResult<HistoricoStock> Put(int id, [FromBody] HistoricoStock cliente)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<HistoricoStock>(id);

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


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<HistoricoStock>(id);
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