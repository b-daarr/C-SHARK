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

        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            status.Visible = true;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            status.Visible = false;
        }

        private void config_button_MouseEnter(object sender, EventArgs e)
        {
            info01.Text = "Config";
            info01.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void config_button_MouseLeave(object sender, EventArgs e)
        {
            info01.Text = string.Empty;
        }

        private void collaborate_button_MouseEnter(object sender, EventArgs e)
        {
            info02.Text = "Develop";
            info02.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void collaborate_button_MouseLeave(object sender, EventArgs e)
        {
            info02.Text = string.Empty;
        }

        private void appearance_button_MouseEnter(object sender, EventArgs e)
        {
            info01.Text = "Appearance";
            info01.TextAlign = ContentAlignment.MiddleRight;
        }

        private void appearance_button_MouseLeave(object sender, EventArgs e)
        {
            info01.Text = string.Empty;
        }

        private void community_button_MouseEnter(object sender, EventArgs e)
        {
            info02.Text = "Community";
            info02.TextAlign = ContentAlignment.MiddleRight;
        }

        private void community_button_MouseLeave(object sender, EventArgs e)
        {
            info02.Text = string.Empty;
        }

        private void donate_button_MouseEnter(object sender, EventArgs e)
        {
            info03.Text = "Donation";
            info03.TextAlign = ContentAlignment.TopLeft;
        }

        private void donate_button_MouseLeave(object sender, EventArgs e)
        {
            info03.Text = string.Empty;
        }

        private void support_button_MouseEnter(object sender, EventArgs e)
        {
            info03.Text = "Support";
            info03.TextAlign = ContentAlignment.TopRight;
        }

        private void support_button_MouseLeave(object sender, EventArgs e)
        {
            info03.Text = string.Empty;
        }

        private void start_button_MouseEnter(object sender, EventArgs e)
        {
            info04.Text = "START";
        }

        private void start_button_MouseLeave(object sender, EventArgs e)
        {
            info04.Text = string.Empty;
        }

        public void LightMode()
        {
            BackColor = Color.FromArgb(255, 255, 128);
            logo.BackColor = Color.FromArgb(255, 255, 128);
            name.BackColor = Color.FromArgb(255, 255, 128);
            exit_button.BackColor = Color.FromArgb(255, 255, 128);
            status.ForeColor = Color.Red;
            name.ForeColor = Color.Black;
            info01.ForeColor = Color.FromArgb(64, 0, 64);
            info02.ForeColor = Color.FromArgb(64, 0, 64);
            info03.ForeColor = Color.FromArgb(64, 0, 64);
            info04.ForeColor = Color.Red;
        }

        public void DarkMode()
        {
            BackColor = Color.FromArgb(64, 0, 64);
            logo.BackColor = Color.FromArgb(64, 0, 64);
            name.BackColor = Color.FromArgb(64, 0, 64);
            exit_button.BackColor = Color.FromArgb(64, 0, 64);
            status.ForeColor = Color.Yellow;
            name.ForeColor = Color.White;
            info01.ForeColor = Color.FromArgb(255, 128, 255);
            info02.ForeColor = Color.FromArgb(255, 128, 255);
            info03.ForeColor = Color.FromArgb(255, 128, 255);
            info04.ForeColor = Color.Yellow;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                File.ReadAllText(@"D:\\mode");
            }
            catch
            {
                File.WriteAllText(@"D:\\mode", "dark");
            }

            string recovery = File.ReadAllText(@"D:\\mode");

            if (recovery == "light")
            {
                LightMode();
            }
            else if (recovery == "dark")
            {
                DarkMode();
            }
        }
    }
}
