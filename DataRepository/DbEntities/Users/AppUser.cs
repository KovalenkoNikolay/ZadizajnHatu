using Microsoft.AspNetCore.Identity;

namespace DataRepository.DbEntities.Users
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactInfo { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public int UserType { get; set; }
    }
}
