using System;

namespace PublicApi.Models.Worker
{
    public class WorkerDetails
    {
        public Guid WorkerId { get; set; }
        public string Name { get; set; }

        public int Rating { get; set; }

        public ContactInfo ContactInfo { get; set; }

        //public int WorkerTypeId { get; set; }
        //public WorkerType WorkerType { get; set; }
        //public WorkerPrice WorkerPrice { get; set; }

        //public ICollection<PortfolioProject> PortfolioProjects { get; set; }
        //public ICollection<WorkerService> WorkerServices { get; set; }
        //public ICollection<WorkerCity> WorkerCities { get; set; }
        //public ICollection<WorkGeography> WorkGeographies { get; set; }
    }
}
