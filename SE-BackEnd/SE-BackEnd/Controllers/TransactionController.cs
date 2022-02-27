using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SE_BackEnd.Mapping.Dto.TransactionDtos;
using SE_BackEnd.Services;

namespace SE_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        [HttpGet("ForMember/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetAllTransactionsForMemberResponseDto>> GetAllTransactionsForMember(Guid id)
        {
            var transactions = await this.transactionService.GetAllTransactionsForMember(id);
            return this.Ok(transactions);
        }

        [HttpGet("{transactionId}")]
        public async Task<ActionResult<TransactionDto>> GetTransaction(Guid transactionId) => this.Ok(await this.transactionService.Get(transactionId));

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TransactionDto>> AddTransaction([FromBody] AddTransactionRequestDto memberRequestDto)
        {
            if (!this.ModelState.IsValid) return this.BadRequest();

            try
            {
                return this.Ok(await this.transactionService.Add(memberRequestDto));
            }
            catch
            {
                return this.BadRequest();
            }
        }

        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<ActionResult<Member>> UpdateMember([FromBody] UpdateMemberRequestDto memberRequestDto)
        //{
        //    if (!this.ModelState.IsValid) return this.BadRequest();

        //    try
        //    {
        //        return this.Ok(await this.memberService.Update(memberRequestDto));
        //    }
        //    catch
        //    {
        //        return this.BadRequest();
        //    }
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<ActionResult<bool>> DeleteMember(Guid id)
        //{
        //    try
        //    {
        //        return this.Ok(await this.memberService.Delete(id));
        //    }
        //    catch
        //    {
        //        return this.BadRequest();
        //    }
        //}
    }
}