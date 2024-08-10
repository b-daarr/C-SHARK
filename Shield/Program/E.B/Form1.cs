using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E.B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Type = 0;
        private void S1_CheckedChanged(object sender, EventArgs e)
        {
            Type = 1;
            Connect.Text = "Connection Request";
            Connect.BackColor = Color.Purple;
            S3.ForeColor = Color.White;
            S2.ForeColor = Color.White;
            S1.ForeColor = Color.FromArgb(255, 255, 128);
            Off.ForeColor = Color.White;
        }
        private void S2_CheckedChanged(object sender, EventArgs e)
        {
            Type = 2;
            Connect.Text = "Connection Request";
            Connect.BackColor = Color.Purple;
            S3.ForeColor = Color.White;
            S2.ForeColor = Color.Gray;
            S1.ForeColor = Color.White;
            Off.ForeColor = Color.White;
        }
        private void S3_CheckedChanged(object sender, EventArgs e)
        {
            Type = 3;
            Connect.Text = "Connection Request";
            Connect.BackColor = Color.Purple;
            S3.ForeColor = Color.FromArgb(128, 128, 255);
            S2.ForeColor = Color.White;
            S1.ForeColor = Color.White;
            Off.ForeColor = Color.White;
        }
        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            Type = 4;
            Connect.Text = "Turn Off Service";
            Connect.BackColor = Color.Red;
            S3.ForeColor = Color.White;
            S2.ForeColor = Color.White;
            S1.ForeColor = Color.White;
            Off.ForeColor = Color.Red;
        }
        private void Support_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ALTONIBOT/Embargo-Breaker");
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (Type == 0)
            {
                Connect.Text = "Not Selected";
                Connect.BackColor = Color.Brown;
            }
            else if (Type == 1)
            {
                Process.Start(@"C:\temp_apps\app_start\short\ServerConfig01.lnk");
            }
            else if (Type == 2)
            {
                Process.Start(@"C:\temp_apps\app_start\short\ServerConfig02.lnk");
            }
            else if (Type == 3)
            {
                Process.Start(@"C:\temp_apps\app_start\short\ServerConfig03.lnk");
            }
            else if (Type == 4)
            {
                Process.Start(@"C:\temp_apps\app_start\short\ServerOff.lnk");
            }
        }
    }
}
