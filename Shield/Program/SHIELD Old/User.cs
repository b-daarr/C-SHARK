using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIELD
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            App app = new App();

            app.Show();
            this.Close();
        }

        private void userInfo_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "User Information";
            description.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void userInfo_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void services_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Uninstall App";
            description.TextAlign = ContentAlignment.MiddleRight;
        }

        private void services_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void report_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Bug Report";
            description.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void report_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Logout";
            description.TextAlign = ContentAlignment.MiddleRight;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void report_Click(object sender, EventArgs e)
        {
            Support support = new Support();

            this.Close();
            support.Show();
        }

        private void services_Click(object sender, EventArgs e)
        {

        }

        private void Theme_MouseEnter(object sender, EventArgs e)
        {
            description.Text = "Theme";
            description.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Theme_MouseLeave(object sender, EventArgs e)
        {
            description.Text = "";
        }

        private void userInfo_Click(object sender, EventArgs e)
        {
            Gate gate = new Gate();

            this.Close();
            gate.Show();
        }
    }
}
