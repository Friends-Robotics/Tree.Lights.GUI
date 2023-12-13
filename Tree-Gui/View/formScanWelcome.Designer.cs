namespace Tree_Gui.View {
    partial class formScanWelcome {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScanWelcome));
            lblTitle = new Label();
            lblInfo = new Label();
            btnStartScan = new Custom_Controls.CustomButton();
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
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoEllipsis = true;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(34, 131);
            lblInfo.Margin = new Padding(25);
            lblInfo.MaximumSize = new Size(1075, 300);
            lblInfo.MinimumSize = new Size(0, 100);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(1065, 165);
            lblInfo.TabIndex = 6;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnStartScan
            // 
            btnStartScan.BackColor = Color.FromArgb(18, 17, 19);
            btnStartScan.BorderColor = Color.FromArgb(18, 17, 19);
            btnStartScan.BorderWidth = 4;
            btnStartScan.CornerRadius = 20;
            btnStartScan.FlatAppearance.BorderSize = 0;
            btnStartScan.FlatStyle = FlatStyle.Flat;
            btnStartScan.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartScan.ForeColor = Color.White;
            btnStartScan.Location = new Point(448, 437);
            btnStartScan.Name = "btnStartScan";
            btnStartScan.Size = new Size(248, 100);
            btnStartScan.TabIndex = 8;
            btnStartScan.Text = "Begin scan";
            btnStartScan.UseVisualStyleBackColor = false;
            // 
            // formScanWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(btnStartScan);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formScan";
            Text = "formUserHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Custom_Controls.CustomButton btnStartScan;
    }
}