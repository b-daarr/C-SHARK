﻿namespace SHIELD
{
    partial class Gate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gate));
            iconPic = new PictureBox();
            appName = new Label();
            backButton = new PictureBox();
            linkUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linkUser).BeginInit();
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
            appName.Text = "LINK";
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
            // linkUser
            // 
            linkUser.BackgroundImageLayout = ImageLayout.Zoom;
            linkUser.Location = new Point(12, 68);
            linkUser.Name = "linkUser";
            linkUser.Size = new Size(100, 100);
            linkUser.SizeMode = PictureBoxSizeMode.Zoom;
            linkUser.TabIndex = 14;
            linkUser.TabStop = false;
            linkUser.Tag = "";
            // 
            // Gate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(linkUser);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gate";
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)linkUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPic;
        private Label appName;
        private PictureBox backButton;
        private PictureBox linkUser;
    }
}