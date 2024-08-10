using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CShark
{
    public partial class Appearance : Form
    {
        public Appearance()
        {
            InitializeComponent();
        }

        private string mode;

        public void LightMode()
        {
            BackColor = Color.FromArgb(255, 255, 128);
            logo.BackColor = Color.FromArgb(255, 255, 128);
            name.BackColor = Color.FromArgb(255, 255, 128);
            switch_mode.BackColor = Color.FromArgb(255, 255, 128);
            mode_pic.BackColor = Color.FromArgb(255, 255, 128);
            mode_status.BackColor = Color.FromArgb(255, 255, 128);
            back_button.BackColor = Color.FromArgb(255, 255, 128);
            status.BackColor = Color.FromArgb(255, 255, 128);
            mode_status.ForeColor = Color.FromArgb(64, 0, 64);
            status.ForeColor = Color.Black;
            mode = "light";
            File.WriteAllText(@"D:\\mode", mode.ToString());
            switch_mode.BackgroundImage = Resources.disable;
            mode_pic.BackgroundImage = Resources.lightmode;
            mode_status.Text = "Light Mode";
        }

        public void DarkMode()
        {
            BackColor = Color.FromArgb(64, 0, 64);
            logo.BackColor = Color.FromArgb(64, 0, 64);
            name.BackColor = Color.FromArgb(64, 0, 64);
            switch_mode.BackColor = Color.FromArgb(64, 0, 64);
            mode_pic.BackColor = Color.FromArgb(64, 0, 64);
            mode_status.BackColor = Color.FromArgb(64, 0, 64);
            back_button.BackColor = Color.FromArgb(64, 0, 64);
            status.BackColor = Color.FromArgb(64, 0, 64);
            mode_status.ForeColor = Color.FromArgb(255, 192, 255);
            status.ForeColor = Color.White;
            mode = "dark";
            File.WriteAllText(@"D:\\mode", mode.ToString());
            switch_mode.BackgroundImage = Resources.enable;
            mode_pic.BackgroundImage = Resources.darkmode;
            mode_status.Text = "Dark Mode";
        }

        private void switch_mode_Click(object sender, EventArgs e)
        {
            if (mode == "dark")
            {
                LightMode();
            }
            else if (mode == "light")
            {
                DarkMode();
            }
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            status.Visible = true;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            status.Visible = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Appearance_Load(object sender, EventArgs e)
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
            mode = recovery;
            

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
