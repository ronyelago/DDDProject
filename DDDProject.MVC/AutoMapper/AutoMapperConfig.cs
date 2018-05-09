using AutoMapper;

namespace DDDProject.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cgc =>
            {
                cgc.AddProfile<DomainToViewModelMappingProfile>();
                cgc.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}