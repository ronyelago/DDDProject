using AutoMapper;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;

namespace DDDProject.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}