namespace CShark
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.name = new System.Windows.Forms.Label();
            this.community_button = new System.Windows.Forms.PictureBox();
            this.collaborate_button = new System.Windows.Forms.PictureBox();
            this.support_button = new System.Windows.Forms.PictureBox();
            this.donate_button = new System.Windows.Forms.PictureBox();
            this.config_button = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.info01 = new System.Windows.Forms.Label();
            this.info02 = new System.Windows.Forms.Label();
            this.info03 = new System.Windows.Forms.Label();
            this.appearance_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.community_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaborate_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.support_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donate_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearance_button)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(78, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 60);
            this.name.TabIndex = 3;
            this.name.Text = "CSHARK";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // community_button
            // 
            this.community_button.BackgroundImage = global::CShark.Resources.community;
            this.community_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.community_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.community_button.Location = new System.Drawing.Point(326, 148);
            this.community_button.Name = "community_button";
            this.community_button.Size = new System.Drawing.Size(60, 60);
            this.community_button.TabIndex = 11;
            this.community_button.TabStop = false;
            this.community_button.Click += new System.EventHandler(this.community_button_Click);
            this.community_button.MouseEnter += new System.EventHandler(this.community_button_MouseEnter);
            this.community_button.MouseLeave += new System.EventHandler(this.community_button_MouseLeave);
            // 
            // collaborate_button
            // 
            this.collaborate_button.BackgroundImage = global::CShark.Resources.collaborate;
            this.collaborate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.collaborate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collaborate_button.Location = new System.Drawing.Point(360, 253);
            this.collaborate_button.Name = "collaborate_button";
            this.collaborate_button.Size = new System.Drawing.Size(60, 60);
            this.collaborate_button.TabIndex = 10;
            this.collaborate_button.TabStop = false;
            this.collaborate_button.Click += new System.EventHandler(this.collaborate_button_Click);
            this.collaborate_button.MouseEnter += new System.EventHandler(this.collaborate_button_MouseEnter);
            this.collaborate_button.MouseLeave += new System.EventHandler(this.collaborate_button_MouseLeave);
            // 
            // support_button
            // 
            this.support_button.BackgroundImage = global::CShark.Resources.report;
            this.support_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.support_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.support_button.Location = new System.Drawing.Point(109, 148);
            this.support_button.Name = "support_button";
            this.support_button.Size = new System.Drawing.Size(60, 60);
            this.support_button.TabIndex = 9;
            this.support_button.TabStop = false;
            this.support_button.Click += new System.EventHandler(this.support_button_Click);
            this.support_button.MouseEnter += new System.EventHandler(this.support_button_MouseEnter);
            this.support_button.MouseLeave += new System.EventHandler(this.support_button_MouseLeave);
            // 
            // donate_button
            // 
            this.donate_button.BackgroundImage = global::CShark.Resources.donate;
            this.donate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.donate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donate_button.Location = new System.Drawing.Point(326, 360);
            this.donate_button.Name = "donate_button";
            this.donate_button.Size = new System.Drawing.Size(60, 60);
            this.donate_button.TabIndex = 6;
            this.donate_button.TabStop = false;
            this.donate_button.Click += new System.EventHandler(this.donate_button_Click);
            this.donate_button.MouseEnter += new System.EventHandler(this.donate_button_MouseEnter);
            this.donate_button.MouseLeave += new System.EventHandler(this.donate_button_MouseLeave);
            // 
            // config_button
            // 
            this.config_button.BackgroundImage = global::CShark.Resources.config;
            this.config_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.config_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.config_button.Location = new System.Drawing.Point(75, 253);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(60, 60);
            this.config_button.TabIndex = 5;
            this.config_button.TabStop = false;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            this.config_button.MouseEnter += new System.EventHandler(this.config_button_MouseEnter);
            this.config_button.MouseLeave += new System.EventHandler(this.config_button_MouseLeave);
            // 
            // start_button
            // 
            this.start_button.BackgroundImage = global::CShark.Resources._try;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Location = new System.Drawing.Point(184, 220);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(126, 126);
            this.start_button.TabIndex = 2;
            this.start_button.TabStop = false;
            this.start_button.MouseEnter += new System.EventHandler(this.start_button_MouseEnter);
            this.start_button.MouseLeave += new System.EventHandler(this.start_button_MouseLeave);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logo.BackgroundImage = global::CShark.Resources.applogo1;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exit_button.BackgroundImage = global::CShark.Resources.exit;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(453, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(35, 35);
            this.exit_button.TabIndex = 0;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Yellow;
            this.status.Location = new System.Drawing.Point(389, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(58, 35);
            this.status.TabIndex = 12;
            this.status.Text = "EXIT";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status.Visible = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // info01
            // 
            this.info01.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.info01.Location = new System.Drawing.Point(12, 105);
            this.info01.Name = "info01";
            this.info01.Size = new System.Drawing.Size(476, 40);
            this.info01.TabIndex = 13;
            this.info01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // info02
            // 
            this.info02.Font = new System.Drawing.Font("Ubuntu", 10.2F);
            this.info02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.info02.Location = new System.Drawing.Point(12, 423);
            this.info02.Name = "info02";
            this.info02.Size = new System.Drawing.Size(476, 40);
            this.info02.TabIndex = 14;
            this.info02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // info03
            // 
            this.info03.Font = new System.Drawing.Font("Ubuntu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.info03.Location = new System.Drawing.Point(12, 220);
            this.info03.Name = "info03";
            this.info03.Size = new System.Drawing.Size(476, 170);
            this.info03.TabIndex = 15;
            this.info03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appearance_button
            // 
            this.appearance_button.BackgroundImage = global::CShark.Resources.theme;
            this.appearance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appearance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appearance_button.Location = new System.Drawing.Point(109, 360);
            this.appearance_button.Name = "appearance_button";
            this.appearance_button.Size = new System.Drawing.Size(60, 60);
            this.appearance_button.TabIndex = 17;
            this.appearance_button.TabStop = false;
            this.appearance_button.Click += new System.EventHandler(this.appearance_button_Click);
            this.appearance_button.MouseEnter += new System.EventHandler(this.appearance_button_MouseEnter);
            this.appearance_button.MouseLeave += new System.EventHandler(this.appearance_button_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.appearance_button);
            this.Controls.Add(this.status);
            this.Controls.Add(this.community_button);
            this.Controls.Add(this.collaborate_button);
            this.Controls.Add(this.support_button);
            this.Controls.Add(this.donate_button);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.name);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.info02);
            this.Controls.Add(this.info01);
            this.Controls.Add(this.info03);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CShark";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.community_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaborate_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.support_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donate_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearance_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox start_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox config_button;
        private System.Windows.Forms.PictureBox donate_button;
        private System.Windows.Forms.PictureBox support_button;
        private System.Windows.Forms.PictureBox collaborate_button;
        private System.Windows.Forms.PictureBox community_button;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label info01;
        private System.Windows.Forms.Label info02;
        private System.Windows.Forms.Label info03;
        private System.Windows.Forms.PictureBox appearance_button;
    }
}

