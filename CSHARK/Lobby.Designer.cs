namespace CSHARK
{
    partial class Lobby
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            exit = new PictureBox();
            minimize = new PictureBox();
            TabController = new TabControl();
            network = new TabPage();
            connectionHint = new Label();
            connect = new PictureBox();
            networkingTitle = new Label();
            networkPanel = new Panel();
            connectionStatus = new PictureBox();
            pingTitle = new Label();
            ping = new Label();
            ipTitle = new Label();
            downloadTitle = new Label();
            dlSpeed = new Label();
            ipv4 = new Label();
            uploadTitle = new Label();
            ulSpeed = new Label();
            elapsedTime = new Label();
            serverListTitle = new Label();
            serverListPanel = new Panel();
            settings = new TabPage();
            settingsSpliter = new TabControl();
            networking = new TabPage();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            pingTiming = new NumericUpDown();
            pingTimingTitle = new Label();
            pingNumberPacket = new NumericUpDown();
            pingNumberPacketTitle = new Label();
            dataSpeedInterval = new NumericUpDown();
            label2 = new Label();
            personalize = new TabPage();
            themeTitle = new Label();
            themeChange = new PictureBox();
            info = new TabPage();
            websiteLink = new Label();
            website = new PictureBox();
            email = new Label();
            telegramLink = new Label();
            youtubeLink = new Label();
            githubLink = new Label();
            pictureBox2 = new PictureBox();
            telegram = new PictureBox();
            youtube = new PictureBox();
            github = new PictureBox();
            appLicense = new RichTextBox();
            pictureBox1 = new PictureBox();
            appName = new Label();
            companyName = new Label();
            resetTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            TabController.SuspendLayout();
            network.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connect).BeginInit();
            networkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectionStatus).BeginInit();
            settings.SuspendLayout();
            settingsSpliter.SuspendLayout();
            networking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pingTiming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pingNumberPacket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSpeedInterval).BeginInit();
            personalize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)themeChange).BeginInit();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)website).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)telegram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)youtube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackgroundImage = Properties.Resources.close;
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.Cursor = Cursors.Hand;
            exit.Location = new Point(476, 12);
            exit.Name = "exit";
            exit.Size = new Size(32, 32);
            exit.TabIndex = 0;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // minimize
            // 
            minimize.BackgroundImage = Properties.Resources.minimize;
            minimize.BackgroundImageLayout = ImageLayout.Zoom;
            minimize.Cursor = Cursors.Hand;
            minimize.Location = new Point(438, 12);
            minimize.Name = "minimize";
            minimize.Size = new Size(32, 32);
            minimize.TabIndex = 1;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // TabController
            // 
            TabController.Controls.Add(network);
            TabController.Controls.Add(settings);
            TabController.Controls.Add(info);
            TabController.Location = new Point(12, 82);
            TabController.Name = "TabController";
            TabController.SelectedIndex = 0;
            TabController.Size = new Size(496, 626);
            TabController.TabIndex = 3;
            // 
            // network
            // 
            network.BackColor = Color.FromArgb(224, 224, 224);
            network.Controls.Add(connectionHint);
            network.Controls.Add(connect);
            network.Controls.Add(networkingTitle);
            network.Controls.Add(networkPanel);
            network.Controls.Add(elapsedTime);
            network.Controls.Add(serverListTitle);
            network.Controls.Add(serverListPanel);
            network.Location = new Point(4, 29);
            network.Name = "network";
            network.Padding = new Padding(3);
            network.Size = new Size(488, 593);
            network.TabIndex = 0;
            network.Text = "Bypass";
            // 
            // connectionHint
            // 
            connectionHint.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            connectionHint.ForeColor = Color.FromArgb(64, 64, 64);
            connectionHint.Location = new Point(127, 493);
            connectionHint.Name = "connectionHint";
            connectionHint.Size = new Size(235, 25);
            connectionHint.TabIndex = 24;
            connectionHint.Text = "Click to connect";
            connectionHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connect
            // 
            connect.BackgroundImage = Properties.Resources.connect;
            connect.BackgroundImageLayout = ImageLayout.Center;
            connect.Cursor = Cursors.Hand;
            connect.Location = new Point(194, 390);
            connect.Name = "connect";
            connect.Size = new Size(100, 100);
            connect.TabIndex = 22;
            connect.TabStop = false;
            connect.Click += connect_Click;
            // 
            // networkingTitle
            // 
            networkingTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            networkingTitle.ForeColor = Color.FromArgb(64, 64, 64);
            networkingTitle.Location = new Point(247, 3);
            networkingTitle.Name = "networkingTitle";
            networkingTitle.Size = new Size(235, 25);
            networkingTitle.TabIndex = 2;
            networkingTitle.Text = "Network Tests";
            networkingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // networkPanel
            // 
            networkPanel.BackColor = Color.FromArgb(224, 224, 224);
            networkPanel.BorderStyle = BorderStyle.FixedSingle;
            networkPanel.Controls.Add(connectionStatus);
            networkPanel.Controls.Add(pingTitle);
            networkPanel.Controls.Add(ping);
            networkPanel.Controls.Add(ipTitle);
            networkPanel.Controls.Add(downloadTitle);
            networkPanel.Controls.Add(dlSpeed);
            networkPanel.Controls.Add(ipv4);
            networkPanel.Controls.Add(uploadTitle);
            networkPanel.Controls.Add(ulSpeed);
            networkPanel.Location = new Point(247, 31);
            networkPanel.Name = "networkPanel";
            networkPanel.Size = new Size(235, 291);
            networkPanel.TabIndex = 1;
            // 
            // connectionStatus
            // 
            connectionStatus.BackgroundImage = Properties.Resources.c01;
            connectionStatus.BackgroundImageLayout = ImageLayout.Zoom;
            connectionStatus.Location = new Point(84, 12);
            connectionStatus.Name = "connectionStatus";
            connectionStatus.Size = new Size(64, 64);
            connectionStatus.TabIndex = 25;
            connectionStatus.TabStop = false;
            // 
            // pingTitle
            // 
            pingTitle.BackColor = Color.Silver;
            pingTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            pingTitle.ForeColor = Color.Black;
            pingTitle.Location = new Point(3, 239);
            pingTitle.Name = "pingTitle";
            pingTitle.Size = new Size(227, 25);
            pingTitle.TabIndex = 16;
            pingTitle.Text = "Ping";
            pingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ping
            // 
            ping.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            ping.ForeColor = Color.FromArgb(0, 0, 64);
            ping.Location = new Point(3, 264);
            ping.Name = "ping";
            ping.Size = new Size(227, 25);
            ping.TabIndex = 15;
            ping.Text = "0 ms";
            ping.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ipTitle
            // 
            ipTitle.BackColor = Color.Silver;
            ipTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            ipTitle.ForeColor = Color.Black;
            ipTitle.Location = new Point(3, 89);
            ipTitle.Name = "ipTitle";
            ipTitle.Size = new Size(227, 25);
            ipTitle.TabIndex = 14;
            ipTitle.Text = "Internet Protocol";
            ipTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // downloadTitle
            // 
            downloadTitle.BackColor = Color.Silver;
            downloadTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            downloadTitle.ForeColor = Color.Black;
            downloadTitle.Location = new Point(3, 139);
            downloadTitle.Name = "downloadTitle";
            downloadTitle.Size = new Size(227, 25);
            downloadTitle.TabIndex = 10;
            downloadTitle.Text = "Download";
            downloadTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dlSpeed
            // 
            dlSpeed.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            dlSpeed.ForeColor = Color.FromArgb(0, 0, 64);
            dlSpeed.Location = new Point(3, 164);
            dlSpeed.Name = "dlSpeed";
            dlSpeed.Size = new Size(227, 25);
            dlSpeed.TabIndex = 9;
            dlSpeed.Text = "0 Mbps";
            dlSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ipv4
            // 
            ipv4.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            ipv4.ForeColor = Color.FromArgb(0, 0, 64);
            ipv4.Location = new Point(3, 114);
            ipv4.Name = "ipv4";
            ipv4.Size = new Size(227, 25);
            ipv4.TabIndex = 13;
            ipv4.Text = "0.0.0.0";
            ipv4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uploadTitle
            // 
            uploadTitle.BackColor = Color.Silver;
            uploadTitle.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            uploadTitle.ForeColor = Color.Black;
            uploadTitle.Location = new Point(3, 189);
            uploadTitle.Name = "uploadTitle";
            uploadTitle.Size = new Size(227, 25);
            uploadTitle.TabIndex = 12;
            uploadTitle.Text = "Upload";
            uploadTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ulSpeed
            // 
            ulSpeed.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold);
            ulSpeed.ForeColor = Color.FromArgb(0, 0, 64);
            ulSpeed.Location = new Point(3, 214);
            ulSpeed.Name = "ulSpeed";
            ulSpeed.Size = new Size(227, 25);
            ulSpeed.TabIndex = 11;
            ulSpeed.Text = "0 Mbps";
            ulSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // elapsedTime
            // 
            elapsedTime.Font = new Font("Ubuntu", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elapsedTime.ForeColor = Color.FromArgb(0, 0, 64);
            elapsedTime.Location = new Point(6, 531);
            elapsedTime.Name = "elapsedTime";
            elapsedTime.Size = new Size(476, 44);
            elapsedTime.TabIndex = 21;
            elapsedTime.Text = "00:00";
            elapsedTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serverListTitle
            // 
            serverListTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            serverListTitle.ForeColor = Color.FromArgb(64, 64, 64);
            serverListTitle.Location = new Point(6, 3);
            serverListTitle.Name = "serverListTitle";
            serverListTitle.Size = new Size(235, 25);
            serverListTitle.TabIndex = 1;
            serverListTitle.Text = "Server List";
            serverListTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serverListPanel
            // 
            serverListPanel.AutoScroll = true;
            serverListPanel.BackColor = Color.FromArgb(224, 224, 224);
            serverListPanel.BorderStyle = BorderStyle.FixedSingle;
            serverListPanel.Location = new Point(6, 31);
            serverListPanel.Name = "serverListPanel";
            serverListPanel.Size = new Size(235, 291);
            serverListPanel.TabIndex = 0;
            // 
            // settings
            // 
            settings.BackColor = Color.White;
            settings.Controls.Add(settingsSpliter);
            settings.Location = new Point(4, 29);
            settings.Name = "settings";
            settings.Padding = new Padding(3);
            settings.Size = new Size(488, 593);
            settings.TabIndex = 1;
            settings.Text = "Setting";
            // 
            // settingsSpliter
            // 
            settingsSpliter.Controls.Add(networking);
            settingsSpliter.Controls.Add(personalize);
            settingsSpliter.Dock = DockStyle.Fill;
            settingsSpliter.Location = new Point(3, 3);
            settingsSpliter.Name = "settingsSpliter";
            settingsSpliter.SelectedIndex = 0;
            settingsSpliter.Size = new Size(482, 587);
            settingsSpliter.TabIndex = 28;
            // 
            // networking
            // 
            networking.BackColor = Color.FromArgb(64, 64, 64);
            networking.Controls.Add(numericUpDown2);
            networking.Controls.Add(label3);
            networking.Controls.Add(pingTiming);
            networking.Controls.Add(pingTimingTitle);
            networking.Controls.Add(pingNumberPacket);
            networking.Controls.Add(pingNumberPacketTitle);
            networking.Controls.Add(dataSpeedInterval);
            networking.Controls.Add(label2);
            networking.Location = new Point(4, 29);
            networking.Name = "networking";
            networking.Padding = new Padding(3);
            networking.Size = new Size(474, 554);
            networking.TabIndex = 0;
            networking.Text = "Connection Setup";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(64, 64, 64);
            numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown2.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown2.ForeColor = Color.FromArgb(255, 255, 128);
            numericUpDown2.Location = new Point(363, 209);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(105, 30);
            numericUpDown2.TabIndex = 33;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.ThousandsSeparator = true;
            numericUpDown2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(6, 172);
            label3.Name = "label3";
            label3.Size = new Size(462, 67);
            label3.TabIndex = 34;
            label3.Text = "Attemp to Reconnect to the Server if the Ping was\r\nGreater than [Milisecond(s)]";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pingTiming
            // 
            pingTiming.BackColor = Color.FromArgb(64, 64, 64);
            pingTiming.BorderStyle = BorderStyle.FixedSingle;
            pingTiming.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pingTiming.ForeColor = Color.FromArgb(255, 255, 128);
            pingTiming.Location = new Point(403, 127);
            pingTiming.Name = "pingTiming";
            pingTiming.Size = new Size(65, 30);
            pingTiming.TabIndex = 31;
            pingTiming.TextAlign = HorizontalAlignment.Center;
            pingTiming.ThousandsSeparator = true;
            pingTiming.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // pingTimingTitle
            // 
            pingTimingTitle.BorderStyle = BorderStyle.FixedSingle;
            pingTimingTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            pingTimingTitle.ForeColor = Color.FromArgb(255, 255, 128);
            pingTimingTitle.Location = new Point(6, 127);
            pingTimingTitle.Name = "pingTimingTitle";
            pingTimingTitle.Size = new Size(391, 30);
            pingTimingTitle.TabIndex = 32;
            pingTimingTitle.Text = "Getting Ping every [Minute(s)]";
            pingTimingTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pingNumberPacket
            // 
            pingNumberPacket.BackColor = Color.FromArgb(64, 64, 64);
            pingNumberPacket.BorderStyle = BorderStyle.FixedSingle;
            pingNumberPacket.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pingNumberPacket.ForeColor = Color.FromArgb(255, 255, 128);
            pingNumberPacket.Location = new Point(403, 84);
            pingNumberPacket.Name = "pingNumberPacket";
            pingNumberPacket.Size = new Size(65, 30);
            pingNumberPacket.TabIndex = 29;
            pingNumberPacket.TextAlign = HorizontalAlignment.Center;
            pingNumberPacket.ThousandsSeparator = true;
            pingNumberPacket.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // pingNumberPacketTitle
            // 
            pingNumberPacketTitle.BorderStyle = BorderStyle.FixedSingle;
            pingNumberPacketTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            pingNumberPacketTitle.ForeColor = Color.FromArgb(255, 255, 128);
            pingNumberPacketTitle.Location = new Point(6, 84);
            pingNumberPacketTitle.Name = "pingNumberPacketTitle";
            pingNumberPacketTitle.Size = new Size(391, 30);
            pingNumberPacketTitle.TabIndex = 30;
            pingNumberPacketTitle.Text = "Number of Ping Packets per time [Max 10]";
            pingNumberPacketTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataSpeedInterval
            // 
            dataSpeedInterval.BackColor = Color.FromArgb(64, 64, 64);
            dataSpeedInterval.BorderStyle = BorderStyle.FixedSingle;
            dataSpeedInterval.Font = new Font("Ubuntu", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataSpeedInterval.ForeColor = Color.FromArgb(255, 255, 128);
            dataSpeedInterval.Location = new Point(403, 43);
            dataSpeedInterval.Name = "dataSpeedInterval";
            dataSpeedInterval.Size = new Size(65, 30);
            dataSpeedInterval.TabIndex = 0;
            dataSpeedInterval.TextAlign = HorizontalAlignment.Center;
            dataSpeedInterval.ThousandsSeparator = true;
            dataSpeedInterval.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(391, 30);
            label2.TabIndex = 28;
            label2.Text = "Check Data Speed every [Minute(s)]";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // personalize
            // 
            personalize.BackColor = Color.Silver;
            personalize.Controls.Add(themeTitle);
            personalize.Controls.Add(themeChange);
            personalize.Location = new Point(4, 29);
            personalize.Name = "personalize";
            personalize.Padding = new Padding(3);
            personalize.Size = new Size(474, 554);
            personalize.TabIndex = 1;
            personalize.Text = "Appearance";
            // 
            // themeTitle
            // 
            themeTitle.BorderStyle = BorderStyle.FixedSingle;
            themeTitle.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            themeTitle.ForeColor = Color.FromArgb(64, 64, 64);
            themeTitle.Location = new Point(6, 12);
            themeTitle.Name = "themeTitle";
            themeTitle.Size = new Size(462, 30);
            themeTitle.TabIndex = 27;
            themeTitle.Text = "Change Theme --- Light";
            themeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeChange
            // 
            themeChange.BackColor = Color.Silver;
            themeChange.BackgroundImage = Properties.Resources.lightmode;
            themeChange.BackgroundImageLayout = ImageLayout.Zoom;
            themeChange.Cursor = Cursors.Hand;
            themeChange.Location = new Point(187, 45);
            themeChange.Name = "themeChange";
            themeChange.Size = new Size(100, 100);
            themeChange.TabIndex = 26;
            themeChange.TabStop = false;
            themeChange.Click += themeChange_Click;
            // 
            // info
            // 
            info.BackColor = Color.Gray;
            info.Controls.Add(websiteLink);
            info.Controls.Add(website);
            info.Controls.Add(email);
            info.Controls.Add(telegramLink);
            info.Controls.Add(youtubeLink);
            info.Controls.Add(githubLink);
            info.Controls.Add(pictureBox2);
            info.Controls.Add(telegram);
            info.Controls.Add(youtube);
            info.Controls.Add(github);
            info.Controls.Add(appLicense);
            info.Location = new Point(4, 29);
            info.Name = "info";
            info.Padding = new Padding(3);
            info.Size = new Size(488, 593);
            info.TabIndex = 2;
            info.Text = "About";
            // 
            // websiteLink
            // 
            websiteLink.Cursor = Cursors.Hand;
            websiteLink.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            websiteLink.ForeColor = Color.White;
            websiteLink.Location = new Point(76, 14);
            websiteLink.Name = "websiteLink";
            websiteLink.Size = new Size(406, 64);
            websiteLink.TabIndex = 11;
            websiteLink.Text = "[Websitee] Link to C-SHARK";
            websiteLink.TextAlign = ContentAlignment.MiddleLeft;
            websiteLink.Click += websiteLink_Click;
            // 
            // website
            // 
            website.BackColor = Color.Gray;
            website.BackgroundImage = Properties.Resources.website;
            website.BackgroundImageLayout = ImageLayout.Zoom;
            website.Location = new Point(6, 14);
            website.Name = "website";
            website.Size = new Size(64, 64);
            website.TabIndex = 10;
            website.TabStop = false;
            // 
            // email
            // 
            email.Cursor = Cursors.Hand;
            email.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            email.ForeColor = Color.White;
            email.Location = new Point(76, 294);
            email.Name = "email";
            email.Size = new Size(406, 64);
            email.TabIndex = 9;
            email.Text = "[Support Email] b.daarr@outlook.com";
            email.TextAlign = ContentAlignment.MiddleLeft;
            email.Click += email_Click;
            // 
            // telegramLink
            // 
            telegramLink.Cursor = Cursors.Hand;
            telegramLink.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            telegramLink.ForeColor = Color.White;
            telegramLink.Location = new Point(76, 224);
            telegramLink.Name = "telegramLink";
            telegramLink.Size = new Size(406, 64);
            telegramLink.TabIndex = 8;
            telegramLink.Text = "[Developer ID] Link to Telegram";
            telegramLink.TextAlign = ContentAlignment.MiddleLeft;
            telegramLink.Click += telegramLink_Click;
            // 
            // youtubeLink
            // 
            youtubeLink.Cursor = Cursors.Hand;
            youtubeLink.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            youtubeLink.ForeColor = Color.White;
            youtubeLink.Location = new Point(76, 84);
            youtubeLink.Name = "youtubeLink";
            youtubeLink.Size = new Size(406, 64);
            youtubeLink.TabIndex = 7;
            youtubeLink.Text = "[App Videos] Link to YouTube";
            youtubeLink.TextAlign = ContentAlignment.MiddleLeft;
            youtubeLink.Click += youtubeLink_Click;
            // 
            // githubLink
            // 
            githubLink.Cursor = Cursors.Hand;
            githubLink.Font = new Font("Zain Black", 13.7999992F, FontStyle.Bold);
            githubLink.ForeColor = Color.White;
            githubLink.Location = new Point(76, 154);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(406, 64);
            githubLink.TabIndex = 6;
            githubLink.Text = "[Source Code] Link to GitHub";
            githubLink.TextAlign = ContentAlignment.MiddleLeft;
            githubLink.Click += githubLink_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BackgroundImage = Properties.Resources.email;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(6, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // telegram
            // 
            telegram.BackColor = Color.Gray;
            telegram.BackgroundImage = Properties.Resources.telegram;
            telegram.BackgroundImageLayout = ImageLayout.Zoom;
            telegram.Location = new Point(6, 224);
            telegram.Name = "telegram";
            telegram.Size = new Size(64, 64);
            telegram.TabIndex = 4;
            telegram.TabStop = false;
            // 
            // youtube
            // 
            youtube.BackColor = Color.Gray;
            youtube.BackgroundImage = Properties.Resources.youtube;
            youtube.BackgroundImageLayout = ImageLayout.Zoom;
            youtube.Location = new Point(6, 84);
            youtube.Name = "youtube";
            youtube.Size = new Size(64, 64);
            youtube.TabIndex = 3;
            youtube.TabStop = false;
            // 
            // github
            // 
            github.BackColor = Color.Gray;
            github.BackgroundImage = Properties.Resources.github;
            github.BackgroundImageLayout = ImageLayout.Zoom;
            github.Location = new Point(6, 154);
            github.Name = "github";
            github.Size = new Size(64, 64);
            github.TabIndex = 2;
            github.TabStop = false;
            // 
            // appLicense
            // 
            appLicense.BackColor = Color.Gray;
            appLicense.BorderStyle = BorderStyle.None;
            appLicense.Cursor = Cursors.Help;
            appLicense.ForeColor = Color.White;
            appLicense.Location = new Point(6, 364);
            appLicense.Name = "appLicense";
            appLicense.Size = new Size(476, 223);
            appLicense.TabIndex = 1;
            appLicense.Text = resources.GetString("appLicense.Text");
            appLicense.MouseDoubleClick += appLicense_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(214, 185, 115);
            pictureBox1.BackgroundImage = Properties.Resources._64_shark;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // appName
            // 
            appName.Font = new Font("Ubuntu", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.Black;
            appName.Location = new Point(82, 17);
            appName.Name = "appName";
            appName.Size = new Size(101, 30);
            appName.TabIndex = 4;
            appName.Text = "C-SHARK";
            appName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // companyName
            // 
            companyName.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyName.ForeColor = Color.Black;
            companyName.Location = new Point(82, 35);
            companyName.Name = "companyName";
            companyName.Size = new Size(222, 34);
            companyName.TabIndex = 5;
            companyName.Text = "Space Cyber Company";
            companyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resetTimer
            // 
            resetTimer.Tick += resetTimer_Tick;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(520, 720);
            Controls.Add(appName);
            Controls.Add(pictureBox1);
            Controls.Add(TabController);
            Controls.Add(minimize);
            Controls.Add(exit);
            Controls.Add(companyName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lobby";
            Load += Lobby_Load;
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            TabController.ResumeLayout(false);
            network.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)connect).EndInit();
            networkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)connectionStatus).EndInit();
            settings.ResumeLayout(false);
            settingsSpliter.ResumeLayout(false);
            networking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pingTiming).EndInit();
            ((System.ComponentModel.ISupportInitialize)pingNumberPacket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSpeedInterval).EndInit();
            personalize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)themeChange).EndInit();
            info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)website).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)telegram).EndInit();
            ((System.ComponentModel.ISupportInitialize)youtube).EndInit();
            ((System.ComponentModel.ISupportInitialize)github).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox exit;
        private PictureBox minimize;
        private TabControl TabController;
        private TabPage network;
        private TabPage settings;
        private PictureBox pictureBox1;
        private Label appName;
        private TabPage info;
        private Label companyName;
        private Panel serverListPanel;
        private Panel networkPanel;
        private Label serverListTitle;
        private Label networkingTitle;
        private Label ulSpeed;
        private Label dlSpeed;
        private Label pingTitle;
        private Label elapsedTime;
        private Label downloadTitle;
        private Label ipTitle;
        private Label ipv4;
        private Label uploadTitle;
        private Label ping;
        private PictureBox connect;
        private Label connectionHint;
        private PictureBox connectionStatus;
        private RichTextBox appLicense;
        private PictureBox github;
        private PictureBox pictureBox2;
        private PictureBox telegram;
        private PictureBox youtube;
        private Label youtubeLink;
        private Label githubLink;
        private Label telegramLink;
        private Label email;
        private System.Windows.Forms.Timer resetTimer;
        private PictureBox themeChange;
        private Label websiteLink;
        private PictureBox website;
        private Label themeTitle;
        private TabControl settingsSpliter;
        private TabPage networking;
        private TabPage personalize;
        private Label label2;
        private NumericUpDown dataSpeedInterval;
        private NumericUpDown pingNumberPacket;
        private Label pingNumberPacketTitle;
        private NumericUpDown pingTiming;
        private Label pingTimingTitle;
        private NumericUpDown numericUpDown2;
        private Label label3;
    }
}