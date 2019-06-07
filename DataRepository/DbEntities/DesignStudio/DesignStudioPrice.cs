using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.DesignStudio
{
    public class DesignStudioPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public decimal MinPrice { get; set; }

        public int PriceTypeId { get; set; }

        public DesignStudioPriceType PriceType { get; set; }

        public Guid DesignStudioId { get; set; }

        public DesignStudio DesignStudio { get; set; }
    }
}
