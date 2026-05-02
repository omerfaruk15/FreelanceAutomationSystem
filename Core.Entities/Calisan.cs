using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
namespace Core.Entities
{
    [Table("Employees")]
    public class Calisan
    {
        [Key]
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Expertise { get; set; }
    }
}