using System.Collections.Generic;

namespace EstimatorApp.Repository.Concrete
{
    using Domain.Abstract;
    using Domain.Entities;

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
