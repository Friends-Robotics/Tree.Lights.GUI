using Tree_Gui._Helpers;
using Tree_Gui.Model;

namespace Tree_Gui.View;
public partial class formHome : Form {
    public formHome() {
        InitializeComponent();

        lblStatus.Text = "Connection status : " + ConnectionManager.IsConnected switch {
            null or false => "Disconnected",
            true => "Connected"
        };

        lblPath.Text = "Path : " + ConnectionManager.Path;
        lblActive.Text = "Activity : " + (ConnectionManager.IsConnected is null || ConnectionManager.IsConnected == false ? "" :
           ConnectionManager.CurrentAnimation is null ? "Idle" : "Playing");
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);


        lblTitle.CenterX();

        lblInfo.MaximumSize = new Size(Width - 50, lblInfo.Height);
        lblInfo.CenterX();

    }
}
