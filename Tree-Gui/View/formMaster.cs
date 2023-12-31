﻿using System.ComponentModel;

namespace Tree_Gui.View;
public partial class formMaster : Form {

    public Form? ChildView { get; private set; }

    public formMaster() {
        InitializeComponent();
        DisplayFormAfterSplash(new formMainMenu());
    }

    protected override void OnClosing(CancelEventArgs e) {
        base.OnClosing(e);
    }

    public void DisplayForm(Form form) {
        ChildView = form;

        // Setup form display settings
        ChildView.TopLevel = false;
        ChildView.Dock = DockStyle.Fill;
        ChildView.FormBorderStyle = FormBorderStyle.None;
        ChildView.Enabled = true;
        ChildView.Visible = true;

        // Display in panel
        pnlFormHolder.Controls.Clear();
        pnlFormHolder.Controls.Add(ChildView);
        pnlFormHolder.Show();

        // Redraw form
        Refresh();
    }

    public void DisplayFormInBackground(Form form) {
        ChildView = form;

        // Setup form display settings
        ChildView.TopLevel = false;
        ChildView.Dock = DockStyle.Fill;
        ChildView.FormBorderStyle = FormBorderStyle.None;
        ChildView.Visible = false;
        ChildView.Enabled = true;

        // Display in panel
        pnlFormHolder.Controls.Add(ChildView);
        ChildView.SendToBack();
        ChildView.Visible = true;
        pnlFormHolder.Show();

        // Redraw form
        Refresh();
    }

    public async void DisplayFormAfterSplash(Form form) {
        formSplash splashScreen = new formSplash();
        DisplayForm(splashScreen);
        DisplayFormInBackground(form);

        await splashScreen.SimulateLoading(1000);

        form.BringToFront();
        pnlFormHolder.Controls.Remove(splashScreen);

        // Redraw form
        Refresh();
    }
}
