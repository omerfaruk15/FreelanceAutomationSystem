using Core.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public static class SqlHelper
    {
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = Baglanti.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                return dt;
            }
        }
    }

        public class ProjectDal
        {
            public void Add(Project project)
            {
                string query = "INSERT INTO Projects (ProjectName, StartDate, Budget) VALUES (@p1, @p2, @p3)";

                SqlParameter[] parameters = {
            new SqlParameter("@p1", project.ProjectName),
            new SqlParameter("@p2", project.StartDate),
            new SqlParameter("@p3", project.Budget)
        };

                SqlHelper.ExecuteNonQuery(query, parameters);
            }

            public List<Project> GetAll()
            {
                List<Project> projects = new List<Project>();
                DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM Projects");

                foreach (DataRow row in dt.Rows)
                {
                    projects.Add(new Project
                    {
                        ProjectID = (int)row["ProjectID"],
                        ProjectName = row["ProjectName"].ToString(),
                        StartDate = (DateTime)row["StartDate"],
                        Budget = (decimal)row["Budget"],
                        IsCompleted = (bool)row["IsCompleted"]
                    });
                }
                return projects;
            }

        public void Delete(int projectId)
        {
            string deleteTasksQuery = "DELETE FROM Tasks WHERE ProjectID = @p1";
            SqlParameter[] pForTasks = { new SqlParameter("@p1", projectId) };
            SqlHelper.ExecuteNonQuery(deleteTasksQuery, pForTasks);

           
            string deleteProjectQuery = "DELETE FROM Projects WHERE ProjectID = @p1";
            SqlParameter[] pForProject = { new SqlParameter("@p1", projectId) };
            SqlHelper.ExecuteNonQuery(deleteProjectQuery, pForProject);
        }

        public void Update(Project project)
        {
            string query = "UPDATE Projects SET ProjectName=@p1, StartDate=@p2, Budget=@p3 WHERE ProjectID=@p4";
            SqlParameter[] parameters = {
        new SqlParameter("@p1", project.ProjectName),
        new SqlParameter("@p2", project.StartDate),
        new SqlParameter("@p3", project.Budget),
        new SqlParameter("@p4", project.ProjectID)
    };
            SqlHelper.ExecuteNonQuery(query, parameters);
        }
    }
    
}