using System;
using System.Collections.Generic;

namespace UsersLogic
{
    public class Admin : IUser
    {
        private static ICollection<string> features = new List<string>()
        {
            "AdminViews"
        };

        public string Name { get; set; }

        public Admin(string aName)
        {
            Name = aName;
        }

        public virtual bool HasFeature(string feature)
        {
            return features.Contains(feature);
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
    }
}