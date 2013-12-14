using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prank
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Color = Color.AliceBlue;
            //Properties.Settings.Default.Transparency = Color.AliceBlue;
            Properties.Settings.Default.Save();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
