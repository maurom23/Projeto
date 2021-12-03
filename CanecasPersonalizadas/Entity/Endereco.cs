using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanecasPersonalizadas.Entity
{
    public class Endereco
    {
        public string Rua { get; set; }

        public int Número{ get; set; }

        public int Complemento { get; set; }

        public int Bairro{ get; set; }

        public int Cidade { get; set; }

        public int Cep { get; set; }
        public int Id { get; set; }
    }
}
