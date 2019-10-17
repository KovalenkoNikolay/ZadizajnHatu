using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities
{
    public class Services
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int WorkerTypeId { get; set; }
    }
}
