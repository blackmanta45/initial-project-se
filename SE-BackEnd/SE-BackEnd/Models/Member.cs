using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE_BackEnd.Models
{
    [Table("member")]
    public class Member
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

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

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime ModifiedAt { get; set; }
    }
}