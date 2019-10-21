using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class WorkerPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerPriceId { get; set; }

        public decimal Amount { get; set; }

        public Guid WorkerId { get; set; }

        public Worker Worker { get; set; }
    }
}
