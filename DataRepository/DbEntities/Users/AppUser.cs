using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DataRepository.DbEntities.Users
{
    public class AppUser : IdentityUser
    {
        public List<DesignStudio.DesignStudio> DesignStudios { get; set; }
    }
}
