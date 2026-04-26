using Microsoft.Data.SqlClient;
using Core.Entities; 

namespace DataAccess
{
    public class ProjectDal
    {
        public void Add(Project project)
        {
            using (SqlConnection conn = Baglanti.GetConnection())
            {
                string query = "INSERT INTO Projects (ProjectName, StartDate, Budget) VALUES (@p1, @p2, @p3)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", project.ProjectName);
                cmd.Parameters.AddWithValue("@p2", project.StartDate);
                cmd.Parameters.AddWithValue("@p3", project.Budget);

                conn.Open();

                cmd.ExecuteNonQuery();

            }
        }
    }
}