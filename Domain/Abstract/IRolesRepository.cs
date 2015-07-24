using System.Collections.Generic;
using EstimatorApp.Domain.Entities;

namespace EstimatorApp.Domain.Abstract
{
    public interface IRolesRepository
    {
        IEnumerable<Role> RolesList { get; }
        Role FindRole(string roleToFind);
    }
}