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

    public class EstadosController : ControllerBase
    {
        List<Estados> LerCodigos = new List<Estados>();
        Estados LerCodigo = new Estados();


        private readonly IHostEnvironment _environment;
        private readonly IConfiguration configuration;
        private string connectionString;
        public EstadosController(IConfiguration configRoot, IHostEnvironment environment)
        {
            configuration = configRoot; // atribuir as configurações ao campo privado
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
            _environment = environment;
        }

        [HttpGet]
        public List<Estados> GetAll()
        {
            LerCodigos = new List<Estados>();

            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.GetAll<Estados>().ToList();
                LerCodigos = res;
            }

            return LerCodigos;
        }


        // GET api/<CodigoPostalController>/5
        [HttpGet("{id}")]
        public Estados Get(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Estados>(id);
                return res;
            }
        }


        // POST api/<CodigoPostalController>
        [HttpPost]
        public Estados Post([FromBody] Estados encomenda)
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

                var idNewRec = DBConn.Insert<Estados>(encomenda);
                var res = DBConn.Get<Estados>(idNewRec);
                return res;
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Clientes> Put(int id, [FromBody] Clientes cliente)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {

                var recLido = DBConn.Get<Clientes>(id);

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

        // DELETE api/<CodigoPostalController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            using (MySqlConnection DBConn = new MySqlConnection(connectionString))
            {
                var res = DBConn.Get<Estados>(id);
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
