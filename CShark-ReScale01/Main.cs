using CShark_ReScale01.Properties;
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
using System.Xml.Linq;
using System.Xml;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CShark_ReScale01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Primary Variables

        public static string rootfile = @"D:\\cshark_files\cshark_cache.json";
        readonly dynamic objects = JObject.Parse(File.ReadAllText(rootfile));

        //

        // Primary Functions

        public void Hover_Hint(dynamic btn, string input)
        {
            button_hint.SetToolTip(btn, input);
        }

        public void Reset_HeadButton()
        {
            headbutton_tips.Text = string.Empty;
            headbutton_tips.ForeColor = Color.White;
        }

        public void HeadButton_Configure(string txt, dynamic clr, dynamic align)
        {
            headbutton_tips.Text = txt;
            headbutton_tips.ForeColor = clr;
            headbutton_tips.TextAlign = align;

        }

        public void LightMode()
        {
            this.BackColor = Color.FromArgb(0, 100, 255);
        }

        public void DarkMode()
        {
            this.BackColor = Color.FromArgb(64, 0, 64);
        }

        public void RootFileTest()
        {
            try
            {
                File.ReadAllText(rootfile);
            }
            catch
            {
                var msg = MessageBox.Show("The root files of the program have been destroyed (x524644) \n To repaire the program, the program must be forcibly reset;\nAll your settings like themes ans configs will be lost! \n\n Do you want to reset the program?", "Root files are lost", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (msg == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (msg == DialogResult.OK)
                {
                    // Reinstall app
                }
            }
        }

        private static void FileWrite()
        {
            File.WriteAllText(rootfile, objects.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));
        }

        //

        private void Main_Load(object sender, EventArgs e)
        {
            RootFileTest();

            if (objects["app_launched"].ToString() == "false")
            {
                objects["app_launched"] = "true";
                FileWrite();

                if (objects["app_theme"].ToString() == "light")
                {
                    LightMode();
                }
                else if (objects["app_theme"].ToString() == "dark")
                {
                    DarkMode();
                }
            }
            else if (objects["app_launched"].ToString() == "true")
            {
                Application.Exit();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect Server

            if (e.CloseReason == CloseReason.UserClosing)
            {
                objects["app_launched"] = "false";
                File.WriteAllText(rootfile, objects.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Disconnect Server
                objects["app_launched"] = "false";
                File.WriteAllText(rootfile, objects.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));
                Application.Exit();
            }
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void theme_mode_Click(object sender, EventArgs e)
        {
            if (objects["app_theme"].ToString() == "light")
            {
                DarkMode();
                objects["app_theme"] = "dark";
                File.WriteAllText(rootfile, objects.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));
            }
            else if (objects["app_theme"].ToString() == "dark")
            {
                LightMode();
                objects["app_theme"] = "light";
                File.WriteAllText(rootfile, objects.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));
            }
        }

        private void app_support_Click(object sender, EventArgs e)
        {
            Process.Start("http://cshark.space/");
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("EXIT", Color.Yellow, ContentAlignment.MiddleRight);
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        private void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("MINIMIZE", Color.White, ContentAlignment.MiddleCenter);
        }

        private void minimize_button_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        private void theme_mode_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("DARK MODE", Color.White, ContentAlignment.MiddleCenter);
        }

        private void theme_mode_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        private void app_support_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("CSHARK PAGE", Color.White, ContentAlignment.MiddleLeft);
        }

        private void app_support_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        private void import_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(import_config, "IMPORT CONFIG");
        }

        private void export_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(export_config, "EXPORT CONFIG");
        }

        private void remove_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(remove_config, "REMOVE CONFIG");
        }

        private void copy_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(copy_config, "COPY CONFIG TO CLIPBOARD");
        }

        private void connection_state_Click(object sender, EventArgs e)
        {
            connection_state.BackgroundImage = Resources.c02;
            connection_tips.Text = "Trying to connect...\n\n Please be patient.";
            this.UseWaitCursor = true;
        }

        private void import_config_Click(object sender, EventArgs e)
        {
            OCF.ShowHelp = false;
            OCF.ShowReadOnly = false;
            OCF.CheckFileExists = true;
            OCF.CheckPathExists = true;
            OCF.Filter = "CShark Config(*.pq)|*.pq";
            if(OCF.ShowDialog() == DialogResult.OK)
            {
                // 
            }
        }
    }
}
