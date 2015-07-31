using System.Linq;
using System.Web.Mvc;

namespace EstimatorApp.WebUI.Controllers
{
    using Domain.Entities;
    using Domain.Abstract;
    using Models;
    using Infrastructure;

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
            var vmodel = usersRepository.UsersList.ConvertToListViewModel();
            return View(vmodel);
        }

        public ActionResult New()
        {
            EditViewModel vmodel = new EditViewModel();
            ViewBag.Title = "Create New User";
            return View("Edit", vmodel);
        }

        public ActionResult Edit(int userID)
        {
            ViewBag.Edit = "Edit";
            ViewBag.Title = "Edit User";
            var vmodel = usersRepository.UsersList.FirstOrDefault(m => m.UserID == userID).ConvertToEditViewModel();
            return View("Edit", vmodel);
        }

        public ActionResult Delete(int userID)
        {
            usersRepository.DeleteUser(userID);
            ViewBag.Confirmation = "User deleted successfully";
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Save(EditViewModel userToSave)
        {
            if (ModelState.IsValid && ValidateUser(userToSave))
            {        
                usersRepository.SaveUser(userToSave.ConvertEditViewModelToUser(rolesRepository));
                return RedirectToAction("List");
            }
            else
            {
                return View("Edit");
            }
        }

        private bool ValidateUser(EditViewModel userToSave)
        {
            var isValid = usersRepository.FindUser(userToSave.Username) == null? true : false;
            if (!isValid) { ModelState.AddModelError("Username", "Duplicated Username"); }
            return isValid;
        }
    }
}