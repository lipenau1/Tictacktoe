using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Cors;


namespace TestArquive.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            using var db = new Data.ApplicationContext();
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var item in db.Usuarios)
            {
                usuarios.Add(item);
            }
            return JsonConvert.SerializeObject(usuarios);
        }

        [HttpGet("{id}")]

        public Usuario Get(string id)
        {
            using var db = new Data.ApplicationContext();
            return db.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario Usuario)
        {
            if (!UsuarioExiste(Usuario.Id))
            {
                using var db = new Data.ApplicationContext();
                db.Usuarios.Add(Usuario);
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, Usuario value)
        {
            using var db = new Data.ApplicationContext();
            try
            {
                if (UsuarioExiste(id))
                {
                    var objUsuario = db.Usuarios.FirstOrDefault(x => x.Id == id);
                    var obj = new
                    {
                        NameUser = value.NameUser,
                        SubName = value.SubName,
                        Email = value.Email,
                        Phone = value.Phone,
                        Date = value.Date,
                        Password = value.Password,
                    };

                    db.Entry(objUsuario).CurrentValues.SetValues(obj);
                    db.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if (UsuarioExiste(id))
            {
                using var db = new Data.ApplicationContext();
                db.Usuarios.Remove(db.Usuarios.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }

        private bool UsuarioExiste(string id)
        {
            using var db = new Data.ApplicationContext();
            return db.Usuarios.Any(e => e.Id == id);
        }
    }
}
