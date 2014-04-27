namespace FrbaCommerce.Core
{
    using System.Configuration;
    using System.Data.SqlClient;

    public abstract class BaseRepository
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
    }
}
