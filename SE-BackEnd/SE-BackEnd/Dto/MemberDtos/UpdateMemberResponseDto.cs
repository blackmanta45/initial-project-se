﻿using System.ComponentModel.DataAnnotations;

namespace SE_BackEnd.Dto.MemberDtos
{
    public class UpdateMemberResponseDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        [StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }
    }
}