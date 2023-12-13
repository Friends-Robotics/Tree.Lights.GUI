using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_Gui.View {
    public partial class formConfig : Form {

        public bool IsTesting { get; set; } = false;
        public formConfig() {
            InitializeComponent();
        }

        private void picTestingCheckbox_Click(object sender, EventArgs e) {
            IsTesting = !IsTesting;
            picTestingCheckbox.Image = IsTesting ? Resources.Icons.dot_circle : Resources.Icons.dot_circle__1_;
        }

        private void customButton1_Click(object sender, EventArgs e) {

        }
    }
}
