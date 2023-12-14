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
            lblInfo = new Label();
            btn = new Custom_Controls.CustomButton();
            pb = new Custom_Controls.CustomProgressBar();
            btnRemark = new Custom_Controls.PictureButton();
            btnRetake = new Custom_Controls.PictureButton();
            btnOk = new Custom_Controls.PictureButton();
            pnlButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbScanView).BeginInit();
            pnlScanViewBorder.SuspendLayout();
            pnlButtons.SuspendLayout();
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
            pbScanView.Click += pbScanView_Click;
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
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoEllipsis = true;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(683, 154);
            lblInfo.Margin = new Padding(25);
            lblInfo.MaximumSize = new Size(400, 500);
            lblInfo.MinimumSize = new Size(400, 500);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(400, 500);
            lblInfo.TabIndex = 10;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
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
            btn.Location = new Point(756, 681);
            btn.Name = "btn";
            btn.Size = new Size(248, 100);
            btn.TabIndex = 11;
            btn.Text = "Start Scan";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btnStartScan_Click;
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
            // btnRemark
            // 
            btnRemark.BackColor = Color.FromArgb(34, 39, 37);
            btnRemark.Image = (Image)resources.GetObject("btnRemark.Image");
            btnRemark.ImagePortion = new Rectangle(-100, -100, 712, 712);
            btnRemark.Location = new Point(120, 0);
            btnRemark.Margin = new Padding(10);
            btnRemark.Name = "btnRemark";
            btnRemark.Size = new Size(100, 100);
            btnRemark.TabIndex = 13;
            btnRemark.Click += btnRemark_Click;
            // 
            // btnRetake
            // 
            btnRetake.BackColor = Color.FromArgb(34, 39, 37);
            btnRetake.Image = Resources.Icons.camera_rotate;
            btnRetake.ImagePortion = new Rectangle(-100, -100, 712, 712);
            btnRetake.Location = new Point(0, 0);
            btnRetake.Margin = new Padding(10);
            btnRetake.Name = "btnRetake";
            btnRetake.Size = new Size(100, 100);
            btnRetake.TabIndex = 14;
            btnRetake.Click += btnRetake_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(34, 39, 37);
            btnOk.Image = Resources.Icons.check;
            btnOk.ImagePortion = new Rectangle(-100, -100, 712, 712);
            btnOk.Location = new Point(240, 0);
            btnOk.Margin = new Padding(10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 100);
            btnOk.TabIndex = 15;
            btnOk.Click += btnOk_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnRetake);
            pnlButtons.Controls.Add(btnOk);
            pnlButtons.Controls.Add(btnRemark);
            pnlButtons.Location = new Point(709, 664);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(340, 100);
            pnlButtons.TabIndex = 16;
            // 
            // formScan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(btn);
            Controls.Add(pnlButtons);
            Controls.Add(pb);
            Controls.Add(lblInfo);
            Controls.Add(pnlScanViewBorder);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formScan";
            Text = "formUserHome";
            ((System.ComponentModel.ISupportInitialize)pbScanView).EndInit();
            pnlScanViewBorder.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbScanView;
        private Custom_Controls.CustomRectangle pnlScanViewBorder;
        private Label lblInfo;
        private Custom_Controls.CustomButton btn;
        private Custom_Controls.CustomProgressBar pb;
        private Custom_Controls.PictureButton btnRemark;
        private Custom_Controls.PictureButton btnRetake;
        private Custom_Controls.PictureButton btnOk;
        private Panel pnlButtons;
    }
}