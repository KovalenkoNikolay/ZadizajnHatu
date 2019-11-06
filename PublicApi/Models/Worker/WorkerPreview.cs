using System;
using System.Collections.Generic;

namespace PublicApi.Models.Worker
{
    public class WorkerPreview
    {
        public Guid WorkerId { get; set; }

        public string Name { get; set; }

        public decimal Rating { get; set; }

        public int RatingCount { get; set; }

        public int CommentCount { get; set; }

        public int WorkerTypeId { get; set; }

        public ICollection<WorkerCity> WorkerCities { get; set; }
    }
}
