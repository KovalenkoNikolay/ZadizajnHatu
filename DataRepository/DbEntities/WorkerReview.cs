using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataRepository.DbEntities
{
    public class WorkerReview
    {
        [Key]
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public Guid WorkerId { get; set; }

        // public Guid UserId { get; set; }
    }
}
