using Tree_Gui._Helpers;

namespace Tree_Gui.View;
public partial class formHome : Form {
    public formHome() {
        InitializeComponent();
    }

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
