using System.Collections.Generic;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class GetAllTransactionsForMemberResponseDto
    {
        public List<TransactionDto> Transactions { get; set; } = new();
        public decimal? TotalIncome { get; set; }
        public decimal? TotalExpense { get; set; }
        public decimal? HighestExpense { get; set; }
        public decimal? LowestExpense { get; set; }
        public decimal? HighestIncome { get; set; }
        public decimal? LowestIncome { get; set; }
        public decimal? RemainingBudget { get; set; }
    }
}