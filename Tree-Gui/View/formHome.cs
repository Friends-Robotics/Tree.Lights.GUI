using Tree_Gui._Helpers;

namespace Tree_Gui.View;
public partial class formHome : Form {
    public formHome() {
        InitializeComponent();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        lblRank.Center();
    }


}
