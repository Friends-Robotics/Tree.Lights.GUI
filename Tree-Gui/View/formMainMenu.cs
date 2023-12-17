using System.Diagnostics;

namespace Tree_Gui.View;
public partial class formMainMenu : Form {

    private const int MENU_WIDTH = 200;
    private const int MINIMISED_MENU_WIDTH = 75;

    private bool _menuMinimised = true;
    private Form? _subForm;
    private int? _subFormBaseHeight;

    private Form? SubForm {
        get => _subForm;
        set {
            _subForm = value;
            _subFormBaseHeight = value?.Height;
            OnResize(EventArgs.Empty);
        }
    }

    private int? UserFormBaseHeight {
        get => _subFormBaseHeight;
    }

    public formMainMenu() {
        InitializeComponent();

        DoubleBuffered = true;

        DisplayUserForm(new formHome());

        // Call the OnResize event to ensure that the form is formatted correctly
        OnResize(EventArgs.Empty);
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);

        // Avoid null references to the userform before it has been initialised
        if (SubForm is null) return;

        if (UserFormBaseHeight <= Height) {
            // Hide the scroll bar if the form is big enough and scale the form appropriately
            sb.Hide();
        }
        else {
            // Show the scroll bar when the form is too small to see the whole user view and scale the form appropriately
            sb.Show();

            // Scale the thumb of the scroll bar
            sb.Maximum = SubForm.Height - Height;
            int sbRange = sb.Maximum - sb.Minimum;
            int thumbHeight = Height - sbRange;

            // Ensure the form is not minimised before making this check to avoid an exception
            if ((ActiveForm as formMaster)?.WindowState != FormWindowState.Minimized)
                sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

            // Set the scroll bar value to the correct position
            // Atm this means resetting it cus idek whats going on when i try to resize not at 0
            sb.Value = 0;
        }


        SubForm.Width = Width - MINIMISED_MENU_WIDTH - sb.Width;
        if (_menuMinimised) MinimiseMenu();
        else MaximiseMenu();
    }

    #region Menu formatting

    private void Menu_Click(object sender, EventArgs e) {
        _menuMinimised = !_menuMinimised;
        if (_menuMinimised) MinimiseMenu();
        else MaximiseMenu();
    }

    private void MinimiseMenu() {
        pnlMenuStrip.Width = MINIMISED_MENU_WIDTH;

        if (SubForm is null) return;
        SubForm.Location = new Point(0, 0);
    }
    private void MaximiseMenu() {
        pnlMenuStrip.Width = MENU_WIDTH;

        if (SubForm is null) return;
        SubForm.Location = new Point(MINIMISED_MENU_WIDTH - MENU_WIDTH, 0);
    }

    #endregion

    #region Menu navigation

    private void DisplayUserForm(Form form) {
        SubForm = (Form?)form;

        if (SubForm is null) return;

        // Setup form display settings
        SubForm.TopLevel = false;
        SubForm.Location = new Point(0, 0);
        SubForm.FormBorderStyle = FormBorderStyle.None;
        SubForm.Enabled = true;
        SubForm.Visible = true;
        SubForm.Width = Width - 75;
        SubForm.Location = _menuMinimised ? new Point(0, 0) : new Point(-125, 0);

        // Display in panel
        pnlViewHolder.Controls.Clear();
        pnlViewHolder.Controls.Add(SubForm);
        pnlViewHolder.Show();

        // Redraw form
        Refresh();
    }

    private void miHome_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (SubForm is not formHome) DisplayUserForm(new formHome());
    }

    private void miPlay_Click(object sender, EventArgs e) {
        MinimiseMenu();
        if (SubForm is not formPlay) DisplayUserForm(new formPlay());
    }

    private void miScan_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (SubForm is not formScan) DisplayUserForm(new formScan());
    }

    private void miTree_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (SubForm is not formTree) DisplayUserForm(new formTree());
    }

    private void miConfig_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        if (SubForm is not formConfig) DisplayUserForm(new formConfig());
    }

    #endregion

    private void miExit_MenuClick(object sender, EventArgs e) {
        MinimiseMenu();
        DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK) {
            (ActiveForm as formMaster)?.Close();
        }
    }

    public void ScrollUserView(int value) {
        sb.Value -= value;
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        if (SubForm is null) return;
        SubForm.Location = new Point(_menuMinimised ? 0 : -125, -sb.Value);
        Refresh();
    }
}
