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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.electricityRateTextBox = New System.Windows.Forms.TextBox()
        Me.timeUsedTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costTextBox = New System.Windows.Forms.TextBox()
        Me.powerRatingTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.applianceComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "autofill börss"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Paketihind (kWh): "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Kasutamise aeg (h): "
        '
        'electricityRateTextBox
        '
        Me.electricityRateTextBox.Location = New System.Drawing.Point(202, 176)
        Me.electricityRateTextBox.Name = "electricityRateTextBox"
        Me.electricityRateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.electricityRateTextBox.TabIndex = 49
        '
        'timeUsedTextBox
        '
        Me.timeUsedTextBox.Location = New System.Drawing.Point(202, 139)
        Me.timeUsedTextBox.Name = "timeUsedTextBox"
        Me.timeUsedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.timeUsedTextBox.TabIndex = 48
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(247, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Otsing"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(166, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 30)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "Võrd"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(85, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 30)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "Kalk"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(4, 3)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 30)
        Me.btn_home.TabIndex = 44
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Orienteeruv hind: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Tarbimisvõimsus (W): "
        '
        'costTextBox
        '
        Me.costTextBox.Location = New System.Drawing.Point(202, 213)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 26)
        Me.costTextBox.TabIndex = 41
        '
        'powerRatingTextBox
        '
        Me.powerRatingTextBox.Location = New System.Drawing.Point(202, 102)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Vali tüüpkodumasin: "
        '
        'applianceComboBox
        '
        Me.applianceComboBox.FormattingEnabled = True
        Me.applianceComboBox.Location = New System.Drawing.Point(202, 67)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.electricityRateTextBox)
        Me.Controls.Add(Me.timeUsedTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.costTextBox)
        Me.Controls.Add(Me.powerRatingTextBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.applianceComboBox)
        Me.Name = "formCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rakendus_Kalkulaator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents electricityRateTextBox As TextBox
    Friend WithEvents timeUsedTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents costTextBox As TextBox
    Friend WithEvents powerRatingTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents applianceComboBox As ComboBox
End Class
