namespace E.B_Setup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NoAccept = new System.Windows.Forms.RadioButton();
            this.Accept = new System.Windows.Forms.RadioButton();
            this.More1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Support = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // NoAccept
            // 
            this.NoAccept.AutoSize = true;
            this.NoAccept.Checked = true;
            this.NoAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoAccept.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAccept.ForeColor = System.Drawing.Color.White;
            this.NoAccept.Location = new System.Drawing.Point(117, 488);
            this.NoAccept.Name = "NoAccept";
            this.NoAccept.Size = new System.Drawing.Size(148, 28);
            this.NoAccept.TabIndex = 50;
            this.NoAccept.TabStop = true;
            this.NoAccept.Text = "I do not agree";
            this.NoAccept.UseVisualStyleBackColor = true;
            this.NoAccept.CheckedChanged += new System.EventHandler(this.NoAccept_CheckedChanged);
            // 
            // Accept
            // 
            this.Accept.AutoSize = true;
            this.Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accept.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.ForeColor = System.Drawing.Color.White;
            this.Accept.Location = new System.Drawing.Point(117, 447);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(91, 28);
            this.Accept.TabIndex = 49;
            this.Accept.Text = "I agree";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.CheckedChanged += new System.EventHandler(this.Accept_CheckedChanged);
            // 
            // More1
            // 
            this.More1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.More1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.More1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More1.ForeColor = System.Drawing.Color.Yellow;
            this.More1.Location = new System.Drawing.Point(70, 25);
            this.More1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.More1.Name = "More1";
            this.More1.Size = new System.Drawing.Size(336, 38);
            this.More1.TabIndex = 48;
            this.More1.Text = "SHIELD License Agreement";
            this.More1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 390);
            this.label1.TabIndex = 53;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // BrowseDialog
            // 
            this.BrowseDialog.RootFolder = System.Environment.SpecialFolder.ProgramFiles;
            this.BrowseDialog.SelectedPath = "C:\\Program Files\\";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Support
            // 
            this.Support.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Support.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Support.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Support.ForeColor = System.Drawing.Color.Cyan;
            this.Support.Location = new System.Drawing.Point(363, 440);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(79, 34);
            this.Support.TabIndex = 54;
            this.Support.Text = "More";
            this.Support.UseVisualStyleBackColor = false;
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Install
            // 
            this.Install.BackColor = System.Drawing.Color.Red;
            this.Install.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Install.Enabled = false;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Install.Location = new System.Drawing.Point(22, 537);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(420, 39);
            this.Install.TabIndex = 52;
            this.Install.Text = "EXIT";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Pic2
            // 
            this.Pic2.BackgroundImage = global::E.B_Setup.Properties.Resources.error;
            this.Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic2.ErrorImage = null;
            this.Pic2.InitialImage = null;
            this.Pic2.Location = new System.Drawing.Point(22, 440);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(80, 80);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic2.TabIndex = 51;
            this.Pic2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(465, 601);
            this.Controls.Add(this.NoAccept);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.More1);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHIELD Setup";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton NoAccept;
        private System.Windows.Forms.RadioButton Accept;
        private System.Windows.Forms.Label More1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog BrowseDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Support;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.PictureBox Pic2;
    }
}

