using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataRepository.DbEntities
{
    public class WorkGeography
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkGeographyId { get; set; }

        public City City { get; set; }

        public Region Region { get; set; }

        public Country Country { get; set; }

        public Worker Worker { get; set; }
    }
}
