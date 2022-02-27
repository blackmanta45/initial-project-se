using System;
using SE_BackEnd.Common;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class TransactionDto
    {
        public Guid MemberId { get; set; }
        public TransactionType Type { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}