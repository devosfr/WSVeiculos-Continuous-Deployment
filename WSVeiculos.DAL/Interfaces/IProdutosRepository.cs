using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSVeiculos.DTO;

namespace WSVeiculos.DAL.Interfaces
{
    public interface IProdutosRepository: IRepositoryBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);

    }
}
