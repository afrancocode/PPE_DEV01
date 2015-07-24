using System.Collections.Generic;
using EstimatorApp.Domain.Abstract;
using EstimatorApp.Domain.Entities;

namespace EstimatorApp.Repository.Concrete
{
    public class RolesRepository : IRolesRepository
    {
        private DummyRolesDBContext rolesData = new DummyRolesDBContext();

        public IEnumerable<Role> RolesList
        {
            get { return rolesData.GetRolesList(); }
        }

        public Role FindRole(string roleToFind)
        {
            return rolesData.FindRole(roleToFind);
        }
    }
}
