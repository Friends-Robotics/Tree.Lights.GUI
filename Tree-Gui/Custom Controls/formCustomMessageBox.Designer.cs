namespace Tree_Gui.Custom_Controls {
    partial class formCustomMessageBox {
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
            pnlBottom = new Panel();
            btnOk = new CustomButton();
            btnCancel = new CustomButton();
            tbInfo = new RichTextBox();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(30, 30, 60);
            pnlBottom.Controls.Add(btnOk);
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 205);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(525, 75);
            pnlBottom.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.BackColor = Color.FromArgb(0, 150, 255);
            btnOk.BorderColor = Color.White;
            btnOk.BorderWidth = 2;
            btnOk.CornerRadius = 20;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(276, 13);
            btnOk.Margin = new Padding(10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 50);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(0, 150, 255);
            btnCancel.BorderColor = Color.White;
            btnCancel.BorderWidth = 2;
            btnCancel.CornerRadius = 20;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(396, 13);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 50);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbInfo
            // 
            tbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbInfo.BackColor = Color.FromArgb(20, 20, 50);
            tbInfo.BorderStyle = BorderStyle.None;
            tbInfo.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbInfo.ForeColor = Color.White;
            tbInfo.Location = new Point(12, 12);
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.Size = new Size(501, 187);
            tbInfo.TabIndex = 1;
            tbInfo.Text = "test text\ntest";
            // 
            // formCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 50);
            ClientSize = new Size(525, 280);
            Controls.Add(tbInfo);
            Controls.Add(pnlBottom);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formCustomMessageBox";
            Text = "formCustomMessageBox";
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBottom;
        private CustomButton btnOk;
        private CustomButton btnCancel;
        private RichTextBox tbInfo;
    }
}