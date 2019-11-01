using System;

namespace PublicApi.Models.Worker
{
    public class Worker
    {
        public Guid WorkerId { get; set; }

        public string Name { get; set; }

        public string Avatar { get; set; }

        public int Rating { get; set; }

        public int WorkerTypeId { get; set; }
    }
}
