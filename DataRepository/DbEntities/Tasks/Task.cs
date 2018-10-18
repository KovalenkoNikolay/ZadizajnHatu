using DataRepository.DbEntities.Users;
using DataRepository.DbEntities.Works;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.Tasks
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TaskId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Work Work { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public AppUser User { get; set; }
        // TODO: Photos
    }
}