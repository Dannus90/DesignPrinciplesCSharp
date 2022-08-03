namespace PlayingAround.RepositoryExample.Interfaces;

public interface IGetEntityByEmail<out T>
{
    T GetEntityByEmail(string email);
}