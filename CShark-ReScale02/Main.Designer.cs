namespace CShark_ReScale01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.appName_label = new System.Windows.Forms.Label();
            this.button_hint = new System.Windows.Forms.ToolTip(this.components);
            this.server_list = new System.Windows.Forms.Panel();
            this.network_statistics = new System.Windows.Forms.Panel();
            this.time_details = new System.Windows.Forms.Label();
            this.ping_details = new System.Windows.Forms.Label();
            this.ip_details = new System.Windows.Forms.Label();
            this.time_state = new System.Windows.Forms.PictureBox();
            this.ping_state = new System.Windows.Forms.PictureBox();
            this.ip_state = new System.Windows.Forms.PictureBox();
            this.speed_details = new System.Windows.Forms.Label();
            this.speed_state = new System.Windows.Forms.PictureBox();
            this.connection_tips = new System.Windows.Forms.Label();
            this.headbutton_tips = new System.Windows.Forms.Label();
            this.app_support = new System.Windows.Forms.PictureBox();
            this.theme_mode = new System.Windows.Forms.PictureBox();
            this.copy_config = new System.Windows.Forms.PictureBox();
            this.connection_state = new System.Windows.Forms.PictureBox();
            this.remove_config = new System.Windows.Forms.PictureBox();
            this.import_config = new System.Windows.Forms.PictureBox();
            this.export_config = new System.Windows.Forms.PictureBox();
            this.minimize_button = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.timing = new System.Windows.Forms.Timer(this.components);
            this.OCF = new System.Windows.Forms.OpenFileDialog();
            this.network_statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ping_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.import_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.export_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // appName_label
            // 
            this.appName_label.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold);
            this.appName_label.ForeColor = System.Drawing.Color.White;
            this.appName_label.Location = new System.Drawing.Point(82, 12);
            this.appName_label.Name = "appName_label";
            this.appName_label.Size = new System.Drawing.Size(108, 64);
            this.appName_label.TabIndex = 1;
            this.appName_label.Text = "CSHARK";
            this.appName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // server_list
            // 
            this.server_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server_list.Location = new System.Drawing.Point(12, 82);
            this.server_list.Name = "server_list";
            this.server_list.Size = new System.Drawing.Size(476, 388);
            this.server_list.TabIndex = 5;
            // 
            // network_statistics
            // 
            this.network_statistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.network_statistics.Controls.Add(this.time_details);
            this.network_statistics.Controls.Add(this.ping_details);
            this.network_statistics.Controls.Add(this.ip_details);
            this.network_statistics.Controls.Add(this.time_state);
            this.network_statistics.Controls.Add(this.ping_state);
            this.network_statistics.Controls.Add(this.ip_state);
            this.network_statistics.Controls.Add(this.speed_details);
            this.network_statistics.Controls.Add(this.speed_state);
            this.network_statistics.Location = new System.Drawing.Point(12, 552);
            this.network_statistics.Name = "network_statistics";
            this.network_statistics.Size = new System.Drawing.Size(476, 156);
            this.network_statistics.TabIndex = 6;
            // 
            // time_details
            // 
            this.time_details.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold);
            this.time_details.ForeColor = System.Drawing.Color.White;
            this.time_details.Location = new System.Drawing.Point(43, 121);
            this.time_details.Name = "time_details";
            this.time_details.Size = new System.Drawing.Size(432, 32);
            this.time_details.TabIndex = 17;
            this.time_details.Text = "00:00";
            this.time_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ping_details
            // 
            this.ping_details.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold);
            this.ping_details.ForeColor = System.Drawing.Color.White;
            this.ping_details.Location = new System.Drawing.Point(41, 83);
            this.ping_details.Name = "ping_details";
            this.ping_details.Size = new System.Drawing.Size(432, 32);
            this.ping_details.TabIndex = 16;
            this.ping_details.Text = "0 Milliseconds";
            this.ping_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ip_details
            // 
            this.ip_details.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold);
            this.ip_details.ForeColor = System.Drawing.Color.White;
            this.ip_details.Location = new System.Drawing.Point(41, 41);
            this.ip_details.Name = "ip_details";
            this.ip_details.Size = new System.Drawing.Size(432, 32);
            this.ip_details.TabIndex = 15;
            this.ip_details.Text = "0.0.0.0 ---- Unknown";
            this.ip_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_state
            // 
            this.time_state.BackgroundImage = global::CShark_ReScale01.Properties.Resources.time;
            this.time_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.time_state.Cursor = System.Windows.Forms.Cursors.Default;
            this.time_state.Location = new System.Drawing.Point(3, 121);
            this.time_state.Name = "time_state";
            this.time_state.Size = new System.Drawing.Size(32, 32);
            this.time_state.TabIndex = 14;
            this.time_state.TabStop = false;
            // 
            // ping_state
            // 
            this.ping_state.BackgroundImage = global::CShark_ReScale01.Properties.Resources.ping;
            this.ping_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ping_state.Cursor = System.Windows.Forms.Cursors.Default;
            this.ping_state.Location = new System.Drawing.Point(3, 83);
            this.ping_state.Name = "ping_state";
            this.ping_state.Size = new System.Drawing.Size(32, 32);
            this.ping_state.TabIndex = 13;
            this.ping_state.TabStop = false;
            // 
            // ip_state
            // 
            this.ip_state.BackgroundImage = global::CShark_ReScale01.Properties.Resources.ip_location;
            this.ip_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ip_state.Cursor = System.Windows.Forms.Cursors.Default;
            this.ip_state.Location = new System.Drawing.Point(3, 41);
            this.ip_state.Name = "ip_state";
            this.ip_state.Size = new System.Drawing.Size(32, 32);
            this.ip_state.TabIndex = 12;
            this.ip_state.TabStop = false;
            // 
            // speed_details
            // 
            this.speed_details.Font = new System.Drawing.Font("Ubuntu", 10.8F, System.Drawing.FontStyle.Bold);
            this.speed_details.ForeColor = System.Drawing.Color.White;
            this.speed_details.Location = new System.Drawing.Point(41, 3);
            this.speed_details.Name = "speed_details";
            this.speed_details.Size = new System.Drawing.Size(432, 32);
            this.speed_details.TabIndex = 7;
            this.speed_details.Text = "Download 0.0 KBps / Upload 0.0 KBps";
            this.speed_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed_state
            // 
            this.speed_state.BackgroundImage = global::CShark_ReScale01.Properties.Resources.speed;
            this.speed_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.speed_state.Cursor = System.Windows.Forms.Cursors.Default;
            this.speed_state.Location = new System.Drawing.Point(3, 3);
            this.speed_state.Name = "speed_state";
            this.speed_state.Size = new System.Drawing.Size(32, 32);
            this.speed_state.TabIndex = 11;
            this.speed_state.TabStop = false;
            // 
            // connection_tips
            // 
            this.connection_tips.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_tips.ForeColor = System.Drawing.Color.White;
            this.connection_tips.Location = new System.Drawing.Point(88, 476);
            this.connection_tips.Name = "connection_tips";
            this.connection_tips.Size = new System.Drawing.Size(330, 73);
            this.connection_tips.TabIndex = 15;
            this.connection_tips.Text = "Not Connected";
            this.connection_tips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headbutton_tips
            // 
            this.headbutton_tips.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headbutton_tips.ForeColor = System.Drawing.Color.White;
            this.headbutton_tips.Location = new System.Drawing.Point(342, 47);
            this.headbutton_tips.Name = "headbutton_tips";
            this.headbutton_tips.Size = new System.Drawing.Size(146, 32);
            this.headbutton_tips.TabIndex = 17;
            this.headbutton_tips.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // app_support
            // 
            this.app_support.BackgroundImage = global::CShark_ReScale01.Properties.Resources.support;
            this.app_support.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.app_support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_support.Location = new System.Drawing.Point(342, 12);
            this.app_support.Name = "app_support";
            this.app_support.Size = new System.Drawing.Size(32, 32);
            this.app_support.TabIndex = 20;
            this.app_support.TabStop = false;
            this.app_support.Click += new System.EventHandler(this.app_support_Click);
            this.app_support.MouseEnter += new System.EventHandler(this.app_support_MouseEnter);
            this.app_support.MouseLeave += new System.EventHandler(this.app_support_MouseLeave);
            // 
            // theme_mode
            // 
            this.theme_mode.BackgroundImage = global::CShark_ReScale01.Properties.Resources.dark;
            this.theme_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.theme_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.theme_mode.Location = new System.Drawing.Point(380, 12);
            this.theme_mode.Name = "theme_mode";
            this.theme_mode.Size = new System.Drawing.Size(32, 32);
            this.theme_mode.TabIndex = 18;
            this.theme_mode.TabStop = false;
            this.theme_mode.Click += new System.EventHandler(this.theme_mode_Click);
            this.theme_mode.MouseEnter += new System.EventHandler(this.theme_mode_MouseEnter);
            this.theme_mode.MouseLeave += new System.EventHandler(this.theme_mode_MouseLeave);
            // 
            // copy_config
            // 
            this.copy_config.BackgroundImage = global::CShark_ReScale01.Properties.Resources.copy;
            this.copy_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copy_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy_config.Enabled = false;
            this.copy_config.Location = new System.Drawing.Point(12, 514);
            this.copy_config.Name = "copy_config";
            this.copy_config.Size = new System.Drawing.Size(32, 32);
            this.copy_config.TabIndex = 16;
            this.copy_config.TabStop = false;
            this.copy_config.MouseHover += new System.EventHandler(this.copy_config_MouseHover);
            // 
            // connection_state
            // 
            this.connection_state.BackgroundImage = global::CShark_ReScale01.Properties.Resources.c01;
            this.connection_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connection_state.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connection_state.Enabled = false;
            this.connection_state.Location = new System.Drawing.Point(424, 479);
            this.connection_state.Name = "connection_state";
            this.connection_state.Size = new System.Drawing.Size(64, 64);
            this.connection_state.TabIndex = 11;
            this.connection_state.TabStop = false;
            this.connection_state.Click += new System.EventHandler(this.connection_state_Click);
            // 
            // remove_config
            // 
            this.remove_config.BackgroundImage = global::CShark_ReScale01.Properties.Resources.remove;
            this.remove_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.remove_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_config.Enabled = false;
            this.remove_config.Location = new System.Drawing.Point(12, 476);
            this.remove_config.Name = "remove_config";
            this.remove_config.Size = new System.Drawing.Size(32, 32);
            this.remove_config.TabIndex = 8;
            this.remove_config.TabStop = false;
            this.remove_config.MouseHover += new System.EventHandler(this.remove_config_MouseHover);
            // 
            // import_config
            // 
            this.import_config.BackgroundImage = global::CShark_ReScale01.Properties.Resources.import;
            this.import_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.import_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_config.Location = new System.Drawing.Point(50, 476);
            this.import_config.Name = "import_config";
            this.import_config.Size = new System.Drawing.Size(32, 32);
            this.import_config.TabIndex = 9;
            this.import_config.TabStop = false;
            this.import_config.Click += new System.EventHandler(this.import_config_Click);
            this.import_config.MouseHover += new System.EventHandler(this.import_config_MouseHover);
            // 
            // export_config
            // 
            this.export_config.BackgroundImage = global::CShark_ReScale01.Properties.Resources.export;
            this.export_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.export_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_config.Enabled = false;
            this.export_config.Location = new System.Drawing.Point(50, 514);
            this.export_config.Name = "export_config";
            this.export_config.Size = new System.Drawing.Size(32, 32);
            this.export_config.TabIndex = 10;
            this.export_config.TabStop = false;
            this.export_config.MouseHover += new System.EventHandler(this.export_config_MouseHover);
            // 
            // minimize_button
            // 
            this.minimize_button.BackgroundImage = global::CShark_ReScale01.Properties.Resources.minimize;
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_button.Location = new System.Drawing.Point(418, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(32, 32);
            this.minimize_button.TabIndex = 3;
            this.minimize_button.TabStop = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            this.minimize_button.MouseEnter += new System.EventHandler(this.minimize_button_MouseEnter);
            this.minimize_button.MouseLeave += new System.EventHandler(this.minimize_button_MouseLeave);
            // 
            // exit_button
            // 
            this.exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_button.BackgroundImage")));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(456, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(32, 32);
            this.exit_button.TabIndex = 2;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            // 
            // logo_picture
            // 
            this.logo_picture.BackgroundImage = global::CShark_ReScale01.Properties.Resources.app_logo;
            this.logo_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_picture.Location = new System.Drawing.Point(12, 12);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(64, 64);
            this.logo_picture.TabIndex = 0;
            this.logo_picture.TabStop = false;
            // 
            // OCF
            // 
            this.OCF.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 720);
            this.Controls.Add(this.app_support);
            this.Controls.Add(this.theme_mode);
            this.Controls.Add(this.headbutton_tips);
            this.Controls.Add(this.copy_config);
            this.Controls.Add(this.connection_tips);
            this.Controls.Add(this.connection_state);
            this.Controls.Add(this.remove_config);
            this.Controls.Add(this.import_config);
            this.Controls.Add(this.export_config);
            this.Controls.Add(this.network_statistics);
            this.Controls.Add(this.server_list);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.appName_label);
            this.Controls.Add(this.logo_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.network_statistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.time_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ping_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connection_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.import_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.export_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.Label appName_label;
        private System.Windows.Forms.PictureBox exit_button;
        private System.Windows.Forms.PictureBox minimize_button;
        private System.Windows.Forms.ToolTip button_hint;
        private System.Windows.Forms.Panel server_list;
        private System.Windows.Forms.Panel network_statistics;
        private System.Windows.Forms.PictureBox export_config;
        private System.Windows.Forms.PictureBox import_config;
        private System.Windows.Forms.PictureBox remove_config;
        private System.Windows.Forms.PictureBox time_state;
        private System.Windows.Forms.PictureBox ping_state;
        private System.Windows.Forms.PictureBox ip_state;
        private System.Windows.Forms.Label speed_details;
        private System.Windows.Forms.PictureBox speed_state;
        private System.Windows.Forms.PictureBox connection_state;
        private System.Windows.Forms.Label connection_tips;
        private System.Windows.Forms.PictureBox copy_config;
        private System.Windows.Forms.Label ip_details;
        private System.Windows.Forms.Label ping_details;
        private System.Windows.Forms.Label time_details;
        private System.Windows.Forms.Label headbutton_tips;
        private System.Windows.Forms.PictureBox theme_mode;
        private System.Windows.Forms.PictureBox app_support;
        private System.Windows.Forms.Timer timing;
        private System.Windows.Forms.OpenFileDialog OCF;
    }
}

