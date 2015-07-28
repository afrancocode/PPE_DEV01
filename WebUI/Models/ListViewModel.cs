using System.Collections.Generic;
using EstimatorApp.Domain.Entities;

namespace EstimatorApp.WebUI.Models
{
    public class ListViewModel
    {
        public IEnumerable<User> UsersList { get; set; }
    }
}