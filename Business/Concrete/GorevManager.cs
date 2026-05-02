using Business.Abstract;
using DataAccess;
using System.Linq;

namespace Business.Concrete
{
    public class GorevManager : IGorevService
    {
        public object GetDetayliRapor()
        {
            using (var db = new AppDbContext())
            {
                return db.Projects
                    .SelectMany(p => p.Gorevler)
                    .Select(g => new {
                        ProjeAdi = g.Project.ProjectName,
                        GorevTipi = g.TaskType,
                        GorevDetayi = g.TaskTitle,
                        Personel = g.Calisan.FirstName + " " + g.Calisan.LastName,
                        Uzmanlik = g.Calisan.Expertise,
                        SaatlikUcret = g.HourlyRate,
                        CalisilanSaat = g.WorkedHours,
                        GorevMaliyeti = (decimal)g.WorkedHours * g.HourlyRate
                    }).ToList();
            }
        }
    }
}