using EstimatorApp.Domain.Entities;
using EstimatorApp.Domain.Abstract;
using System.ComponentModel.DataAnnotations;
using EstimatorApp.Repository.Concrete;
using System.Web.Mvc;
using System.Collections.Generic;

namespace EstimatorApp.WebUI.Models
{
    public class EditViewModel
    {        
        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(20)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public PricerCredentials PPCredentials { get; set; }
    }
}