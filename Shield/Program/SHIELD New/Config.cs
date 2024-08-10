using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace SHIELD
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            App app = new App();

            app.Show();
            this.Close();
        }

        private void import_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Import Config";
        }

        private void import_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void export_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Export Config";
        }

        private void export_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void delete_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Remove Config";
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void repair_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Repair Config";
            description.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void repair_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void Config_Load(object sender, EventArgs e)
        {
            ConfigTool configTool = new ConfigTool();
            configTool.List(Clist);
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo.Visible = true;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            buttonInfo.Visible &= false;
        }

        private void import_Click(object sender, EventArgs e)
        {
            openConfig.ShowHelp = false;
            openConfig.ShowHiddenFiles = false;
            openConfig.ShowPinnedPlaces = false;
            openConfig.Filter = "Shield File(*.SHI)|*.shi";
            openConfig.Multiselect = false;
            //openConfig.OkRequiresInteraction = false;

            if (openConfig.ShowDialog() == DialogResult.OK)
            {
                string[] data;
                data = System.IO.File.ReadAllLines(openConfig.FileName);
                if (data.Length >= 3)
                {
                    
                }
                else
                {
                    MessageBox.Show("Config is INCORRECT!", "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            saveConfig.ShowHelp = false;
            saveConfig.ShowHiddenFiles = false;
            saveConfig.ShowPinnedPlaces = false;
            saveConfig.Filter = "Shield File(*.SHI)|*.shi";
            saveConfig.CheckFileExists = true;
            saveConfig.CheckPathExists = true;

            ConfigTool ct = new ConfigTool();

            if (saveConfig.ShowDialog() == DialogResult.OK)
            {
                ct.expConfig(saveConfig.FileName);
            }
        }
    }
}
