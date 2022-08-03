using PlayingAround.RepositoryExample;
using static System.Console;

namespace PlayingAround;

public static class PlayingAround
{
    public static void ExecutePlayingAround()
    {
        var userRepository = new UserRepository();

        var userById = userRepository.GetEntityById(Guid.NewGuid());
        var userByEmail = userRepository.GetEntityByEmail(string.Empty);
        var users = userRepository.GetEntities();
        
        WriteLine(userById);
        WriteLine(userByEmail);
        
        foreach (var user in users)
        {
            WriteLine(user);
        }
    }
}