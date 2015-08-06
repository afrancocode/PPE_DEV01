using System.ComponentModel.DataAnnotations;

namespace EstimatorApp.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required.", AllowEmptyStrings = false)]
        [Display(Name = "Username: ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.", AllowEmptyStrings = false)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}