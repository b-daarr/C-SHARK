using CShark.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CShark
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        // Variables
        private static readonly string rootFile = @"D:\\cshark_files\\cshark_cache.json";
        private static JObject jsObject;
        private static readonly JObject basicData = JObject.Parse(@"{ 
            'app_launched': false, 
            'app_theme': 'light', 
            'config_list': [
                { 
                    'config_name': 'Troubleshooter', 
                    'preferred_dns_server_ip': '1.1.1.1', 
                    'alternate_dns_server_ip': '8.8.8.8'
                }
            ] 
        }");

        // Functions
        private void RootFileTest()
        {
            if (File.Exists(rootFile))
            {
                jsObject = JObject.Parse(File.ReadAllText(rootFile));
            }
            else
            {
                File.WriteAllText(rootFile, JsonConvert.SerializeObject(basicData, Formatting.Indented));
            }
        }

        private void LoadSettings()
        {
            if (jsObject["app_launched"].ToObject<bool>() == false)
            {
                JSonModify("app_launched", true);
                SetTheme(jsObject["app_theme"].ToString());
            }
            else if (jsObject["app_launched"].ToObject<bool>() == true)
            {
                Application.Exit();
            }
        }

        private void SetTheme(string theme)
        {
            if (theme == "light")
            {
                BackColor = Color.FromArgb(0, 100, 255);
            }
            else if (theme == "dark")
            {
                BackColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void HoverHint(Control btn, string input)
        {
            button_hint.SetToolTip(btn, input);
        }

        private void ResetHeadButton()
        {
            headbutton_tips.Text = string.Empty;
            headbutton_tips.ForeColor = Color.White;
        }

        private void HeadButtonConfigure(string txt, Color clr, ContentAlignment align)
        {
            headbutton_tips.Text = txt;
            headbutton_tips.ForeColor = clr;
            headbutton_tips.TextAlign = align;
        }

        private static void JsonSave()
        {
            File.WriteAllText(rootFile, JsonConvert.SerializeObject(jsObject, Formatting.Indented));
        }

        private static void JSonModify(string key, object value)
        {
            jsObject[key] = JToken.FromObject(value);
            JsonSave();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RootFileTest();
            //LoadSettings();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                JSonModify("app_launched", false);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \nIn case of exit, the services will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (msg == DialogResult.OK)
            {
                // Disconnect Server
                JSonModify("app_launched", false);
                Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ThemeMode_Click(object sender, EventArgs e)
        {
            if (jsObject["app_theme"].ToString() == "light")
            {
                JSonModify("app_theme", "dark");
                SetTheme("dark");
            }
            else if (jsObject["app_theme"].ToString() == "dark")
            {
                JSonModify("app_theme", "light");
                SetTheme("light");
            }
        }

        private void AppSupport_Click(object sender, EventArgs e)
        {
            Process.Start("http://cshark.space/");
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            HeadButtonConfigure("EXIT", Color.Yellow, ContentAlignment.MiddleRight);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ResetHeadButton();
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            HeadButtonConfigure("MINIMIZE", Color.White, ContentAlignment.MiddleCenter);
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            ResetHeadButton();
        }

        private void ThemeMode_MouseEnter(object sender, EventArgs e)
        {
            HeadButtonConfigure("DARK MODE", Color.White, ContentAlignment.MiddleCenter);
        }

        private void ThemeMode_MouseLeave(object sender, EventArgs e)
        {
            ResetHeadButton();
        }

        private void AppSupport_MouseEnter(object sender, EventArgs e)
        {
            HeadButtonConfigure("CSHARK PAGE", Color.White, ContentAlignment.MiddleLeft);
        }

        private void AppSupport_MouseLeave(object sender, EventArgs e)
        {
            ResetHeadButton();
        }

        private void ImportConfig_MouseHover(object sender, EventArgs e)
        {
            HoverHint(import_config, "IMPORT CONFIG");
        }

        private void ExportConfig_MouseHover(object sender, EventArgs e)
        {
            HoverHint(export_config, "EXPORT CONFIG");
        }

        private void RemoveConfig_MouseHover(object sender, EventArgs e)
        {
            HoverHint(remove_config, "REMOVE CONFIG");
        }

        private void CopyConfig_MouseHover(object sender, EventArgs e)
        {
            HoverHint(copy_config, "COPY CONFIG TO CLIPBOARD");
        }

        private void ConnectionState_Click(object sender, EventArgs e)
        {
            connection_state.BackgroundImage = Resources.c02;
            connection_tips.Text = "Trying to connect...\n\n Please be patient.";
            UseWaitCursor = true;
        }

        private void ImportConfig_Click(object sender, EventArgs e)
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