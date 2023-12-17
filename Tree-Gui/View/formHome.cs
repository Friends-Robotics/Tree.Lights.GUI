using Tree_Gui._Helpers;
using Tree_Gui.Model;

namespace Tree_Gui.View;
public partial class formHome : Form {
    public formHome() {
        InitializeComponent();

        lblStatus.Text = "Connection status : " + TreeManager.IsConnected switch {
            null or false => "Disconnected",
            true => "Connected"
        };

        lblPath.Text = "Path : " + TreeManager.Path;
        lblActive.Text = "Activity : " + (TreeManager.IsConnected is null || TreeManager.IsConnected == false ? "" :
           TreeManager.CurrentAnimation is null ? "Idle" : "Playing");
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblTitle.CenterX();

        lblInfo.MaximumSize = new Size(Width - 50, lblInfo.Height);
        lblInfo.CenterX();
    }

    protected override void OnMouseWheel(MouseEventArgs e) {
        base.OnMouseWheel(e);

        ((ActiveForm as formMaster)?.ChildView as formMainMenu)?.ScrollUserView(e.Delta);
    }
}
