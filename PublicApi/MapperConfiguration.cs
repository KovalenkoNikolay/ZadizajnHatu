using AutoMapper;
using Newtonsoft.Json;
using PublicApi.Models.Worker;

namespace PublicApi
{
    public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<DataRepository.DbEntities.Worker, WorkerPreview>();
                cfg.CreateMap<DataRepository.DbEntities.PortfolioProject, PortfolioProject>();
                cfg.CreateMap<DataRepository.DbEntities.WorkerReview, WorkerReview>();
                cfg.CreateMap<DataRepository.DbEntities.Image, Models.Image>();
                cfg.CreateMap<DataRepository.DbEntities.Worker, WorkerDetails>()
                    .ForMember(x => x.ContactInfo, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<ContactInfo>(src.ContactInfo)));
            });
        }
    }
}

