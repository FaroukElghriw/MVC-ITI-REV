using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int Age { get; set; }
    }
}
