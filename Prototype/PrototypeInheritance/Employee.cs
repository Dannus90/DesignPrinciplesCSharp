namespace Prototype.PrototypeInheritance;

public class Employee : Person
{
    public int Salary;

    public Employee()
    {
    }
    
    public Employee(int salary)
    {
        Salary = salary;
    }

    public Employee(string[] names, Address address, int salary) : base(names, address)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
    }
}