using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities.Tasks
{
    public class TaskStatus
    {
        [Key]
        public int TaskStatusId { get; set; }

        public string TaskStatusName { get; set; }
    }
}
