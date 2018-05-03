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
    public partial class VisitorView : UserControl, IUserFeatureControl
    {
        private ISession session;
        public VisitorView()
        {
            InitializeComponent();
        }

        public void SetSession(ISession aSession)
        {
            session = aSession;
            Visitor user = (Visitor) session.LoggedUser;
            textBox1.Text = user.Name;
            textBox2.Text = "" + user.Age;
        }

        public string GetRequiredFeature()
        {
            return "VisitorViews";
        }
    }
}
