using System;
using System.ComponentModel.DataAnnotations;
using SE_BackEnd.Common;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class AddTransactionRequestDto
    {
        [Required]
        public Guid MemberId { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        public decimal Price { get; set; }
        public string Details { get; set; }
    }
}