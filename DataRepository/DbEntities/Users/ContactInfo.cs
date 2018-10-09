using System.Collections.Generic;

namespace DataRepository.DbEntities.Users
{
    public class ContactInfo
    {
        public List<Phone> PhoneNumbers { get; set; }

        public List<Link> Links { get; set; }

        public string Email { get; set; }

        public Place Place { get; set; }
    }
}