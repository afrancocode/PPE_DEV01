using System.Collections.Generic;
using EstimatorApp.Domain;

namespace EstimatorApp.WebUI.Models
{
    public class UsersListViewModel
    {
        public IEnumerable<Users> UsersList { get; set; }
    }
}