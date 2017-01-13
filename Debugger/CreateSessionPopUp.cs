using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugger
{
    public partial class CreateSessionPopup : Form
    {
        public static String environmentSelected = "REL";
        public static bool sessionTypeIsP2P = false;
        public static bool isConnectionEventSupressed = false;
        public CreateSessionPopup()
        {
            InitializeComponent();
            sesssionTypeCheckbox.Checked = sessionTypeIsP2P;
            connectionEventSupressCheckbox.Checked = isConnectionEventSupressed;
            string[] environmentsArray = new string[] { "REL", "DEV", "PROD" };
            envComboBox.Items.AddRange(environmentsArray);
            for (int i = 0; i < environmentsArray.Length; i++)
            {
                if (environmentsArray[i].Equals(environmentSelected))
                {
                    envComboBox.SelectedIndex = i;
                }
            }
        }

        private void create_session(object sender, EventArgs e)
        {
            isConnectionEventSupressed = connectionEventSupressCheckbox.Checked;
            sessionTypeIsP2P = sesssionTypeCheckbox.Checked;
            environmentSelected = (String)envComboBox.SelectedItem;
        }
    }
}
