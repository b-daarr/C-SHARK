namespace E.B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Support = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.RadioButton();
            this.Dsc = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.S3 = new System.Windows.Forms.RadioButton();
            this.S1 = new System.Windows.Forms.RadioButton();
            this.S2 = new System.Windows.Forms.RadioButton();
            this.PicMain = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Support);
            this.panel1.Controls.Add(this.Off);
            this.panel1.Controls.Add(this.Dsc);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Controls.Add(this.S3);
            this.panel1.Controls.Add(this.S1);
            this.panel1.Controls.Add(this.S2);
            this.panel1.Controls.Add(this.PicMain);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 402);
            this.panel1.TabIndex = 10;
            // 
            // Support
            // 
            this.Support.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Support.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Support.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Support.ForeColor = System.Drawing.Color.Yellow;
            this.Support.Location = new System.Drawing.Point(326, 3);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(75, 31);
            this.Support.TabIndex = 11;
            this.Support.Text = "More";
            this.Support.UseVisualStyleBackColor = true;
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Off
            // 
            this.Off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Off.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Off.ForeColor = System.Drawing.Color.White;
            this.Off.Location = new System.Drawing.Point(263, 231);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(122, 39);
            this.Off.TabIndex = 11;
            this.Off.Text = "Turn Off";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.CheckedChanged += new System.EventHandler(this.Off_CheckedChanged);
            // 
            // Dsc
            // 
            this.Dsc.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dsc.ForeColor = System.Drawing.Color.Fuchsia;
            this.Dsc.Location = new System.Drawing.Point(21, 188);
            this.Dsc.Name = "Dsc";
            this.Dsc.Size = new System.Drawing.Size(364, 40);
            this.Dsc.TabIndex = 10;
            this.Dsc.Text = "Select a server for break embargos";
            this.Dsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Purple;
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("MingLiU-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.White;
            this.Connect.Location = new System.Drawing.Point(25, 347);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(360, 40);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connection Request";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // S3
            // 
            this.S3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S3.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S3.ForeColor = System.Drawing.Color.White;
            this.S3.Location = new System.Drawing.Point(25, 231);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(152, 39);
            this.S3.TabIndex = 4;
            this.S3.Text = "Ocean";
            this.S3.UseVisualStyleBackColor = true;
            this.S3.CheckedChanged += new System.EventHandler(this.S3_CheckedChanged);
            // 
            // S1
            // 
            this.S1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S1.ForeColor = System.Drawing.Color.White;
            this.S1.Location = new System.Drawing.Point(263, 288);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(122, 39);
            this.S1.TabIndex = 2;
            this.S1.Text = "Desert";
            this.S1.UseVisualStyleBackColor = true;
            this.S1.CheckedChanged += new System.EventHandler(this.S1_CheckedChanged);
            // 
            // S2
            // 
            this.S2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S2.ForeColor = System.Drawing.Color.White;
            this.S2.Location = new System.Drawing.Point(25, 288);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(162, 39);
            this.S2.TabIndex = 3;
            this.S2.Text = "Mount";
            this.S2.UseVisualStyleBackColor = true;
            this.S2.CheckedChanged += new System.EventHandler(this.S2_CheckedChanged);
            // 
            // PicMain
            // 
            this.PicMain.BackColor = System.Drawing.Color.Black;
            this.PicMain.BackgroundImage = global::E.B.Properties.Resources.Back;
            this.PicMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicMain.ErrorImage = null;
            this.PicMain.InitialImage = null;
            this.PicMain.Location = new System.Drawing.Point(-1, -1);
            this.PicMain.Name = "PicMain";
            this.PicMain.Size = new System.Drawing.Size(406, 186);
            this.PicMain.TabIndex = 9;
            this.PicMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(431, 425);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Embargo Breaker";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Off;
        private System.Windows.Forms.Label Dsc;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RadioButton S3;
        private System.Windows.Forms.RadioButton S1;
        private System.Windows.Forms.RadioButton S2;
        private System.Windows.Forms.Button Support;
        private System.Windows.Forms.PictureBox PicMain;
    }
}

