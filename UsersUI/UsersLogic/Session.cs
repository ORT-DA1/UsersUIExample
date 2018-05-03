namespace UsersLogic
{
    public class Session : ISession
    {

        public IUser LoggedUser
        {
            get; 
        }

        public Session(IUser user)
        {
            LoggedUser = user;
        }
    }
}