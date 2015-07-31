using System.Collections.Generic;

namespace EstimatorApp.Domain.Abstract
{
    using Entities;

    public interface IRolesRepository
    {
        IEnumerable<Role> RolesList { get; }
        Role FindRole(string roleToFind);
    }
}