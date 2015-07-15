using System.Collections.Generic;
using EstimatorApp.Domain;

namespace EstimatorApp.Repository.Concrete
{
    public class DummyDBContext
    {
        private List<Users> UsersList;

        public DummyDBContext()
        {
            UsersList = new List<Users>();
            UsersList.Add(new Users() { UserID = 1, Username="sysadmin", Name="System Administrator", Password="sysadmin", Role="Pricer", Email="sysadmin@codservices.com.mx"});
            UsersList.Add(new Users() { UserID = 2, Username = "mharo", Name = "Mirella Haro", Password = "ensenada", Role = "Estimator", Email="mharo@codeservices.com.mx" });
            UsersList.Add(new Users() { UserID = 3, Username = "dmendez", Name = "Doreen Mendez", Password = "dmendez123", Role = "Estimator", Email = "dmendez@codeservices.com.mx" });
        }

        public IEnumerable<Users> GetUsersList()
        {
            return UsersList;
        }

        public void SaveChanges(Users user)
        {
            if (user.UserID == 0)
            {
                user.UserID = GetNewUserID();
                UsersList.Add(user);
            }
            else
            {
                Users dbEntry = UsersList.Find(x => x.UserID == user.UserID);
                if (dbEntry != null)
                {
                    dbEntry.Username = user.Username;
                    dbEntry.Password = user.Password;
                    dbEntry.Name = user.Name;
                    dbEntry.Role = user.Role;
                    dbEntry.Email = user.Email;
                }
            }
        }

        private int GetNewUserID()
        {
            return UsersList.Count + 1;
        }

        public void DeleteUser(int userID)
        {
            Users dbEntry = UsersList.Find(x => x.UserID == userID);
            UsersList.Remove(dbEntry);
        }
    }
}
