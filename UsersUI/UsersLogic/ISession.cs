namespace UsersLogic
{
    public interface ISession
    {
        IUser LoggedUser
        {
            get; 
        }
    }
}