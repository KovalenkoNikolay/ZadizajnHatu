using System;
using System.Collections.Generic;

namespace PublicApi.Models.Worker
{
    public class PortfolioProject
    {
        public Guid PortfolioProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
