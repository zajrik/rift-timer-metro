﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rift_timer
{
    public partial class UpdateDialog : UserControl
    {
        public UpdateDialog()
        {
            InitializeComponent();
        }

        public string currentVersion = Application.ProductVersion;
        public string[] latestVersionExplode;

        public void SetDialogInfo(string latestVersion)
        {
            versionsLabel.Text = String.Format("Installed: {0}  Latest: {1}", currentVersion, latestVersion);
            latestVersionExplode = latestVersion.Split('.');
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string updateUrl = "http://zajriksrv.us.to/rift-timer/metro/rifttimer-metro-{0}-{1}-{2}.rar";
            updateUrl = String.Format
                (
                    updateUrl,
                    latestVersionExplode[0],
                    latestVersionExplode[1],
                    latestVersionExplode[2]
                );
            Process.Start(updateUrl);
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
