using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RolePasswordManager.Models.Requests
{
    public class RegisterRequest
    {
        [Required(ErrorMessage ="Вы должны указать почту")]
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Вы должны указать имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Вы должны указать фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Вы должны указать пароль")]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Подтвердите пароль")]
        [Compare("Password",ErrorMessage ="Пароли должны совпадать")]
        [DataType(DataType.Password)]
        [Display(Name ="Повторите пароль")]
        public string PasswordConfirm { get; set; }
    }
}
