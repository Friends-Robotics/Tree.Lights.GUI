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
            lblQuizTitle = new Label();
            pb = new Custom_Controls.CustomProgressBar();
            SuspendLayout();
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.Anchor = AnchorStyles.None;
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizTitle.ForeColor = Color.FromArgb(247, 247, 242);
            lblQuizTitle.Location = new Point(490, 276);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(196, 47);
            lblQuizTitle.TabIndex = 2;
            lblQuizTitle.Text = "Tree Gui";
            // 
            // pb
            // 
            pb.Anchor = AnchorStyles.None;
            pb.Angle = 0;
            pb.BackingColor = Color.White;
            pb.EndColor = Color.FromArgb(228, 230, 195);
            pb.Location = new Point(354, 649);
            pb.Name = "pb";
            pb.Progress = 1F;
            pb.Size = new Size(500, 50);
            pb.StartColor = Color.FromArgb(137, 152, 120);
            pb.TabIndex = 3;
            pb.Text = "customProgressBar1";
            // 
            // formSplash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 37);
            ClientSize = new Size(1222, 1000);
            Controls.Add(pb);
            Controls.Add(lblQuizTitle);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formSplash";
            Text = "FormSplash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuizTitle;
        private Custom_Controls.CustomProgressBar pb;
    }
}