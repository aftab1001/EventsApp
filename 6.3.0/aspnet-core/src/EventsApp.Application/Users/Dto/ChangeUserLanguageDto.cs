using System.ComponentModel.DataAnnotations;

namespace EventsApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}