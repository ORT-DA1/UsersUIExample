using UsersLogic;

namespace UsersUI
{
    internal interface IUserFeatureControl
    {
        string GetRequiredFeature();
        void SetSession(ISession aSession);
    }
}