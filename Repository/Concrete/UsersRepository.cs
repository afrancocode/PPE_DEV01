using System.Collections.Generic;

namespace EstimatorApp.Repository.Concrete
{
    using Domain.Abstract;
    using Domain.Entities;

    public class UsersRepository : IUsersRepository
    {
        private DummyUserDBContext userData = new DummyUserDBContext();

        public IEnumerable<User> UsersList
        {
            get { return userData.GetUsersList(); }
        }

        public User FindUser(string userToFind)
        {
            return userData.FindUser(userToFind);
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
