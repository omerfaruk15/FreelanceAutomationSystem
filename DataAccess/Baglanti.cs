using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class Baglanti
    {
        public static string ConnectionString = "Server=.; Database=yonetim_sistemi; Trusted_Connection=True; TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }

}