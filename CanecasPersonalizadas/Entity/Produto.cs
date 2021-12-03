using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanecasPersonalizadas.Entity
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Categoria Categoria { get; set; }

        public int CategoriaId { get; set; }


        public string Descricao { get; set; }




    }
}
