using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CanecasPersonalizadas.Context;
using CanecasPersonalizadas.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CanecasPersonalizadas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                var list = ctx.Usuarios.ToList();
                return Ok(list);
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetPeloId(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Usuarios cliente = ctx.Usuarios.Where(c => c.Id.Equals(id)).FirstOrDefault();

                if (cliente == null)
                    return NotFound();

                return Ok(cliente);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Usuarios cliente = ctx.Usuarios.Where(c => c.Id.Equals(id)).FirstOrDefault();

                if (cliente == null)
                    return NotFound();

                 ctx.Usuarios.Remove(cliente);
                ctx.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Usuarios cliente)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Usuarios.Add(cliente);
                ctx.SaveChanges();
            }
            return Ok(cliente);
        }

        [HttpPut]
        public ActionResult Put(Usuarios cliente)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Usuarios.Update(cliente);
                ctx.SaveChanges();
            }
            return Ok(cliente);
        }
    }

    internal class Cliente
    {
    }
}