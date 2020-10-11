using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionFactory : IConnectionFactory
    {
        public string ConnectionString { get; set; }

        public IDbConnection GetConnection()
        {            
           var conn = new SqlConnection();
           conn.ConnectionString = ConnectionString ;
           conn.Open();
           return conn;            
        }
    }
}
