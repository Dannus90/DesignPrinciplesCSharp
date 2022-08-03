namespace PlayingAround.RepositoryExample;

public class User
{
    private string _name;
    private int _age;

    public User(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public override string ToString()
    {
        return $"{nameof(_name)}: {_name}, {nameof(_age)}: {_age}";
    }
}