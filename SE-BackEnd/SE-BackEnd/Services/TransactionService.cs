using System;
using System.Threading.Tasks;
using AutoMapper;
using SE_BackEnd.Mapping.Dto.TransactionDtos;
using SE_BackEnd.Models;
using SE_BackEnd.Repositories;

namespace SE_BackEnd.Services
{
    public sealed class TransactionService : ITransactionService
    {
        private readonly IMapper mapper;
        private readonly IMemberRepository memberRepository;
        private readonly ITransactionRepository transactionRepository;

        public TransactionService(
            IMapper mapper,
            ITransactionRepository transactionRepository,
            IMemberRepository memberRepository)
        {
            this.mapper = mapper;
            this.transactionRepository = transactionRepository;
            this.memberRepository = memberRepository;
        }

        public async Task<TransactionDto> Get(Guid transactionId)
        { 
            var dbTransaction = await this.transactionRepository.GetByIdAsync(transactionId);
            return this.mapper.Map<TransactionDto>(dbTransaction);
        }

        public async Task<GetAllTransactionsForMemberResponseDto> GetAllTransactionsForMember(Guid memberId)
        {
            var member = await this.memberRepository.GetByIdAsync(memberId);
            var transactions = await this.transactionRepository.GetAllTransactionsForMember(member);
            return this.mapper.Map<GetAllTransactionsForMemberResponseDto>(transactions);
        }

        public async Task<AddTransactionResponseDto> Add(AddTransactionRequestDto dto)
        {
            var transaction = this.mapper.Map<Transaction>(dto);
            var dbTransaction = await this.transactionRepository.AddAsync(transaction);
            return this.mapper.Map<AddTransactionResponseDto>(dbTransaction);
        }
    }
}