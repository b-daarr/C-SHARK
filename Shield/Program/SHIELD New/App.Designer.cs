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
            buttonInfo = new Label();
            appSettingButton = new PictureBox();
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
            exitButton.BackgroundImage = Data.exit;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(353, 11);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 32);
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
            appName.Location = new Point(69, 11);
            appName.Name = "appName";
            appName.Size = new Size(75, 45);
            appName.TabIndex = 2;
            appName.Text = "SHIELD";
            appName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPic
            // 
            iconPic.BackgroundImage = Data.icon;
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.ErrorImage = null;
            iconPic.Location = new Point(12, 11);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(50, 45);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 3;
            iconPic.TabStop = false;
            // 
            // configButton
            // 
            configButton.BackgroundImage = Data.configure;
            configButton.BackgroundImageLayout = ImageLayout.Zoom;
            configButton.Cursor = Cursors.Hand;
            configButton.Location = new Point(37, 116);
            configButton.Name = "configButton";
            configButton.Size = new Size(60, 54);
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
            infoButton.BackgroundImage = Data.info;
            infoButton.BackgroundImageLayout = ImageLayout.Zoom;
            infoButton.Cursor = Cursors.Hand;
            infoButton.Location = new Point(12, 208);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(60, 54);
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
            supportButton.BackgroundImage = Data.support;
            supportButton.BackgroundImageLayout = ImageLayout.Zoom;
            supportButton.Cursor = Cursors.Hand;
            supportButton.Location = new Point(328, 208);
            supportButton.Name = "supportButton";
            supportButton.Size = new Size(60, 54);
            supportButton.SizeMode = PictureBoxSizeMode.Zoom;
            supportButton.TabIndex = 10;
            supportButton.TabStop = false;
            supportButton.Tag = "";
            supportButton.Click += supportButton_Click;
            supportButton.MouseEnter += supportButton_MouseEnter;
            supportButton.MouseLeave += supportButton_MouseLeave;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(283, 11);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 32);
            buttonInfo.TabIndex = 12;
            buttonInfo.Text = "EXIT";
            buttonInfo.TextAlign = ContentAlignment.MiddleRight;
            buttonInfo.Visible = false;
            // 
            // appSettingButton
            // 
            appSettingButton.BackgroundImage = Data.setting;
            appSettingButton.BackgroundImageLayout = ImageLayout.Zoom;
            appSettingButton.Cursor = Cursors.Hand;
            appSettingButton.Location = new Point(311, 116);
            appSettingButton.Name = "appSettingButton";
            appSettingButton.Size = new Size(60, 54);
            appSettingButton.SizeMode = PictureBoxSizeMode.Zoom;
            appSettingButton.TabIndex = 7;
            appSettingButton.TabStop = false;
            appSettingButton.Tag = "";
            appSettingButton.Click += appSettingButton_Click;
            appSettingButton.MouseEnter += appSettingButton_MouseEnter;
            appSettingButton.MouseLeave += appSettingButton_MouseLeave;
            // 
            // start
            // 
            start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            start.BackgroundImage = Data.cloud;
            start.BackgroundImageLayout = ImageLayout.Zoom;
            start.Cursor = Cursors.Hand;
            start.Location = new Point(145, 298);
            start.Name = "start";
            start.Size = new Size(100, 90);
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
            Controls.Add(buttonInfo);
            Controls.Add(supportButton);
            Controls.Add(infoButton);
            Controls.Add(appSettingButton);
            Controls.Add(configButton);
            Controls.Add(start);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SHIELD🛡️";
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
        private Label buttonInfo;
        private PictureBox appSettingButton;
        private PictureBox start;
    }
}
