using System.Web.Mvc;

namespace EstimatorApp.Domain.Entities
{
    public class Role
    {
        [HiddenInput(DisplayValue = false)]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
