namespace FrbaCommerce.Core.Security.Providers
{
    using System;
    using FrbaCommerce.Core.Repositories;

    public class SqlRoleProvider : IRoleProvider
    {
        private readonly IRoleRepository _roleRepository;

        public SqlRoleProvider(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        #region IRoleProvider Members

        public void AddUserToRole(int userId, string role)
        {
            throw new NotImplementedException();
        }

        public string[] GetFeaturesByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public string[] GetUserRoles(int userId)
        {
            throw new NotImplementedException();
        }

        public void CreateRole(string role)
        {
            _roleRepository.CreateRole(role);
        }

        public void AddFeaturesToRole(string[] features, string role)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
