using Core.Entities;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccess
{
    public class TaskDal
    {
        public void Add(Gorev gorev)
        {
            string query = "INSERT INTO Tasks (ProjectID, EmployeeID, TaskTitle, HourlyRate, WorkedHours, TaskType) " +
                           "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

            SqlParameter[] parameters =
            {
        new SqlParameter("@p1", gorev.ProjectID),
        new SqlParameter("@p2", gorev.EmployeeID),
        new SqlParameter("@p3", gorev.TaskTitle),
        new SqlParameter("@p4", gorev.HourlyRate),
        new SqlParameter("@p5", gorev.WorkedHours),
        new SqlParameter("@p6", gorev.TaskType)
    };

            SqlHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Core.Entities.Gorev> GetAll()
        {
            List<Core.Entities.Gorev> list = new List<Core.Entities.Gorev>();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM Tasks");

            foreach (DataRow row in dt.Rows)
            {
                string type = row["TaskType"].ToString() ?? "";
                Core.Entities.Gorev g = type == "Yazılım" ? new YazilimGorevi() : new TasarimGorevi();

                g.TaskID = (int)row["TaskID"];
                g.ProjectID = (int)row["ProjectID"];
                g.EmployeeID = (int)row["EmployeeID"];
                g.TaskTitle = row["TaskTitle"].ToString();
                g.HourlyRate = (decimal)row["HourlyRate"];
                g.WorkedHours = (decimal)row["WorkedHours"];
                g.TaskType = type;

                list.Add(g);
            }
            return list;
        }

        public void Delete(int taskId)
        {
            string query = "DELETE FROM Tasks WHERE TaskID = @p1";
            SqlParameter[] parameters = { new SqlParameter("@p1", taskId) };
            SqlHelper.ExecuteNonQuery(query, parameters);
        }

        public void Update(Gorev task)
        {
            string query = "UPDATE Tasks SET TaskTitle=@p1, HourlyRate=@p2, WorkedHours=@p3 WHERE TaskID=@p4";
            SqlParameter[] parameters = {
        new SqlParameter("@p1", task.TaskTitle),
        new SqlParameter("@p2", task.HourlyRate),
        new SqlParameter("@p3", task.WorkedHours),
        new SqlParameter("@p4", task.TaskID)
    };
            SqlHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
