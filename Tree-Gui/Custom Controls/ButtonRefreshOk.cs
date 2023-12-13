using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_Gui.Custom_Controls {
    public partial class ButtonRefreshOk : UserControl {
        public ButtonRefreshOk() {
            InitializeComponent();
        }

        public event EventHandler? OkClick;
        public event EventHandler? RefreshClick;

        private void picturePanel1_Click(object sender, EventArgs e) {
            RefreshClick?.Invoke(sender, e);
        }

        private void picturePanel2_Click(object sender, EventArgs e) {
            OkClick?.Invoke(sender, e);
        }

        private void pnlStatus_Click(object sender, EventArgs e) {
            RefreshClick?.Invoke(sender, e);
        }

        private void customRectangle1_Click(object sender, EventArgs e) {
            OkClick?.Invoke(sender, e);
        }
    }
}
