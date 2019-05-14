using AutoMapper;
using DataRepository.DbEntities.Users;

namespace PublicApi
{
    public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<User, AppUser>());
        }
    }
}
