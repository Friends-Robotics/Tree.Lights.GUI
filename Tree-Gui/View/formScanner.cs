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
    public partial class formScan : Form {

        private static VideoCapture? _camera;

        private Queue<PointF> _points = new();

        private ScanState scanState = ScanState.Welcome;


        public formScan() {
            InitializeComponent();

            pnlButtons.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);

            _camera?.Stop();
            _camera?.Dispose();
        }

        private void btnStartScan_Click(object sender, EventArgs e) {
            StartScan();
        }

        private void StartScan() {
            scanState = ScanState.ScanCorners;
            lblInfo.Text = "Initialising camera";
            pbScanView.Image = CaptureBitmap();
            btn.Visible = false;
            pnlButtons.Visible = true;
            lblInfo.Text = "Mark the corners of the tree by clicking the image. Ensure all lights are within the triangle\n\nOnce you are happy with the outline, click tick. Click reset to try and mark the tree edges again and click the camera button to retake the image";
        }

        private Bitmap CaptureBitmap() {
            _camera ??= new VideoCapture();
            Mat Picture = new();
            _camera.Read(Picture);
            return Picture.ToBitmap();
        }

        private void btnRetake_Click(object sender, EventArgs e) {
            pbScanView.Image = CaptureBitmap();
        }

        private void btnRemark_Click(object sender, EventArgs e) {
            _points.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (_points.Count == 3) scanState = ScanState.ScanTree;
        }

        private void pbScanView_Click(object sender, EventArgs e) {
            if (scanState != ScanState.ScanCorners) return;

            Point mousePosition = PointToClient(MousePosition);
            PointF relativeClickPosition = PointF.Subtract(mousePosition, new Size(-pbScanView.Location.X, -pbScanView.Location.Y));
            PointF relativeImagePosition = new PointF(relativeClickPosition.X / pbScanView.Width, relativeClickPosition.Y / pbScanView.Height);
            
            _points.Enqueue(relativeImagePosition);
            if (_points.Count > 3) _points.Dequeue();


        }

        private enum ScanState {
            Welcome,
            ScanCorners,
            ScanTree
        }
    }
}
