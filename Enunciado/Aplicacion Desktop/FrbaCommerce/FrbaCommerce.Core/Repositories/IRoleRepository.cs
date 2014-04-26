namespace FrbaCommerce.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public interface IRoleRepository
    {
        void CreateRole(string role);
        void AddUserToRole(int userId, string role);
    }
}
