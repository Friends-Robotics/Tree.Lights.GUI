namespace Tree_Gui.Custom_Controls {
    partial class PictureButton {
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
            pb = new PicturePanel();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.FromArgb(18, 17, 19);
            pnlStatus.BorderColor = Color.White;
            pnlStatus.BorderWidth = 0;
            pnlStatus.Controls.Add(pb);
            pnlStatus.CornerRadius = 20;
            pnlStatus.Dock = DockStyle.Fill;
            pnlStatus.Location = new Point(0, 0);
            pnlStatus.Margin = new Padding(25);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(100, 100);
            pnlStatus.TabIndex = 2;
            pnlStatus.Text = "customRectangle1";
            pnlStatus.Click += ButtonClick;
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb.Image = Resources.Icons.refresh;
            pb.ImagePortion = new Rectangle(-100, -100, 712, 712);
            pb.Location = new Point(10, 10);
            pb.Name = "pb";
            pb.Size = new Size(80, 80);
            pb.TabIndex = 0;
            pb.Click += ButtonClick;
            // 
            // PictureButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlStatus);
            Name = "PictureButton";
            Size = new Size(100, 100);
            pnlStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomRectangle pnlStatus;
        private PicturePanel pb;
    }
}
