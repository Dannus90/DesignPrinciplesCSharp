using Prototype.PrototypeInheritance.Interfaces;

namespace Prototype.PrototypeInheritance;

public class Employee : Person, IDeepCopyable<Employee>
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

    public void CopyTo(Employee target)
    {  
        base.CopyTo(target);
        target.Salary = Salary;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
    }
}