using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSVeiculos.DAL.Interfaces;
using WSVeiculos.DTO;

namespace WSVeiculos.DAL
{
    public class ProdutosRepository : RepositoryBase<Produtos>, IProdutosRepository
    {
       public IEnumerable<Produtos> BuscarPorNome(string marca)
        {
            return db.Produtos.Where(x => x.Marca == marca);
        }
    }
}
