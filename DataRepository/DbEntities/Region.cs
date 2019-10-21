using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RegionId { get; set; }
        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }
        public ICollection<WorkGeography> WorkGeographies { get; set; }
    }
}