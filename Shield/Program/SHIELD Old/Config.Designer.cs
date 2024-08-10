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
            iconPic.BackgroundImageLayout = ImageLayout.Zoom;
            iconPic.Image = Properties.Resource.configure;
            iconPic.Location = new Point(12, 12);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(40, 40);
            iconPic.SizeMode = PictureBoxSizeMode.Zoom;
            iconPic.TabIndex = 6;
            iconPic.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(58, 12);
            appName.Name = "appName";
            appName.Size = new Size(101, 40);
            appName.TabIndex = 5;
            appName.Text = "CONFIG";
            appName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
            backButton.Image = Properties.Resource.previous;
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
            Clist.Location = new Point(12, 132);
            Clist.Name = "Clist";
            Clist.Size = new Size(376, 256);
            Clist.TabIndex = 17;
            // 
            // delete
            // 
            delete.BackgroundImageLayout = ImageLayout.Zoom;
            delete.Cursor = Cursors.Hand;
            delete.Image = Properties.Resource.export;
            delete.Location = new Point(68, 76);
            delete.Name = "delete";
            delete.Size = new Size(50, 50);
            delete.SizeMode = PictureBoxSizeMode.Zoom;
            delete.TabIndex = 16;
            delete.TabStop = false;
            delete.Tag = "";
            delete.MouseEnter += delete_MouseEnter;
            delete.MouseLeave += delete_MouseLeave;
            // 
            // import
            // 
            import.BackgroundImageLayout = ImageLayout.Zoom;
            import.Cursor = Cursors.Hand;
            import.Image = Properties.Resource.import;
            import.Location = new Point(12, 76);
            import.Name = "import";
            import.Size = new Size(50, 50);
            import.SizeMode = PictureBoxSizeMode.Zoom;
            import.TabIndex = 13;
            import.TabStop = false;
            import.Tag = "";
            import.MouseEnter += import_MouseEnter;
            import.MouseLeave += import_MouseLeave;
            // 
            // export
            // 
            export.BackgroundImageLayout = ImageLayout.Zoom;
            export.Cursor = Cursors.Hand;
            export.Image = Properties.Resource.remove;
            export.Location = new Point(124, 76);
            export.Name = "export";
            export.Size = new Size(50, 50);
            export.SizeMode = PictureBoxSizeMode.Zoom;
            export.TabIndex = 14;
            export.TabStop = false;
            export.Tag = "";
            export.MouseEnter += export_MouseEnter;
            export.MouseLeave += export_MouseLeave;
            // 
            // description
            // 
            description.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.ForeColor = Color.FromArgb(217, 144, 88);
            description.Location = new Point(180, 76);
            description.Name = "description";
            description.Size = new Size(208, 50);
            description.TabIndex = 15;
            description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.ForeColor = Color.Yellow;
            buttonInfo.Location = new Point(284, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(63, 35);
            buttonInfo.TabIndex = 18;
            buttonInfo.Text = "BACK";
            buttonInfo.TextAlign = ContentAlignment.MiddleCenter;
            buttonInfo.Visible = false;
            // 
            // openConfig
            // 
            openConfig.FileName = "openFileDialog1";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
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