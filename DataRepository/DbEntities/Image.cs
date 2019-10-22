using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PortfolioProject PortfolioProject { get; set; }
    }
}
