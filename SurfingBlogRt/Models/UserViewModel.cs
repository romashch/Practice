using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SurfClub.Models
{
    public class UserViewModel : User
    {
        [Required(ErrorMessage = "*Поле обязательно для заполнения")]
        [Display(Name = "Подтвердите пароль*")]       
        public string ConfirmPassword { get; set; }
    }
}
