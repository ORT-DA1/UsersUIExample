namespace UsersLogic
{
    public interface IUser
    {
        bool HasFeature(string feature);
        bool EqualsByName(string name);
    }
}