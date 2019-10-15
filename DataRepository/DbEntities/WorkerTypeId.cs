using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities
{
    public class WorkerTypeId
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
