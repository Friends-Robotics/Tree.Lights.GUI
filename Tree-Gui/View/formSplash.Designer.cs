namespace Tree_Gui {
    partial class formSplash {
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
            pb = new Custom_Controls.CustomProgressBar();
            picLogo = new Custom_Controls.PicturePanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(247, 247, 242);
            lblTitle.Location = new Point(495, 181);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 47);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Tree Gui";
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Angle = 0;
            pb.BackingColor = Color.White;
            pb.EndColor = Color.FromArgb(228, 230, 195);
            pb.Location = new Point(331, 710);
            pb.Name = "pb";
            pb.Progress = 1F;
            pb.Size = new Size(500, 50);
            pb.StartColor = Color.FromArgb(137, 152, 120);
            pb.TabIndex = 3;
            pb.Text = "customProgressBar1";
            // 
            // picLogo
            // 
            picLogo.Image = Resources.Images.Circuit_Christmas_Tree;
            picLogo.ImagePortion = new Rectangle(0, 0, 942, 1213);
            picLogo.Location = new Point(443, 248);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(314, 404);
            picLogo.TabIndex = 5;
            picLogo.Text = "picturePanel1";
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1200, 1000);
            Controls.Add(picLogo);
            Controls.Add(pb);
            Controls.Add(lblTitle);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formSplash";
            Text = "FormSplash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Custom_Controls.CustomProgressBar pb;
        private Custom_Controls.PicturePanel picLogo;
    }
}