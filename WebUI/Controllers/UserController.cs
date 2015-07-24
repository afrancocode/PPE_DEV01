using System.Linq;
using System.Web.Mvc;
using EstimatorApp.Domain.Entities;
using EstimatorApp.Domain.Abstract;
using EstimatorApp.WebUI.Models;

namespace EstimatorApp.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUsersRepository repository;
        private IRolesRepository rolesRepository;
        
        public UserController(IUsersRepository userRepository, IRolesRepository rolesRepository)
        {
            this.repository = userRepository;
            this.rolesRepository = rolesRepository;
        }

        public ViewResult List()
        {
            UsersListViewModel model = new UsersListViewModel { UsersList = repository.UsersList };
            return View(model);
        }

        public ActionResult Edit(int userID = 0)
        {
            User userItem = new User();
            if (userID != 0)
            {
                ViewBag.Edit = "Edit";
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
        public ActionResult Save(User userToSave)
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