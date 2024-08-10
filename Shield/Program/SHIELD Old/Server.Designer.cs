namespace SHIELD
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            iconPic = new PictureBox();
            appName = new Label();
            backButton = new PictureBox();
            connectionTime = new System.Windows.Forms.Timer(components);
            Clist = new FlowLayoutPanel();
            buttonInfo = new Label();
            connection = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connection).BeginInit();
            SuspendLayout();
            // 
            // iconPic
            // 
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.Image = Properties.Resource.server;
            iconPic.Location = new Point(12, 12);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(40, 40);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 6;
            iconPic.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(58, 12);
            appName.Name = "appName";
            appName.Size = new Size(109, 40);
            appName.TabIndex = 5;
            appName.Text = "SERVERS";
            appName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
            backButton.Image = Properties.Resource.previous;
            backButton.Location = new Point(353, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(35, 35);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 4;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += backButton_MouseEnter;
            backButton.MouseLeave += backButton_MouseLeave;
            // 
            // Clist
            // 
            Clist.AutoScroll = true;
            Clist.BorderStyle = BorderStyle.FixedSingle;
            Clist.Location = new Point(12, 80);
            Clist.Name = "Clist";
            Clist.Size = new Size(376, 212);
            Clist.TabIndex = 18;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(283, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 35);
            buttonInfo.TabIndex = 19;
            buttonInfo.Text = "EXIT";
            buttonInfo.TextAlign = ContentAlignment.MiddleCenter;
            buttonInfo.Visible = false;
            // 
            // connection
            // 
            connection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            connection.BackgroundImageLayout = ImageLayout.Zoom;
            connection.Cursor = Cursors.Hand;
            connection.Image = Properties.Resource.start;
            connection.Location = new Point(150, 298);
            connection.Name = "connection";
            connection.Size = new Size(100, 90);
            connection.SizeMode = PictureBoxSizeMode.Zoom;
            connection.TabIndex = 13;
            connection.TabStop = false;
            connection.Click += connection_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(buttonInfo);
            Controls.Add(Clist);
            Controls.Add(connection);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Server_Load;
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)connection).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPic;
        private Label appName;
        private PictureBox backButton;
        private System.Windows.Forms.Timer connectionTime;
        private FlowLayoutPanel Clist;
        private Label buttonInfo;
        private PictureBox connection;
    }
}