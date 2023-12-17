using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tree_Gui.Model;

namespace Tree_Gui.View {
    public partial class formConfig : Form {

        // Ip v4 regex
        [GeneratedRegex(@"^(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$")]
        private static partial Regex IpAddressRegex();

        public bool IsTesting { get; set; } = false;
        public formConfig() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {
            // Test for valid inputs

            bool ipOk = IpAddressRegex().IsMatch(tbIp.Text);
            bool portOk = int.TryParse(tbPort.Text, out int port);

            if (!ipOk && !portOk) MessageBox.Show("Please type in a valid port and ip address", "Connection info error", MessageBoxButtons.OK);
            else if (!ipOk) MessageBox.Show("Please type a vaild ip address", "Connection info error", MessageBoxButtons.OK);
            else if (!portOk) MessageBox.Show("Please type a vaild port", "Connection info error", MessageBoxButtons.OK);

            if (!(ipOk && portOk)) return;

            TreeManager.Connect(tbIp.Text, port);
        }
    }
}
