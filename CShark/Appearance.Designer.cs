namespace CShark
{
    partial class Appearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appearance));
            this.status = new System.Windows.Forms.Label();
            this.mode_status = new System.Windows.Forms.Label();
            this.switch_mode = new System.Windows.Forms.PictureBox();
            this.mode_pic = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.bdaarr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.switch_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mode_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdaarr)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(365, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(82, 35);
            this.status.TabIndex = 13;
            this.status.Text = "BACK";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status.Visible = false;
            // 
            // mode_status
            // 
            this.mode_status.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_status.ForeColor = System.Drawing.Color.White;
            this.mode_status.Location = new System.Drawing.Point(187, 113);
            this.mode_status.Name = "mode_status";
            this.mode_status.Size = new System.Drawing.Size(127, 50);
            this.mode_status.TabIndex = 18;
            this.mode_status.Text = "Dark Mode";
            this.mode_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switch_mode
            // 
            this.switch_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.switch_mode.BackgroundImage = global::CShark.Resources.enable;
            this.switch_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_mode.Location = new System.Drawing.Point(438, 113);
            this.switch_mode.Name = "switch_mode";
            this.switch_mode.Size = new System.Drawing.Size(50, 50);
            this.switch_mode.TabIndex = 17;
            this.switch_mode.TabStop = false;
            this.switch_mode.Click += new System.EventHandler(this.switch_mode_Click);
            // 
            // mode_pic
            // 
            this.mode_pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mode_pic.BackgroundImage = global::CShark.Resources.darkmode;
            this.mode_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mode_pic.Location = new System.Drawing.Point(12, 88);
            this.mode_pic.Name = "mode_pic";
            this.mode_pic.Size = new System.Drawing.Size(100, 100);
            this.mode_pic.TabIndex = 16;
            this.mode_pic.TabStop = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.name.BackgroundImage = global::CShark.Resources.theme;
            this.name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.Location = new System.Drawing.Point(78, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 35);
            this.name.TabIndex = 15;
            this.name.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logo.BackgroundImage = global::CShark.Resources.applogo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back_button.BackgroundImage = global::CShark.Resources.back;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Location = new System.Drawing.Point(453, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(35, 35);
            this.back_button.TabIndex = 1;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseEnter += new System.EventHandler(this.back_button_MouseEnter);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            // 
            // bdaarr
            // 
            this.bdaarr.BackgroundImage = global::CShark.Resources.awake;
            this.bdaarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bdaarr.Cursor = System.Windows.Forms.Cursors.Help;
            this.bdaarr.Location = new System.Drawing.Point(12, 198);
            this.bdaarr.Name = "bdaarr";
            this.bdaarr.Size = new System.Drawing.Size(30, 30);
            this.bdaarr.TabIndex = 20;
            this.bdaarr.TabStop = false;
            // 
            // Appearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 240);
            this.Controls.Add(this.bdaarr);
            this.Controls.Add(this.mode_status);
            this.Controls.Add(this.switch_mode);
            this.Controls.Add(this.mode_pic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appearance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Appearance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.switch_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mode_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdaarr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox mode_pic;
        private System.Windows.Forms.PictureBox switch_mode;
        private System.Windows.Forms.Label mode_status;
        private System.Windows.Forms.PictureBox bdaarr;
    }
}