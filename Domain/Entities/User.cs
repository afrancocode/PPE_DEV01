using System.Web.Mvc;

namespace EstimatorApp.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public PricerCredentials PPCredentials { get; set; }
    }
}
