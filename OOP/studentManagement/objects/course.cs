public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Instructor { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public Course(int courseId, string name, string instructor)
    {
        CourseId = courseId;
        Name = name;
        Instructor = instructor;
        Enrollments = new List<Enrollment>();
    }
}
