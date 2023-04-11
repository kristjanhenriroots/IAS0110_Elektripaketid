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
        Me.Label2.Location = New System.Drawing.Point(328, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "autofill börss"
        '
        'electricityRateLabel
        '
        Me.electricityRateLabel.AutoSize = True
        Me.electricityRateLabel.Location = New System.Drawing.Point(61, 179)
        Me.electricityRateLabel.Name = "electricityRateLabel"
        Me.electricityRateLabel.Size = New System.Drawing.Size(137, 20)
        Me.electricityRateLabel.TabIndex = 51
        Me.electricityRateLabel.Text = "Paketihind (kWh): "
        '
        'timeUsedLabel
        '
        Me.timeUsedLabel.AutoSize = True
        Me.timeUsedLabel.Location = New System.Drawing.Point(44, 142)
        Me.timeUsedLabel.Name = "timeUsedLabel"
        Me.timeUsedLabel.Size = New System.Drawing.Size(154, 20)
        Me.timeUsedLabel.TabIndex = 50
        Me.timeUsedLabel.Text = "Kasutamise aeg (h): "
        '
        'electricityRateTextBox
        '
        Me.electricityRateTextBox.Location = New System.Drawing.Point(213, 176)
        Me.electricityRateTextBox.Name = "electricityRateTextBox"
        Me.electricityRateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.electricityRateTextBox.TabIndex = 49
        '
        'timeUsedTextBox
        '
        Me.timeUsedTextBox.Location = New System.Drawing.Point(213, 139)
        Me.timeUsedTextBox.Name = "timeUsedTextBox"
        Me.timeUsedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.timeUsedTextBox.TabIndex = 48
        '
        'otsingButton
        '
        Me.otsingButton.Location = New System.Drawing.Point(247, 3)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(75, 30)
        Me.otsingButton.TabIndex = 47
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(166, 3)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(75, 30)
        Me.vordlusButton.TabIndex = 46
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(85, 3)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 30)
        Me.calcButton.TabIndex = 45
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(4, 3)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(75, 30)
        Me.homeButton.TabIndex = 44
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(65, 213)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(133, 20)
        Me.costLabel.TabIndex = 43
        Me.costLabel.Text = "Orienteeruv hind: "
        '
        'powerRatingLabel
        '
        Me.powerRatingLabel.AutoSize = True
        Me.powerRatingLabel.Location = New System.Drawing.Point(36, 105)
        Me.powerRatingLabel.Name = "powerRatingLabel"
        Me.powerRatingLabel.Size = New System.Drawing.Size(162, 20)
        Me.powerRatingLabel.TabIndex = 42
        Me.powerRatingLabel.Text = "Tarbimisvõimsus (W): "
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(213, 213)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 26)
        Me.costTextBox.TabIndex = 41
        '
        'powerRatingTextBox
        '
        Me.powerRatingTextBox.Location = New System.Drawing.Point(213, 102)
        Me.powerRatingTextBox.Name = "powerRatingTextBox"
        Me.powerRatingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.powerRatingTextBox.TabIndex = 40
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(202, 260)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 35)
        Me.calculateButton.TabIndex = 39
        Me.calculateButton.Text = "Kuva"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'applianceLabel
        '
        Me.applianceLabel.AutoSize = True
        Me.applianceLabel.Location = New System.Drawing.Point(42, 71)
        Me.applianceLabel.Name = "applianceLabel"
        Me.applianceLabel.Size = New System.Drawing.Size(156, 20)
        Me.applianceLabel.TabIndex = 38
        Me.applianceLabel.Text = "Vali tüüpkodumasin: "
        '
        'applianceComboBox
        '
        Me.applianceComboBox.FormattingEnabled = True
        Me.applianceComboBox.Location = New System.Drawing.Point(213, 67)
        Me.applianceComboBox.Name = "applianceComboBox"
        Me.applianceComboBox.Size = New System.Drawing.Size(227, 28)
        Me.applianceComboBox.TabIndex = 37
        '
        'formCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 343)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rakendus_Kalkulaator"
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
