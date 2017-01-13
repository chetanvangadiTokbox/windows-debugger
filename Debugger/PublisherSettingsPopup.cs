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
    public partial class PublisherSettingsPopup : Form
    {
        public static String resolutionSelected = "Medium";
        public static String framerateSelected = "30";
        public static bool isAudioEnabled = true;
        public static bool isVideoEnabled = true;
        public PublisherSettingsPopup()
        {
            InitializeComponent();
            string [] resolutionArray = new string[] { "Medium", "Low", "High" };
            string [] framerateArray = new string[] {"30", "15", "7", "1" };
            resolutionCombobox.Items.AddRange(resolutionArray);
            framerateComboBox.Items.AddRange(framerateArray);

            for (int i = 0; i < resolutionArray.Length; i++)
            {
                if(resolutionSelected.Equals(resolutionArray[i]))
                {
                    resolutionCombobox.SelectedIndex = i;
                }
            }

            for (int i = 0; i < framerateArray.Length; i++)
            {
                if (framerateSelected.Equals(framerateArray[i]))
                {
                    framerateComboBox.SelectedIndex = i;
                }
            }

            audioCheckBox.Checked = isAudioEnabled;
            videoCheckbox.Checked = isVideoEnabled;
        }

        private void publish_button_click(object sender, EventArgs e)
        {
            isAudioEnabled = audioCheckBox.Checked;
            isVideoEnabled = videoCheckbox.Checked;
            resolutionSelected = (String)resolutionCombobox.SelectedItem;
            framerateSelected = (String)framerateComboBox.SelectedItem;
        }
    }
}
