using System.Collections.Generic;
using EstimatorApp.Domain;

namespace EstimatorApp.Repository.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<Users> UsersList { get; }
        void SaveUser(Users user);
        void DeleteUser(int UserID);
    }
}
