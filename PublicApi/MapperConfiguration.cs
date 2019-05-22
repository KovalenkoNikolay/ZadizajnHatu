using AutoMapper;
using BusinessLogic.Managers;
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
                cfg.CreateMap<CreateDesignStudio, DataRepository.DbEntities.DesignStudio.DesignStudio>();
                cfg.CreateMap<DataRepository.DbEntities.DesignStudio.DesignStudio, Models.DesignStudio.DesignStudio>().ForMember(x=>x.CoverPath, opt=> opt.MapFrom(src=> ImageManager.GetImgFullPath(src.CoverName)));
            });
        }
    }
}
