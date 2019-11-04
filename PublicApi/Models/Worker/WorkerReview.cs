using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicApi.Models.Worker
{
    public class WorkerReview
    {
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public Guid WorkerId { get; set; }
    }
}
