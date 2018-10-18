using DataRepository.DbEntities.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.Works
{
    public class Work
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid WorkId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinCost { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MaxCost { get; set; }
        public string Currency { get; set; }

        public WorkType WorkType { get; set; }
        public AppUser User { get; set; }
    }
}