using System.Linq;
using System.Web.Mvc;
using EstimatorApp.Domain.Entities;
using EstimatorApp.Domain.Abstract;
using EstimatorApp.WebUI.Models;

namespace EstimatorApp.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUsersRepository usersRepository;
        private IRolesRepository rolesRepository;
        
        public UserController(IUsersRepository usersRepository, IRolesRepository rolesRepository)
        {
            this.usersRepository = usersRepository;
            this.rolesRepository = rolesRepository;
        }

        public ViewResult List()
        {
            ListViewModel model = new ListViewModel { UsersList = usersRepository.UsersList };
            return View(model);
        }

        public ActionResult Edit(int userID = 0)
        {
            User userItem = new User();
            if (userID != 0)
            {
                ViewBag.Edit = "Edit";
                ViewBag.Title = "Edit User";
     
                userItem = usersRepository.UsersList.FirstOrDefault(m => m.UserID == userID);
            }
            else
            {
                ViewBag.Title = "Create New User";
            }
            return View(userItem);
        }

        public ActionResult Delete(int userID)
        {
            usersRepository.DeleteUser(userID);
            ViewBag.Confirmation = "User deleted successfully";
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Save(User userToSave)
        {
            if (ModelState.IsValid)
            {
                usersRepository.SaveUser(userToSave);
                return RedirectToAction("List");
            }
            else
            {
                return View("Edit");
            }
        }
    }
}