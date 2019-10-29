using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class Worker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkerId { get; set; }
        public string Name { get; set; }
        // JSON
        public string ContactInfo { get; set; }

        public int WorkerTypeId { get; set; }
        public WorkerType WorkerType { get; set; }
        public WorkerPrice WorkerPrice { get; set; }

        public ICollection<PortfolioProject> PortfolioProjects { get; set; }
        public ICollection<WorkerService> WorkerServices { get; set; }
        public ICollection<WorkerCity> WorkerCities { get; set; }
        public ICollection<WorkGeography> WorkGeographies { get; set; }

        // TODO: Add after authentication
        //public Guid UserId { get; set; }
    }
}
