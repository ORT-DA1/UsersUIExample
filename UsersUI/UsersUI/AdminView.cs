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
    public partial class AdminView : UserControl, IUserFeatureControl
    {
        private ISession session;

        public AdminView()
        {
            InitializeComponent();
        }

        public string GetRequiredFeature()
        {
            return "AdminViews";
        }

        public void SetSession(ISession aSession)
        {
            session = aSession;
        }
    }
}
