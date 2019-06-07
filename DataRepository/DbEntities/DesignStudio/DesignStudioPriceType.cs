using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.DesignStudio
{
    public class DesignStudioPriceType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<DesignStudioPrice> Prices { get; set; }
    }
}
