namespace SEPAssignment03;

public class Department : IDepartmentService
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public List<Course> Courses { get; set; }
    
    public struct Budget
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
    }
    
    public Budget SchoolYearBudget { get; set; }
}