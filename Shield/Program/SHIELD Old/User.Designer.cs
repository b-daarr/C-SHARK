namespace SHIELD
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            iconPic = new PictureBox();
            appName = new Label();
            backButton = new PictureBox();
            uninstall = new PictureBox();
            userInfo = new PictureBox();
            report = new PictureBox();
            description = new Label();
            Theme = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uninstall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)report).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Theme).BeginInit();
            SuspendLayout();
            // 
            // iconPic
            // 
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.Location = new Point(12, 12);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(30, 30);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 6;
            iconPic.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(48, 12);
            appName.Name = "appName";
            appName.Size = new Size(75, 30);
            appName.TabIndex = 5;
            appName.Text = "USER";
            appName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(353, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(35, 35);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 4;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // uninstall
            // 
            uninstall.BackgroundImageLayout = ImageLayout.Zoom;
            uninstall.Cursor = Cursors.Hand;
            uninstall.Location = new Point(288, 288);
            uninstall.Name = "uninstall";
            uninstall.Size = new Size(100, 100);
            uninstall.SizeMode = PictureBoxSizeMode.Zoom;
            uninstall.TabIndex = 14;
            uninstall.TabStop = false;
            uninstall.Tag = "";
            uninstall.Click += services_Click;
            uninstall.MouseEnter += services_MouseEnter;
            uninstall.MouseLeave += services_MouseLeave;
            // 
            // userInfo
            // 
            userInfo.BackgroundImageLayout = ImageLayout.Zoom;
            userInfo.Cursor = Cursors.Hand;
            userInfo.Location = new Point(12, 80);
            userInfo.Name = "userInfo";
            userInfo.Size = new Size(100, 100);
            userInfo.SizeMode = PictureBoxSizeMode.Zoom;
            userInfo.TabIndex = 13;
            userInfo.TabStop = false;
            userInfo.Tag = "";
            userInfo.Click += userInfo_Click;
            userInfo.MouseEnter += userInfo_MouseEnter;
            userInfo.MouseLeave += userInfo_MouseLeave;
            // 
            // report
            // 
            report.BackgroundImageLayout = ImageLayout.Zoom;
            report.Cursor = Cursors.Hand;
            report.Location = new Point(12, 288);
            report.Name = "report";
            report.Size = new Size(100, 100);
            report.SizeMode = PictureBoxSizeMode.Zoom;
            report.TabIndex = 15;
            report.TabStop = false;
            report.Tag = "";
            report.Click += report_Click;
            report.MouseEnter += report_MouseEnter;
            report.MouseLeave += report_MouseLeave;
            // 
            // description
            // 
            description.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.ForeColor = Color.FromArgb(217, 144, 88);
            description.Location = new Point(12, 223);
            description.Name = "description";
            description.Size = new Size(376, 30);
            description.TabIndex = 17;
            description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(Theme);
            Controls.Add(description);
            Controls.Add(report);
            Controls.Add(uninstall);
            Controls.Add(userInfo);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)uninstall).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)report).EndInit();
            ((System.ComponentModel.ISupportInitialize)Theme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPic;
        private Label appName;
        private PictureBox backButton;
        private PictureBox uninstall;
        private PictureBox userInfo;
        private PictureBox report;
        private Label description;
        private PictureBox Theme;
    }
}