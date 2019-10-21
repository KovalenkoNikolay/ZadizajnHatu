using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public ICollection<Region> Regions { get; set; }
        public ICollection<WorkGeography> WorkGeographies { get; set; }
    }
}