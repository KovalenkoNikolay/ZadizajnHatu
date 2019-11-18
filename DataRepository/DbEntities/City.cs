using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        public string Name { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<WorkerCity> WorkerCities { get; set; }
        public ICollection<WorkGeography> WorkGeographies { get; set; }
    }
}
