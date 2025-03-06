namespace SEPAssignment03;

public class Course : ICourseService
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> EnrolledStudents { get; set; }
}