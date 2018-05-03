using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogic
{

    internal class Users
    {
        private static Users instance;
        public static Users Instance {
            get
            {
                return instance;
            }
        }

        static Users()
        {
            instance = new Users();
        }

        public ICollection<IUser> AllUsers { get; set; }


        private Users()
        {
            AllUsers = new List<IUser>
            {
                new Admin("Admin"),
                new Visitor("Visitor", 20),
                new AdminExtended("AdminExtended")
            };
        }
    }
}
