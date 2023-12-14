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
    public partial class PictureButton : UserControl {
        public PictureButton() {
            InitializeComponent();
        }

        [Category("PictureButton")]
        public Image? Image {
            get => pb.Image;
            set => pb.Image = value;
        }

        [Category("PictureButton")]
        public Rectangle? ImagePortion {
            get => pb.ImagePortion;
            set => pb.ImagePortion = value;
        }

        public event EventHandler? ButtonClicked;

        private void ButtonClick(object sender, EventArgs e) {
            ButtonClicked?.Invoke(sender, e);
        }
    }
}
