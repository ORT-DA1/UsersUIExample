using System.Linq;

namespace UsersLogic
{
    public  class SessionConnector
    {
        public ISession CreateSession(string name)
        {
            IUser user = Users.Instance.AllUsers.FirstOrDefault(u => u.EqualsByName(name));
            return new Session(user);
        }
    }
}