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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MainChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.btnCalcTimeFrame = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTimeFrame = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbRecTimeFrame = New System.Windows.Forms.TextBox()
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
        ChartArea1.Name = "ChartArea1"
        Me.MainChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.MainChart.Legends.Add(Legend1)
        Me.MainChart.Location = New System.Drawing.Point(34, 65)
        Me.MainChart.Margin = New System.Windows.Forms.Padding(2)
        Me.MainChart.Name = "MainChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.MainChart.Series.Add(Series1)
        Me.MainChart.Size = New System.Drawing.Size(351, 195)
        Me.MainChart.TabIndex = 0
        Me.MainChart.Text = "MainChart"
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(173, 11)
        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(50, 20)
        Me.otsingButton.TabIndex = 74
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(119, 11)
        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
        Me.vordlusButton.TabIndex = 73
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(65, 11)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(50, 20)
        Me.calcButton.TabIndex = 72
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(11, 11)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 20)
        Me.homeButton.TabIndex = 71
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'btnCalcTimeFrame
        '
        Me.btnCalcTimeFrame.Location = New System.Drawing.Point(397, 102)
        Me.btnCalcTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcTimeFrame.Name = "btnCalcTimeFrame"
        Me.btnCalcTimeFrame.Size = New System.Drawing.Size(81, 36)
        Me.btnCalcTimeFrame.TabIndex = 70
        Me.btnCalcTimeFrame.Text = "Muuda kasutusaegu"
        Me.btnCalcTimeFrame.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(394, 65)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Kuva valik:"
        '
        'cbTimeFrame
        '
        Me.cbTimeFrame.FormattingEnabled = True
        Me.cbTimeFrame.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbTimeFrame.Location = New System.Drawing.Point(397, 80)
        Me.cbTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTimeFrame.Name = "cbTimeFrame"
        Me.cbTimeFrame.Size = New System.Drawing.Size(82, 21)
        Me.cbTimeFrame.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(275, 276)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(115, 20)
        Me.TextBox4.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(277, 262)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "CO2 jalajälg:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 43)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Hetkel valitud kuva: Kinnisvara"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 262)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vali ajavahemik:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 276)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(68, 20)
        Me.TextBox3.TabIndex = 62
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(33, 276)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 61
        '
        'tbRecTimeFrame
        '
        Me.tbRecTimeFrame.Location = New System.Drawing.Point(394, 166)
        Me.tbRecTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRecTimeFrame.Name = "tbRecTimeFrame"
        Me.tbRecTimeFrame.Size = New System.Drawing.Size(115, 20)
        Me.tbRecTimeFrame.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
        '
        'shrinkButton
        '
        Me.shrinkButton.Location = New System.Drawing.Point(490, 290)
        Me.shrinkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.shrinkButton.Name = "shrinkButton"
        Me.shrinkButton.Size = New System.Drawing.Size(17, 16)
        Me.shrinkButton.TabIndex = 58
        Me.shrinkButton.Text = "-"
        Me.shrinkButton.UseVisualStyleBackColor = True
        '
        'enlargeButton
        '
        Me.enlargeButton.Location = New System.Drawing.Point(490, 269)
        Me.enlargeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enlargeButton.Name = "enlargeButton"
        Me.enlargeButton.Size = New System.Drawing.Size(17, 16)
        Me.enlargeButton.TabIndex = 57
        Me.enlargeButton.Text = "+"
        Me.enlargeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Graafiku valik:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tulpdiagramm", "Tabeldiagramm"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 275)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Hetkel valitud pakett: Börsipakett"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Tere, <Kasutaja>!"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 317)
        Me.Controls.Add(Me.otsingButton)
        Me.Controls.Add(Me.vordlusButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.btnCalcTimeFrame)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbTimeFrame)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbRecTimeFrame)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.shrinkButton)
        Me.Controls.Add(Me.enlargeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainChart)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents btnCalcTimeFrame As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTimeFrame As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tbRecTimeFrame As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents shrinkButton As Button
    Friend WithEvents enlargeButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
