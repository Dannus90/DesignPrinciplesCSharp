namespace PlayingAround.RepositoryExample.Interfaces;

public interface IGetEntities<out T>
{
    IEnumerable<T> GetEntities();
}