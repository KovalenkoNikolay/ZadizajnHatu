using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.DesignStudio
{
    public class DesignStudioImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FileName { get; set; }

        public Guid DesignStudioPortfolioId { get; set; }
    }
}
