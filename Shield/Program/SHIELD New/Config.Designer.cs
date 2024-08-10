namespace SHIELD
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            iconPic = new PictureBox();
            appName = new Label();
            backButton = new PictureBox();
            Clist = new FlowLayoutPanel();
            delete = new PictureBox();
            import = new PictureBox();
            export = new PictureBox();
            description = new Label();
            buttonInfo = new Label();
            openConfig = new OpenFileDialog();
            saveConfig = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)delete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)import).BeginInit();
            ((System.ComponentModel.ISupportInitialize)export).BeginInit();
            SuspendLayout();
            // 
            // iconPic
            // 
            iconPic.BackgroundImage = Data.configure;
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
            appName.Text = "CONFIG";
            appName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackgroundImage = Data.previous;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
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
            Clist.Location = new Point(12, 104);
            Clist.Name = "Clist";
            Clist.Size = new Size(376, 284);
            Clist.TabIndex = 17;
            // 
            // delete
            // 
            delete.BackgroundImage = Data.remove;
            delete.BackgroundImageLayout = ImageLayout.Zoom;
            delete.Cursor = Cursors.Hand;
            delete.Location = new Point(114, 53);
            delete.Name = "delete";
            delete.Size = new Size(45, 45);
            delete.SizeMode = PictureBoxSizeMode.Zoom;
            delete.TabIndex = 16;
            delete.TabStop = false;
            delete.Tag = "";
            delete.MouseEnter += delete_MouseEnter;
            delete.MouseLeave += delete_MouseLeave;
            // 
            // import
            // 
            import.BackgroundImage = Data.import;
            import.BackgroundImageLayout = ImageLayout.Zoom;
            import.Cursor = Cursors.Hand;
            import.Location = new Point(12, 53);
            import.Name = "import";
            import.Size = new Size(45, 45);
            import.SizeMode = PictureBoxSizeMode.Zoom;
            import.TabIndex = 13;
            import.TabStop = false;
            import.Tag = "";
            import.Click += import_Click;
            import.MouseEnter += import_MouseEnter;
            import.MouseLeave += import_MouseLeave;
            // 
            // export
            // 
            export.BackgroundImage = Data.export;
            export.BackgroundImageLayout = ImageLayout.Zoom;
            export.Cursor = Cursors.Hand;
            export.Location = new Point(63, 53);
            export.Name = "export";
            export.Size = new Size(45, 45);
            export.SizeMode = PictureBoxSizeMode.Zoom;
            export.TabIndex = 14;
            export.TabStop = false;
            export.Tag = "";
            export.Click += export_Click;
            export.MouseEnter += export_MouseEnter;
            export.MouseLeave += export_MouseLeave;
            // 
            // description
            // 
            description.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.ForeColor = Color.FromArgb(217, 144, 88);
            description.Location = new Point(165, 53);
            description.Name = "description";
            description.Size = new Size(223, 45);
            description.TabIndex = 15;
            description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(283, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(64, 35);
            buttonInfo.TabIndex = 18;
            buttonInfo.Text = "BACK";
            buttonInfo.TextAlign = ContentAlignment.MiddleRight;
            buttonInfo.Visible = false;
            // 
            // openConfig
            // 
            openConfig.FileName = "openFileDialog1";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(400, 400);
            Controls.Add(buttonInfo);
            Controls.Add(description);
            Controls.Add(export);
            Controls.Add(import);
            Controls.Add(delete);
            Controls.Add(Clist);
            Controls.Add(iconPic);
            Controls.Add(appName);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Config";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Config";
            Load += Config_Load;
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)delete).EndInit();
            ((System.ComponentModel.ISupportInitialize)import).EndInit();
            ((System.ComponentModel.ISupportInitialize)export).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPic;
        private Label appName;
        private PictureBox backButton;
        private FlowLayoutPanel Clist;
        private PictureBox export;
        private Label description;
        private PictureBox delete;
        private PictureBox import;
        private Label buttonInfo;
        private OpenFileDialog openConfig;
        private SaveFileDialog saveConfig;
    }
}