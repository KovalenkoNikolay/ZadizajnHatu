using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class WorkerCity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerCityId { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; }

        public Guid WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
