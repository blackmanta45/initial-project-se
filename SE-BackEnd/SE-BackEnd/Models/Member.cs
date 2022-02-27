using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SE_BackEnd.Entity;

namespace SE_BackEnd.Models
{
    [Table("member")]
    public class Member : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int SpendingLimit { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(13, MinimumLength = 13)]
        public string Cnp { get; set; }
    }
}