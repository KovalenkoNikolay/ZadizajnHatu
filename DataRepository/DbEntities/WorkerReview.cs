using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class WorkerReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public Guid WorkerId { get; set; }
        public Worker Worker { get; set; }

        // public Guid ClientId { get; set; }
    }
}
