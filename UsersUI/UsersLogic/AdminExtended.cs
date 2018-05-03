using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogic
{
    public class AdminExtended : Admin
    {
        public AdminExtended(string aName) : base(aName)
        {
        }

        public void AddUser(IUser user)
        {
            Users.Instance.AllUsers.Add(user);
        }

        public override bool HasFeature(string feature)
        {
            return base.HasFeature(feature) || "AdminExtended" == feature;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
    }
}
