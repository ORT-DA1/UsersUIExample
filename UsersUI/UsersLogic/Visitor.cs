using System;
using System.Collections.Generic;

namespace UsersLogic
{
    public class Visitor : IUser
    {
        private static ICollection<string> features = new List<string>()
        {
            "VisitorViews"
        };

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                } else
                {
                    throw new InvalidNameException();
                }
            }
        }
        public int Age { get; set; }

        public Visitor(string aName, int anAge)
        {
            Name = aName;
            Age = anAge;

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