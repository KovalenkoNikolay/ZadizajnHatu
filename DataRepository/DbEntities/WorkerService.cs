using System;

namespace DataRepository.DbEntities
{
    public class WorkerService
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public Guid WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
