using CShark.Properties;
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
using System.IO;
using Newtonsoft.Json.Linq;

namespace CShark
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void appearance_button_Click(object sender, EventArgs e)
        {
            Appearance appearance = new Appearance();
            appearance.Show();
            this.Hide();
        }

        private void donate_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://coffeete.ir/b_daarr");
        }

        private void support_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void community_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://YouTube.com/@b_daarr");
        }

        private void collaborate_button_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/b-daarr/CShark");
        }

        private void config_button_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
            this.Hide();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            status.Text = "Exit";
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            status.Text = string.Empty;
        }

        private void config_button_MouseEnter(object sender, EventArgs e)
        {
            info03.Text = "Config";
            info03.TextAlign = ContentAlignment.TopLeft;
        }

        private void config_button_MouseLeave(object sender, EventArgs e)
        {
            info03.Text = string.Empty;
        }

        private void collaborate_button_MouseEnter(object sender, EventArgs e)
        {
            info03.Text = "Develop";
            info03.TextAlign = ContentAlignment.TopRight;
        }

        private void collaborate_button_MouseLeave(object sender, EventArgs e)
        {
            info03.Text = string.Empty;
        }

        private void appearance_button_MouseEnter(object sender, EventArgs e)
        {
            info02.Text = "Appearance";
            info02.TextAlign = ContentAlignment.TopLeft;
        }

        private void appearance_button_MouseLeave(object sender, EventArgs e)
        {
            info02.Text = string.Empty;
        }

        private void community_button_MouseEnter(object sender, EventArgs e)
        {
            info01.Text = "Community";
            info01.TextAlign = ContentAlignment.BottomRight;
        }

        private void community_button_MouseLeave(object sender, EventArgs e)
        {
            info01.Text = string.Empty;
        }

        private void donate_button_MouseEnter(object sender, EventArgs e)
        {
            info02.Text = "Donation";
            info02.TextAlign = ContentAlignment.TopRight;
        }

        private void donate_button_MouseLeave(object sender, EventArgs e)
        {
            info02.Text = string.Empty;
        }

        private void support_button_MouseEnter(object sender, EventArgs e)
        {
            info01.Text = "Support";
            info01.TextAlign = ContentAlignment.BottomLeft;
        }

        private void support_button_MouseLeave(object sender, EventArgs e)
        {
            info01.Text = string.Empty;
        }

        private void start_button_MouseEnter(object sender, EventArgs e)
        {
            info03.Text = "START";
            info03.TextAlign = ContentAlignment.BottomCenter;
        }

        private void start_button_MouseLeave(object sender, EventArgs e)
        {
            info03.Text = string.Empty;
        }

        public static string rootfile = @"D:\\cshark_cache.json";
        private string json = File.ReadAllText(rootfile);

        public void LightMode()
        {
            BackColor = Color.FromArgb(0, 100, 255);
            logo.BackColor = Color.FromArgb(0, 100, 255);
            name.BackColor = Color.FromArgb(0, 100, 255);
            exit_button.BackColor = Color.FromArgb(0, 100, 255);
            minimize_button.BackColor = Color.FromArgb(0, 100, 255);
            name.ForeColor = Color.Black;
            info01.ForeColor = Color.FromArgb(64, 0, 64);
            info02.ForeColor = Color.FromArgb(64, 0, 64);
            info03.ForeColor = Color.FromArgb(64, 0, 64);
        }

        public void DarkMode()
        {
            BackColor = Color.FromArgb(64, 0, 64);
            logo.BackColor = Color.FromArgb(64, 0, 64);
            name.BackColor = Color.FromArgb(64, 0, 64);
            exit_button.BackColor = Color.FromArgb(64, 0, 64);
            minimize_button.BackColor = Color.FromArgb(64, 0, 64);
            name.ForeColor = Color.White;
            info01.ForeColor = Color.FromArgb(255, 128, 255);
            info02.ForeColor = Color.FromArgb(255, 128, 255);
            info03.ForeColor = Color.FromArgb(255, 128, 255);
        }

        public void RootFileTest()
        {
            try
            {
                File.ReadAllText(rootfile);
            }
            catch
            {
                var msg = MessageBox.Show("The root files of the program have been destroyed! \n >>> Reinstall the program. \n https://GitHub.com/b-daarr/CShark", "Root files are lost", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (msg == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Process[] processes =Process.GetProcessesByName("cshark");
            //if (processes.Length > 0)
            //{
            //    var msg = MessageBox.Show("the program is currently running!", "error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    if (msg == DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //}


            RootFileTest();

            var objects = JObject.Parse(json);

            if (objects["app_theme"].ToString() == "light")
            {
                LightMode();
            }
            else if (objects["app_theme"].ToString() == "dark")
            {
                DarkMode();
            }
        }

        private void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            status.Text = "Minimize";
        }

        private void minimize_button_MouseLeave(object sender, EventArgs e)
        {
            status.Text = string.Empty;
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
