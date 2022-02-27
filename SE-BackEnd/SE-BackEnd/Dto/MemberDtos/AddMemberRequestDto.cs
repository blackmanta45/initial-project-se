using System.ComponentModel.DataAnnotations;

namespace SE_BackEnd.Dto.MemberDtos
{
    public class AddMemberRequestDto
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