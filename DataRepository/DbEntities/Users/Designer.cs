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
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public List<Work> Works { get; set; }
        public string Description { get; set; }
        public ContactInfo ContactInfro { get; set; }

        public User User { get; set; }
    }
}
