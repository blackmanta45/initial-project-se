using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SE_BackEnd.Dto.MemberDtos;
using SE_BackEnd.Models;
using SE_BackEnd.Services;

namespace SE_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MemberController(IMemberService memberService)
        {
            this.memberService = memberService;
        }

        [HttpGet]
        public async Task<IEnumerable<Member>> GetAllMembers() => await this.memberService.GetAll();

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(Guid id) => await this.memberService.Get(id);

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Member>> AddMember([FromBody] AddMemberRequestDto memberRequestDto)
        {
            if (!this.ModelState.IsValid) return this.BadRequest();

            try
            {
                return this.Ok(await this.memberService.Add(memberRequestDto));
            }
            catch
            {
                return this.BadRequest();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Member>> UpdateMember([FromBody] UpdateMemberRequestDto memberRequestDto)
        {
            if (!this.ModelState.IsValid) return this.BadRequest();

            try
            {
                return this.Ok(await this.memberService.Update(memberRequestDto));
            }
            catch
            {
                return this.BadRequest();
            }
        }
    }
}