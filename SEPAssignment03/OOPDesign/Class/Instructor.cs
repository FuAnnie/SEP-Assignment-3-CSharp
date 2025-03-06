namespace SEPAssignment03;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    private DateTime JoinDate { get; set; }

    public int GetYearsOfExperience()
    {
        DateTime now = DateTime.Now;
        int yearsOfExperience = now.Year - JoinDate.Year;
        if (JoinDate.Month < now.Month || (JoinDate.Month == now.Month && JoinDate.Day < now.Day))
        {
            yearsOfExperience--;
        }
        return yearsOfExperience;
    }

    public override decimal GetSalary()
    {
        decimal bonusSalary = BaseSalary * 0.05m * GetYearsOfExperience();
        return BaseSalary + bonusSalary;
    }
}