using System;
using System.Collections.Generic;

namespace PublicApi.Models.DesignStudio
{
    public class DesignStudioPortfolio
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid DesignStudioId { get; set; }

        public List<Image> Images { get; set; }
    }
}
