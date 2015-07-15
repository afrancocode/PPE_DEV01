using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EstimatorApp.Domain
{
    public class Users
    {
        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }

        [Required()]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; }

        [Required()]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required()]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Role must be specified.")]
        [DataType(DataType.Text)]
        [StringLength(255)]
        public string Role { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(128)]
        [Required()]
        public string Email { get; set; }
    }
}
