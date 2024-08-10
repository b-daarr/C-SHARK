namespace SHIELD_Config
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            exitButton = new PictureBox();
            pictureBox1 = new PictureBox();
            appName = new Label();
            buttonInfo = new Label();
            name = new TextBox();
            saveConfig = new SaveFileDialog();
            configName = new Label();
            configFIP = new Label();
            F1 = new TextBox();
            configSIP = new Label();
            start = new PictureBox();
            result = new Label();
            log = new Label();
            copy = new PictureBox();
            export = new PictureBox();
            clear = new PictureBox();
            F2 = new TextBox();
            F3 = new TextBox();
            F4 = new TextBox();
            S4 = new TextBox();
            S3 = new TextBox();
            S2 = new TextBox();
            S1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)export).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clear).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Repository.exit;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(353, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 35);
            exitButton.TabIndex = 0;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click;
            exitButton.MouseEnter += exitButton_MouseEnter;
            exitButton.MouseLeave += exitButton_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Repository._00;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F);
            appName.ForeColor = Color.White;
            appName.Location = new Point(68, 12);
            appName.Name = "appName";
            appName.Size = new Size(157, 50);
            appName.TabIndex = 2;
            appName.Text = "SHIELD Configure";
            appName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(262, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(85, 35);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "EXIT";
            buttonInfo.TextAlign = ContentAlignment.MiddleRight;
            buttonInfo.Visible = false;
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(64, 64, 64);
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = Color.Silver;
            name.Location = new Point(12, 126);
            name.Name = "name";
            name.ScrollBars = ScrollBars.Vertical;
            name.Size = new Size(376, 32);
            name.TabIndex = 4;
            name.TextAlign = HorizontalAlignment.Center;
            // 
            // saveConfig
            // 
            saveConfig.AddExtension = false;
            saveConfig.AddToRecent = false;
            saveConfig.CheckFileExists = true;
            saveConfig.OkRequiresInteraction = true;
            saveConfig.ShowPinnedPlaces = false;
            // 
            // configName
            // 
            configName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            configName.ForeColor = Color.FromArgb(255, 192, 128);
            configName.Location = new Point(12, 91);
            configName.Name = "configName";
            configName.Size = new Size(376, 32);
            configName.TabIndex = 5;
            configName.Text = "Config Name";
            configName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // configFIP
            // 
            configFIP.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            configFIP.ForeColor = Color.FromArgb(255, 192, 128);
            configFIP.Location = new Point(12, 161);
            configFIP.Name = "configFIP";
            configFIP.Size = new Size(376, 32);
            configFIP.TabIndex = 7;
            configFIP.Text = "Preferred DNS Server (IP)";
            configFIP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F1
            // 
            F1.BackColor = Color.FromArgb(64, 64, 64);
            F1.BorderStyle = BorderStyle.FixedSingle;
            F1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            F1.ForeColor = Color.Silver;
            F1.Location = new Point(12, 196);
            F1.MaxLength = 3;
            F1.Name = "F1";
            F1.Size = new Size(88, 32);
            F1.TabIndex = 6;
            F1.TextAlign = HorizontalAlignment.Center;
            // 
            // configSIP
            // 
            configSIP.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            configSIP.ForeColor = Color.FromArgb(255, 192, 128);
            configSIP.Location = new Point(12, 231);
            configSIP.Name = "configSIP";
            configSIP.Size = new Size(376, 32);
            configSIP.TabIndex = 9;
            configSIP.Text = "Alternate DNS Server (IP)";
            configSIP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            start.BackgroundImage = Repository.icons;
            start.BackgroundImageLayout = ImageLayout.Zoom;
            start.Cursor = Cursors.Hand;
            start.Location = new Point(12, 712);
            start.Name = "start";
            start.Size = new Size(85, 85);
            start.TabIndex = 12;
            start.TabStop = false;
            start.Click += pictureBox2_Click;
            // 
            // result
            // 
            result.BorderStyle = BorderStyle.Fixed3D;
            result.Font = new Font("Segoe UI", 10.2F);
            result.ForeColor = Color.FromArgb(255, 255, 128);
            result.Location = new Point(12, 333);
            result.Name = "result";
            result.Size = new Size(376, 376);
            result.TabIndex = 13;
            // 
            // log
            // 
            log.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log.ForeColor = Color.FromArgb(255, 192, 128);
            log.Location = new Point(12, 301);
            log.Name = "log";
            log.Size = new Size(376, 32);
            log.TabIndex = 14;
            log.Text = "Config Result";
            log.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // copy
            // 
            copy.BackgroundImage = Repository._29_;
            copy.BackgroundImageLayout = ImageLayout.Zoom;
            copy.Cursor = Cursors.Hand;
            copy.Location = new Point(338, 712);
            copy.Name = "copy";
            copy.Size = new Size(50, 50);
            copy.TabIndex = 15;
            copy.TabStop = false;
            copy.Click += copy_Click;
            // 
            // export
            // 
            export.BackgroundImage = Repository.export;
            export.BackgroundImageLayout = ImageLayout.Zoom;
            export.Cursor = Cursors.Hand;
            export.Location = new Point(282, 712);
            export.Name = "export";
            export.Size = new Size(50, 50);
            export.TabIndex = 20;
            export.TabStop = false;
            export.Click += export_Click;
            // 
            // clear
            // 
            clear.BackgroundImage = Repository._5_;
            clear.BackgroundImageLayout = ImageLayout.Zoom;
            clear.Cursor = Cursors.Hand;
            clear.Location = new Point(226, 712);
            clear.Name = "clear";
            clear.Size = new Size(50, 50);
            clear.TabIndex = 21;
            clear.TabStop = false;
            clear.Click += clear_Click;
            // 
            // F2
            // 
            F2.BackColor = Color.FromArgb(64, 64, 64);
            F2.BorderStyle = BorderStyle.FixedSingle;
            F2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            F2.ForeColor = Color.Silver;
            F2.Location = new Point(106, 196);
            F2.MaxLength = 3;
            F2.Name = "F2";
            F2.ScrollBars = ScrollBars.Vertical;
            F2.Size = new Size(90, 32);
            F2.TabIndex = 22;
            F2.TextAlign = HorizontalAlignment.Center;
            // 
            // F3
            // 
            F3.BackColor = Color.FromArgb(64, 64, 64);
            F3.BorderStyle = BorderStyle.FixedSingle;
            F3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            F3.ForeColor = Color.Silver;
            F3.Location = new Point(202, 196);
            F3.MaxLength = 3;
            F3.Name = "F3";
            F3.ScrollBars = ScrollBars.Vertical;
            F3.Size = new Size(90, 32);
            F3.TabIndex = 23;
            F3.TextAlign = HorizontalAlignment.Center;
            // 
            // F4
            // 
            F4.BackColor = Color.FromArgb(64, 64, 64);
            F4.BorderStyle = BorderStyle.FixedSingle;
            F4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            F4.ForeColor = Color.Silver;
            F4.Location = new Point(298, 196);
            F4.MaxLength = 3;
            F4.Name = "F4";
            F4.ScrollBars = ScrollBars.Vertical;
            F4.Size = new Size(90, 32);
            F4.TabIndex = 24;
            F4.TextAlign = HorizontalAlignment.Center;
            // 
            // S4
            // 
            S4.BackColor = Color.FromArgb(64, 64, 64);
            S4.BorderStyle = BorderStyle.FixedSingle;
            S4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S4.ForeColor = Color.Silver;
            S4.Location = new Point(298, 266);
            S4.MaxLength = 3;
            S4.Name = "S4";
            S4.ScrollBars = ScrollBars.Vertical;
            S4.Size = new Size(90, 32);
            S4.TabIndex = 28;
            S4.TextAlign = HorizontalAlignment.Center;
            // 
            // S3
            // 
            S3.BackColor = Color.FromArgb(64, 64, 64);
            S3.BorderStyle = BorderStyle.FixedSingle;
            S3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S3.ForeColor = Color.Silver;
            S3.Location = new Point(202, 266);
            S3.MaxLength = 3;
            S3.Name = "S3";
            S3.ScrollBars = ScrollBars.Vertical;
            S3.Size = new Size(90, 32);
            S3.TabIndex = 27;
            S3.TextAlign = HorizontalAlignment.Center;
            // 
            // S2
            // 
            S2.BackColor = Color.FromArgb(64, 64, 64);
            S2.BorderStyle = BorderStyle.FixedSingle;
            S2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S2.ForeColor = Color.Silver;
            S2.Location = new Point(106, 266);
            S2.MaxLength = 3;
            S2.Name = "S2";
            S2.ScrollBars = ScrollBars.Vertical;
            S2.Size = new Size(90, 32);
            S2.TabIndex = 26;
            S2.TextAlign = HorizontalAlignment.Center;
            // 
            // S1
            // 
            S1.BackColor = Color.FromArgb(64, 64, 64);
            S1.BorderStyle = BorderStyle.FixedSingle;
            S1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            S1.ForeColor = Color.Silver;
            S1.Location = new Point(12, 266);
            S1.MaxLength = 3;
            S1.Name = "S1";
            S1.ScrollBars = ScrollBars.Vertical;
            S1.Size = new Size(88, 32);
            S1.TabIndex = 25;
            S1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(400, 809);
            Controls.Add(S4);
            Controls.Add(S3);
            Controls.Add(S2);
            Controls.Add(S1);
            Controls.Add(F4);
            Controls.Add(F3);
            Controls.Add(F2);
            Controls.Add(clear);
            Controls.Add(export);
            Controls.Add(copy);
            Controls.Add(log);
            Controls.Add(result);
            Controls.Add(start);
            Controls.Add(configSIP);
            Controls.Add(configFIP);
            Controls.Add(F1);
            Controls.Add(configName);
            Controls.Add(name);
            Controls.Add(buttonInfo);
            Controls.Add(appName);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)start).EndInit();
            ((System.ComponentModel.ISupportInitialize)copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)export).EndInit();
            ((System.ComponentModel.ISupportInitialize)clear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox exitButton;
        private PictureBox pictureBox1;
        private Label appName;
        private Label buttonInfo;
        private TextBox name;
        private SaveFileDialog saveConfig;
        private Label configName;
        private Label configFIP;
        private TextBox F1;
        private Label configSIP;
        private PictureBox start;
        private Label result;
        private Label log;
        private PictureBox copy;
        private PictureBox export;
        private PictureBox clear;
        private TextBox F2;
        private TextBox F3;
        private TextBox F4;
        private TextBox S4;
        private TextBox S3;
        private TextBox S2;
        private TextBox S1;
    }
}
