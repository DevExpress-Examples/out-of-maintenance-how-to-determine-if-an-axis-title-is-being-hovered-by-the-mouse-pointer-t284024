Namespace AxisTitleHitTestSample
    Partial Public Class SampleForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(423.721R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(178.719R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(308.845R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(348.555R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(160.274R, Object))})
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(476.851R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(195.769R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(335.793R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(374.771R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(182.373R, Object))})
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Illinois", New Object() { (DirectCast(528.904R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Indiana", New Object() { (DirectCast(227.271R, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Michigan", New Object() { (DirectCast(372.576R, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("Ohio", New Object() { (DirectCast(418.258R, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("Wisconsin", New Object() { (DirectCast(211.727R, Object))})
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.tooltipController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "Millions of USD"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.RuntimeHitTesting = True
            series1.Name = "1998"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            series2.Name = "2001"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10})
            series3.Name = "2004"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15})
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
            Me.chart.Size = New System.Drawing.Size(624, 321)
            Me.chart.TabIndex = 0
            chartTitle1.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            chartTitle1.Indent = 1
            chartTitle1.Text = "Great lakes gross state product"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' SampleForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chart)
            Me.Name = "SampleForm"
            Me.Text = "Axis Title Hit Test Sample"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chart As DevExpress.XtraCharts.ChartControl
        Private tooltipController As DevExpress.Utils.ToolTipController
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

