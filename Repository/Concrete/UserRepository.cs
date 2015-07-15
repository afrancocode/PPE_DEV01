using System.Collections.Generic;
using EstimatorApp.Repository.Abstract;
using EstimatorApp.Domain;

namespace EstimatorApp.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {
        private DummyDBContext userData = new DummyDBContext();

        public IEnumerable<Users> UsersList
        {
            get { return userData.GetUsersList(); }
        }

        public void SaveUser(Users user)
        {
            userData.SaveChanges(user);
        }

        public void DeleteUser(int userID)
        {
            userData.DeleteUser(userID);
        }
    }
}
