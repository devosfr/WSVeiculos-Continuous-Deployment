using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSVeiculos.DTO;

namespace WSVeiculos.DAL.EntitiesConfig
{
    public class ProdutosMap : EntityTypeConfiguration<Produtos>
    {

        public ProdutosMap()
        {

            ToTable("Produtos");

            HasKey(p => p.CodProdutos);

            Property(p => p.Marca).IsRequired().HasMaxLength(100);

            Property(p => p.Modelo).IsRequired().HasMaxLength(100);

            Property(p => p.Preco).IsRequired();

            HasRequired(p => p.Cliente);

           
        }


    }
}
