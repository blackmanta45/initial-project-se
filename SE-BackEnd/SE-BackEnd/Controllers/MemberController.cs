using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SE_BackEnd.Dto;
using SE_BackEnd.Models;
using SE_BackEnd.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService memberService;
        private readonly IMapper mapper;
        public MemberController(IMapper mapper,IMemberService memberService)
        {
            this.memberService = memberService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            return await memberService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(Guid id)
        {
            return await memberService.Get(id); 
        }

       [HttpPost]
       [ProducesResponseType(StatusCodes.Status200OK)]
       [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Member>> PutMember([FromBody]AddMemberDto memberDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var member = this.mapper.Map<Member>(memberDto);
            member.CreatedAt = DateTime.Now;
            var memberResult = await memberService.Update(member);

            if (memberResult == null) return BadRequest();

            return Ok(mapper.Map<AddMemberDto>(memberResult));
          
        }

    }
}
