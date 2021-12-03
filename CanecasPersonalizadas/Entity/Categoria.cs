using System.Collections.Generic;

namespace CanecasPersonalizadas.Entity
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }




    }
}