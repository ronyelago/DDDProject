using System.Collections.Generic;
using System.Linq;
using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;

namespace DDDProject.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
