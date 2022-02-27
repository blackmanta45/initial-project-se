using System.ComponentModel.DataAnnotations;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class AddMemberRequestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int SpendingLimit { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }
    }
}