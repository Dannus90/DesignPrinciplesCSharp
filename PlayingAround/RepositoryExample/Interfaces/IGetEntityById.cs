namespace PlayingAround.RepositoryExample.Interfaces;

public interface IGetEntityById<out T, in TP>
{
    T GetEntityById(TP id);
}