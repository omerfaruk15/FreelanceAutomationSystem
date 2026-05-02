using Core.Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq; 

namespace DataAccess
{
    public class EmployeeDal
    {
        public void Add(Calisan employee)
        {
            using (var context = new AppDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public List<Calisan> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Employees.ToList();
            }
        }

        public void Delete(int employeeId)
        {
            using (var context = new AppDbContext())
            {
                var tasks = context.Tasks.Where(t => t.EmployeeID == employeeId);
                context.Tasks.RemoveRange(tasks);

                var emp = context.Employees.Find(employeeId);
                if (emp != null)
                {
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                }
            }
        }

        public void Update(Calisan emp)
        {
            using (var context = new AppDbContext())
            {
                var existing = context.Employees.Find(emp.EmployeeID);
                if (existing != null)
                {
                    existing.FirstName = emp.FirstName;
                    existing.LastName = emp.LastName;
                    existing.Expertise = emp.Expertise;
                    context.SaveChanges();
                }
            }
        }

        public List<Calisan> GetByExpertise(string expertise)
        {
            using (var context = new AppDbContext())
            {
                return context.Employees.Where(e => e.Expertise == expertise).ToList();
            }
        }
    }
}