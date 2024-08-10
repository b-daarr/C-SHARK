namespace SHIELD
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            backButton = new PictureBox();
            telegramSupport = new PictureBox();
            githubSupport = new PictureBox();
            iconPic = new PictureBox();
            appName = new Label();
            githubDescription = new Label();
            telegramDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)telegramSupport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)githubSupport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(337, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(35, 35);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 2;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // telegramSupport
            // 
            telegramSupport.BackgroundImageLayout = ImageLayout.Zoom;
            telegramSupport.Cursor = Cursors.Hand;
            telegramSupport.Location = new Point(12, 74);
            telegramSupport.Name = "telegramSupport";
            telegramSupport.Size = new Size(100, 151);
            telegramSupport.SizeMode = PictureBoxSizeMode.Zoom;
            telegramSupport.TabIndex = 11;
            telegramSupport.TabStop = false;
            telegramSupport.Tag = "";
            // 
            // githubSupport
            // 
            githubSupport.BackgroundImageLayout = ImageLayout.Zoom;
            githubSupport.Cursor = Cursors.Hand;
            githubSupport.Location = new Point(12, 231);
            githubSupport.Name = "githubSupport";
            githubSupport.Size = new Size(100, 157);
            githubSupport.SizeMode = PictureBoxSizeMode.Zoom;
            githubSupport.TabIndex = 12;
            githubSupport.TabStop = false;
            githubSupport.Tag = "";
            // 
            // iconPic
            // 
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.Location = new Point(12, 12);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(30, 30);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 14;
            iconPic.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(46, 12);
            appName.Name = "appName";
            appName.Size = new Size(97, 30);
            appName.TabIndex = 13;
            appName.Text = "SUPPORT";
            appName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // githubDescription
            // 
            githubDescription.BorderStyle = BorderStyle.FixedSingle;
            githubDescription.Location = new Point(118, 231);
            githubDescription.Name = "githubDescription";
            githubDescription.Size = new Size(254, 157);
            githubDescription.TabIndex = 15;
            githubDescription.Text = "label1";
            // 
            // telegramDescription
            // 
            telegramDescription.BorderStyle = BorderStyle.FixedSingle;
            telegramDescription.Location = new Point(118, 74);
            telegramDescription.Name = "telegramDescription";
            telegramDescription.Size = new Size(254, 151);
            telegramDescription.TabIndex = 16;
            telegramDescription.Text = "label1";
            // 
            // Support
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(telegramDescription);
            Controls.Add(githubDescription);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(githubSupport);
            Controls.Add(telegramSupport);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Support";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support";
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)telegramSupport).EndInit();
            ((System.ComponentModel.ISupportInitialize)githubSupport).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backButton;
        private PictureBox telegramSupport;
        private PictureBox githubSupport;
        private PictureBox iconPic;
        private Label appName;
        private Label githubDescription;
        private Label telegramDescription;
    }
}