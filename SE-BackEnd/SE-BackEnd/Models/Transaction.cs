using SE_BackEnd.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE_BackEnd.Models
{
    [Table("transaction")]
    public sealed class Transaction
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Member Member { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime ModifiedAt { get; set; }

        public string Details { get; set; }
    }
}
