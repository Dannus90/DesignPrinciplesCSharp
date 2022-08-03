using PlayingAround.RepositoryExample.Interfaces;

namespace PlayingAround.RepositoryExample;

public class UserRepository : IUserRepository
{
    public IEnumerable<User> GetEntities()
    {
        return new List<User> { new("Daniel", 32), new("Alexander", 34)};
    }

    public User GetEntityById(Guid id)
    {
        return new User("Daniel", 32);
    }

    public User GetEntityByEmail(string email)
    {
        return new User("Daniel", 32);
    }
}