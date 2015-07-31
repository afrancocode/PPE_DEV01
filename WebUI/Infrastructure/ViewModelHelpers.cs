using System.Collections.Generic;

namespace EstimatorApp.WebUI.Infrastructure
{
    using Domain.Entities;
    using Models;
    using Domain.Abstract;

    public static class ViewModelHelpers
    {
        public static IEnumerable<ListViewModel> ConvertToListViewModel(this IEnumerable<User> users)
        {
            foreach(var user in users)
            {
                yield return new ListViewModel { UserID = user.UserID, Username = user.Username, Name = user.Name, Role = user.Role.RoleName };
            }
        }

        public static EditViewModel ConvertToEditViewModel(this User users)
        {
            EditViewModel vmodel =  new EditViewModel { UserID = users.UserID, Username = users.Username, Password = users.Password, Name = users.Name, Role = users.Role.RoleName, Email = users.Email };
            if (users.Role.RoleName == "Pricer") { vmodel.PPCredentials = users.PPCredentials; }
            return vmodel;
        }

        public static User ConvertEditViewModelToUser(this EditViewModel vmodel, IRolesRepository rolesRepository )
        {
            User user = new User { UserID = vmodel.UserID, Username = vmodel.Username, Password = vmodel.Password, Name = vmodel.Name, Email = vmodel.Email };
            user.Role = rolesRepository.FindRole(vmodel.Role);
            if (vmodel.Role == "Pricer") { user.PPCredentials = vmodel.PPCredentials; }
            return user;
        }
    }
}