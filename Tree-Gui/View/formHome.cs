using Tree_Gui._Helpers;
using Tree_Gui.Model;

namespace Tree_Gui.View;
public partial class formHome : Form, MenuSubView {
    public formHome() {
        InitializeComponent();

        lblStatus.Text = "Status : " + (ConnectionManager.IsConnected ? "Connected" : "Disconnected");
        lblPath.Text = "Path : " + (ConnectionManager.IsConnected ? "" : ConnectionManager.Path);
        lblActive.Text = "State : ";
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
