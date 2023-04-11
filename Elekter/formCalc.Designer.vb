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
        Me.borssRadioButton = New System.Windows.Forms.RadioButton()
        Me.universaalRadioButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'electricityRateLabel
        '
        Me.electricityRateLabel.AutoSize = True
        Me.electricityRateLabel.Location = New System.Drawing.Point(76, 194)
        Me.electricityRateLabel.Name = "electricityRateLabel"
        Me.electricityRateLabel.Size = New System.Drawing.Size(137, 20)
        Me.electricityRateLabel.TabIndex = 67
        Me.electricityRateLabel.Text = "Paketihind (kWh): "
        '
        'timeUsedLabel
        '
        Me.timeUsedLabel.AutoSize = True
        Me.timeUsedLabel.Location = New System.Drawing.Point(58, 157)
        Me.timeUsedLabel.Name = "timeUsedLabel"
        Me.timeUsedLabel.Size = New System.Drawing.Size(154, 20)
        Me.timeUsedLabel.TabIndex = 66
        Me.timeUsedLabel.Text = "Kasutamise aeg (h): "
        '
        'electricityRateTextBox
        '
        Me.electricityRateTextBox.Location = New System.Drawing.Point(228, 191)
        Me.electricityRateTextBox.Name = "electricityRateTextBox"
        Me.electricityRateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.electricityRateTextBox.TabIndex = 65
        '
        'timeUsedTextBox
        '
        Me.timeUsedTextBox.Location = New System.Drawing.Point(228, 154)
        Me.timeUsedTextBox.Name = "timeUsedTextBox"
        Me.timeUsedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.timeUsedTextBox.TabIndex = 64
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(262, 18)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(75, 31)
        Me.otsingButton.TabIndex = 63
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(182, 18)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(75, 31)
        Me.vordlusButton.TabIndex = 62
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(100, 18)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 31)
        Me.calcButton.TabIndex = 61
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(20, 18)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(75, 31)
        Me.homeButton.TabIndex = 60
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(80, 228)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(133, 20)
        Me.costLabel.TabIndex = 59
        Me.costLabel.Text = "Orienteeruv hind: "
        '
        'powerRatingLabel
        '
        Me.powerRatingLabel.AutoSize = True
        Me.powerRatingLabel.Location = New System.Drawing.Point(51, 120)
        Me.powerRatingLabel.Name = "powerRatingLabel"
        Me.powerRatingLabel.Size = New System.Drawing.Size(162, 20)
        Me.powerRatingLabel.TabIndex = 58
        Me.powerRatingLabel.Text = "Tarbimisvõimsus (W): "
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(228, 228)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 26)
        Me.costTextBox.TabIndex = 57
        '
        'powerRatingTextBox
        '
        Me.powerRatingTextBox.Location = New System.Drawing.Point(228, 117)
        Me.powerRatingTextBox.Name = "powerRatingTextBox"
        Me.powerRatingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.powerRatingTextBox.TabIndex = 56
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(218, 275)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 35)
        Me.calculateButton.TabIndex = 55
        Me.calculateButton.Text = "Kuva"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'applianceLabel
        '
        Me.applianceLabel.AutoSize = True
        Me.applianceLabel.Location = New System.Drawing.Point(57, 86)
        Me.applianceLabel.Name = "applianceLabel"
        Me.applianceLabel.Size = New System.Drawing.Size(156, 20)
        Me.applianceLabel.TabIndex = 54
        Me.applianceLabel.Text = "Vali tüüpkodumasin: "
        '
        'applianceComboBox
        '
        Me.applianceComboBox.FormattingEnabled = True
        Me.applianceComboBox.Location = New System.Drawing.Point(228, 83)
        Me.applianceComboBox.Name = "applianceComboBox"
        Me.applianceComboBox.Size = New System.Drawing.Size(228, 28)
        Me.applianceComboBox.TabIndex = 53
        '
        'borssRadioButton
        '
        Me.borssRadioButton.AutoSize = True
        Me.borssRadioButton.Location = New System.Drawing.Point(346, 194)
        Me.borssRadioButton.Name = "borssRadioButton"
        Me.borssRadioButton.Size = New System.Drawing.Size(75, 24)
        Me.borssRadioButton.TabIndex = 68
        Me.borssRadioButton.TabStop = True
        Me.borssRadioButton.Text = "Börss"
        Me.borssRadioButton.UseVisualStyleBackColor = True
        '
        'universaalRadioButton
        '
        Me.universaalRadioButton.AutoSize = True
        Me.universaalRadioButton.Location = New System.Drawing.Point(427, 194)
        Me.universaalRadioButton.Name = "universaalRadioButton"
        Me.universaalRadioButton.Size = New System.Drawing.Size(108, 24)
        Me.universaalRadioButton.TabIndex = 69
        Me.universaalRadioButton.TabStop = True
        Me.universaalRadioButton.Text = "Universaal"
        Me.universaalRadioButton.UseVisualStyleBackColor = True
        '
        'formCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 349)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formCalc"
        Me.Text = "formCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents borssRadioButton As RadioButton
    Friend WithEvents universaalRadioButton As RadioButton
End Class
