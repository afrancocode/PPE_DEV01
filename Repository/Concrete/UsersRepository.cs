using System.Collections.Generic;
using EstimatorApp.Domain.Abstract;
using EstimatorApp.Domain.Entities;

namespace EstimatorApp.Repository.Concrete
{
    public class UsersRepository : IUsersRepository
    {
        private DummyUserDBContext userData = new DummyUserDBContext();

        public IEnumerable<User> UsersList
        {
            get { return userData.GetUsersList(); }
        }

        public void SaveUser(User user)
        {
            userData.SaveChanges(user);
        }

        public void DeleteUser(int userID)
        {
            userData.DeleteUser(userID);
        }
    }
}
