<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVordlus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jarjestamineComboBox = New System.Windows.Forms.ComboBox()
        Me.compareButton = New System.Windows.Forms.Button()
        Me.pakettCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.packageChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.packageChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(272, 23)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(75, 31)
        Me.otsingButton.TabIndex = 64
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(190, 23)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(75, 31)
        Me.vordlusButton.TabIndex = 63
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(110, 23)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 31)
        Me.calcButton.TabIndex = 62
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(28, 23)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(75, 31)
        Me.homeButton.TabIndex = 61
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Pakettide võrdlus:"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Filter 1", "Filter 2"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(252, 273)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(121, 50)
        Me.CheckedListBox2.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Filtreeri pakette:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Järjestamise viis:"
        '
        'jarjestamineComboBox
        '
        Me.jarjestamineComboBox.FormattingEnabled = True
        Me.jarjestamineComboBox.Location = New System.Drawing.Point(256, 120)
        Me.jarjestamineComboBox.Name = "jarjestamineComboBox"
        Me.jarjestamineComboBox.Size = New System.Drawing.Size(121, 28)
        Me.jarjestamineComboBox.TabIndex = 55
        '
        'compareButton
        '
        Me.compareButton.Location = New System.Drawing.Point(252, 346)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(122, 31)
        Me.compareButton.TabIndex = 54
        Me.compareButton.Text = "Võrdle pakette"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'pakettCheckedListBox
        '
        Me.pakettCheckedListBox.CheckOnClick = True
        Me.pakettCheckedListBox.FormattingEnabled = True
        Me.pakettCheckedListBox.HorizontalScrollbar = True
        Me.pakettCheckedListBox.Location = New System.Drawing.Point(52, 120)
        Me.pakettCheckedListBox.Name = "pakettCheckedListBox"
        Me.pakettCheckedListBox.Size = New System.Drawing.Size(173, 257)
        Me.pakettCheckedListBox.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Pakettide nimekiri:"
        '
        'packageChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.packageChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.packageChart.Legends.Add(Legend1)
        Me.packageChart.Location = New System.Drawing.Point(410, 119)
        Me.packageChart.Name = "packageChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.packageChart.Series.Add(Series1)
        Me.packageChart.Size = New System.Drawing.Size(361, 258)
        Me.packageChart.TabIndex = 65
        Me.packageChart.Text = "Chart1"
        '
        'formVordlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 414)
        Me.Controls.Add(Me.packageChart)
        Me.Controls.Add(Me.otsingButton)
        Me.Controls.Add(Me.vordlusButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.jarjestamineComboBox)
        Me.Controls.Add(Me.compareButton)
        Me.Controls.Add(Me.pakettCheckedListBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formVordlus"
        Me.Text = "formVordlus"
        CType(Me.packageChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents otsingButton As Button
    Friend WithEvents vordlusButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jarjestamineComboBox As ComboBox
    Friend WithEvents compareButton As Button
    Friend WithEvents pakettCheckedListBox As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents packageChart As DataVisualization.Charting.Chart
End Class
