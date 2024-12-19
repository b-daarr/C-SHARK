﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSHARK.Properties;

namespace CSHARK
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        #region Variables and Calling methods
        Global global = new Global();
        #endregion

        #region Lobby
        private void Lobby_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = false;
                radioButton.Size = new Size(190, 30);
                radioButton.Text = "Quick Patch " + (i + 1).ToString();
                radioButton.Location = new Point(20, 30 * i);
                this.serverListPanel.Controls.Add(radioButton);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Disconnect Server
                File.AppendAllText(global.appLog(), global.logMessageAE);
                Application.Exit();
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            connect.BackgroundImage = Resources.hold;
            this.UseWaitCursor = true;
            connect.Enabled = false;
            serverListPanel.Enabled = false;
            connectionHint.Text = "Checking server...";
            connectionStatus.BackgroundImage = Resources.c02;
        }
        #endregion

        #region About
        private void websiteLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://CSHARK.SPACE/") { UseShellExecute = true });
        }

        private void youtubeLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://YouTube.com/@b_daarr/") { UseShellExecute = true });
        }
        private void githubLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://GitHub.com/b-daarr/") { UseShellExecute = true });
        }

        private void telegramLink_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://T.me/b_daarr/") { UseShellExecute = true });
        }

        private void email_Click(object sender, EventArgs e)
        {
            resetTimer.Interval = 3000;
            resetTimer.Start();
            Clipboard.SetText("b.daarr@outlook.com");
            email.Text += "\nCopied ✔";
        }

        private void resetTimer_Tick(object sender, EventArgs e)
        {
            resetTimer.Stop();
            email.Text = email.Text.Substring(0, email.Text.Length - 9);
        }

        private void appLicense_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://GitHub.com/b-daarr/CShark/blob/main/LICENSE") { UseShellExecute = true });
        }
        #endregion

        #region Setting (Network)
        private void themeChange_Click(object sender, EventArgs e)
        {
            themeChange.BackgroundImage = Resources.darkmode;
            themeTitle.Text = "Change Theme --- Dark";
            //if ()
            //{
            //    themeChange.BackgroundImage = Resources.darkmode;
            //    themeTitle.Text = "Change Theme --- Dark";
            //}
            //else
            //{
            //    themeChange.BackgroundImage = Resources.lightmode;
            //    themeTitle.Text = "Change Theme --- Light";
            //}
        }
        #endregion
    }
}