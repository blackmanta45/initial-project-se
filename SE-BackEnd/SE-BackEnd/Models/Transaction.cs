using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SE_BackEnd.Common;
using SE_BackEnd.Entity;

namespace SE_BackEnd.Models
{
    [Table("transaction")]
    public sealed class Transaction : EntityBase
    {
        [Required]
        public Member Member { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Details { get; set; }
    }
}