using System.ComponentModel.DataAnnotations;

namespace SurfClub.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*Поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимальная длина псевдонима - 3 символа")]
        [MaxLength(20, ErrorMessage = "Максимальная длина псевдонима - 20 символов")]
        [Display(Name = "Псевдоним")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "*Поле обязательно для заполнения")]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля - 6 символов")]
        [MaxLength(20, ErrorMessage = "Максимальная длина пароля - 20 символов")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
