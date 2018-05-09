using AutoMapper;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;

namespace DDDProject.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}