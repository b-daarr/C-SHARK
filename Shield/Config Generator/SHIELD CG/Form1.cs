using System.Security.Cryptography;
using System.Text;

namespace SHIELD_Config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo.Visible = true;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            buttonInfo.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 2)
            {
                try
                {
    
                    
                }
            }
            else
            {
                MessageBox.Show("Incorrect Format!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (msg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                Clipboard.SetText(result.Text);
                result.Text = "Copied Config to Clipboard";
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            saveConfig.FileName = name.Text + ".shi";
            saveConfig.Filter = "Shield File(*.SHI)|*.shi";

            string file;

            if (saveConfig.ShowDialog() == DialogResult.OK)
            {
                file = saveConfig.FileName;

                File.WriteAllText(file, result.Text);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }
    }
}
