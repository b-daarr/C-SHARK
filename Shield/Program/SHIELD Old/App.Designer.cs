namespace SHIELD
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            exitButton = new PictureBox();
            appName = new Label();
            iconPic = new PictureBox();
            configButton = new PictureBox();
            infoButton = new PictureBox();
            supportButton = new PictureBox();
            ds1 = new Label();
            buttonInfo = new Label();
            appSettingButton = new PictureBox();
            ds2 = new Label();
            start = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)configButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supportButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appSettingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)start).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Image = Properties.Resource.exit;
            exitButton.Location = new Point(358, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 1;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseLeave;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(58, 12);
            appName.Name = "appName";
            appName.Size = new Size(93, 40);
            appName.TabIndex = 2;
            appName.Text = "SHIELD";
            appName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPic
            // 
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.ErrorImage = null;
            iconPic.Image = Properties.Resource.icon1;
            iconPic.Location = new Point(12, 12);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(40, 40);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 3;
            iconPic.TabStop = false;
            // 
            // configButton
            // 
            configButton.BackgroundImageLayout = ImageLayout.Zoom;
            configButton.Cursor = Cursors.Hand;
            configButton.Image = Properties.Resource.configure;
            configButton.Location = new Point(101, 100);
            configButton.Name = "configButton";
            configButton.Size = new Size(50, 50);
            configButton.SizeMode = PictureBoxSizeMode.Zoom;
            configButton.TabIndex = 6;
            configButton.TabStop = false;
            configButton.Tag = "";
            configButton.Click += configButton_Click;
            configButton.MouseEnter += configButton_MouseEnter;
            configButton.MouseLeave += configButton_MouseLeave;
            // 
            // infoButton
            // 
            infoButton.BackgroundImageLayout = ImageLayout.Zoom;
            infoButton.Cursor = Cursors.Hand;
            infoButton.Image = Properties.Resource.info;
            infoButton.Location = new Point(101, 249);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(50, 50);
            infoButton.SizeMode = PictureBoxSizeMode.Zoom;
            infoButton.TabIndex = 9;
            infoButton.TabStop = false;
            infoButton.Tag = "";
            infoButton.Click += infoButton_Click;
            infoButton.MouseEnter += infoButton_MouseEnter;
            infoButton.MouseLeave += infoButton_MouseLeave;
            // 
            // supportButton
            // 
            supportButton.BackgroundImageLayout = ImageLayout.Zoom;
            supportButton.Cursor = Cursors.Hand;
            supportButton.Image = Properties.Resource.support;
            supportButton.Location = new Point(251, 249);
            supportButton.Name = "supportButton";
            supportButton.Size = new Size(50, 50);
            supportButton.SizeMode = PictureBoxSizeMode.Zoom;
            supportButton.TabIndex = 10;
            supportButton.TabStop = false;
            supportButton.Tag = "";
            supportButton.Click += supportButton_Click;
            supportButton.MouseEnter += supportButton_MouseEnter;
            supportButton.MouseLeave += supportButton_MouseLeave;
            // 
            // ds1
            // 
            ds1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ds1.ForeColor = Color.FromArgb(217, 144, 88);
            ds1.Location = new Point(14, 156);
            ds1.Name = "ds1";
            ds1.Size = new Size(137, 90);
            ds1.TabIndex = 11;
            ds1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(283, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 30);
            buttonInfo.TabIndex = 12;
            buttonInfo.Text = "EXIT";
            buttonInfo.TextAlign = ContentAlignment.MiddleCenter;
            buttonInfo.Visible = false;
            // 
            // appSettingButton
            // 
            appSettingButton.BackgroundImageLayout = ImageLayout.Zoom;
            appSettingButton.Cursor = Cursors.Hand;
            appSettingButton.Image = Properties.Resource.setting;
            appSettingButton.Location = new Point(251, 100);
            appSettingButton.Name = "appSettingButton";
            appSettingButton.Size = new Size(50, 50);
            appSettingButton.SizeMode = PictureBoxSizeMode.Zoom;
            appSettingButton.TabIndex = 7;
            appSettingButton.TabStop = false;
            appSettingButton.Tag = "";
            appSettingButton.Click += appSettingButton_Click;
            appSettingButton.MouseEnter += appSettingButton_MouseEnter;
            appSettingButton.MouseLeave += appSettingButton_MouseLeave;
            // 
            // ds2
            // 
            ds2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ds2.ForeColor = Color.FromArgb(217, 144, 88);
            ds2.Location = new Point(251, 156);
            ds2.Name = "ds2";
            ds2.Size = new Size(132, 90);
            ds2.TabIndex = 13;
            ds2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            start.BackgroundImageLayout = ImageLayout.Zoom;
            start.Cursor = Cursors.Hand;
            start.Image = Properties.Resource.shield;
            start.Location = new Point(155, 156);
            start.Name = "start";
            start.Size = new Size(90, 90);
            start.SizeMode = PictureBoxSizeMode.Zoom;
            start.TabIndex = 5;
            start.TabStop = false;
            start.Click += start_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(ds2);
            Controls.Add(buttonInfo);
            Controls.Add(supportButton);
            Controls.Add(infoButton);
            Controls.Add(appSettingButton);
            Controls.Add(configButton);
            Controls.Add(start);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(exitButton);
            Controls.Add(ds1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SHIELD🛡️";
            Load += App_Load;
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)configButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)supportButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)appSettingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)start).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox exitButton;
        private Label appName;
        private PictureBox iconPic;
        private PictureBox configButton;
        private PictureBox infoButton;
        private PictureBox supportButton;
        private Label ds1;
        private Label buttonInfo;
        private PictureBox appSettingButton;
        private Label ds2;
        private PictureBox start;
    }
}
