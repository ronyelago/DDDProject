﻿using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;

namespace DDDProject.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}