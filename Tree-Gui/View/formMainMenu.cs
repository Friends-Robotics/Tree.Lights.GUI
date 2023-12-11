using System.Diagnostics;

namespace Tree_Gui.View;
public partial class formMainMenu : Form {

    private bool _menuMinimised = true;
    private Form? _userForm;
    private int? _userFormBaseHeight;

    private Form? UserForm {
        get => _userForm;
        set {
            _userForm = value;
            _userFormBaseHeight = value?.Height;
        }
    }

    private int? UserFormBaseHeight {
        get => _userFormBaseHeight;
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
        if (UserForm is null) return;

        if (UserFormBaseHeight <= Height) {
            // Hide the scroll bar if the form is big enough and scale the form appropriately
            sb.Hide();
            UserForm.Dock = DockStyle.Fill;
        }
        else {
            // Show the scroll bar when the form is too small to see the whole user view and scale the form appropriately
            sb.Show();
            UserForm.Dock = DockStyle.None;

            // Scale the thumb of the scroll bar
            sb.Maximum = UserForm.Height - Height;
            int sbRange = sb.Maximum - sb.Minimum;
            int thumbHeight = Height - sbRange;
            sb.ThumbSize = new Size(sb.ThumbSize.Width, Math.Max(thumbHeight, 30));

            // Set the scroll bar value to the correct position
            sb.Value = 0;
        }

        UserForm.Width = Width - 75;
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

        if (UserForm is null) return;
        UserForm.Location = new Point(0, 0);
    }
    private void Maximise() {
        pnlMenuStrip.Width = 200;

        if (UserForm is null) return;
        UserForm.Location = new Point(-125, 0);
    }

    private void DisplayUserForm(Form form) {
        UserForm = form;

        // Setup form display settings
        UserForm.TopLevel = false;
        UserForm.Location = new Point(0, 0);
        UserForm.FormBorderStyle = FormBorderStyle.None;
        UserForm.Enabled = true;
        UserForm.Visible = true;
        UserForm.Width = Width - 75;
        UserForm.Location = _menuMinimised ? new Point(0, 0) : new Point(-125, 0);

        // Display in panel
        pnlUserViewHolder.Controls.Clear();
        pnlUserViewHolder.Controls.Add(UserForm);
        pnlUserViewHolder.Show();

        // Redraw form
        Refresh();
    }

    private void miHome_MenuClick(object sender, EventArgs e) {
        if (UserForm is not formHome) DisplayUserForm(new formHome());
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
        DialogResult result = MessageBox.Show("Sign out", "Are you sure you want to sign out?", MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK) {
            (ActiveForm as formMaster)?.Close();
        }
    }

    private void miAdmin_MenuClick(object sender, EventArgs e) {
        throw new NotImplementedException();
    }

    public void ScrollUserView(int distance) {
        if (UserForm is null) return;
        UserForm.Location = new Point(0, distance);
        Refresh();
    }

    private void sb_ValueChanged(object sender, EventArgs e) {
        ScrollUserView(-sb.Value);
    }
}
