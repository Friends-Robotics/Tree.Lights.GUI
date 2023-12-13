namespace Tree_Gui.View {
    partial class formScan {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScan));
            lblTitle = new Label();
            pbScanView = new PictureBox();
            pnlScanViewBorder = new Custom_Controls.CustomRectangle();
            buttonRefreshOk1 = new Custom_Controls.ButtonRefreshOk();
            lblInfo = new Label();
            btnStartScan = new Custom_Controls.CustomButton();
            pb = new Custom_Controls.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)pbScanView).BeginInit();
            pnlScanViewBorder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoEllipsis = true;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(408, 58);
            lblTitle.Margin = new Padding(25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 47);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Tree Lights";
            // 
            // pbScanView
            // 
            pbScanView.Location = new Point(10, 10);
            pbScanView.Name = "pbScanView";
            pbScanView.Size = new Size(600, 600);
            pbScanView.SizeMode = PictureBoxSizeMode.StretchImage;
            pbScanView.TabIndex = 4;
            pbScanView.TabStop = false;
            // 
            // pnlScanViewBorder
            // 
            pnlScanViewBorder.Anchor = AnchorStyles.None;
            pnlScanViewBorder.BackColor = Color.FromArgb(18, 17, 19);
            pnlScanViewBorder.BorderColor = Color.White;
            pnlScanViewBorder.BorderWidth = 0;
            pnlScanViewBorder.Controls.Add(pbScanView);
            pnlScanViewBorder.CornerRadius = 20;
            pnlScanViewBorder.Location = new Point(34, 144);
            pnlScanViewBorder.Margin = new Padding(25);
            pnlScanViewBorder.Name = "pnlScanViewBorder";
            pnlScanViewBorder.Size = new Size(620, 620);
            pnlScanViewBorder.TabIndex = 5;
            pnlScanViewBorder.Text = "customRectangle1";
            // 
            // buttonRefreshOk1
            // 
            buttonRefreshOk1.BackColor = Color.Transparent;
            buttonRefreshOk1.Location = new Point(775, 682);
            buttonRefreshOk1.Name = "buttonRefreshOk1";
            buttonRefreshOk1.Size = new Size(220, 100);
            buttonRefreshOk1.TabIndex = 9;
            buttonRefreshOk1.Visible = false;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoEllipsis = true;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(672, 154);
            lblInfo.Margin = new Padding(25);
            lblInfo.MaximumSize = new Size(400, 500);
            lblInfo.MinimumSize = new Size(400, 500);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(400, 500);
            lblInfo.TabIndex = 10;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
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
            btnStartScan.Location = new Point(765, 682);
            btnStartScan.Name = "btnStartScan";
            btnStartScan.Size = new Size(248, 100);
            btnStartScan.TabIndex = 11;
            btnStartScan.Text = "Start Scan";
            btnStartScan.UseVisualStyleBackColor = false;
            btnStartScan.Click += btnStartScan_Click;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Angle = 0;
            pb.BackingColor = Color.FromArgb(18, 17, 19);
            pb.EndColor = Color.FromArgb(228, 230, 195);
            pb.Location = new Point(44, 792);
            pb.Name = "pb";
            pb.Progress = 0F;
            pb.Size = new Size(600, 50);
            pb.StartColor = Color.FromArgb(137, 152, 120);
            pb.TabIndex = 12;
            pb.Text = "customProgressBar1";
            pb.Visible = false;
            // 
            // formScan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(pb);
            Controls.Add(btnStartScan);
            Controls.Add(lblInfo);
            Controls.Add(buttonRefreshOk1);
            Controls.Add(pnlScanViewBorder);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formScan";
            Text = "formUserHome";
            ((System.ComponentModel.ISupportInitialize)pbScanView).EndInit();
            pnlScanViewBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private PictureBox pbScanView;
        private Custom_Controls.CustomRectangle pnlScanViewBorder;
        private Custom_Controls.ButtonRefreshOk buttonRefreshOk1;
        private Label lblInfo;
        private Custom_Controls.CustomButton btnStartScan;
        private Custom_Controls.CustomProgressBar pb;
    }
}