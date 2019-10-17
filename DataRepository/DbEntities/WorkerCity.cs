using System;

namespace DataRepository.DbEntities
{
    public class WorkerCity
    {
        public Guid CityId { get; set; }
        public City City { get; set; }

        public Guid WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
