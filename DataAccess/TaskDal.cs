using Core.Entities;
using DataAccess; 
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TaskDal
    {
        public void Add(Gorev gorev)
        {
            using (var context = new AppDbContext())
            {
                context.Tasks.Add(gorev);
                context.SaveChanges();
            }
        }

        public List<Gorev> GetAll()
        {
            using (var context = new AppDbContext())
            {
                var list = context.Tasks
                                  .Include(t => t.Calisan)
                                  .Include(t => t.Project)
                                  .ToList();

                foreach (var item in list)
                {
                    if (item.Calisan != null)
                        item.CalisanAdSoyad = item.Calisan.FirstName + " " + item.Calisan.LastName;
                }
                return list;
            }
        }

        public void Delete(int taskId)
        {
            using (var context = new AppDbContext())
            {
                var taskToDelete = context.Tasks.Find(taskId);
                if (taskToDelete != null)
                {
                    context.Tasks.Remove(taskToDelete);
                    context.SaveChanges();
                }
            }
        }

      
        public int GetTaskCountByType(string type)
        {
            using (var context = new AppDbContext())
            {
                return context.Tasks.Count(t => t.TaskType == type);
            }
        }
    }
}