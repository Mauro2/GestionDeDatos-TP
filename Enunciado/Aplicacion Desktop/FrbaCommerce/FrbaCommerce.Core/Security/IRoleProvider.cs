namespace FrbaCommerce.Core.Security
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IRoleProvider
    {
        void CreateRole(string role);
        void AddUserToRole(int userId, string role);
        void AddFeaturesToRole(string[] features, string role);
        
        string[] GetFeaturesByUser(int userId);
        string[] GetUserRoles(int userId);
    }
}
