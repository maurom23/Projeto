using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CanecasPersonalizadas.Entity
{
    public class Venda
    {
        public int Id { get; set; }

        public Usuarios Usuario { get; set; }

        public IEnumerable<ItemDeVenda> Items { get; set; }

        public DateTime MomentoDaCompra { get; set; }
      
    }
}
