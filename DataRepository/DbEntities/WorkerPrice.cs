using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataRepository.DbEntities
{
    public class WorkerPrice
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public Guid WorkId { get; set; }
    }
}
