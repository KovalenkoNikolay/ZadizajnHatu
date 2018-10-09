using DataRepository.DbEntities.Works;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.Users
{
    public class Designer
    {
        // TODO: Avatar
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DesignerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public List<Work> Works { get; set; }
        public string Description { get; set; }

        // JSON:
        //public List<Phone> PhoneNumbers { get; set; }
        //public List<Link> Links { get; set; }
        //public string Email { get; set; }
        //public Place Place { get; set; }
        //public class Place
        //{
        //    public string Country { get; set; }
        //    public string City { get; set; }
        //    public string Addresse { get; set; }
        //}
        //public class Link
        //{
        //    public string LinkAddresse { get; set; }

        //    public LinkType LinkType { get; set; }
        //}
        //public class LinkType
        //{
        //    public int LinkTypeId { get; set; }
        //    public string LinkTypeName { get; set; } //Pinterest, Behance, Twitter, Facebook, Site, Instagramm
        //}
        public string ContactInfo { get; set; }
        
        public User User { get; set; }
    }
}
