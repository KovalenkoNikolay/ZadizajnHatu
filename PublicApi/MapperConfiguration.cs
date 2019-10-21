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
                cfg.CreateMap<DesignStudioPrice, Price>()
                    .ForMember(x => x.Min, opt => opt.MapFrom(src => src.MinPrice))
                    .ForMember(x => x.PriceTypeId, opt => opt.MapFrom(src => src.PriceTypeId));
                cfg.CreateMap<DataRepository.DbEntities.DesignStudio.DesignStudio, Models.DesignStudio.DesignStudio>()
                    .ForMember(x => x.CoverPath, opt => opt.MapFrom(src => ImageManager.GetImgFullPath(src.CoverName)));
                cfg.CreateMap<DataRepository.DbEntities.DesignStudio.DesignStudioPortfolio, Models.DesignStudio.DesignStudioPortfolio>();
                cfg.CreateMap<DesignStudioImage, Image>()
                    .ForMember(x => x.FullPath, opt => opt.MapFrom(src => ImageManager.GetImgFullPath(src.FileName)));
            });
        }
    }
}

