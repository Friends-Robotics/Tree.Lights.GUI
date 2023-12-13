using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;


namespace Tree_Gui.View {
    public partial class formScan : Form, MenuSubView {
        private static VideoCapture? _camera;
        
        public formScan() {
            InitializeComponent();
        }

        public bool CanExit() {
            throw new NotImplementedException();
        }

        public void Exit() {
            throw new NotImplementedException();
        }

        public void MenuEnter() {
            throw new NotImplementedException();
        }

        private void btnStartScan_Click(object sender, EventArgs e) {
            lblInfo.Text = "Initialising camera";
            lblInfo.Text = "Mark the corners of the tree by clicking the image. Ensure all lights are within the triangle\n\nOnce you are happy with the outline, click tick. Click reset to try and mark the tree edges again and click the camera button to retake the image";
        }

        private Bitmap CaptureBitmap() {
            _camera ??= new();
            Mat Picture = new();
            _camera.Read(Picture);
            return Picture.ToBitmap();
        }
    }
}
