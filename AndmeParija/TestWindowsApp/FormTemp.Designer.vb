<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTemp
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
        Me.tbMargins = New System.Windows.Forms.TextBox()
        Me.dgvTimePrice = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTimePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMargins
        '
        Me.tbMargins.Location = New System.Drawing.Point(12, 12)
        Me.tbMargins.Multiline = True
        Me.tbMargins.Name = "tbMargins"
        Me.tbMargins.ReadOnly = True
        Me.tbMargins.Size = New System.Drawing.Size(417, 296)
        Me.tbMargins.TabIndex = 0
        '
        'dgvTimePrice
        '
        Me.dgvTimePrice.AllowUserToAddRows = False
        Me.dgvTimePrice.AllowUserToDeleteRows = False
        Me.dgvTimePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimePrice.Location = New System.Drawing.Point(463, 22)
        Me.dgvTimePrice.Name = "dgvTimePrice"
        Me.dgvTimePrice.ReadOnly = True
        Me.dgvTimePrice.Size = New System.Drawing.Size(240, 150)
        Me.dgvTimePrice.TabIndex = 1
        '
        'FormTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvTimePrice)
        Me.Controls.Add(Me.tbMargins)
        Me.Name = "FormTemp"
        Me.Text = "FormTemp"
        CType(Me.dgvTimePrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMargins As TextBox
    Friend WithEvents dgvTimePrice As DataGridView
End Class
