namespace Day1.Models
{
    public static class StudentList
    {
        public static List<Student> Students   { get; set; }

        static StudentList()
        {
              Students = new List<Student>();
            Students.Add(new Student() { Id= 1  , Name="Faroyk",  Address="Tanta",Image="1.jpg"});
            Students.Add(new Student() { Id = 2, Name = "Faroyk", Address = "Tanta", Image = "2.jpg" });
            Students.Add(new Student() { Id = 3, Name = "Faroyk", Address = "Tanta", Image = "3.jpg" });
        }
    } 
}
