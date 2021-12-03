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
    public class VendaController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                return Ok(ctx.Vendas.ToList());
            }
        }

        [HttpGet("{id}")]
        public ActionResult getPeloId(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Venda venda = ctx.Vendas.Where(e => e.Id.Equals(id)).FirstOrDefault();

                if (venda == null)
                    return NotFound();

                return Ok(venda);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delte(int id)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                Venda venda = ctx.Vendas.Where(e => e.Id.Equals(id)).FirstOrDefault();

                if (venda == null)
                    return NotFound();

                ctx.Vendas.Remove(venda);
                ctx.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Venda venda)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Vendas.Add(venda);
                ctx.SaveChanges();
            }
            return Ok(venda);
        }

        [HttpPost("CompraCarrinho")]
        public ActionResult PostCompraCarrinho(Venda[] vendas)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                for (int i = 0; i < vendas.Count(); i++)
                {
                    ctx.Vendas.Add(vendas[i]);
                }
                ctx.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Venda venda)
        {
            using (CanecasPersonalizadasContext ctx = new CanecasPersonalizadasContext())
            {
                ctx.Vendas.Update(venda);
                ctx.SaveChanges();
            }
            return Ok(venda);
        }
    }
}