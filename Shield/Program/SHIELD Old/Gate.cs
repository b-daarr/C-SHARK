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
    public partial class Gate : Form
    {
        public Gate()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            this.Close();
            user.ShowDialog();
        }
    }
}
