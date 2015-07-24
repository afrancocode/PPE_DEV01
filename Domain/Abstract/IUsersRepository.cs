using System.Collections.Generic;
using EstimatorApp.Domain.Entities;

namespace EstimatorApp.Domain.Abstract
{
    public interface IUsersRepository
    {
        IEnumerable<User> UsersList { get; }
        void SaveUser(User user);
        void DeleteUser(int UserID);
    }
}
