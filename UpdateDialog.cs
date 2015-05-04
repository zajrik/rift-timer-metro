using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rift_timer
{
    public partial class UpdateDialog : UserControl
    {
        public UpdateDialog()
        {
            InitializeComponent();
        }

        public string currentVersion = Application.ProductVersion;
        public bool isConfirmed = false;

        public void SetVersionText(string latestVersion)
        {
            versionsLabel.Text = String.Format("Installed: {0}  Latest: {1}", currentVersion, latestVersion);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            isConfirmed = true;
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
