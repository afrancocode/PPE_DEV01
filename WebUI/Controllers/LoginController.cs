using System.Linq;
using System.Web.Mvc;

namespace EstimatorApp.WebUI.Controllers
{
    using Domain.Abstract;
    using Models;
    using System.Web.Security;

    public class LoginController : Controller
    {
        private IUsersRepository usersRepository;

        public LoginController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public ActionResult Login()
        {
            if (Session["Username"] == null)
            {
                return View();
            }
            else
            {
                //this is temporary. We'll be the SPA Home page with some menues according to the Session["UserRole"] Ask Alfonso.
                return Redirect("~/User/List");
            }
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginvm)
        {
            if (ModelState.IsValid)
            {
                var user = usersRepository.UsersList.Where(m => m.Username == loginvm.Username && m.Password == loginvm.Password).FirstOrDefault();
                if (user != null)
                {
                    Session["UserID"] = user.UserID;
                    Session["UserName"] = user.Name;
                    // I think Session["UserRole"] will be needed. Ask Alfonso.
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    //this is temporary. We'll be the SPA Home page with some menues according to the role
                    return Redirect("~/User/List");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is incorrect. Please try again.");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}