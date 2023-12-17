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
            pnlScanViewBorder = new Custom_Controls.CustomRectangle();
            pbScanView = new Custom_Controls.PicturePanel();
            lblInfo = new Label();
            btnStartScan = new Custom_Controls.CustomButton();
            pb = new Custom_Controls.CustomProgressBar();
            btnOk = new Custom_Controls.CustomButton();
            pnlButtons = new Panel();
            btnRetake = new Custom_Controls.CustomButton();
            btnScanTree = new Custom_Controls.CustomButton();
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
            // pbScanView
            // 
            pbScanView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbScanView.Enabled = false;
            pbScanView.Image = null;
            pbScanView.ImagePortion = null;
            pbScanView.Location = new Point(10, 10);
            pbScanView.Name = "pbScanView";
            pbScanView.Size = new Size(600, 600);
            pbScanView.TabIndex = 0;
            pbScanView.Text = "picturePanel1";
            pbScanView.Click += pbScanView_Click;
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
            // btnStartScan
            // 
            btnStartScan.Anchor = AnchorStyles.None;
            btnStartScan.BackColor = Color.FromArgb(18, 17, 19);
            btnStartScan.BorderColor = Color.FromArgb(18, 17, 19);
            btnStartScan.BorderWidth = 4;
            btnStartScan.CornerRadius = 20;
            btnStartScan.FlatAppearance.BorderSize = 0;
            btnStartScan.FlatStyle = FlatStyle.Flat;
            btnStartScan.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartScan.ForeColor = Color.White;
            btnStartScan.Image = null;
            btnStartScan.ImageSize = new Size(0, 0);
            btnStartScan.Location = new Point(757, 664);
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
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(18, 17, 19);
            btnOk.BorderColor = Color.FromArgb(18, 17, 19);
            btnOk.BorderWidth = 4;
            btnOk.CornerRadius = 20;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Image = Resources.Icons.check;
            btnOk.ImageSize = new Size(50, 50);
            btnOk.Location = new Point(0, 0);
            btnOk.Margin = new Padding(25);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 100);
            btnOk.TabIndex = 11;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.Anchor = AnchorStyles.None;
            pnlButtons.Controls.Add(btnRetake);
            pnlButtons.Controls.Add(btnOk);
            pnlButtons.Location = new Point(770, 664);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(220, 100);
            pnlButtons.TabIndex = 13;
            pnlButtons.Visible = false;
            // 
            // btnRetake
            // 
            btnRetake.BackColor = Color.FromArgb(18, 17, 19);
            btnRetake.BorderColor = Color.FromArgb(18, 17, 19);
            btnRetake.BorderWidth = 4;
            btnRetake.CornerRadius = 20;
            btnRetake.FlatAppearance.BorderSize = 0;
            btnRetake.FlatStyle = FlatStyle.Flat;
            btnRetake.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetake.ForeColor = Color.White;
            btnRetake.Image = Resources.Icons.camera_rotate;
            btnRetake.ImageSize = new Size(50, 50);
            btnRetake.Location = new Point(115, 0);
            btnRetake.Margin = new Padding(25);
            btnRetake.Name = "btnRetake";
            btnRetake.Size = new Size(100, 100);
            btnRetake.TabIndex = 11;
            btnRetake.UseVisualStyleBackColor = false;
            btnRetake.Click += btnRetake_Click;
            // 
            // btnScanTree
            // 
            btnScanTree.Anchor = AnchorStyles.None;
            btnScanTree.BackColor = Color.FromArgb(18, 17, 19);
            btnScanTree.BorderColor = Color.FromArgb(18, 17, 19);
            btnScanTree.BorderWidth = 4;
            btnScanTree.CornerRadius = 20;
            btnScanTree.FlatAppearance.BorderSize = 0;
            btnScanTree.FlatStyle = FlatStyle.Flat;
            btnScanTree.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnScanTree.ForeColor = Color.White;
            btnScanTree.Image = null;
            btnScanTree.ImageSize = new Size(0, 0);
            btnScanTree.Location = new Point(757, 664);
            btnScanTree.Name = "btnScanTree";
            btnScanTree.Size = new Size(248, 100);
            btnScanTree.TabIndex = 11;
            btnScanTree.Text = "Scan Tree";
            btnScanTree.UseVisualStyleBackColor = false;
            btnScanTree.Visible = false;
            btnScanTree.Click += btnScanTree_Click;
            // 
            // formScan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
            Controls.Add(pb);
            Controls.Add(lblInfo);
            Controls.Add(pnlScanViewBorder);
            Controls.Add(lblTitle);
            Controls.Add(btnStartScan);
            Controls.Add(pnlButtons);
            Controls.Add(btnScanTree);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formScan";
            Text = "formUserHome";
            pnlScanViewBorder.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Custom_Controls.CustomRectangle pnlScanViewBorder;
        private Label lblInfo;
        private Custom_Controls.CustomButton btnStartScan;
        private Custom_Controls.CustomProgressBar pb;
        private Custom_Controls.PicturePanel pbScanView;
        private Custom_Controls.CustomButton btnOk;
        private Panel pnlButtons;
        private Custom_Controls.CustomButton btnRetake;
        private Custom_Controls.CustomButton btnScanTree;
    }
}