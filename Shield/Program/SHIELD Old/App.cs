using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace SHIELD
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void configButton_MouseEnter(object sender, EventArgs e)
        {
            ds1.Text = "Manage Config";
            ds1.TextAlign = ContentAlignment.TopRight;
        }

        private void configButton_MouseLeave(object sender, EventArgs e)
        {
            ds1.Text = "";
        }

        private void appSettingButton_MouseEnter(object sender, EventArgs e)
        {
            ds2.Text = "Setting";
            ds2.TextAlign = ContentAlignment.TopLeft;
        }

        private void appSettingButton_MouseLeave(object sender, EventArgs e)
        {
            ds2.Text = "";
        }

        private void infoButton_MouseEnter(object sender, EventArgs e)
        {
            ds1.Text = "Program Task";
            ds1.TextAlign = ContentAlignment.BottomRight;
        }

        private void infoButton_MouseLeave(object sender, EventArgs e)
        {
            ds1.Text = "";
        }

        private void supportButton_MouseEnter(object sender, EventArgs e)
        {
            ds2.Text = "Contact Us";
            ds2.TextAlign = ContentAlignment.BottomLeft;
        }

        private void supportButton_MouseLeave(object sender, EventArgs e)
        {
            ds2.Text = "";
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Information information = new Information();

            this.Hide();
            information.Show();
        }

        private void appSettingButton_Click(object sender, EventArgs e)
        {
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Config config = new Config();

            this.Hide();
            config.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit? \n\n If you exit the program, the services of the program will be disabled!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (msg == DialogResult.OK)
            {
                string mode = "Wi-Fi", modes = "Ethernet";

                ProcessStartInfo psi = new ProcessStartInfo("cmd", "/c netsh interface ipv4 delete dnsservers " + mode + " all")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process process = new Process
                {
                    StartInfo = psi
                };
                process.Start();
                process.WaitForExit();

                Application.Exit();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Server server = new Server();

            this.Hide();
            server.Show();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo.Visible = true;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            buttonInfo.Visible = false;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
