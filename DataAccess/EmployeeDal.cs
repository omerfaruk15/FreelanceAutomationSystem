using Core.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EmployeeDal
    {
        public void Add(Calisan employee)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, Expertise) VALUES (@p1, @p2, @p3)";

            SqlParameter[] parameters = {
                new SqlParameter("@p1", employee.FirstName),
                new SqlParameter("@p2", employee.LastName),
                new SqlParameter("@p3", employee.Expertise)
            };

            SqlHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Calisan> GetAll()
        {
            List<Calisan> employees = new List<Calisan>();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM Employees");

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(new Calisan
                {
                    EmployeeID = (int)row["EmployeeID"],
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Expertise = row["Expertise"].ToString()
                });
            }
            return employees;
        }

        public void Delete(int employeeId)
        {
            string deleteTasksQuery = "DELETE FROM Tasks WHERE EmployeeID = @p1";
            SqlParameter[] p1 = { new SqlParameter("@p1", employeeId) };
            SqlHelper.ExecuteNonQuery(deleteTasksQuery, p1);

            string deleteEmpQuery = "DELETE FROM Employees WHERE EmployeeID = @p1";
            SqlParameter[] p2 = { new SqlParameter("@p1", employeeId) };
            SqlHelper.ExecuteNonQuery(deleteEmpQuery, p2);
        }

        public void Update(Calisan emp)
        {
            string query = "UPDATE Employees SET FirstName=@p1, LastName=@p2, Expertise=@p3 WHERE EmployeeID=@p4";
            SqlParameter[] parameters = {
        new SqlParameter("@p1", emp.FirstName),
        new SqlParameter("@p2", emp.LastName),
        new SqlParameter("@p3", emp.Expertise),
        new SqlParameter("@p4", emp.EmployeeID)
    };
            SqlHelper.ExecuteNonQuery(query, parameters);
        }
    }
}