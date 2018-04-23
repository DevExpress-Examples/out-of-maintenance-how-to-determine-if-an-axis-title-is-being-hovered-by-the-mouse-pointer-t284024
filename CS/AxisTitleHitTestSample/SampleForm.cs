using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace AxisTitleHitTestSample {
    public partial class SampleForm : Form {
        public SampleForm() {
            InitializeComponent();
        }

        private void OnMouseMove(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.X, e.Y);
            if (hitInfo.AxisTitle != null)
                tooltipController.ShowHint(
                    String.Format(
                        "The pointer is over the {0} object.", 
                        hitInfo.AxisTitle.GetType().ToString()
                    )
                );
            else
                tooltipController.HideHint();
        }
    }
}
