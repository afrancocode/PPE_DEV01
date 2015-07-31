using System.Collections.Generic;

namespace EstimatorApp.Domain.Abstract
{
    using Entities;

    public interface IUsersRepository
    {
        IEnumerable<User> UsersList { get; }
        User FindUser(string userToFind);
        void SaveUser(User user);
        void DeleteUser(int UserID);
    }
}
