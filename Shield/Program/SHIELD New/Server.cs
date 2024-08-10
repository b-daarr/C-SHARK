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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            App app = new App();

            this.Close();
            app.Show();
        }

        private void connection_Click(object sender, EventArgs e)
        {
            connection.Cursor = Cursors.WaitCursor;
            //this.WindowState = FormWindowState.Minimized;
        }

        private void Server_Load(object sender, EventArgs e)
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
            buttonInfo.Visible = false;
        }
    }
}
