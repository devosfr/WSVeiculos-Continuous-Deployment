using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSVeiculos.DTO
{
    public class Produtos
    {

        public int CodProdutos { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int CodClient { get; set; }

        public virtual Cliente Cliente { get; set; }

        public double Preco { get; set; }

    }
}
