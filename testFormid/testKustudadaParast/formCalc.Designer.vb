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
        Me.Label2 = New System.Windows.Forms.Label()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "autofill börss"
        '
        'electricityRateLabel
        '
        Me.electricityRateLabel.AutoSize = True
        Me.electricityRateLabel.Location = New System.Drawing.Point(51, 126)
        Me.electricityRateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.electricityRateLabel.Name = "electricityRateLabel"
        Me.electricityRateLabel.Size = New System.Drawing.Size(95, 13)
        Me.electricityRateLabel.TabIndex = 67
        Me.electricityRateLabel.Text = "Paketihind (kWh): "
        '
        'timeUsedLabel
        '
        Me.timeUsedLabel.AutoSize = True
        Me.timeUsedLabel.Location = New System.Drawing.Point(39, 102)
        Me.timeUsedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.timeUsedLabel.Name = "timeUsedLabel"
        Me.timeUsedLabel.Size = New System.Drawing.Size(103, 13)
        Me.timeUsedLabel.TabIndex = 66
        Me.timeUsedLabel.Text = "Kasutamise aeg (h): "
        '
        'electricityRateTextBox
        '
        Me.electricityRateTextBox.Location = New System.Drawing.Point(152, 124)
        Me.electricityRateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.electricityRateTextBox.Name = "electricityRateTextBox"
        Me.electricityRateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.electricityRateTextBox.TabIndex = 65
        '
        'timeUsedTextBox
        '
        Me.timeUsedTextBox.Location = New System.Drawing.Point(152, 100)
        Me.timeUsedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.timeUsedTextBox.Name = "timeUsedTextBox"
        Me.timeUsedTextBox.Size = New System.Drawing.Size(68, 20)
        Me.timeUsedTextBox.TabIndex = 64
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(175, 12)
        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(50, 20)
        Me.otsingButton.TabIndex = 63
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(121, 12)
        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
        Me.vordlusButton.TabIndex = 62
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(67, 12)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(50, 20)
        Me.calcButton.TabIndex = 61
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(13, 12)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 20)
        Me.homeButton.TabIndex = 60
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(53, 148)
        Me.costLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(91, 13)
        Me.costLabel.TabIndex = 59
        Me.costLabel.Text = "Orienteeruv hind: "
        '
        'powerRatingLabel
        '
        Me.powerRatingLabel.AutoSize = True
        Me.powerRatingLabel.Location = New System.Drawing.Point(34, 78)
        Me.powerRatingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.powerRatingLabel.Name = "powerRatingLabel"
        Me.powerRatingLabel.Size = New System.Drawing.Size(110, 13)
        Me.powerRatingLabel.TabIndex = 58
        Me.powerRatingLabel.Text = "Tarbimisvõimsus (W): "
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(152, 148)
        Me.costTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(68, 20)
        Me.costTextBox.TabIndex = 57
        '
        'powerRatingTextBox
        '
        Me.powerRatingTextBox.Location = New System.Drawing.Point(152, 76)
        Me.powerRatingTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.powerRatingTextBox.Name = "powerRatingTextBox"
        Me.powerRatingTextBox.Size = New System.Drawing.Size(68, 20)
        Me.powerRatingTextBox.TabIndex = 56
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(145, 179)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(67, 23)
        Me.calculateButton.TabIndex = 55
        Me.calculateButton.Text = "Kuva"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'applianceLabel
        '
        Me.applianceLabel.AutoSize = True
        Me.applianceLabel.Location = New System.Drawing.Point(38, 56)
        Me.applianceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.applianceLabel.Name = "applianceLabel"
        Me.applianceLabel.Size = New System.Drawing.Size(105, 13)
        Me.applianceLabel.TabIndex = 54
        Me.applianceLabel.Text = "Vali tüüpkodumasin: "
        '
        'applianceComboBox
        '
        Me.applianceComboBox.FormattingEnabled = True
        Me.applianceComboBox.Location = New System.Drawing.Point(152, 54)
        Me.applianceComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.applianceComboBox.Name = "applianceComboBox"
        Me.applianceComboBox.Size = New System.Drawing.Size(153, 21)
        Me.applianceComboBox.TabIndex = 53
        '
        'formCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 227)
        Me.Controls.Add(Me.Label2)
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

    Friend WithEvents Label2 As Label
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
