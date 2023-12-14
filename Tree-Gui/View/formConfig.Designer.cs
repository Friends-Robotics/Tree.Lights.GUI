namespace Tree_Gui.View {
    partial class formConfig {
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
            tbIp = new Custom_Controls.CustomTextbox();
            lblStatusTitle = new Label();
            lblTitle = new Label();
            customRectangle1 = new Custom_Controls.CustomRectangle();
            tbPort = new Custom_Controls.CustomTextbox();
            label1 = new Label();
            customRectangle2 = new Custom_Controls.CustomRectangle();
            picTestingCheckbox = new Custom_Controls.PicturePanel();
            label2 = new Label();
            lblInfo = new Label();
            btn = new Custom_Controls.CustomButton();
            pnlLevel.SuspendLayout();
            customRectangle1.SuspendLayout();
            customRectangle2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLevel
            // 
            pnlLevel.BackColor = Color.FromArgb(18, 17, 19);
            pnlLevel.BorderColor = Color.White;
            pnlLevel.BorderWidth = 0;
            pnlLevel.Controls.Add(tbIp);
            pnlLevel.Controls.Add(lblStatusTitle);
            pnlLevel.CornerRadius = 20;
            pnlLevel.Location = new Point(29, 327);
            pnlLevel.Margin = new Padding(25);
            pnlLevel.Name = "pnlLevel";
            pnlLevel.Size = new Size(728, 100);
            pnlLevel.TabIndex = 1;
            pnlLevel.Text = "customRectangle1";
            // 
            // tbIp
            // 
            tbIp.BackColor = Color.FromArgb(18, 17, 19);
            tbIp.BorderColor = Color.White;
            tbIp.BorderFocusColor = Color.White;
            tbIp.BorderSize = 4;
            tbIp.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbIp.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbIp.ForeColor = Color.White;
            tbIp.IsMultiline = false;
            tbIp.Location = new Point(230, 26);
            tbIp.Margin = new Padding(25);
            tbIp.Name = "tbIp";
            tbIp.Padding = new Padding(7);
            tbIp.PlaceholderText = "";
            tbIp.PlaceholderTextColor = Color.White;
            tbIp.ShortcutEnabled = true;
            tbIp.Size = new Size(473, 49);
            tbIp.TabIndex = 3;
            tbIp.UsePasswordChar = false;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Anchor = AnchorStyles.Left;
            lblStatusTitle.AutoEllipsis = true;
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusTitle.ForeColor = Color.White;
            lblStatusTitle.Location = new Point(25, 33);
            lblStatusTitle.Margin = new Padding(25);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(195, 33);
            lblStatusTitle.TabIndex = 2;
            lblStatusTitle.Text = "IP Address :";
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(341, 49);
            lblTitle.Margin = new Padding(25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(416, 47);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Tree Configuration";
            // 
            // customRectangle1
            // 
            customRectangle1.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle1.BorderColor = Color.White;
            customRectangle1.BorderWidth = 0;
            customRectangle1.Controls.Add(tbPort);
            customRectangle1.Controls.Add(label1);
            customRectangle1.CornerRadius = 20;
            customRectangle1.Location = new Point(29, 477);
            customRectangle1.Margin = new Padding(25);
            customRectangle1.Name = "customRectangle1";
            customRectangle1.Size = new Size(728, 100);
            customRectangle1.TabIndex = 1;
            customRectangle1.Text = "customRectangle1";
            // 
            // tbPort
            // 
            tbPort.BackColor = Color.FromArgb(18, 17, 19);
            tbPort.BorderColor = Color.White;
            tbPort.BorderFocusColor = Color.White;
            tbPort.BorderSize = 4;
            tbPort.CustomBorderStyle = Custom_Controls.CustomTextbox.CustomTextboxBorderStyle.Underlined;
            tbPort.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPort.ForeColor = Color.White;
            tbPort.IsMultiline = false;
            tbPort.Location = new Point(165, 25);
            tbPort.Margin = new Padding(25);
            tbPort.Name = "tbPort";
            tbPort.Padding = new Padding(7);
            tbPort.PlaceholderText = "";
            tbPort.PlaceholderTextColor = Color.White;
            tbPort.ShortcutEnabled = true;
            tbPort.Size = new Size(538, 49);
            tbPort.TabIndex = 4;
            tbPort.UsePasswordChar = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 33);
            label1.Margin = new Padding(25);
            label1.Name = "label1";
            label1.Size = new Size(105, 33);
            label1.TabIndex = 2;
            label1.Text = "Port :";
            // 
            // customRectangle2
            // 
            customRectangle2.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle2.BorderColor = Color.White;
            customRectangle2.BorderWidth = 0;
            customRectangle2.Controls.Add(picTestingCheckbox);
            customRectangle2.Controls.Add(label2);
            customRectangle2.CornerRadius = 20;
            customRectangle2.Location = new Point(29, 627);
            customRectangle2.Margin = new Padding(25);
            customRectangle2.Name = "customRectangle2";
            customRectangle2.Size = new Size(277, 100);
            customRectangle2.TabIndex = 1;
            customRectangle2.Text = "customRectangle1";
            // 
            // picTestingCheckbox
            // 
            picTestingCheckbox.Image = Resources.Icons.dot_circle__1_;
            picTestingCheckbox.ImagePortion = new Rectangle(0, 0, 512, 512);
            picTestingCheckbox.Location = new Point(198, 32);
            picTestingCheckbox.Name = "picTestingCheckbox";
            picTestingCheckbox.Size = new Size(40, 40);
            picTestingCheckbox.TabIndex = 8;
            picTestingCheckbox.Click += picTestingCheckbox_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 33);
            label2.Margin = new Padding(25);
            label2.Name = "label2";
            label2.Size = new Size(150, 33);
            label2.TabIndex = 2;
            label2.Text = "Testing :";
            // 
            // lblInfo
            // 
            lblInfo.AutoEllipsis = true;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(34, 146);
            lblInfo.Margin = new Padding(25);
            lblInfo.MaximumSize = new Size(1075, 100);
            lblInfo.MinimumSize = new Size(0, 100);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(1035, 100);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Setup the following parameters then click connect to setup the tree connection";
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(18, 17, 19);
            btn.BorderColor = Color.FromArgb(18, 17, 19);
            btn.BorderWidth = 4;
            btn.CornerRadius = 20;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = new Point(509, 627);
            btn.Name = "btn";
            btn.Size = new Size(248, 100);
            btn.TabIndex = 7;
            btn.Text = "Connect";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // formConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(btn);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(customRectangle2);
            Controls.Add(customRectangle1);
            Controls.Add(pnlLevel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formConfig";
            Text = "formUserHome";
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
        private Label lblTitle;
        private Custom_Controls.CustomRectangle customRectangle1;
        private Label label1;
        private Custom_Controls.CustomRectangle customRectangle2;
        private Label label2;
        private Label lblInfo;
        private Custom_Controls.CustomTextbox tbIp;
        private Custom_Controls.CustomTextbox tbPort;
        private Custom_Controls.CustomButton btn;
        private Custom_Controls.PicturePanel picTestingCheckbox;
    }
}