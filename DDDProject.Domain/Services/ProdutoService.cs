using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;

namespace DDDProject.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoRepository
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
