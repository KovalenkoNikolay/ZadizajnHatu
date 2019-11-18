using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class WorkGeography
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkGeographyId { get; set; }

        public bool IsInLocation { get; set; }

        public bool IsFullCountry { get; set; }

        public ICollection<Region> Regions { get; set; }
    }
}
