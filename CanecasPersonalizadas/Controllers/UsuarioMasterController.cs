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
    public class UsuarioMasterController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                return Ok(ctx.UsuariosMaster.ToList());
            }
        }

   

        [HttpGet("{id}")]
        public ActionResult getPeloId(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                UsuarioMaster usuarioMaster = ctx.UsuariosMaster.Where(u => u.Id.Equals(id)).FirstOrDefault();

                if (usuarioMaster == null)
                    return NotFound();

                return Ok(usuarioMaster);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delte(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                UsuarioMaster usuarioMaster = ctx.UsuariosMaster.Where(e => e.Id.Equals(id)).FirstOrDefault();

                if (usuarioMaster == null)
                    return NotFound();

                ctx.UsuariosMaster.Remove(usuarioMaster);
                ctx.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult actionResult(UsuarioMaster usuarioMaster)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.UsuariosMaster.Add(usuarioMaster);
                ctx.SaveChanges();
            }
            return Ok(usuarioMaster);
        }

        [HttpPut]
        public ActionResult Post(UsuarioMaster usuarioMaster)
        {
            using( CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.UsuariosMaster.Update(usuarioMaster);
                ctx.SaveChanges();
            }
            return Ok(usuarioMaster);
        }
    }
}

    
    