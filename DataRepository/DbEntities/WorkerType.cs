using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities
{
    public class WorkerType
    {
        [Key]
        public int WorkerTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
