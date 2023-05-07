<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formExport
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
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblQval = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtQval = New System.Windows.Forms.TextBox()
        Me.cbOverwrite = New System.Windows.Forms.CheckBox()
        Me.btnChangePath = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(75, 42)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(45, 13)
        Me.lblSeparator.TabIndex = 0
        Me.lblSeparator.Text = "Eraldaja"
        '
        'lblQval
        '
        Me.lblQval.AutoSize = True
        Me.lblQval.Location = New System.Drawing.Point(75, 79)
        Me.lblQval.Name = "lblQval"
        Me.lblQval.Size = New System.Drawing.Size(65, 13)
        Me.lblQval.TabIndex = 1
        Me.lblQval.Text = "Kvalifikaator"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(75, 115)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(23, 13)
        Me.lblPath.TabIndex = 2
        Me.lblPath.Text = "Fail"
        '
        'txtSeparator
        '
        Me.txtSeparator.Location = New System.Drawing.Point(142, 42)
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(100, 20)
        Me.txtSeparator.TabIndex = 3
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(142, 115)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(239, 20)
        Me.txtPath.TabIndex = 4
        '
        'txtQval
        '
        Me.txtQval.Location = New System.Drawing.Point(142, 79)
        Me.txtQval.Name = "txtQval"
        Me.txtQval.Size = New System.Drawing.Size(100, 20)
        Me.txtQval.TabIndex = 5
        '
        'cbOverwrite
        '
        Me.cbOverwrite.AutoSize = True
        Me.cbOverwrite.Location = New System.Drawing.Point(263, 198)
        Me.cbOverwrite.Name = "cbOverwrite"
        Me.cbOverwrite.Size = New System.Drawing.Size(72, 17)
        Me.cbOverwrite.TabIndex = 6
        Me.cbOverwrite.Text = "Kirjuta üle"
        Me.cbOverwrite.UseVisualStyleBackColor = True
        '
        'btnChangePath
        '
        Me.btnChangePath.Location = New System.Drawing.Point(142, 154)
        Me.btnChangePath.Name = "btnChangePath"
        Me.btnChangePath.Size = New System.Drawing.Size(75, 23)
        Me.btnChangePath.TabIndex = 7
        Me.btnChangePath.Text = "Muuda"
        Me.btnChangePath.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(142, 192)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Salvesta"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'formExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 265)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnChangePath)
        Me.Controls.Add(Me.cbOverwrite)
        Me.Controls.Add(Me.txtQval)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtSeparator)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblQval)
        Me.Controls.Add(Me.lblSeparator)
        Me.Name = "formExport"
        Me.Text = "CSV export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblQval As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents txtSeparator As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents txtQval As TextBox
    Friend WithEvents cbOverwrite As CheckBox
    Friend WithEvents btnChangePath As Button
    Friend WithEvents btnExport As Button
End Class
