namespace Tree_Gui.View {
    partial class formHome {
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
            pnlStatus = new Custom_Controls.CustomRectangle();
            lblStatus = new Label();
            picLogo = new Custom_Controls.PicturePanel();
            lblTitle = new Label();
            pnlPath = new Custom_Controls.CustomRectangle();
            lblPath = new Label();
            pnlActive = new Custom_Controls.CustomRectangle();
            lblActive = new Label();
            lblInfo = new Label();
            pnlStatus.SuspendLayout();
            pnlPath.SuspendLayout();
            pnlActive.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStatus
            // 
            pnlStatus.Anchor = AnchorStyles.None;
            pnlStatus.BackColor = Color.FromArgb(18, 17, 19);
            pnlStatus.BorderColor = Color.White;
            pnlStatus.BorderWidth = 0;
            pnlStatus.Controls.Add(lblStatus);
            pnlStatus.CornerRadius = 20;
            pnlStatus.Location = new Point(530, 332);
            pnlStatus.Margin = new Padding(25);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(574, 100);
            pnlStatus.TabIndex = 1;
            pnlStatus.Text = "customRectangle1";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoEllipsis = true;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(16, 33);
            lblStatus.Margin = new Padding(25);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(150, 33);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status : ";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = Resources.Images.Circuit_Christmas_Tree;
            picLogo.ImagePortion = new Rectangle(0, 0, 942, 1213);
            picLogo.Location = new Point(34, 259);
            picLogo.Margin = new Padding(25, 25, 0, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(471, 607);
            picLogo.TabIndex = 5;
            picLogo.Text = "picturePanel1";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(408, 34);
            lblTitle.Margin = new Padding(25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 47);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Tree Lights";
            // 
            // pnlPath
            // 
            pnlPath.Anchor = AnchorStyles.None;
            pnlPath.BackColor = Color.FromArgb(18, 17, 19);
            pnlPath.BorderColor = Color.White;
            pnlPath.BorderWidth = 0;
            pnlPath.Controls.Add(lblPath);
            pnlPath.CornerRadius = 20;
            pnlPath.Location = new Point(530, 482);
            pnlPath.Margin = new Padding(25);
            pnlPath.Name = "pnlPath";
            pnlPath.Size = new Size(574, 100);
            pnlPath.TabIndex = 1;
            pnlPath.Text = "customRectangle1";
            // 
            // lblPath
            // 
            lblPath.Anchor = AnchorStyles.None;
            lblPath.AutoEllipsis = true;
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPath.ForeColor = Color.White;
            lblPath.Location = new Point(16, 33);
            lblPath.Margin = new Padding(25);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(105, 33);
            lblPath.TabIndex = 2;
            lblPath.Text = "Path :";
            // 
            // pnlActive
            // 
            pnlActive.Anchor = AnchorStyles.None;
            pnlActive.BackColor = Color.FromArgb(18, 17, 19);
            pnlActive.BorderColor = Color.White;
            pnlActive.BorderWidth = 0;
            pnlActive.Controls.Add(lblActive);
            pnlActive.CornerRadius = 20;
            pnlActive.Location = new Point(530, 632);
            pnlActive.Margin = new Padding(25);
            pnlActive.Name = "pnlActive";
            pnlActive.Size = new Size(574, 100);
            pnlActive.TabIndex = 1;
            pnlActive.Text = "customRectangle1";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.None;
            lblActive.AutoEllipsis = true;
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblActive.ForeColor = Color.White;
            lblActive.Location = new Point(16, 33);
            lblActive.Margin = new Padding(25);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(135, 33);
            lblActive.TabIndex = 2;
            lblActive.Text = "Active :";
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoEllipsis = true;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(34, 131);
            lblInfo.Margin = new Padding(25);
            lblInfo.MaximumSize = new Size(1075, 100);
            lblInfo.MinimumSize = new Size(0, 100);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(1035, 100);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Welcome! This application is designed to make it easier to interact with the tree. To setup a connection go to the config menu\r\n\r\n";
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            Controls.Add(pnlActive);
            Controls.Add(pnlPath);
            Controls.Add(pnlStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formHome";
            Text = "formUserHome";
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            pnlPath.ResumeLayout(false);
            pnlPath.PerformLayout();
            pnlActive.ResumeLayout(false);
            pnlActive.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.CustomRectangle pnlStatus;
        private Label lblStatus;
        private Custom_Controls.PicturePanel picLogo;
        private Label lblTitle;
        private Custom_Controls.CustomRectangle pnlPath;
        private Label lblPath;
        private Custom_Controls.CustomRectangle pnlActive;
        private Label lblActive;
        private Label lblInfo;
    }
}