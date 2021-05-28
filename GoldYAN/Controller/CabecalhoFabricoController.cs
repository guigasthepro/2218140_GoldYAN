using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using GoldYAN.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Dapper;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldYAN.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Admin, Dev, Atendimento, Oficina, Contabilidade")]

    public class CabecalhoFabricoController : ControllerBase
    {
        List<CabecalhoFabrico> LerCodigos = new List<CabecalhoFabrico>();
        CabecalhoFabrico LerCodigo = new CabecalhoFabrico();


        private readonly IHostEnvironment _environment;
        private readonly IConfiguration configuration;
        private string connectionString;
        public CabecalhoFabricoController(IConfiguration configRoot, IHostEnvironment environment)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
            _environment = environment;
        }

        [HttpGet]
        public List<CabecalhoFabrico> GetAll()
        {
            LerCodigos = new List<CabecalhoFabrico>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<CabecalhoFabrico>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        [HttpGet("{id}")]
        public List<CabecalhoFabrico> GetAllQuery(int id)
        {
            string query = $"SELECT * FROM `modelos` WHERE idmodelo = {id}";

            LerCodigos = new List<CabecalhoFabrico>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<CabecalhoFabrico>(query).ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }


        //[HttpGet("{id}")]
        //public List<Fabrico> GetSingleQuery(string id, int linha)
        //{
        //    string query = $"SELECT * FROM `modelos` WHERE idmodelo = '{id}' AND linha = '{linha}'";


        //    using (MySqlConnection DBConn = new MySqlConnection(connectionString))
        //    {
        //        var res = DBConn.Query<Modelos>(Fabrico).ToList();
        //        return res;
        //    }


        //}


        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public CabecalhoFabrico Get(int id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<CabecalhoFabrico>(id);
                return res;
            }
        }


        // POST api/<CodigoPostalController>
        [HttpPost]
        public CabecalhoFabrico Post([FromBody] CabecalhoFabrico encomenda)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                //string imgname = encomenda.Image.FileName;
                //string extension = Path.GetExtension(imgname);

                //string newFileName = $"{Guid.NewGuid()}{extension}";
                //string filePath = Path.Combine(_environment.ContentRootPath, "Images", newFileName);

                //using(var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                //{
                //     encomenda.Image.CopyToAsync(fileStream);
                //}

                var idNewRec = DBConn.Insert<CabecalhoFabrico>(encomenda);
                var res = DBConn.Get<CabecalhoFabrico>(idNewRec);
                return res;
            }
        }

        [HttpPut]
        public ActionResult<CabecalhoFabrico> Put(string id, int linha, [FromBody] CabecalhoFabrico cmodelos)
        {
            string getsql = $"SELECT* FROM `modelos` WHERE idmodelo = '{id}' AND linha = '{linha}';";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Query<CabecalhoFabrico>(getsql).ToList();

                if (recLido != null)
                {


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
                var res = DBConn.Get<CabecalhoFabrico>(id);
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
