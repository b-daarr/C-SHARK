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

namespace E.B_Setup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            Install.Enabled = true;
        }
        private void NoAccept_CheckedChanged(object sender, EventArgs e)
        {
            Install.Enabled = false;
        }
        private void Install_Click(object sender, EventArgs e)
        {
            Accept.Enabled = false;
            NoAccept.Enabled = false;
            Install.Enabled = false;
            Install.Text = "Please wait...";

            Process.Start(@"C:\temp_apps\starter\setup.exe");

            Application.Exit();
        }
        private void Support_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ALTONIBOT/Embargo-Breaker");
        }
    }
}
