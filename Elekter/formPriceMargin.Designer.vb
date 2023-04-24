<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPriceMargin
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
        Me.tbPriceMargins = New System.Windows.Forms.TextBox()
        Me.dgvTimePrice = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTimePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPriceMargins
        '
        Me.tbPriceMargins.Location = New System.Drawing.Point(12, 12)
        Me.tbPriceMargins.Multiline = True
        Me.tbPriceMargins.Name = "tbPriceMargins"
        Me.tbPriceMargins.ReadOnly = True
        Me.tbPriceMargins.Size = New System.Drawing.Size(308, 426)
        Me.tbPriceMargins.TabIndex = 0
        '
        'dgvTimePrice
        '
        Me.dgvTimePrice.AllowUserToAddRows = False
        Me.dgvTimePrice.AllowUserToDeleteRows = False
        Me.dgvTimePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimePrice.Location = New System.Drawing.Point(348, 12)
        Me.dgvTimePrice.Name = "dgvTimePrice"
        Me.dgvTimePrice.ReadOnly = True
        Me.dgvTimePrice.Size = New System.Drawing.Size(301, 280)
        Me.dgvTimePrice.TabIndex = 1
        '
        'formPriceMargin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 453)
        Me.Controls.Add(Me.dgvTimePrice)
        Me.Controls.Add(Me.tbPriceMargins)
        Me.Name = "formPriceMargin"
        Me.Text = "Leitud paketti hinnad"
        CType(Me.dgvTimePrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPriceMargins As TextBox
    Friend WithEvents dgvTimePrice As DataGridView
End Class
