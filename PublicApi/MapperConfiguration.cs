using AutoMapper;
using BusinessLogic.Managers;
using DataRepository.DbEntities;
using DataRepository.DbEntities.DesignStudio;
using DataRepository.DbEntities.Users;
using Newtonsoft.Json;
using PublicApi.Models.DesignStudio;
using PublicApi.Models.Worker;

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
                //cfg.CreateMap<DesignStudioImage, Image>()
                //    .ForMember(x => x.FullPath, opt => opt.MapFrom(src => ImageManager.GetImgFullPath(src.FileName)));

                cfg.CreateMap<DataRepository.DbEntities.Worker, Models.Worker.Worker>();
                cfg.CreateMap<DataRepository.DbEntities.PortfolioProject, Models.Worker.PortfolioProject>();
                cfg.CreateMap<DataRepository.DbEntities.Image, Models.Image>();
                cfg.CreateMap<DataRepository.DbEntities.Worker, WorkerDetails>()
                    .ForMember(x => x.ContactInfo, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<ContactInfo>(src.ContactInfo)));
            });
        }
    }
}

