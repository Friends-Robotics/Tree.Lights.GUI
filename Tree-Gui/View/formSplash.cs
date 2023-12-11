using Tree_Gui._Helpers;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_Gui {
    public partial class formSplash : Form {

        const int FRAME_DELAY = 1;
        public formSplash() {
            InitializeComponent();
            OnResize(EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            pb.CenterX();
            lblTitle.CenterX();
            picLogo.Center();
        }

        public async Task SimulateLoading(int duration = 1000) {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            while (stopwatch.ElapsedMilliseconds < duration) {
                pb.Progress = (float)stopwatch.ElapsedMilliseconds / duration;
                await Task.Delay(FRAME_DELAY);
            }

            stopwatch.Stop();
        }
    }
}
