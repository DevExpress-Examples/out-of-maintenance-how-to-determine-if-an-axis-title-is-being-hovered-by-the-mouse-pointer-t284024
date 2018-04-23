Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace AxisTitleHitTestSample
    Partial Public Class SampleForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Overloads Sub OnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.X, e.Y)
            If hitInfo.AxisTitle IsNot Nothing Then
                tooltipController.ShowHint(String.Format("The pointer is over the {0} object.", hitInfo.AxisTitle.GetType().ToString()))
            Else
                tooltipController.HideHint()
            End If
        End Sub
    End Class
End Namespace
