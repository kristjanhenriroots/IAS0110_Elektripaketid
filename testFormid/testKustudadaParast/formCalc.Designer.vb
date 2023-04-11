<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCalc
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
        Me.universaalRadioButton = New System.Windows.Forms.RadioButton()
        Me.borssRadioButton = New System.Windows.Forms.RadioButton()
        Me.electricityRateLabel = New System.Windows.Forms.Label()
        Me.timeUsedLabel = New System.Windows.Forms.Label()
        Me.electricityRateTextBox = New System.Windows.Forms.TextBox()
        Me.timeUsedTextBox = New System.Windows.Forms.TextBox()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.powerRatingLabel = New System.Windows.Forms.Label()
        Me.costTextBox = New System.Windows.Forms.TextBox()
        Me.powerRatingTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.applianceLabel = New System.Windows.Forms.Label()
        Me.applianceComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'universaalRadioButton
        '
        Me.universaalRadioButton.AutoSize = True
        Me.universaalRadioButton.Location = New System.Drawing.Point(283, 125)
        Me.universaalRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.universaalRadioButton.Name = "universaalRadioButton"
        Me.universaalRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.universaalRadioButton.TabIndex = 86
        Me.universaalRadioButton.TabStop = True
        Me.universaalRadioButton.Text = "Universaal"
        Me.universaalRadioButton.UseVisualStyleBackColor = True
        '
        'borssRadioButton
        '
        Me.borssRadioButton.AutoSize = True
        Me.borssRadioButton.Location = New System.Drawing.Point(229, 125)
        Me.borssRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.borssRadioButton.Name = "borssRadioButton"
        Me.borssRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.borssRadioButton.TabIndex = 85
        Me.borssRadioButton.TabStop = True
        Me.borssRadioButton.Text = "Börss"
        Me.borssRadioButton.UseVisualStyleBackColor = True
        '
        'electricityRateLabel
        '
        Me.electricityRateLabel.AutoSize = True
        Me.electricityRateLabel.Location = New System.Drawing.Point(49, 125)
        Me.electricityRateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.electricityRateLabel.Name = "electricityRateLabel"
        Me.electricityRateLabel.Size = New System.Drawing.Size(95, 13)
        Me.electricityRateLabel.TabIndex = 84
        Me.electricityRateLabel.Text = "Paketihind (kWh): "
        '
        'timeUsedLabel
        '
        Me.timeUsedLabel.AutoSize = True
        Me.timeUsedLabel.Location = New System.Drawing.Point(37, 101)
        Me.timeUsedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.timeUsedLabel.Name = "timeUsedLabel"
        Me.timeUsedLabel.Size = New System.Drawing.Size(103, 13)
        Me.timeUsedLabel.TabIndex = 83
        Me.timeUsedLabel.Text = "Kasutamise aeg (h): "
        '
        'electricityRateTextBox
        '
        Me.electricityRateTextBox.Location = New System.Drawing.Point(150, 123)
        Me.electricityRateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.electricityRateTextBox.Name = "electricityRateTextBox"
        Me.electricityRateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.electricityRateTextBox.TabIndex = 82
        '
        'timeUsedTextBox
        '
        Me.timeUsedTextBox.Location = New System.Drawing.Point(150, 99)
        Me.timeUsedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.timeUsedTextBox.Name = "timeUsedTextBox"
        Me.timeUsedTextBox.Size = New System.Drawing.Size(68, 20)
        Me.timeUsedTextBox.TabIndex = 81
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(173, 11)
        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(50, 20)
        Me.otsingButton.TabIndex = 80
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(119, 11)
        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
        Me.vordlusButton.TabIndex = 79
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(65, 11)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(50, 20)
        Me.calcButton.TabIndex = 78
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(11, 11)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 20)
        Me.homeButton.TabIndex = 77
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(51, 147)
        Me.costLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(91, 13)
        Me.costLabel.TabIndex = 76
        Me.costLabel.Text = "Orienteeruv hind: "
        '
        'powerRatingLabel
        '
        Me.powerRatingLabel.AutoSize = True
        Me.powerRatingLabel.Location = New System.Drawing.Point(32, 77)
        Me.powerRatingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.powerRatingLabel.Name = "powerRatingLabel"
        Me.powerRatingLabel.Size = New System.Drawing.Size(110, 13)
        Me.powerRatingLabel.TabIndex = 75
        Me.powerRatingLabel.Text = "Tarbimisvõimsus (W): "
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(150, 147)
        Me.costTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(68, 20)
        Me.costTextBox.TabIndex = 74
        '
        'powerRatingTextBox
        '
        Me.powerRatingTextBox.Location = New System.Drawing.Point(150, 75)
        Me.powerRatingTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.powerRatingTextBox.Name = "powerRatingTextBox"
        Me.powerRatingTextBox.Size = New System.Drawing.Size(68, 20)
        Me.powerRatingTextBox.TabIndex = 73
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(143, 178)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(67, 23)
        Me.calculateButton.TabIndex = 72
        Me.calculateButton.Text = "Kuva"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'applianceLabel
        '
        Me.applianceLabel.AutoSize = True
        Me.applianceLabel.Location = New System.Drawing.Point(36, 55)
        Me.applianceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.applianceLabel.Name = "applianceLabel"
        Me.applianceLabel.Size = New System.Drawing.Size(105, 13)
        Me.applianceLabel.TabIndex = 71
        Me.applianceLabel.Text = "Vali tüüpkodumasin: "
        '
        'applianceComboBox
        '
        Me.applianceComboBox.FormattingEnabled = True
        Me.applianceComboBox.Location = New System.Drawing.Point(150, 53)
        Me.applianceComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.applianceComboBox.Name = "applianceComboBox"
        Me.applianceComboBox.Size = New System.Drawing.Size(153, 21)
        Me.applianceComboBox.TabIndex = 70
        '
        'formCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 227)
        Me.Controls.Add(Me.universaalRadioButton)
        Me.Controls.Add(Me.borssRadioButton)
        Me.Controls.Add(Me.electricityRateLabel)
        Me.Controls.Add(Me.timeUsedLabel)
        Me.Controls.Add(Me.electricityRateTextBox)
        Me.Controls.Add(Me.timeUsedTextBox)
        Me.Controls.Add(Me.otsingButton)
        Me.Controls.Add(Me.vordlusButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.powerRatingLabel)
        Me.Controls.Add(Me.costTextBox)
        Me.Controls.Add(Me.powerRatingTextBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.applianceLabel)
        Me.Controls.Add(Me.applianceComboBox)
        Me.Name = "formCalc"
        Me.Text = "formCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents universaalRadioButton As RadioButton
    Friend WithEvents borssRadioButton As RadioButton
    Friend WithEvents electricityRateLabel As Label
    Friend WithEvents timeUsedLabel As Label
    Friend WithEvents electricityRateTextBox As TextBox
    Friend WithEvents timeUsedTextBox As TextBox
    Friend WithEvents otsingButton As Button
    Friend WithEvents vordlusButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents costLabel As Label
    Friend WithEvents powerRatingLabel As Label
    Friend WithEvents costTextBox As TextBox
    Friend WithEvents powerRatingTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents applianceLabel As Label
    Friend WithEvents applianceComboBox As ComboBox
End Class
