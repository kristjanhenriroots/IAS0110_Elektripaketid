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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.cbProvider = New System.Windows.Forms.ComboBox()
        Me.cbPackage = New System.Windows.Forms.ComboBox()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.cbStartTime = New System.Windows.Forms.ComboBox()
        Me.cbEndTime = New System.Windows.Forms.ComboBox()
        Me.btnFindPackage = New System.Windows.Forms.Button()
        CType(Me.packageChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(181, 15)
        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(50, 20)
        Me.otsingButton.TabIndex = 64
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(127, 15)
        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
        Me.vordlusButton.TabIndex = 63
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(73, 15)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(50, 20)
        Me.calcButton.TabIndex = 62
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(19, 15)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 20)
        Me.homeButton.TabIndex = 61
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Pakettide võrdlus:"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Filter 1", "Filter 2"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(141, 130)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(82, 34)
        Me.CheckedListBox2.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Filtreeri pakette:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Järjestamise viis:"
        '
        'jarjestamineComboBox
        '
        Me.jarjestamineComboBox.FormattingEnabled = True
        Me.jarjestamineComboBox.Location = New System.Drawing.Point(141, 78)
        Me.jarjestamineComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.jarjestamineComboBox.Name = "jarjestamineComboBox"
        Me.jarjestamineComboBox.Size = New System.Drawing.Size(82, 21)
        Me.jarjestamineComboBox.TabIndex = 55
        '
        'compareButton
        '
        Me.compareButton.Location = New System.Drawing.Point(143, 181)
        Me.compareButton.Margin = New System.Windows.Forms.Padding(2)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(81, 20)
        Me.compareButton.TabIndex = 54
        Me.compareButton.Text = "Võrdle pakette"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'pakettCheckedListBox
        '
        Me.pakettCheckedListBox.CheckOnClick = True
        Me.pakettCheckedListBox.FormattingEnabled = True
        Me.pakettCheckedListBox.Location = New System.Drawing.Point(35, 78)
        Me.pakettCheckedListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.pakettCheckedListBox.Name = "pakettCheckedListBox"
        Me.pakettCheckedListBox.Size = New System.Drawing.Size(88, 124)
        Me.pakettCheckedListBox.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Pakettide nimekiri:"
        '
        'packageChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.packageChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.packageChart.Legends.Add(Legend3)
        Me.packageChart.Location = New System.Drawing.Point(233, 78)
        Me.packageChart.Margin = New System.Windows.Forms.Padding(2)
        Me.packageChart.Name = "packageChart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.packageChart.Series.Add(Series3)
        Me.packageChart.Size = New System.Drawing.Size(163, 122)
        Me.packageChart.TabIndex = 65
        Me.packageChart.Text = "Chart1"
        '
        'cbProvider
        '
        Me.cbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvider.FormattingEnabled = True
        Me.cbProvider.Location = New System.Drawing.Point(35, 247)
        Me.cbProvider.Name = "cbProvider"
        Me.cbProvider.Size = New System.Drawing.Size(142, 21)
        Me.cbProvider.TabIndex = 66
        '
        'cbPackage
        '
        Me.cbPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPackage.FormattingEnabled = True
        Me.cbPackage.Location = New System.Drawing.Point(35, 294)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(142, 21)
        Me.cbPackage.TabIndex = 67
        '
        'lblProvider
        '
        Me.lblProvider.AutoSize = True
        Me.lblProvider.Location = New System.Drawing.Point(32, 231)
        Me.lblProvider.Name = "lblProvider"
        Me.lblProvider.Size = New System.Drawing.Size(46, 13)
        Me.lblProvider.TabIndex = 68
        Me.lblProvider.Text = "Pakkuja"
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(32, 278)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(38, 13)
        Me.lblPackage.TabIndex = 69
        Me.lblPackage.Text = "Pakett"
        '
        'cbStartTime
        '
        Me.cbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartTime.FormattingEnabled = True
        Me.cbStartTime.Location = New System.Drawing.Point(221, 247)
        Me.cbStartTime.Name = "cbStartTime"
        Me.cbStartTime.Size = New System.Drawing.Size(142, 21)
        Me.cbStartTime.TabIndex = 70
        '
        'cbEndTime
        '
        Me.cbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEndTime.FormattingEnabled = True
        Me.cbEndTime.Location = New System.Drawing.Point(221, 294)
        Me.cbEndTime.Name = "cbEndTime"
        Me.cbEndTime.Size = New System.Drawing.Size(142, 21)
        Me.cbEndTime.TabIndex = 71
        '
        'btnFindPackage
        '
        Me.btnFindPackage.Location = New System.Drawing.Point(35, 321)
        Me.btnFindPackage.Name = "btnFindPackage"
        Me.btnFindPackage.Size = New System.Drawing.Size(121, 22)
        Me.btnFindPackage.TabIndex = 72
        Me.btnFindPackage.Text = "Leia pakett"
        Me.btnFindPackage.UseVisualStyleBackColor = True
        '
        'formVordlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 405)
        Me.Controls.Add(Me.btnFindPackage)
        Me.Controls.Add(Me.cbEndTime)
        Me.Controls.Add(Me.cbStartTime)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.lblProvider)
        Me.Controls.Add(Me.cbPackage)
        Me.Controls.Add(Me.cbProvider)
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
    Friend WithEvents cbProvider As ComboBox
    Friend WithEvents cbPackage As ComboBox
    Friend WithEvents lblProvider As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents cbStartTime As ComboBox
    Friend WithEvents cbEndTime As ComboBox
    Friend WithEvents btnFindPackage As Button
End Class
