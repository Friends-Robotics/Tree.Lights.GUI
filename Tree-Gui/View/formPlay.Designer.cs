namespace Tree_Gui.View {
    partial class formPlay {
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
            lblTitle = new Label();
            customRectangle2 = new Custom_Controls.CustomRectangle();
            label2 = new Label();
            lblInfo = new Label();
            customRectangle2.SuspendLayout();
            SuspendLayout();
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
            // customRectangle2
            // 
            customRectangle2.Anchor = AnchorStyles.None;
            customRectangle2.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle2.BorderColor = Color.White;
            customRectangle2.BorderWidth = 0;
            customRectangle2.Controls.Add(label2);
            customRectangle2.CornerRadius = 20;
            customRectangle2.Location = new Point(374, 308);
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
            // formPlay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(customRectangle2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPlay";
            Text = "formUserHome";
            customRectangle2.ResumeLayout(false);
            customRectangle2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Custom_Controls.CustomRectangle customRectangle2;
        private Label label2;
        private Label lblInfo;
    }
}