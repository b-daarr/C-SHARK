using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CShark
{
    public partial class Main : Form
    {
        // Constants
        private readonly string RootFile = @"D:\\cshark_files\\cshark_cache.json";
        private dynamic AppSettings;

        // Default data
        private static readonly dynamic DefaultSettings = new
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

        public Main()
        {
            InitializeComponent();
        }

        #region Main Form Events

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                AppSettings = LoadOrCreateSettings();
                ApplyTheme(AppSettings["app_theme"].ToString());
            }
            catch (Exception ex)
            {
                ShowError($"Error loading settings: {ex.Message}");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                UpdateSetting("app_launched", false);
            }
        }

        #endregion

        #region Button Click Events

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?\nExiting will disable all services.", 
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                UpdateSetting("app_launched", false);
                Application.Exit();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ThemeMode_Click(object sender, EventArgs e)
        {
            string newTheme = AppSettings["app_theme"].ToString() == "light" ? "dark" : "light";
            ApplyTheme(newTheme);
            UpdateSetting("app_theme", newTheme);
        }

        private void AppSupport_Click(object sender, EventArgs e)
        {
            Process.Start("http://cshark.space/");
        }

        #endregion

        #region JSON Settings Handling

        private dynamic LoadOrCreateSettings()
        {
            if (File.Exists(RootFile))
            {
                return JObject.Parse(File.ReadAllText(RootFile));
            }
            else
            {
                var jsonSettings = JsonConvert.SerializeObject(DefaultSettings, Formatting.Indented);
                File.WriteAllText(RootFile, jsonSettings);
                return JObject.Parse(jsonSettings);
            }
        }

        private void SaveSettings()
        {
            File.WriteAllText(RootFile, JsonConvert.SerializeObject(AppSettings, Formatting.Indented));
        }

        private void UpdateSetting(string key, dynamic value)
        {
            AppSettings[key] = value;
            SaveSettings();
        }

        #endregion

        #region Theme Management

        private void ApplyTheme(string theme)
        {
            BackColor = theme == "dark" ? Color.FromArgb(64, 0, 64) : Color.FromArgb(0, 100, 255);
        }

        #endregion

        #region UI Helpers

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                HeadButton_Configure(btn.Text.ToUpper(), Color.Yellow, ContentAlignment.MiddleRight);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Reset_HeadButton();
        }

        private void HeadButton_Configure(string text, Color color, ContentAlignment alignment)
        {
            headbutton_tips.Text = text;
            headbutton_tips.ForeColor = color;
            headbutton_tips.TextAlign = alignment;
        }

        private void ResetHeadButton()
        {
            headbutton_tips.Text = string.Empty;
            headbutton_tips.ForeColor = Color.White;
        }

        #endregion
    }
}