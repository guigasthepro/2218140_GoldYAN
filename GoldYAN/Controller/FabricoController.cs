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

    public class FabricoController : ControllerBase
    {
        List<Fabrico> LerCodigos = new List<Fabrico>();
        Fabrico LerCodigo = new Fabrico();


        private readonly IHostEnvironment _environment;
        private readonly IConfiguration configuration;
        private string connectionString;
        public FabricoController(IConfiguration configRoot, IHostEnvironment environment)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
            _environment = environment;
        }

        [HttpGet]
        public List<Fabrico> GetAll()
        {
            LerCodigos = new List<Fabrico>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Fabrico>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }

        [HttpGet("{id}")]
        public List<Fabrico> GetAllQuery(int id)
        {
            string query = $"SELECT * FROM `fabricos` WHERE idfabrico = '{id}'";

            LerCodigos = new List<Fabrico>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Query<Fabrico>(query).ToList();
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
        public Fabrico Get(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Fabrico>(id);
                return res;
            }
        }


        // POST api/<CodigoPostalController>
        [HttpPost]
        public Fabrico Post([FromBody] Fabrico encomenda)
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

                var idNewRec = DBConn.Insert<Fabrico>(encomenda);
                var res = DBConn.Get<Fabrico>(idNewRec);
                return res;
            }
        }

        [HttpPut]
        public ActionResult<Fabrico> Put(string id, int linha, [FromBody] Fabrico cmodelos)
        {
            string getsql = $"SELECT* FROM `modelos` WHERE idmodelo = '{id}' AND linha = '{linha}';";

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var recLido = DBConn.Query<Fabrico>(getsql).ToList();

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
        public string Delete(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Fabrico>(id);
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
