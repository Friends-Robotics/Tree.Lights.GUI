namespace Tree_Gui.View {
    partial class formMainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pnlMenuStrip = new Panel();
            miConfig = new Custom_Controls.MenuItem();
            miExit = new Custom_Controls.MenuItem();
            miAdmin = new Custom_Controls.MenuItem();
            miSettings = new Custom_Controls.MenuItem();
            miRanks = new Custom_Controls.MenuItem();
            miHome = new Custom_Controls.MenuItem();
            pnlMenuDivider = new Panel();
            miMenu = new Custom_Controls.MenuItem();
            pnlUserViewHolder = new Panel();
            sb = new Custom_Controls.CustomScrollBar();
            pnlMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuStrip
            // 
            pnlMenuStrip.BackColor = Color.FromArgb(18, 17, 19);
            pnlMenuStrip.Controls.Add(miConfig);
            pnlMenuStrip.Controls.Add(miExit);
            pnlMenuStrip.Controls.Add(miAdmin);
            pnlMenuStrip.Controls.Add(miSettings);
            pnlMenuStrip.Controls.Add(miRanks);
            pnlMenuStrip.Controls.Add(miHome);
            pnlMenuStrip.Controls.Add(pnlMenuDivider);
            pnlMenuStrip.Controls.Add(miMenu);
            pnlMenuStrip.Dock = DockStyle.Left;
            pnlMenuStrip.Location = new Point(0, 0);
            pnlMenuStrip.Name = "pnlMenuStrip";
            pnlMenuStrip.Size = new Size(200, 900);
            pnlMenuStrip.TabIndex = 0;
            // 
            // miConfig
            // 
            miConfig.BackColor = Color.FromArgb(18, 17, 19);
            miConfig.BaseColor = Color.FromArgb(18, 17, 19);
            miConfig.Dock = DockStyle.Top;
            miConfig.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miConfig.HoverColour = Color.FromArgb(107, 122, 110);
            miConfig.Image = Resources.Icons.settings_sliders;
            miConfig.ImagePadding = 20;
            miConfig.Location = new Point(0, 407);
            miConfig.MenuText = "Config";
            miConfig.Name = "miConfig";
            miConfig.Size = new Size(200, 80);
            miConfig.TabIndex = 10;
            // 
            // miExit
            // 
            miExit.BackColor = Color.FromArgb(18, 17, 19);
            miExit.BaseColor = Color.FromArgb(18, 17, 19);
            miExit.Dock = DockStyle.Bottom;
            miExit.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miExit.HoverColour = Color.FromArgb(107, 122, 110);
            miExit.Image = Resources.Icons.circle_xmark;
            miExit.ImagePadding = 20;
            miExit.Location = new Point(0, 820);
            miExit.MenuText = "Exit";
            miExit.Name = "miExit";
            miExit.Size = new Size(200, 80);
            miExit.TabIndex = 8;
            miExit.MenuClick += miSignOut_MenuClick;
            // 
            // miAdmin
            // 
            miAdmin.BackColor = Color.FromArgb(18, 17, 19);
            miAdmin.BaseColor = Color.FromArgb(18, 17, 19);
            miAdmin.Dock = DockStyle.Top;
            miAdmin.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miAdmin.HoverColour = Color.FromArgb(107, 122, 110);
            miAdmin.Image = Resources.Icons.tree_christmas;
            miAdmin.ImagePadding = 20;
            miAdmin.Location = new Point(0, 327);
            miAdmin.MenuText = "Tree";
            miAdmin.Name = "miAdmin";
            miAdmin.Size = new Size(200, 80);
            miAdmin.TabIndex = 7;
            miAdmin.MenuClick += miAdmin_MenuClick;
            // 
            // miSettings
            // 
            miSettings.BackColor = Color.FromArgb(18, 17, 19);
            miSettings.BaseColor = Color.FromArgb(18, 17, 19);
            miSettings.Dock = DockStyle.Top;
            miSettings.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miSettings.HoverColour = Color.FromArgb(107, 122, 110);
            miSettings.Image = Resources.Icons.camera;
            miSettings.ImagePadding = 20;
            miSettings.Location = new Point(0, 247);
            miSettings.MenuText = "Scan";
            miSettings.Name = "miSettings";
            miSettings.Size = new Size(200, 80);
            miSettings.TabIndex = 6;
            miSettings.MenuClick += miSettings_MenuClick;
            // 
            // miRanks
            // 
            miRanks.BackColor = Color.FromArgb(18, 17, 19);
            miRanks.BaseColor = Color.FromArgb(18, 17, 19);
            miRanks.Dock = DockStyle.Top;
            miRanks.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miRanks.HoverColour = Color.FromArgb(107, 122, 110);
            miRanks.Image = Resources.Icons.animated_icon;
            miRanks.ImagePadding = 20;
            miRanks.Location = new Point(0, 167);
            miRanks.MenuText = "Play";
            miRanks.Name = "miRanks";
            miRanks.Size = new Size(200, 80);
            miRanks.TabIndex = 9;
            miRanks.MenuClick += miRanks_Click;
            // 
            // miHome
            // 
            miHome.BackColor = Color.FromArgb(18, 17, 19);
            miHome.BaseColor = Color.FromArgb(18, 17, 19);
            miHome.Dock = DockStyle.Top;
            miHome.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miHome.HoverColour = Color.FromArgb(107, 122, 110);
            miHome.Image = Resources.Icons.house_tree;
            miHome.ImagePadding = 20;
            miHome.Location = new Point(0, 87);
            miHome.MenuText = "Home";
            miHome.Name = "miHome";
            miHome.Size = new Size(200, 80);
            miHome.TabIndex = 3;
            miHome.MenuClick += miHome_MenuClick;
            // 
            // pnlMenuDivider
            // 
            pnlMenuDivider.BackColor = Color.FromArgb(137, 152, 120);
            pnlMenuDivider.Dock = DockStyle.Top;
            pnlMenuDivider.Location = new Point(0, 80);
            pnlMenuDivider.Name = "pnlMenuDivider";
            pnlMenuDivider.Size = new Size(200, 7);
            pnlMenuDivider.TabIndex = 2;
            // 
            // miMenu
            // 
            miMenu.BackColor = Color.FromArgb(18, 17, 19);
            miMenu.BaseColor = Color.FromArgb(18, 17, 19);
            miMenu.Dock = DockStyle.Top;
            miMenu.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            miMenu.HoverColour = Color.FromArgb(107, 122, 110);
            miMenu.Image = Resources.Icons.menu_dots_vertical;
            miMenu.ImagePadding = 20;
            miMenu.Location = new Point(0, 0);
            miMenu.MenuText = "Menu";
            miMenu.Name = "miMenu";
            miMenu.Size = new Size(200, 80);
            miMenu.TabIndex = 1;
            miMenu.MenuClick += Menu_Click;
            // 
            // pnlUserViewHolder
            // 
            pnlUserViewHolder.BackColor = Color.FromArgb(34, 39, 37);
            pnlUserViewHolder.Dock = DockStyle.Fill;
            pnlUserViewHolder.Location = new Point(200, 0);
            pnlUserViewHolder.Margin = new Padding(3, 4, 3, 4);
            pnlUserViewHolder.Name = "pnlUserViewHolder";
            pnlUserViewHolder.Size = new Size(975, 900);
            pnlUserViewHolder.TabIndex = 1;
            // 
            // sb
            // 
            sb.BackColor = Color.FromArgb(18, 17, 19);
            sb.BorderColor = Color.Black;
            sb.BorderWidth = 0;
            sb.ChannelColor = Color.FromArgb(18, 17, 19);
            sb.ChannelPadding = new Padding(5);
            sb.Dock = DockStyle.Right;
            sb.Location = new Point(1175, 0);
            sb.Maximum = 100;
            sb.Minimum = 0;
            sb.MouseWheelSensitivity = 1;
            sb.Name = "sb";
            sb.Size = new Size(25, 900);
            sb.TabIndex = 0;
            sb.Text = "customScrollBar1";
            sb.ThumbColor = Color.White;
            sb.ThumbSize = new Size(15, 80);
            sb.Value = 0;
            sb.ValueChanged += sb_ValueChanged;
            // 
            // formMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(1200, 900);
            Controls.Add(pnlUserViewHolder);
            Controls.Add(sb);
            Controls.Add(pnlMenuStrip);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formMainMenu";
            Text = "HomeView";
            pnlMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuStrip;
        private Panel pnlUserViewHolder;
        private Custom_Controls.MenuItem miMenu;
        private Custom_Controls.MenuItem miAdmin;
        private Custom_Controls.MenuItem miSettings;
        private Custom_Controls.MenuItem miHome;
        private Panel pnlMenuDivider;
        private Custom_Controls.MenuItem miExit;
        private Custom_Controls.MenuItem miRanks;
        private Custom_Controls.CustomScrollBar sb;
        private Custom_Controls.MenuItem miConfig;
    }
}