using System.ComponentModel.DataAnnotations;

namespace ABPCoreLearning.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}