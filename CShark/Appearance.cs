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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CShark
{
    public partial class Appearance : Form
    {
        public Appearance()
        {
            InitializeComponent();
        }

        private static string rootfile = @"D:\\cshark_cache.json";
        private string json = File.ReadAllText(rootfile);

        public void LightMode()
        {
            var objects = JObject.Parse(json);
            objects["app_theme"] = "light";
            File.WriteAllText(rootfile, objects.ToString(Formatting.Indented));

            BackColor = Color.FromArgb(0, 100, 255);
            logo.BackColor = Color.FromArgb(0, 100, 255);
            name.BackColor = Color.FromArgb(0, 100, 255);
            switch_mode.BackColor = Color.FromArgb(0, 100, 255);
            mode_pic.BackColor = Color.FromArgb(0, 100, 255);
            mode_status.BackColor = Color.FromArgb(0, 100, 255);
            back_button.BackColor = Color.FromArgb(0, 100, 255);
            status.BackColor = Color.FromArgb(0, 100, 255);
            mode_status.ForeColor = Color.Black;
            status.ForeColor = Color.Black;
            switch_mode.BackgroundImage = Resources.disable;
            mode_pic.BackgroundImage = Resources.lightmode;
            mode_status.Text = "Day Mode";
        }

        public void DarkMode()
        {
            var objects = JObject.Parse(json);
            objects["app_theme"] = "dark";
            File.WriteAllText(rootfile, objects.ToString(Formatting.Indented));

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
            switch_mode.BackgroundImage = Resources.enable;
            mode_pic.BackgroundImage = Resources.darkmode;
            mode_status.Text = "Night Mode";
        }

        private void switch_mode_Click(object sender, EventArgs e)
        {
            var objects = JObject.Parse(json);
            Main main = new Main();

            if (objects["app_theme"].ToString() == "dark")
            {
                LightMode();
            }
            else if (objects["app_theme"].ToString() == "light")
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
            Main main = new Main();
            main.RootFileTest();

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
    }
}
