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
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public Guid WorkId { get; set; }

        public void asdf()
        {
            var asdf = new WorkerTypeId();
        }
    }
}
