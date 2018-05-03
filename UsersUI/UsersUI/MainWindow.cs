using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersLogic;

namespace UsersUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            SessionConnector connector = new SessionConnector();
            ISession session = connector.CreateSession("AdminExtended");

            List<IUserFeatureControl> views = new List<IUserFeatureControl>()
            {
                new AdminView(),
                new VisitorView(),
                new VisitorCreation()
            };

            foreach (var view in views)
            {
                if(session.LoggedUser.HasFeature(view.GetRequiredFeature()))
                {
                    mainPanel.Controls.Add((UserControl) view);
                    view.SetSession(session);
                }
            }
        }
    }
}
