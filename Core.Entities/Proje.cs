using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Core.Entities
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string? ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Budget { get; set; }

        public bool IsCompleted { get; set; }
      
       public virtual ICollection<Gorev> Gorevler { get; set; } = new List<Gorev>();
    }
}