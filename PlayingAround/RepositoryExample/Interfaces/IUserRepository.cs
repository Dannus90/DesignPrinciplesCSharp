namespace PlayingAround.RepositoryExample.Interfaces;

public interface IUserRepository : 
    IGetEntityById<User, Guid>,
    IGetEntities<User>,
    IGetEntityByEmail<User>
{
}