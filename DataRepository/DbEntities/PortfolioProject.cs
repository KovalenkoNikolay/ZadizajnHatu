using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities
{
    public class PortfolioProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PortfolioProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Image> Images { get; set; }

        public Worker Worker { get; set; }
    }
}
