using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CanecasPersonalizadas.Context;
using CanecasPersonalizadas.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aereo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                return Ok(ctx.Endereco.ToList());
            }
        }

        [HttpGet("{id}")]
        public ActionResult getPeloId(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Endereco endereco = ctx.Endereco.Where(e => e.Id.Equals(id)).FirstOrDefault();

                if (endereco == null)
                    return NotFound();

                return Ok(endereco);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delte(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Endereco endereco = ctx.Endereco.Where(e => e.Id.Equals(id)).FirstOrDefault();

                if (endereco == null)
                    return NotFound();

                ctx.Endereco.Remove(endereco);
                ctx.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Endereco endereco)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Endereco.Add(endereco);
                ctx.SaveChanges();
            }
            return Ok(endereco);
        }

        [HttpPut]
        public ActionResult Put(Endereco endereco)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Endereco.Update(endereco);
                ctx.SaveChanges();
            }
            return Ok(endereco);
        }
    }
}