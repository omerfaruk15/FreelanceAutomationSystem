using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("Tasks")]
    public abstract class Gorev
    {
        [Key]
        public int TaskID { get; set; }

        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }

        public string? TaskTitle { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal WorkedHours { get; set; }
        public string? TaskType { get; set; }

        [NotMapped]
        public string? CalisanAdSoyad { get; set; }

        [NotMapped]
        public decimal ToplamMaliyet => HourlyRate * WorkedHours;


        [ForeignKey(nameof(ProjectID))] 
        public virtual Project? Project { get; set; }

        [ForeignKey(nameof(EmployeeID))] 
        public virtual Calisan? Calisan { get; set; }

        public abstract decimal HakedisHesapla();
    }
}