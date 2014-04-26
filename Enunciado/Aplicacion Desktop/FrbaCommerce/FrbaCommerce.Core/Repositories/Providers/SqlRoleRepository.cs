namespace FrbaCommerce.Core.Repositories.Providers
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

    public class SqlRoleRepository : IRoleRepository
    {
        #region IRoleRepository Members

        public void CreateRole(string role)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnx.Open();

                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Rol] ([Nombre]) VALUES (@Nombre)";
                    cmd.Parameters.AddWithValue("@Nombre", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddUserToRole(int userId, string role)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
