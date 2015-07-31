using System.Collections.Generic;
using EstimatorApp.Domain.Entities;
using EstimatorApp.Domain.Abstract;
namespace EstimatorApp.Repository.Concrete
{
    public class DummyUserDBContext
    {
        private List<User> UsersList;
        private DummyRolesDBContext RolesList;

        public DummyUserDBContext()
        {
            RolesList = new DummyRolesDBContext();
            UsersList = new List<User>();
            UsersList.Add(new User() { UserID = 1, Username = "sysadmin", Name = "System Administrator", Password = "sysadmin", Role = RolesList.FindRole("Pricer"), Email = "sysadmin@codservices.com.mx", PPCredentials = new PricerCredentials() { PPUsername="sys", PPPassword="sys" } });
            UsersList.Add(new User() { UserID = 2, Username = "mharo", Name = "Mirella Haro", Password = "ensenada", Role = RolesList.FindRole("Pricer"), Email="mharo@codeservices.com.mx", PPCredentials = new PricerCredentials() { PPUsername = "mharo", PPPassword = "ensenada" } });
            UsersList.Add(new User() { UserID = 3, Username = "dmendez", Name = "Doreen Mendez", Password = "dmendez123", Role = RolesList.FindRole("Estimator"), Email = "dmendez@codeservices.com.mx" });
        }

        public IEnumerable<User> GetUsersList()
        {
            return UsersList;
        }

        public void SaveChanges(User user)
        {
            if (user.UserID == 0)
            {
                user.UserID = GetNewUserID();
                user.Role = RolesList.FindRole(user.Role.RoleName);
                UsersList.Add(user);
            }
            else
            {
                User dbEntry = UsersList.Find(x => x.UserID == user.UserID);
                if (dbEntry != null)
                {
                    dbEntry.Username = user.Username;
                    dbEntry.Password = user.Password;
                    dbEntry.Name = user.Name;
                    dbEntry.Email = user.Email;
                    dbEntry.PPCredentials = user.PPCredentials;
                }
            }
        }

        private int GetNewUserID()
        {
            return UsersList.Count + 1;
        }

        public void DeleteUser(int userID)
        {
            User dbEntry = UsersList.Find(x => x.UserID == userID);
            UsersList.Remove(dbEntry);
        }

        public User FindUser(string userToFind)
        {
            return UsersList.Find(x => x.Username == userToFind);
        }
    }
}
