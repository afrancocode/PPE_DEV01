using System.Web.Mvc;

namespace EstimatorApp.WebUI.Models
{
    public class ListViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}