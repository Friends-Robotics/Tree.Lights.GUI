﻿namespace Tree_Gui.View {
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
            pnlLevel = new Custom_Controls.CustomRectangle();
            lblStatusTitle = new Label();
            picLogo = new Custom_Controls.PicturePanel();
            lblTitle = new Label();
            customRectangle1 = new Custom_Controls.CustomRectangle();
            label1 = new Label();
            customRectangle2 = new Custom_Controls.CustomRectangle();
            label2 = new Label();
            lblInfo = new Label();
            pnlLevel.SuspendLayout();
            customRectangle1.SuspendLayout();
            customRectangle2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLevel
            // 
            pnlLevel.Anchor = AnchorStyles.None;
            pnlLevel.BackColor = Color.FromArgb(18, 17, 19);
            pnlLevel.BorderColor = Color.White;
            pnlLevel.BorderWidth = 0;
            pnlLevel.Controls.Add(lblStatusTitle);
            pnlLevel.CornerRadius = 20;
            pnlLevel.Location = new Point(596, 332);
            pnlLevel.Margin = new Padding(25);
            pnlLevel.Name = "pnlLevel";
            pnlLevel.Size = new Size(411, 100);
            pnlLevel.TabIndex = 1;
            pnlLevel.Text = "customRectangle1";
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Anchor = AnchorStyles.None;
            lblStatusTitle.AutoEllipsis = true;
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusTitle.ForeColor = Color.White;
            lblStatusTitle.Location = new Point(25, 33);
            lblStatusTitle.Margin = new Padding(25);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(150, 33);
            lblStatusTitle.TabIndex = 2;
            lblStatusTitle.Text = "Status : ";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = Resources.Images.Circuit_Christmas_Tree;
            picLogo.ImagePortion = new Rectangle(0, 0, 942, 1213);
            picLogo.Location = new Point(100, 259);
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
            // customRectangle1
            // 
            customRectangle1.Anchor = AnchorStyles.None;
            customRectangle1.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle1.BorderColor = Color.White;
            customRectangle1.BorderWidth = 0;
            customRectangle1.Controls.Add(label1);
            customRectangle1.CornerRadius = 20;
            customRectangle1.Location = new Point(596, 482);
            customRectangle1.Margin = new Padding(25);
            customRectangle1.Name = "customRectangle1";
            customRectangle1.Size = new Size(411, 100);
            customRectangle1.TabIndex = 1;
            customRectangle1.Text = "customRectangle1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 33);
            label1.Margin = new Padding(25);
            label1.Name = "label1";
            label1.Size = new Size(105, 33);
            label1.TabIndex = 2;
            label1.Text = "Path :";
            // 
            // customRectangle2
            // 
            customRectangle2.Anchor = AnchorStyles.None;
            customRectangle2.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle2.BorderColor = Color.White;
            customRectangle2.BorderWidth = 0;
            customRectangle2.Controls.Add(label2);
            customRectangle2.CornerRadius = 20;
            customRectangle2.Location = new Point(596, 632);
            customRectangle2.Margin = new Padding(25);
            customRectangle2.Name = "customRectangle2";
            customRectangle2.Size = new Size(411, 100);
            customRectangle2.TabIndex = 1;
            customRectangle2.Text = "customRectangle1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 33);
            label2.Margin = new Padding(25);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 2;
            label2.Text = "Active";
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
            Controls.Add(customRectangle2);
            Controls.Add(customRectangle1);
            Controls.Add(pnlLevel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formHome";
            Text = "formUserHome";
            Load += formHome_Load;
            pnlLevel.ResumeLayout(false);
            pnlLevel.PerformLayout();
            customRectangle1.ResumeLayout(false);
            customRectangle1.PerformLayout();
            customRectangle2.ResumeLayout(false);
            customRectangle2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.CustomRectangle pnlLevel;
        private Label lblStatusTitle;
        private Custom_Controls.PicturePanel picLogo;
        private Label lblTitle;
        private Custom_Controls.CustomRectangle customRectangle1;
        private Label label1;
        private Custom_Controls.CustomRectangle customRectangle2;
        private Label label2;
        private Label lblInfo;
    }
}