using System.Collections.Specialized;

namespace SEPAssignment03;

public class Student : Person, IStudentService
{
    public List<Course> Courses { get; set; }
    public Dictionary<int, Grade> Grades { get; set; }

    public double GetGPA()
    {
        double totalGradePoints = 0;
        foreach (var grade in Grades)
        {
            totalGradePoints += (double)grade.Value;
        }
        int numberOfCourses = Courses.Count;
        return totalGradePoints / numberOfCourses;
    }
}