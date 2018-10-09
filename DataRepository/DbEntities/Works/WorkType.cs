using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities.Works
{
    public class WorkType
    {
        [Key]
        public int WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
    }
}
