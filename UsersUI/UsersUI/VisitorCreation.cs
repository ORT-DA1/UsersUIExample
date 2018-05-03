using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersLogic;

namespace UsersUI
{
    public partial class VisitorCreation : UserControl, IUserFeatureControl
    {
        private ISession session;

        public VisitorCreation()
        {
            InitializeComponent();
        }

        public string GetRequiredFeature()
        {
            return "AdminExtended";
        }

        public void SetSession(ISession aSession)
        {
            session = aSession;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                IUser user = new Visitor(txtName.Text, Int32.Parse(txtAge.Text));
                AdminExtended admin = (AdminExtended)session.LoggedUser;
                admin.AddUser(user);
            }
            catch (Exception)
            {

            }
        }
    }
}
