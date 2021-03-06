﻿using DDDProject.Domain.Entities;
using System.Collections.Generic;

namespace DDDProject.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
