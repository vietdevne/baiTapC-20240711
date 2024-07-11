using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Enrollment> enrollments = new List<Enrollment>();

        students.Add(new Student(1, "Lê Đức Sơn"));
        students.Add(new Student(2, "Phạm Văn Hoàng"));

        courses.Add(new Course(101, "Kỹ năng phòng the cơ bản", "Nguyễn Tấn Thắng"));
        courses.Add(new Course(102, "Kỹ năng phòng the nâng cao", "Phạm Ngọc Duy"));

        enrollments.Add(new Enrollment(1, 1, 101));
        enrollments.Add(new Enrollment(2, 2, 101));
        enrollments.Add(new Enrollment(3, 1, 102));

        Console.WriteLine("Thông tin các sinh viên và các khóa học mà họ đang tham gia:");
        foreach (var student in students)
        {
            Console.WriteLine($"Sinh viên: {student.Name}");
            foreach (var enrollment in enrollments)
            {
                if (enrollment.StudentId != student.StudentId)
                {
                    continue;
                }
                
                var course = courses.Find(c => c.CourseId == enrollment.CourseId);
                Console.WriteLine($"- Khóa học: {course.Name}, Giảng viên: {course.Instructor}");
            }
            Console.WriteLine();
        }
    }
}
