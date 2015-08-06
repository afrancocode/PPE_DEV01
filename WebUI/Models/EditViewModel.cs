using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EstimatorApp.WebUI.Models
{
    using Domain.Entities;

    public class EditViewModel
    {        
        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Username is required.", AllowEmptyStrings = false)]
        [StringLength(20)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required", AllowEmptyStrings = false)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name is required", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required", AllowEmptyStrings = false)]
        public string Role { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public PricerCredentials PPCredentials { get; set; }
    }
}