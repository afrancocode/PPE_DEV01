using System.Collections.Generic;
using EstimatorApp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EstimatorApp.WebUI.Models
{
    public class UsersListViewModel
    {
        public IEnumerable<User> UsersList { get; set; }
    }
}