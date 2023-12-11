using System.Diagnostics;

namespace Tree_Gui.View;
public partial class formMainMenu : Form {

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
            sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Clamp(thumbHeight, 30, Height - sb.ChannelPadding.Vertical));

            // Set the scroll bar value to the correct position
            sb.Value = 0;
        }


        SubForm.Width = Width - 75;
        if (_menuMinimised) Minimise();
        else Maximise();
    }

    private void Menu_Click(object sender, EventArgs e) {
        _menuMinimised = !_menuMinimised;
        if (_menuMinimised) Minimise();
        else Maximise();
    }

    private void Minimise() {
        pnlMenuStrip.Width = 75;

        if (SubForm is null) return;
        SubForm.Location = new Point(0, 0);
    }
    private void Maximise() {
        pnlMenuStrip.Width = 200;

        if (SubForm is null) return;
        SubForm.Location = new Point(-125, 0);
    }

    private void DisplayUserForm(Form form) {
        SubForm = form;

        // Setup form display settings
        SubForm.TopLevel = false;
        SubForm.Location = new Point(0, 0);
        SubForm.FormBorderStyle = FormBorderStyle.None;
        SubForm.Enabled = true;
        SubForm.Visible = true;
        SubForm.Width = Width - 75;
        SubForm.Location = _menuMinimised ? new Point(0, 0) : new Point(-125, 0);

        // Display in panel
        pnlUserViewHolder.Controls.Clear();
        pnlUserViewHolder.Controls.Add(SubForm);
        pnlUserViewHolder.Show();

        // Redraw form
        Refresh();
    }

    private void miHome_MenuClick(object sender, EventArgs e) {
        if (SubForm is not formHome) DisplayUserForm(new formHome());
    }

    private void miQuiz_MenuClick(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    private void miRanks_Click(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    private void miSettings_MenuClick(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    private void miSignOut_MenuClick(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK) {
            (ActiveForm as formMaster)?.Close();
        }
    }

    private void miAdmin_MenuClick(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    public void ScrollUserView(int distance) {
        if (SubForm is null) return;
        SubForm.Location = new Point(0, distance);
        Refresh();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        ScrollUserView(-sb.Value);
    }
}
