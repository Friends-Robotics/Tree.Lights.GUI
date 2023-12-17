using Emgu.CV;
using Tree_Gui.Custom_Controls;
using Tree_Gui.Model;
using TreeAPI;

namespace Tree_Gui.View;
public partial class formScan : Form {

    private static VideoCapture? _camera;

    private readonly List<CustomButton> _buttonPoints = new();

    public formScan() {
        InitializeComponent();
    }

    protected override void OnFormClosing(FormClosingEventArgs e) {
        base.OnFormClosing(e);

        _camera?.Stop();
        _camera?.Dispose();
    }

    private void btnStartScan_Click(object sender, EventArgs e) {
        Scan();
    }

    private void Scan() {
        lblInfo.Text = "Initialising camera";

        CaptureBitmap();

        btnStartScan.Visible = false;
        pnlButtons.Visible = true;
        pbScanView.Enabled = true;

        lblInfo.Text = "Mark the corners of the tree by clicking the image. Ensure all lights are within the triangle\n\n" +
            "Once you are happy with the outline, click tick. To remove any points click them. Click" +
            " the camera button to retake the image";
    }

    private void btnRetake_Click(object sender, EventArgs e) {
        CaptureBitmap();
    }

    private void btnOk_Click(object sender, EventArgs e) {
        foreach (CustomButton btn in _buttonPoints) {
            DataManager.AddCornerPoint(new Rectangle(btn.Location.X + btn.Width / 2, btn.Location.Y + btn.Width / 2, pbScanView.Width, pbScanView.Height));
            btn.Visible = false;
        }

        pnlButtons.Visible = false;
        btnScanTree.Visible = true;
    }

    private void CaptureBitmap() {
        _camera ??= new VideoCapture();
        Mat Picture = new();
        _camera.Read(Picture);
        pbScanView.Image = Picture.ToBitmap();
        pbScanView.ImagePortion = new Rectangle(new Point(0, 0), pbScanView.Image.Size);
    }

    private void pbScanView_Click(object sender, EventArgs e) {
        if (_buttonPoints.Count >= 3) return;

        CustomButton button = new();
        pbScanView.Controls.Add(button);
        button.CornerRadius = 10;
        button.Size = new Size(20, 20);
        Point pictureClickLocation = pbScanView.PointToClient(MousePosition);
        button.Location = new Point(pictureClickLocation.X - button.Width / 2, pictureClickLocation.Y - button.Height / 2);
        button.BackColor = Color.Red;

        _buttonPoints.Add(button);
        button.Click += (s, e) => {
            _buttonPoints.Remove(button);
            ((Button)s!).Dispose();
        };
    }

    private void btnScanTree_Click(object sender, EventArgs e) {
        TreeAPI.Tree tree = new TreeAPI.Tree();
        tree.Send(new Setup());
    }
}
