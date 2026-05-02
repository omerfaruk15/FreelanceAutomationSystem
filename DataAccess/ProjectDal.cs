using Core.Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class ProjectDal
    {
        public void Add(Project project)
        {
            using (var context = new AppDbContext())
            {
                context.Projects.Add(project);
                context.SaveChanges();
            }
        }

        public List<Project> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Projects.ToList();
            }
        }

        public void Delete(int projectId)
        {
            using (var context = new AppDbContext())
            {
                var project = context.Projects.Find(projectId);
                if (project != null)
                {
                    context.Projects.Remove(project);
                    context.SaveChanges();
                }
            }
        }

        public void Update(Project project)
        {
            using (var context = new AppDbContext())
            {
                
                var existing = context.Projects.Find(project.ProjectID);
                if (existing != null)
                {
                    existing.ProjectName = project.ProjectName;
                    existing.StartDate = project.StartDate;
                    existing.Budget = project.Budget;
                    context.SaveChanges();
                }
            }
        }

    
        public List<Project> GetHighBudgetProjects(decimal limit)
        {
            using (var context = new AppDbContext())
            {
                return context.Projects.Where(p => p.Budget > limit).ToList();
            }
        }
    }
}