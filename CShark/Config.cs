using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CShark
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Config_KeyDown);
            this.KeyPreview = true;
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

        private static string rootfile = @"D:\\cshark_cache.json";
        private string json = File.ReadAllText(rootfile);

        public void LightMode()
        {
            BackColor = Color.FromArgb(0, 100, 255);
            logo.BackColor = Color.FromArgb(0, 100, 255);
            name.BackColor = Color.FromArgb(0, 100, 255);
            back_button.BackColor = Color.FromArgb(0, 100, 255);
            remove.BackColor = Color.FromArgb(0, 100, 255);
            export.BackColor = Color.FromArgb(0, 100, 255);
            import.BackColor = Color.FromArgb(0, 100, 255);
            config_list.BackColor = Color.FromArgb(0, 100, 255);
            status.ForeColor = Color.Black;
            name.ForeColor = Color.Black;
            item_status.ForeColor = Color.Black;
        }

        public void DarkMode()
        {
            BackColor = Color.FromArgb(64, 0, 64);
            logo.BackColor = Color.FromArgb(64, 0, 64);
            name.BackColor = Color.FromArgb(64, 0, 64);
            back_button.BackColor = Color.FromArgb(64, 0, 64);
            remove.BackColor = Color.FromArgb(64, 0, 64);
            export.BackColor = Color.FromArgb(64, 0, 64);
            import.BackColor = Color.FromArgb(64, 0, 64);
            config_list.BackColor = Color.FromArgb(64, 0, 64);
            status.ForeColor = Color.White;
            name.ForeColor = Color.White;
            item_status.ForeColor = Color.White;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            Main main = new Main();
            main.RootFileTest();


            var jsonObject = JObject.Parse(json);

            if (jsonObject["app_theme"].ToString() == "light")
            {
                LightMode();
            }
            else if (jsonObject["app_theme"].ToString() == "dark")
            {
                DarkMode();
            }
        }

        private void import_MouseEnter(object sender, EventArgs e)
        {
            item_status.Text = "Import Config";
            hint.SetToolTip(import, "Ctrl + I");
        }

        private void import_MouseLeave(object sender, EventArgs e)
        {
            item_status.Text = string.Empty;
        }

        private void export_MouseEnter(object sender, EventArgs e)
        {
            item_status.Text = "Export Config";
            hint.SetToolTip(export, "Ctrl + E");
        }

        private void export_MouseLeave(object sender, EventArgs e)
        {
            item_status.Text = string.Empty;
        }

        private void remove_MouseEnter(object sender, EventArgs e)
        {
            item_status.Text = "Remove Config";
            hint.SetToolTip(remove, "Ctrl + R");
        }

        private void remove_MouseLeave(object sender, EventArgs e)
        {
            item_status.Text = string.Empty;
        }

        private void Config_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                //
            }
            else if (export.Enabled == true && e.Control && e.KeyCode == Keys.E)
            {
                //
            }
            else if (remove.Enabled == true && e.Control && e.KeyCode == Keys.R)
            {
                //
            }
        }
    }
}
