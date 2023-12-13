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
            lblTitle = new Label();
            pbScanView = new PictureBox();
            pnlScanViewBorder = new Custom_Controls.CustomRectangle();
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
            lblTitle.Location = new Point(408, 34);
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
            pnlScanViewBorder.Location = new Point(34, 120);
            pnlScanViewBorder.Margin = new Padding(25);
            pnlScanViewBorder.Name = "pnlScanViewBorder";
            pnlScanViewBorder.Size = new Size(620, 620);
            pnlScanViewBorder.TabIndex = 5;
            pnlScanViewBorder.Text = "customRectangle1";
            // 
            // formScan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1125, 900);
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
    }
}