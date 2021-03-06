using System.ComponentModel.DataAnnotations;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class UpdateMemberResponseDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int SpendingLimit { get; set; }

        [StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }
    }
}