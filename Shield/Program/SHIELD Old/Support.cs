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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            App app = new App();

            app.Show();
            this.Close();
        }
    }
}
