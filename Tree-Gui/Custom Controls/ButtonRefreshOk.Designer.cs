namespace Tree_Gui.Custom_Controls {
    partial class ButtonRefreshOk {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pnlStatus = new CustomRectangle();
            picturePanel1 = new PicturePanel();
            picturePanel2 = new PicturePanel();
            customRectangle1 = new CustomRectangle();
            pnlStatus.SuspendLayout();
            customRectangle1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStatus
            // 
            pnlStatus.Anchor = AnchorStyles.Left;
            pnlStatus.BackColor = Color.FromArgb(18, 17, 19);
            pnlStatus.BorderColor = Color.White;
            pnlStatus.BorderWidth = 0;
            pnlStatus.Controls.Add(picturePanel1);
            pnlStatus.CornerRadius = 20;
            pnlStatus.Location = new Point(0, 0);
            pnlStatus.Margin = new Padding(25);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(100, 100);
            pnlStatus.TabIndex = 2;
            pnlStatus.Text = "customRectangle1";
            pnlStatus.Click += pnlStatus_Click;
            // 
            // picturePanel1
            // 
            picturePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePanel1.Image = Resources.Icons.refresh;
            picturePanel1.ImagePortion = new Rectangle(-100, -100, 712, 712);
            picturePanel1.Location = new Point(10, 10);
            picturePanel1.Name = "picturePanel1";
            picturePanel1.Size = new Size(80, 80);
            picturePanel1.TabIndex = 0;
            picturePanel1.Text = "picturePanel1";
            picturePanel1.Click += picturePanel1_Click;
            // 
            // picturePanel2
            // 
            picturePanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePanel2.Image = Resources.Icons.check;
            picturePanel2.ImagePortion = new Rectangle(-100, -100, 712, 712);
            picturePanel2.Location = new Point(10, 10);
            picturePanel2.Name = "picturePanel2";
            picturePanel2.Size = new Size(80, 80);
            picturePanel2.TabIndex = 0;
            picturePanel2.Text = "picturePanel2";
            picturePanel2.Click += picturePanel2_Click;
            // 
            // customRectangle1
            // 
            customRectangle1.Anchor = AnchorStyles.Left;
            customRectangle1.BackColor = Color.FromArgb(18, 17, 19);
            customRectangle1.BorderColor = Color.White;
            customRectangle1.BorderWidth = 0;
            customRectangle1.Controls.Add(picturePanel2);
            customRectangle1.CornerRadius = 20;
            customRectangle1.Location = new Point(120, 0);
            customRectangle1.Margin = new Padding(25);
            customRectangle1.Name = "customRectangle1";
            customRectangle1.Size = new Size(100, 100);
            customRectangle1.TabIndex = 3;
            customRectangle1.Text = "customRectangle1";
            customRectangle1.Click += customRectangle1_Click;
            // 
            // ButtonRefreshOk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(customRectangle1);
            Controls.Add(pnlStatus);
            Name = "ButtonRefreshOk";
            Size = new Size(220, 100);
            pnlStatus.ResumeLayout(false);
            customRectangle1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomRectangle pnlStatus;
        private PicturePanel picturePanel1;
        private PicturePanel picturePanel2;
        private CustomRectangle customRectangle1;
    }
}
