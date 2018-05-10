using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;

namespace DDDProject.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
