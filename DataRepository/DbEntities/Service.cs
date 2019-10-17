using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string Name { get; set; }

        public WorkerType WorkerType { get; set; }

        public ICollection<WorkerService> WorkerServices { get; set; }
    }
}
