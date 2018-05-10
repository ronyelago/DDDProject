using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
