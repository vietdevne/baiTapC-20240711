public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public Student(int studentId, string name)
    {
        StudentId = studentId;
        Name = name;
        Enrollments = new List<Enrollment>();
    }
}