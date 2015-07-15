using System.Linq;
using System.Web.Mvc;
using EstimatorApp.Domain;
using EstimatorApp.Repository.Abstract;
using EstimatorApp.WebUI.Models;

namespace EstimatorApp.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository repository;

        public UserController(IUserRepository userRepository)
        {
            this.repository = userRepository;
        }

        public ViewResult List()
        {
            UsersListViewModel model = new UsersListViewModel { UsersList = repository.UsersList };
            return View(model);
        }

        public ViewResult Edit(int userID = 0)
        {
            Users userItem = new Users();
            if (userID != 0)
            {
                userItem = repository.UsersList.FirstOrDefault(m => m.UserID == userID);
            }
            return View(userItem);
        }

        public ActionResult Delete(int userID)
        {
            repository.DeleteUser(userID);
            ViewBag.Confirmation = "User deleted successfully";
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Save(Users userToSave)
        {
            if (ModelState.IsValid)
            {
                repository.SaveUser(userToSave);
                return RedirectToAction("List");
            }
            else
            {
                return View("Edit");
            }
        }
    }
}