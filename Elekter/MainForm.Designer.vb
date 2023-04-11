<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MainChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shrinkButton = New System.Windows.Forms.Button()
        Me.enlargeButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainChart
        '
        Me.MainChart.Anchor = System.Windows.Forms.AnchorStyles.None
        ChartArea2.Name = "ChartArea1"
        Me.MainChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.MainChart.Legends.Add(Legend2)
        Me.MainChart.Location = New System.Drawing.Point(51, 100)
        Me.MainChart.Name = "MainChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.MainChart.Series.Add(Series2)
        Me.MainChart.Size = New System.Drawing.Size(526, 300)
        Me.MainChart.TabIndex = 0
        Me.MainChart.Text = "MainChart"
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(260, 17)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(75, 31)
        Me.otsingButton.TabIndex = 74
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(178, 17)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(75, 31)
        Me.vordlusButton.TabIndex = 73
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(98, 17)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 31)
        Me.calcButton.TabIndex = 72
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(16, 17)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(75, 31)
        Me.homeButton.TabIndex = 71
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(596, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 55)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Muuda kasutusaegu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(591, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Kuva valik:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(596, 123)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(412, 425)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 26)
        Me.TextBox4.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "CO2 jalajälg:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 20)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Hetkel valitud kuva: Kinnisvara"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 20)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vali ajavahemik:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(176, 425)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 62
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(50, 425)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(591, 255)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 26)
        Me.TextBox1.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(584, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
        '
        'shrinkButton
        '
        Me.shrinkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shrinkButton.Location = New System.Drawing.Point(735, 446)
        Me.shrinkButton.Name = "shrinkButton"
        Me.shrinkButton.Size = New System.Drawing.Size(26, 25)
        Me.shrinkButton.TabIndex = 58
        Me.shrinkButton.Text = "-"
        Me.shrinkButton.UseVisualStyleBackColor = True
        '
        'enlargeButton
        '
        Me.enlargeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enlargeButton.Location = New System.Drawing.Point(735, 414)
        Me.enlargeButton.Name = "enlargeButton"
        Me.enlargeButton.Size = New System.Drawing.Size(26, 25)
        Me.enlargeButton.TabIndex = 57
        Me.enlargeButton.Text = "+"
        Me.enlargeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Graafiku valik:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tulpdiagramm", "Tabeldiagramm"})
        Me.ComboBox1.Location = New System.Drawing.Point(282, 423)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 28)
        Me.ComboBox1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Hetkel valitud pakett: Börsipakett"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Tere, <Kasutaja>!"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 488)
        Me.Controls.Add(Me.otsingButton)
        Me.Controls.Add(Me.vordlusButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.shrinkButton)
        Me.Controls.Add(Me.enlargeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainChart)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainChart As DataVisualization.Charting.Chart
    Friend WithEvents otsingButton As Button
    Friend WithEvents vordlusButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents shrinkButton As Button
    Friend WithEvents enlargeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
