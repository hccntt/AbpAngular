using System.ComponentModel.DataAnnotations;

namespace angularAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}