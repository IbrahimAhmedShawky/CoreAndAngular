using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }

        public string JobTitle { get; set; }
    }
}