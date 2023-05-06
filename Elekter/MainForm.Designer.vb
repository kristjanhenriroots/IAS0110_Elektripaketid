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
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.btnCalcTimeFrame = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTimeFrame = New System.Windows.Forms.ComboBox()
        Me.tbCO2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.lblAverageNow = New System.Windows.Forms.Label()
        Me.lblAverageTF = New System.Windows.Forms.Label()
        Me.lblSavedPer = New System.Windows.Forms.Label()
        Me.chartPanel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jarjestamineComboBox = New System.Windows.Forms.ComboBox()
        Me.compareButton = New System.Windows.Forms.Button()
        Me.pakettCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbWeekAVG = New System.Windows.Forms.CheckBox()
        Me.cbProvider = New System.Windows.Forms.ComboBox()
        Me.cbPackage = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.dgvUniversalPackages = New System.Windows.Forms.DataGridView()
        Me.dgvFixedPackages = New System.Windows.Forms.DataGridView()
        Me.dgvBorsPackages = New System.Windows.Forms.DataGridView()
        Me.cbPackagesFilter = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.chartPanel.SuspendLayout()
        CType(Me.dgvUniversalPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFixedPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorsPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnCalcTimeFrame.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCalcTimeFrame.Location = New System.Drawing.Point(773, 82)
        Me.btnCalcTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcTimeFrame.Name = "btnCalcTimeFrame"
        Me.btnCalcTimeFrame.Size = New System.Drawing.Size(81, 36)
        Me.btnCalcTimeFrame.TabIndex = 70
        Me.btnCalcTimeFrame.Text = "Muuda kasutusaegu"
        Me.btnCalcTimeFrame.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(770, 45)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Kuva valik:"
        '
        'cbTimeFrame
        '
        Me.cbTimeFrame.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cbTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimeFrame.FormattingEnabled = True
        Me.cbTimeFrame.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbTimeFrame.Location = New System.Drawing.Point(773, 60)
        Me.cbTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTimeFrame.Name = "cbTimeFrame"
        Me.cbTimeFrame.Size = New System.Drawing.Size(82, 21)
        Me.cbTimeFrame.TabIndex = 68
        '
        'tbCO2
        '
        Me.tbCO2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbCO2.Location = New System.Drawing.Point(627, 521)
        Me.tbCO2.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCO2.Name = "tbCO2"
        Me.tbCO2.Size = New System.Drawing.Size(115, 20)
        Me.tbCO2.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(624, 506)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "CO2 jalajälg:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 524)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 508)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vali ajavahemik:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(117, 522)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(68, 20)
        Me.TextBox3.TabIndex = 62
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(33, 522)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 61
        '
        'tbRecTimeFrame
        '
        Me.tbRecTimeFrame.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tbRecTimeFrame.Location = New System.Drawing.Point(770, 146)
        Me.tbRecTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRecTimeFrame.Name = "tbRecTimeFrame"
        Me.tbRecTimeFrame.ReadOnly = True
        Me.tbRecTimeFrame.Size = New System.Drawing.Size(115, 20)
        Me.tbRecTimeFrame.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(765, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
        '
        'shrinkButton
        '
        Me.shrinkButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.shrinkButton.Location = New System.Drawing.Point(956, 31)
        Me.shrinkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.shrinkButton.Name = "shrinkButton"
        Me.shrinkButton.Size = New System.Drawing.Size(17, 16)
        Me.shrinkButton.TabIndex = 58
        Me.shrinkButton.Text = "-"
        Me.shrinkButton.UseVisualStyleBackColor = True
        '
        'enlargeButton
        '
        Me.enlargeButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.enlargeButton.Location = New System.Drawing.Point(956, 11)
        Me.enlargeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enlargeButton.Name = "enlargeButton"
        Me.enlargeButton.Size = New System.Drawing.Size(17, 16)
        Me.enlargeButton.TabIndex = 57
        Me.enlargeButton.Text = "+"
        Me.enlargeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 508)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Graafiku valik:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tulpdiagramm", "Tabeldiagramm"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 521)
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
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 52
        '
        'lblAverageNow
        '
        Me.lblAverageNow.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAverageNow.AutoSize = True
        Me.lblAverageNow.Location = New System.Drawing.Point(772, 174)
        Me.lblAverageNow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageNow.Name = "lblAverageNow"
        Me.lblAverageNow.Size = New System.Drawing.Size(82, 13)
        Me.lblAverageNow.TabIndex = 75
        Me.lblAverageNow.Text = "Keskmine hind: "
        '
        'lblAverageTF
        '
        Me.lblAverageTF.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAverageTF.AutoSize = True
        Me.lblAverageTF.Location = New System.Drawing.Point(772, 193)
        Me.lblAverageTF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageTF.Name = "lblAverageTF"
        Me.lblAverageTF.Size = New System.Drawing.Size(109, 13)
        Me.lblAverageTF.TabIndex = 76
        Me.lblAverageTF.Text = "Soovituslik keskmine:"
        '
        'lblSavedPer
        '
        Me.lblSavedPer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSavedPer.AutoSize = True
        Me.lblSavedPer.Location = New System.Drawing.Point(772, 215)
        Me.lblSavedPer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavedPer.Name = "lblSavedPer"
        Me.lblSavedPer.Size = New System.Drawing.Size(62, 13)
        Me.lblSavedPer.TabIndex = 77
        Me.lblSavedPer.Text = "Säästaksid:"
        '
        'chartPanel
        '
        Me.chartPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartPanel.AutoSize = True
        Me.chartPanel.Controls.Add(Me.dgvBorsPackages)
        Me.chartPanel.Controls.Add(Me.dgvFixedPackages)
        Me.chartPanel.Controls.Add(Me.dgvUniversalPackages)
        Me.chartPanel.Location = New System.Drawing.Point(34, 64)
        Me.chartPanel.Name = "chartPanel"
        Me.chartPanel.Size = New System.Drawing.Size(712, 429)
        Me.chartPanel.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(888, 464)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Järjestamise viis:"
        '
        'jarjestamineComboBox
        '
        Me.jarjestamineComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.jarjestamineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jarjestamineComboBox.FormattingEnabled = True
        Me.jarjestamineComboBox.Items.AddRange(New Object() {"A - Z", "Z - A", "Hind kasvav", "Hind kahanev"})
        Me.jarjestamineComboBox.Location = New System.Drawing.Point(891, 480)
        Me.jarjestamineComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.jarjestamineComboBox.Name = "jarjestamineComboBox"
        Me.jarjestamineComboBox.Size = New System.Drawing.Size(82, 21)
        Me.jarjestamineComboBox.TabIndex = 83
        '
        'compareButton
        '
        Me.compareButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.compareButton.Location = New System.Drawing.Point(775, 479)
        Me.compareButton.Margin = New System.Windows.Forms.Padding(2)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(81, 20)
        Me.compareButton.TabIndex = 82
        Me.compareButton.Text = "Võrdle pakette"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'pakettCheckedListBox
        '
        Me.pakettCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pakettCheckedListBox.CheckOnClick = True
        Me.pakettCheckedListBox.FormattingEnabled = True
        Me.pakettCheckedListBox.Location = New System.Drawing.Point(775, 340)
        Me.pakettCheckedListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.pakettCheckedListBox.Name = "pakettCheckedListBox"
        Me.pakettCheckedListBox.Size = New System.Drawing.Size(198, 124)
        Me.pakettCheckedListBox.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(772, 317)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Pakettide nimekiri:"
        '
        'cbWeekAVG
        '
        Me.cbWeekAVG.AutoSize = True
        Me.cbWeekAVG.Location = New System.Drawing.Point(200, 41)
        Me.cbWeekAVG.Name = "cbWeekAVG"
        Me.cbWeekAVG.Size = New System.Drawing.Size(108, 17)
        Me.cbWeekAVG.TabIndex = 90
        Me.cbWeekAVG.Text = "Nädala keskmine"
        Me.cbWeekAVG.UseVisualStyleBackColor = True
        '
        'cbProvider
        '
        Me.cbProvider.FormattingEnabled = True
        Me.cbProvider.Location = New System.Drawing.Point(356, 520)
        Me.cbProvider.Name = "cbProvider"
        Me.cbProvider.Size = New System.Drawing.Size(121, 21)
        Me.cbProvider.TabIndex = 91
        '
        'cbPackage
        '
        Me.cbPackage.FormattingEnabled = True
        Me.cbPackage.Location = New System.Drawing.Point(483, 520)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(121, 21)
        Me.cbPackage.TabIndex = 92
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(772, 519)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(83, 25)
        Me.btnConfirm.TabIndex = 93
        Me.btnConfirm.Text = "Kinnita"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblProvider
        '
        Me.lblProvider.AutoSize = True
        Me.lblProvider.Location = New System.Drawing.Point(353, 506)
        Me.lblProvider.Name = "lblProvider"
        Me.lblProvider.Size = New System.Drawing.Size(49, 13)
        Me.lblProvider.TabIndex = 94
        Me.lblProvider.Text = "Pakkuja:"
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(483, 506)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(41, 13)
        Me.lblPackage.TabIndex = 95
        Me.lblPackage.Text = "Pakett:"
        '
        'dgvUniversalPackages
        '
        Me.dgvUniversalPackages.AllowUserToAddRows = False
        Me.dgvUniversalPackages.AllowUserToDeleteRows = False
        Me.dgvUniversalPackages.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvUniversalPackages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUniversalPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUniversalPackages.Location = New System.Drawing.Point(0, 0)
        Me.dgvUniversalPackages.Name = "dgvUniversalPackages"
        Me.dgvUniversalPackages.ReadOnly = True
        Me.dgvUniversalPackages.Size = New System.Drawing.Size(709, 123)
        Me.dgvUniversalPackages.TabIndex = 0
        '
        'dgvFixedPackages
        '
        Me.dgvFixedPackages.AllowUserToAddRows = False
        Me.dgvFixedPackages.AllowUserToDeleteRows = False
        Me.dgvFixedPackages.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvFixedPackages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFixedPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFixedPackages.Location = New System.Drawing.Point(0, 151)
        Me.dgvFixedPackages.Name = "dgvFixedPackages"
        Me.dgvFixedPackages.ReadOnly = True
        Me.dgvFixedPackages.Size = New System.Drawing.Size(709, 123)
        Me.dgvFixedPackages.TabIndex = 1
        '
        'dgvBorsPackages
        '
        Me.dgvBorsPackages.AllowUserToAddRows = False
        Me.dgvBorsPackages.AllowUserToDeleteRows = False
        Me.dgvBorsPackages.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBorsPackages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBorsPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorsPackages.Location = New System.Drawing.Point(-1, 303)
        Me.dgvBorsPackages.Name = "dgvBorsPackages"
        Me.dgvBorsPackages.ReadOnly = True
        Me.dgvBorsPackages.Size = New System.Drawing.Size(709, 123)
        Me.dgvBorsPackages.TabIndex = 2
        '
        'cbPackagesFilter
        '
        Me.cbPackagesFilter.FormattingEnabled = True
        Me.cbPackagesFilter.Location = New System.Drawing.Point(775, 243)
        Me.cbPackagesFilter.Name = "cbPackagesFilter"
        Me.cbPackagesFilter.Size = New System.Drawing.Size(121, 21)
        Me.cbPackagesFilter.TabIndex = 96
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(775, 283)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 97
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(902, 243)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 98
        Me.btnFilter.Text = "filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.cbPackagesFilter)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.lblProvider)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.cbPackage)
        Me.Controls.Add(Me.cbProvider)
        Me.Controls.Add(Me.cbWeekAVG)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.jarjestamineComboBox)
        Me.Controls.Add(Me.compareButton)
        Me.Controls.Add(Me.pakettCheckedListBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblSavedPer)
        Me.Controls.Add(Me.lblAverageTF)
        Me.Controls.Add(Me.lblAverageNow)
        Me.Controls.Add(Me.otsingButton)
        Me.Controls.Add(Me.vordlusButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.btnCalcTimeFrame)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbTimeFrame)
        Me.Controls.Add(Me.tbCO2)
        Me.Controls.Add(Me.Label8)
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
        Me.Controls.Add(Me.chartPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.chartPanel.ResumeLayout(False)
        CType(Me.dgvUniversalPackages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFixedPackages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorsPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents otsingButton As Button
    Friend WithEvents vordlusButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents homeButton As Button
    Friend WithEvents btnCalcTimeFrame As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTimeFrame As ComboBox
    Friend WithEvents tbCO2 As TextBox
    Friend WithEvents Label8 As Label
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
    Friend WithEvents lblAverageNow As Label
    Friend WithEvents lblAverageTF As Label
    Friend WithEvents lblSavedPer As Label
    Friend WithEvents chartPanel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents jarjestamineComboBox As ComboBox
    Friend WithEvents compareButton As Button
    Friend WithEvents pakettCheckedListBox As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbWeekAVG As CheckBox
    Friend WithEvents cbProvider As ComboBox
    Friend WithEvents cbPackage As ComboBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblProvider As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents dgvUniversalPackages As DataGridView
    Friend WithEvents dgvBorsPackages As DataGridView
    Friend WithEvents dgvFixedPackages As DataGridView
    Friend WithEvents cbPackagesFilter As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnFilter As Button
End Class
'=======
'﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
'Partial Class MainForm
'    Inherits System.Windows.Forms.Form

'    'Form overrides dispose to clean up the component list.
'    <System.Diagnostics.DebuggerNonUserCode()>
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    <System.Diagnostics.DebuggerStepThrough()>
'    Private Sub InitializeComponent()
'        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
'        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
'        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
'        Me.MainChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
'        Me.otsingButton = New System.Windows.Forms.Button()
'        Me.vordlusButton = New System.Windows.Forms.Button()
'        Me.calcButton = New System.Windows.Forms.Button()
'        Me.homeButton = New System.Windows.Forms.Button()
'        Me.Button3 = New System.Windows.Forms.Button()
'        Me.Label9 = New System.Windows.Forms.Label()
'        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
'        Me.TextBox4 = New System.Windows.Forms.TextBox()
'        Me.Label8 = New System.Windows.Forms.Label()
'        Me.Label7 = New System.Windows.Forms.Label()
'        Me.Label6 = New System.Windows.Forms.Label()
'        Me.Label5 = New System.Windows.Forms.Label()
'        Me.TextBox1 = New System.Windows.Forms.TextBox()
'        Me.Label4 = New System.Windows.Forms.Label()
'        Me.shrinkButton = New System.Windows.Forms.Button()
'        Me.enlargeButton = New System.Windows.Forms.Button()
'        Me.Label3 = New System.Windows.Forms.Label()
'        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
'        Me.Label2 = New System.Windows.Forms.Label()
'        Me.Label1 = New System.Windows.Forms.Label()
'        Me.cbStartTime = New System.Windows.Forms.ComboBox()
'        Me.cbEndTime = New System.Windows.Forms.ComboBox()
'        Me.btnFindPackage = New System.Windows.Forms.Button()
'        Me.cbProvider = New System.Windows.Forms.ComboBox()
'        Me.cbPakett = New System.Windows.Forms.ComboBox()
'        Me.lblPackages = New System.Windows.Forms.Label()
'        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'MainChart
'        '
'        ChartArea2.Name = "ChartArea1"
'        Me.MainChart.ChartAreas.Add(ChartArea2)
'        Legend2.Name = "Legend1"
'        Me.MainChart.Legends.Add(Legend2)
'        Me.MainChart.Location = New System.Drawing.Point(34, 65)
'        Me.MainChart.Margin = New System.Windows.Forms.Padding(2)
'        Me.MainChart.Name = "MainChart"
'        Series2.ChartArea = "ChartArea1"
'        Series2.Legend = "Legend1"
'        Series2.Name = "Series1"
'        Me.MainChart.Series.Add(Series2)
'        Me.MainChart.Size = New System.Drawing.Size(351, 195)
'        Me.MainChart.TabIndex = 0
'        Me.MainChart.Text = "MainChart"
'        '
'        'otsingButton
'        '
'        Me.otsingButton.Location = New System.Drawing.Point(173, 11)
'        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.otsingButton.Name = "otsingButton"
'        Me.otsingButton.Size = New System.Drawing.Size(50, 20)
'        Me.otsingButton.TabIndex = 74
'        Me.otsingButton.Text = "Otsing"
'        Me.otsingButton.UseVisualStyleBackColor = True
'        '
'        'vordlusButton
'        '
'        Me.vordlusButton.Location = New System.Drawing.Point(119, 11)
'        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.vordlusButton.Name = "vordlusButton"
'        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
'        Me.vordlusButton.TabIndex = 73
'        Me.vordlusButton.Text = "Võrd"
'        Me.vordlusButton.UseVisualStyleBackColor = True
'        '
'        'calcButton
'        '
'        Me.calcButton.Location = New System.Drawing.Point(65, 11)
'        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.calcButton.Name = "calcButton"
'        Me.calcButton.Size = New System.Drawing.Size(50, 20)
'        Me.calcButton.TabIndex = 72
'        Me.calcButton.Text = "Kalk"
'        Me.calcButton.UseVisualStyleBackColor = True
'        '
'        'homeButton
'        '
'        Me.homeButton.Location = New System.Drawing.Point(11, 11)
'        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.homeButton.Name = "homeButton"
'        Me.homeButton.Size = New System.Drawing.Size(50, 20)
'        Me.homeButton.TabIndex = 71
'        Me.homeButton.Text = "Home"
'        Me.homeButton.UseVisualStyleBackColor = True
'        '
'        'Button3
'        '
'        Me.Button3.Location = New System.Drawing.Point(397, 102)
'        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
'        Me.Button3.Name = "Button3"
'        Me.Button3.Size = New System.Drawing.Size(81, 36)
'        Me.Button3.TabIndex = 70
'        Me.Button3.Text = "Muuda kasutusaegu"
'        Me.Button3.UseVisualStyleBackColor = True
'        '
'        'Label9
'        '
'        Me.Label9.AutoSize = True
'        Me.Label9.Location = New System.Drawing.Point(394, 65)
'        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label9.Name = "Label9"
'        Me.Label9.Size = New System.Drawing.Size(60, 13)
'        Me.Label9.TabIndex = 69
'        Me.Label9.Text = "Kuva valik:"
'        '
'        'ComboBox2
'        '
'        Me.ComboBox2.FormattingEnabled = True
'        Me.ComboBox2.Location = New System.Drawing.Point(397, 80)
'        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
'        Me.ComboBox2.Name = "ComboBox2"
'        Me.ComboBox2.Size = New System.Drawing.Size(82, 21)
'        Me.ComboBox2.TabIndex = 68
'        '
'        'TextBox4
'        '
'        Me.TextBox4.Location = New System.Drawing.Point(275, 276)
'        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
'        Me.TextBox4.Name = "TextBox4"
'        Me.TextBox4.Size = New System.Drawing.Size(115, 20)
'        Me.TextBox4.TabIndex = 67
'        '
'        'Label8
'        '
'        Me.Label8.AutoSize = True
'        Me.Label8.Location = New System.Drawing.Point(277, 262)
'        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label8.Name = "Label8"
'        Me.Label8.Size = New System.Drawing.Size(66, 13)
'        Me.Label8.TabIndex = 66
'        Me.Label8.Text = "CO2 jalajälg:"
'        '
'        'Label7
'        '
'        Me.Label7.AutoSize = True
'        Me.Label7.Location = New System.Drawing.Point(243, 43)
'        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label7.Name = "Label7"
'        Me.Label7.Size = New System.Drawing.Size(154, 13)
'        Me.Label7.TabIndex = 65
'        Me.Label7.Text = "Hetkel valitud kuva: Kinnisvara"
'        '
'        'Label6
'        '
'        Me.Label6.AutoSize = True
'        Me.Label6.Location = New System.Drawing.Point(104, 278)
'        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label6.Name = "Label6"
'        Me.Label6.Size = New System.Drawing.Size(10, 13)
'        Me.Label6.TabIndex = 64
'        Me.Label6.Text = "-"
'        '
'        'Label5
'        '
'        Me.Label5.AutoSize = True
'        Me.Label5.Location = New System.Drawing.Point(31, 262)
'        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label5.Name = "Label5"
'        Me.Label5.Size = New System.Drawing.Size(84, 13)
'        Me.Label5.TabIndex = 63
'        Me.Label5.Text = "Vali ajavahemik:"
'        '
'        'TextBox1
'        '
'        Me.TextBox1.Location = New System.Drawing.Point(394, 166)
'        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
'        Me.TextBox1.Name = "TextBox1"
'        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
'        Me.TextBox1.TabIndex = 60
'        '
'        'Label4
'        '
'        Me.Label4.AutoSize = True
'        Me.Label4.Location = New System.Drawing.Point(389, 151)
'        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label4.Name = "Label4"
'        Me.Label4.Size = New System.Drawing.Size(123, 13)
'        Me.Label4.TabIndex = 59
'        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
'        '
'        'shrinkButton
'        '
'        Me.shrinkButton.Location = New System.Drawing.Point(490, 290)
'        Me.shrinkButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.shrinkButton.Name = "shrinkButton"
'        Me.shrinkButton.Size = New System.Drawing.Size(17, 16)
'        Me.shrinkButton.TabIndex = 58
'        Me.shrinkButton.Text = "-"
'        Me.shrinkButton.UseVisualStyleBackColor = True
'        '
'        'enlargeButton
'        '
'        Me.enlargeButton.Location = New System.Drawing.Point(490, 269)
'        Me.enlargeButton.Margin = New System.Windows.Forms.Padding(2)
'        Me.enlargeButton.Name = "enlargeButton"
'        Me.enlargeButton.Size = New System.Drawing.Size(17, 16)
'        Me.enlargeButton.TabIndex = 57
'        Me.enlargeButton.Text = "+"
'        Me.enlargeButton.UseVisualStyleBackColor = True
'        '
'        'Label3
'        '
'        Me.Label3.AutoSize = True
'        Me.Label3.Location = New System.Drawing.Point(185, 262)
'        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label3.Name = "Label3"
'        Me.Label3.Size = New System.Drawing.Size(75, 13)
'        Me.Label3.TabIndex = 56
'        Me.Label3.Text = "Graafiku valik:"
'        '
'        'ComboBox1
'        '
'        Me.ComboBox1.FormattingEnabled = True
'        Me.ComboBox1.Items.AddRange(New Object() {"Tulpdiagramm", "Tabeldiagramm"})
'        Me.ComboBox1.Location = New System.Drawing.Point(188, 275)
'        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
'        Me.ComboBox1.Name = "ComboBox1"
'        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
'        Me.ComboBox1.TabIndex = 55
'        '
'        'Label2
'        '
'        Me.Label2.AutoSize = True
'        Me.Label2.Location = New System.Drawing.Point(31, 43)
'        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label2.Name = "Label2"
'        Me.Label2.Size = New System.Drawing.Size(164, 13)
'        Me.Label2.TabIndex = 53
'        Me.Label2.Text = "Hetkel valitud pakett: Börsipakett"
'        '
'        'Label1
'        '
'        Me.Label1.AutoSize = True
'        Me.Label1.Location = New System.Drawing.Point(415, 18)
'        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
'        Me.Label1.Name = "Label1"
'        Me.Label1.Size = New System.Drawing.Size(91, 13)
'        Me.Label1.TabIndex = 52
'        Me.Label1.Text = "Tere, <Kasutaja>!"
'        '
'        'cbStartTime
'        '
'        Me.cbStartTime.FormattingEnabled = True
'        Me.cbStartTime.Location = New System.Drawing.Point(34, 276)
'        Me.cbStartTime.Name = "cbStartTime"
'        Me.cbStartTime.Size = New System.Drawing.Size(68, 21)
'        Me.cbStartTime.TabIndex = 75
'        '
'        'cbEndTime
'        '
'        Me.cbEndTime.FormattingEnabled = True
'        Me.cbEndTime.Location = New System.Drawing.Point(115, 276)
'        Me.cbEndTime.Name = "cbEndTime"
'        Me.cbEndTime.Size = New System.Drawing.Size(68, 21)
'        Me.cbEndTime.TabIndex = 76
'        '
'        'btnFindPackage
'        '
'        Me.btnFindPackage.Location = New System.Drawing.Point(403, 275)
'        Me.btnFindPackage.Name = "btnFindPackage"
'        Me.btnFindPackage.Size = New System.Drawing.Size(75, 23)
'        Me.btnFindPackage.TabIndex = 77
'        Me.btnFindPackage.Text = "Otsi paketti"
'        Me.btnFindPackage.UseVisualStyleBackColor = True
'        '
'        'cbProvider
'        '
'        Me.cbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
'        Me.cbProvider.FormattingEnabled = True
'        Me.cbProvider.Location = New System.Drawing.Point(34, 317)
'        Me.cbProvider.Name = "cbProvider"
'        Me.cbProvider.Size = New System.Drawing.Size(122, 21)
'        Me.cbProvider.TabIndex = 78
'        '
'        'cbPakett
'        '
'        Me.cbPakett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
'        Me.cbPakett.FormattingEnabled = True
'        Me.cbPakett.Location = New System.Drawing.Point(162, 317)
'        Me.cbPakett.Name = "cbPakett"
'        Me.cbPakett.Size = New System.Drawing.Size(145, 21)
'        Me.cbPakett.TabIndex = 79
'        '
'        'lblPackages
'        '
'        Me.lblPackages.AutoSize = True
'        Me.lblPackages.Location = New System.Drawing.Point(31, 301)
'        Me.lblPackages.Name = "lblPackages"
'        Me.lblPackages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
'        Me.lblPackages.Size = New System.Drawing.Size(131, 13)
'        Me.lblPackages.TabIndex = 80
'        Me.lblPackages.Text = "Vali pakkuja ja börsipakett"
'        '
'        'MainForm
'        '
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(532, 341)
'        Me.Controls.Add(Me.lblPackages)
'        Me.Controls.Add(Me.cbPakett)
'        Me.Controls.Add(Me.cbProvider)
'        Me.Controls.Add(Me.btnFindPackage)
'        Me.Controls.Add(Me.cbEndTime)
'        Me.Controls.Add(Me.cbStartTime)
'        Me.Controls.Add(Me.otsingButton)
'        Me.Controls.Add(Me.vordlusButton)
'        Me.Controls.Add(Me.calcButton)
'        Me.Controls.Add(Me.homeButton)
'        Me.Controls.Add(Me.Button3)
'        Me.Controls.Add(Me.Label9)
'        Me.Controls.Add(Me.ComboBox2)
'        Me.Controls.Add(Me.TextBox4)
'        Me.Controls.Add(Me.Label8)
'        Me.Controls.Add(Me.Label7)
'        Me.Controls.Add(Me.Label6)
'        Me.Controls.Add(Me.Label5)
'        Me.Controls.Add(Me.TextBox1)
'        Me.Controls.Add(Me.Label4)
'        Me.Controls.Add(Me.shrinkButton)
'        Me.Controls.Add(Me.enlargeButton)
'        Me.Controls.Add(Me.Label3)
'        Me.Controls.Add(Me.ComboBox1)
'        Me.Controls.Add(Me.Label2)
'        Me.Controls.Add(Me.Label1)
'        Me.Controls.Add(Me.MainChart)
'        Me.Margin = New System.Windows.Forms.Padding(2)
'        Me.Name = "MainForm"
'        Me.Text = "MainForm"
'        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub

'    Friend WithEvents MainChart As DataVisualization.Charting.Chart
'    Friend WithEvents otsingButton As Button
'    Friend WithEvents vordlusButton As Button
'    Friend WithEvents calcButton As Button
'    Friend WithEvents homeButton As Button
'    Friend WithEvents Button3 As Button
'    Friend WithEvents Label9 As Label
'    Friend WithEvents ComboBox2 As ComboBox
'    Friend WithEvents TextBox4 As TextBox
'    Friend WithEvents Label8 As Label
'    Friend WithEvents Label7 As Label
'    Friend WithEvents Label6 As Label
'    Friend WithEvents Label5 As Label
'    Friend WithEvents TextBox1 As TextBox
'    Friend WithEvents Label4 As Label
'    Friend WithEvents shrinkButton As Button
'    Friend WithEvents enlargeButton As Button
'    Friend WithEvents Label3 As Label
'    Friend WithEvents ComboBox1 As ComboBox
'    Friend WithEvents Label2 As Label
'    Friend WithEvents Label1 As Label
'    Friend WithEvents cbStartTime As ComboBox
'    Friend WithEvents cbEndTime As ComboBox
'    Friend WithEvents btnFindPackage As Button
'    Friend WithEvents cbProvider As ComboBox
'    Friend WithEvents cbPakett As ComboBox
'    Friend WithEvents lblPackages As Label
'End Class
'>>>>>>> Temp form for testing. Added solution to tempform.
