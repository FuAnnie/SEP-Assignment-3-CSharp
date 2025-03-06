namespace SEPAssignment03;

public abstract class Person : IPersonService
{
    public int Id { get; private set; }
    public string Name { get; set; }
    private DateTime Birthday { get; set; }
    private List<string> Address { get; set; }
    private decimal _baseSalary;

    protected decimal BaseSalary
    {
        get
        {
            return _baseSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("BaseSalary cannot be negative.");
            }
            _baseSalary = value;
        }
    }

    public int GetAge()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - Birthday.Year;
        if (now.Month < Birthday.Month || now.Month > Birthday.Month)
        {
            age--;
        }
        return age;
    }

    public virtual decimal GetSalary()
    {
        return BaseSalary;
    }

    public List<string> GetAddress()
    {
        return Address;
    }
}