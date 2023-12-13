using Tree_Gui._Helpers;
using Tree_Gui.Model;

namespace Tree_Gui.View;
public partial class formHome : Form, MenuSubView {
    public formHome() {
        InitializeComponent();
    }

    public void MenuEnter() {
        lblStatus.Text = "Connection status : " + ConnectionManager.IsConnected switch {
            null or false => "Disconnected",
            true => "Connected"
        };

        lblPath.Text = "Path : " + ConnectionManager.Path;
        lblActive.Text = "State : " + ConnectionManager.IsConnected is null || ConnectionManager.IsConnected == false ? "" :
           ConnectionManager.CurrentAnimation is null ? "Idle" : "Playing";
    }
    public bool CanExit() => true;
    public void Exit() { }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);


        lblTitle.CenterX();

        lblInfo.MaximumSize = new Size(Width - 50, lblInfo.Height);
        lblInfo.CenterX();

    }

    private void formHome_Load(object sender, EventArgs e) {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e) {

    }
}
