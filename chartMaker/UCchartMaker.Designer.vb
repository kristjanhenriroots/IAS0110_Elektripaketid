<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCchartMaker
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CartesianChart = New LiveCharts.WinForms.CartesianChart()
        Me.SuspendLayout()
        '
        'CartesianChart
        '
        Me.CartesianChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CartesianChart.Location = New System.Drawing.Point(0, 0)
        Me.CartesianChart.Name = "CartesianChart"
        Me.CartesianChart.Size = New System.Drawing.Size(80, 50)
        Me.CartesianChart.TabIndex = 0
        Me.CartesianChart.Text = "CartesianChart1"
        '
        'UCchartMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.CartesianChart)
        Me.Name = "UCchartMaker"
        Me.Size = New System.Drawing.Size(350, 195)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CartesianChart As LiveCharts.WinForms.CartesianChart
End Class
