using System.Collections;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
