namespace CShark
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.name = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.import = new System.Windows.Forms.PictureBox();
            this.export = new System.Windows.Forms.PictureBox();
            this.remove = new System.Windows.Forms.PictureBox();
            this.item_status = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.ToolTip(this.components);
            this.config_list = new System.Windows.Forms.FlowLayoutPanel();
            this.bdaarr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdaarr)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.name.BackgroundImage = global::CShark.Resources.config;
            this.name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.Location = new System.Drawing.Point(78, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 35);
            this.name.TabIndex = 19;
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
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(365, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(82, 35);
            this.status.TabIndex = 17;
            this.status.Text = "BACK";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status.Visible = false;
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
            this.back_button.TabIndex = 16;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseEnter += new System.EventHandler(this.back_button_MouseEnter);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.import.BackgroundImage = global::CShark.Resources.import;
            this.import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import.Location = new System.Drawing.Point(326, 438);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(50, 50);
            this.import.TabIndex = 20;
            this.import.TabStop = false;
            this.import.MouseEnter += new System.EventHandler(this.import_MouseEnter);
            this.import.MouseLeave += new System.EventHandler(this.import_MouseLeave);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.export.BackgroundImage = global::CShark.Resources.export;
            this.export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export.Enabled = false;
            this.export.Location = new System.Drawing.Point(382, 438);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(50, 50);
            this.export.TabIndex = 21;
            this.export.TabStop = false;
            this.export.MouseEnter += new System.EventHandler(this.export_MouseEnter);
            this.export.MouseLeave += new System.EventHandler(this.export_MouseLeave);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.remove.BackgroundImage = global::CShark.Resources.remove;
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.Enabled = false;
            this.remove.Location = new System.Drawing.Point(438, 438);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(50, 50);
            this.remove.TabIndex = 22;
            this.remove.TabStop = false;
            this.remove.MouseEnter += new System.EventHandler(this.remove_MouseEnter);
            this.remove.MouseLeave += new System.EventHandler(this.remove_MouseLeave);
            // 
            // item_status
            // 
            this.item_status.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_status.ForeColor = System.Drawing.Color.White;
            this.item_status.Location = new System.Drawing.Point(48, 438);
            this.item_status.Name = "item_status";
            this.item_status.Size = new System.Drawing.Size(272, 50);
            this.item_status.TabIndex = 24;
            this.item_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // config_list
            // 
            this.config_list.Location = new System.Drawing.Point(12, 78);
            this.config_list.Name = "config_list";
            this.config_list.Size = new System.Drawing.Size(476, 354);
            this.config_list.TabIndex = 25;
            // 
            // bdaarr
            // 
            this.bdaarr.BackgroundImage = global::CShark.Resources.awake;
            this.bdaarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bdaarr.Cursor = System.Windows.Forms.Cursors.Help;
            this.bdaarr.Location = new System.Drawing.Point(12, 458);
            this.bdaarr.Name = "bdaarr";
            this.bdaarr.Size = new System.Drawing.Size(30, 30);
            this.bdaarr.TabIndex = 26;
            this.bdaarr.TabStop = false;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.bdaarr);
            this.Controls.Add(this.config_list);
            this.Controls.Add(this.item_status);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Config_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdaarr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox name;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.PictureBox import;
        private System.Windows.Forms.PictureBox export;
        private System.Windows.Forms.PictureBox remove;
        private System.Windows.Forms.Label item_status;
        private System.Windows.Forms.ToolTip hint;
        private System.Windows.Forms.FlowLayoutPanel config_list;
        private System.Windows.Forms.PictureBox bdaarr;
    }
}