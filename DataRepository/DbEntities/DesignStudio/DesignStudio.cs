using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.DesignStudio
{
    public class DesignStudio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Cover { get; set; }

        public string AppUserId { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
