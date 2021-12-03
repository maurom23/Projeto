using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanecasPersonalizadas.Entity
{
    public class ItemDeVenda
    {
        public int Quantidade { get; set; }


        public int Id { get; set; }


        public Produto Produto { get; set; }

    }
}
