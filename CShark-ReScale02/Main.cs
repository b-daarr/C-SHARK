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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CShark_ReScale01
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // Variables

        readonly static string root_file = @"D:\\cshark_files\cshark_cache.json";

        static dynamic js_object;

        static dynamic basic_data = new
        {
            app_launched = false,
            app_theme = "light",
            config_list = new[]
                {
                    new
                    {
                        config_name = "Troubleshooter",
                        preferred_dns_server_ip = "1.1.1.1",
                        alternate_dns_server_ip = "8.8.8.8"
                    }
                }
        };

        //

        // Functions

        void RootFileTest()
        {
            if (File.Exists(root_file))
            {
                js_object = JObject.Parse(File.ReadAllText(root_file));
            }
            else
            {
                File.WriteAllText(root_file, Newtonsoft.Json.JsonConvert.SerializeObject(basic_data, Newtonsoft.Json.Formatting.Indented));
            }
        }

        static void LoadSettings()
        {
            if (js_object["app_launched"].ToString() == false)
            {
                JSonModify("app_launched", true);

                if (js_object["app_theme"].ToString() == "light")
                {
                    LightMode();
                }
                else if (js_object["app_theme"].ToString() == "dark")
                {
                    DarkMode();
                }
            }
            else if (js_object["app_launched"] == true)
            {
                Application.Exit();
            }
        }

        static void LightMode()
        {
            Main main = new Main();
            main.BackColor = Color.FromArgb(0, 100, 255);
        }

        static void DarkMode()
        {
            Main main = new Main();
            main.BackColor = Color.FromArgb(64, 0, 64);
        }

        void Hover_Hint(dynamic btn, string input)
        {
            button_hint.SetToolTip(btn, input);
        }

        void Reset_HeadButton()
        {
            headbutton_tips.Text = string.Empty;
            headbutton_tips.ForeColor = Color.White;
        }

        void HeadButton_Configure(string txt, dynamic clr, dynamic align)
        {
            headbutton_tips.Text = txt;
            headbutton_tips.ForeColor = clr;
            headbutton_tips.TextAlign = align;

        }

        static void JsonSave()
        {
            File.WriteAllText(root_file, Newtonsoft.Json.JsonConvert.SerializeObject(js_object, Newtonsoft.Json.Formatting.Indented));
        }

        static void JSonModify(dynamic key, dynamic value)
        {
            js_object[key] = value;
            JsonSave();
        }

        static void JsonInclude(dynamic key, dynamic value)
        {
            js_object["config_list"].ToString()[key] = value;
            JsonSave();
        }

        static void JsonExclude(dynamic key)
        {
            js_object.Remove(key);
            JsonSave();
        }

        //

        private void Main_Load(object sender, EventArgs e)
        {
            RootFileTest();
            //LoadSettings();
        }

        void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect Server

            if (e.CloseReason == CloseReason.UserClosing)
            {
                js_object["app_launched"] = false;
                JsonSave();
            }
        }

        void exit_button_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Disconnect Server
                js_object["app_launched"] = false;
                JsonSave();
                Application.Exit();
            }
        }

        void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void theme_mode_Click(object sender, EventArgs e)
        {
            if (js_object["app_theme"].ToString() == "light")
            {
                DarkMode();
                js_object["app_theme"] = "dark";
                JsonSave();
            }
            else if (js_object["app_theme"].ToString() == "dark")
            {
                LightMode();
                js_object["app_theme"] = "light";
                JsonSave();
            }
        }

        void app_support_Click(object sender, EventArgs e)
        {
            Process.Start("http://cshark.space/");
        }

        void exit_button_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("EXIT", Color.Yellow, ContentAlignment.MiddleRight);
        }

        void exit_button_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("MINIMIZE", Color.White, ContentAlignment.MiddleCenter);
        }

        void minimize_button_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        void theme_mode_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("DARK MODE", Color.White, ContentAlignment.MiddleCenter);
        }

        void theme_mode_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        void app_support_MouseEnter(object sender, EventArgs e)
        {
            HeadButton_Configure("CSHARK PAGE", Color.White, ContentAlignment.MiddleLeft);
        }

        void app_support_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        void import_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(import_config, "IMPORT CONFIG");
        }

        void export_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(export_config, "EXPORT CONFIG");
        }

        void remove_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(remove_config, "REMOVE CONFIG");
        }

        void copy_config_MouseHover(object sender, EventArgs e)
        {
            Hover_Hint(copy_config, "COPY CONFIG TO CLIPBOARD");
        }

        void connection_state_Click(object sender, EventArgs e)
        {
            connection_state.BackgroundImage = Resources.c02;
            connection_tips.Text = "Trying to connect...\n\n Please be patient.";
            this.UseWaitCursor = true;
        }

        void import_config_Click(object sender, EventArgs e)
        {
            OCF.ShowHelp = false;
            OCF.ShowReadOnly = false;
            OCF.CheckFileExists = true;
            OCF.CheckPathExists = true;
            OCF.Filter = "CShark Config(*.pq)|*.pq";
            if (OCF.ShowDialog() == DialogResult.OK)
            {
                // ConfigInclude();
            }
        }
    }
}
