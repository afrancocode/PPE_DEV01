using System.Collections.Generic;

namespace EstimatorApp.Repository.Concrete
{
    using Domain.Entities;

    public class DummyRolesDBContext
    {
        private List<Role> RolesList;

        public DummyRolesDBContext()
        {
            RolesList = new List<Role>();
            RolesList.Add(new Role() { RoleID = 1, RoleName = "Pricer" });
            RolesList.Add(new Role() { RoleID = 2, RoleName = "Estimator" });
        }

        public IEnumerable<Role> GetRolesList()
        {
            return RolesList;
        }

        public Role FindRole(string roleToFind)
        {
            return RolesList.Find(x => x.RoleName == roleToFind);
        }
    }
}
