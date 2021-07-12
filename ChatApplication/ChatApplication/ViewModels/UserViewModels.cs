using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ChatApplication.ViewModels
{
    public class UserViewModels
    {

        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required(ErrorMessage = "The email address is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmedPassword { get; set; }
        public string ErrorMessage { get; set; }

    }
}
