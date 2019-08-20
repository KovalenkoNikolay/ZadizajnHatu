using AutoMapper;
using DataRepository.DbEntities.DesignStudio;
using DataRepository.DbEntities.Users;
using PublicApi.Models.DesignStudio;

namespace PublicApi
{
    public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<User, AppUser>();
                cfg.CreateMap<CreateDesignStudio, DesignStudio>();
            });
        }
    }
}
