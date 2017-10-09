using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSVeiculos.DTO;

namespace WSVeiculos.DAL.EntitiesConfig
{
    public class ClienteMap: EntityTypeConfiguration<Cliente>
    {

        public ClienteMap()
        {

            ToTable("Cliente");

            HasKey(c => c.CodCliente);

            Property(c => c.Nome).IsRequired().HasMaxLength(100);
            

        }


    }
}
