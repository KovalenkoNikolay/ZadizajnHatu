using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class WorkerService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerServiceId { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public Guid WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
