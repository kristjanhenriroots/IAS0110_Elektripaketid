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
<<<<<<< HEAD
        Me.Label1 = New System.Windows.Forms.Label()
=======
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.btnCalcTimeFrame = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTimeFrame = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.packageChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label7 = New System.Windows.Forms.Label()
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jarjestamineComboBox = New System.Windows.Forms.ComboBox()
        Me.compareButton = New System.Windows.Forms.Button()
        Me.pakettCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label12 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTimeFrame = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbRecTimeFrame = New System.Windows.Forms.TextBox()
        Me.btnCalcTimeFrame = New System.Windows.Forms.Button()
        Me.lblSavedPer = New System.Windows.Forms.Label()
        Me.lblAverageTF = New System.Windows.Forms.Label()
        Me.lblAverageNow = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelAdditionalRanges = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelNavbar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vordlusButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.otsingButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.chartPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.panelAdditionalRanges.SuspendLayout()
        Me.panelNavbar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
=======
        CType(Me.packageChart, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.SuspendLayout()
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
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Filter 1", "Filter 2"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(127, 302)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(82, 34)
        Me.CheckedListBox2.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(124, 279)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Filtreeri pakette:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 227)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Järjestamise viis:"
        '
        'jarjestamineComboBox
        '
<<<<<<< HEAD
        Me.jarjestamineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jarjestamineComboBox.FormattingEnabled = True
        Me.jarjestamineComboBox.Items.AddRange(New Object() {"A - Z", "Z - A", "Hind kasvav", "Hind kahanev"})
        Me.jarjestamineComboBox.Location = New System.Drawing.Point(127, 250)
        Me.jarjestamineComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.jarjestamineComboBox.Name = "jarjestamineComboBox"
        Me.jarjestamineComboBox.Size = New System.Drawing.Size(82, 21)
        Me.jarjestamineComboBox.TabIndex = 83
        '
        'compareButton
        '
        Me.compareButton.Location = New System.Drawing.Point(20, 389)
        Me.compareButton.Margin = New System.Windows.Forms.Padding(2)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(81, 20)
        Me.compareButton.TabIndex = 82
        Me.compareButton.Text = "Võrdle pakette"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'pakettCheckedListBox
        '
        Me.pakettCheckedListBox.CheckOnClick = True
        Me.pakettCheckedListBox.FormattingEnabled = True
        Me.pakettCheckedListBox.Location = New System.Drawing.Point(20, 250)
        Me.pakettCheckedListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.pakettCheckedListBox.Name = "pakettCheckedListBox"
        Me.pakettCheckedListBox.Size = New System.Drawing.Size(90, 124)
        Me.pakettCheckedListBox.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 227)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Pakettide nimekiri:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CheckedListBox2)
        Me.Panel1.Controls.Add(Me.lblAverageNow)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblAverageTF)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblSavedPer)
        Me.Panel1.Controls.Add(Me.jarjestamineComboBox)
        Me.Panel1.Controls.Add(Me.btnCalcTimeFrame)
        Me.Panel1.Controls.Add(Me.compareButton)
        Me.Panel1.Controls.Add(Me.tbRecTimeFrame)
        Me.Panel1.Controls.Add(Me.pakettCheckedListBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbTimeFrame)
        Me.Panel1.Location = New System.Drawing.Point(953, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 429)
        Me.Panel1.TabIndex = 82
        '
        'cbTimeFrame
        '
        Me.cbTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimeFrame.FormattingEnabled = True
        Me.cbTimeFrame.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbTimeFrame.Location = New System.Drawing.Point(20, 26)
        Me.cbTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTimeFrame.Name = "cbTimeFrame"
        Me.cbTimeFrame.Size = New System.Drawing.Size(82, 21)
        Me.cbTimeFrame.TabIndex = 68
=======
        Me.btnCalcTimeFrame.Location = New System.Drawing.Point(774, 67)
        Me.btnCalcTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcTimeFrame.Name = "btnCalcTimeFrame"
        Me.btnCalcTimeFrame.Size = New System.Drawing.Size(81, 36)
        Me.btnCalcTimeFrame.TabIndex = 70
        Me.btnCalcTimeFrame.Text = "Muuda kasutusaegu"
        Me.btnCalcTimeFrame.UseVisualStyleBackColor = True
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
<<<<<<< HEAD
        Me.Label9.Location = New System.Drawing.Point(17, 11)
=======
        Me.Label9.Location = New System.Drawing.Point(771, 30)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Kuva valik:"
        '
        'tbRecTimeFrame
        '
<<<<<<< HEAD
        Me.tbRecTimeFrame.Location = New System.Drawing.Point(17, 112)
        Me.tbRecTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRecTimeFrame.Name = "tbRecTimeFrame"
        Me.tbRecTimeFrame.ReadOnly = True
        Me.tbRecTimeFrame.Size = New System.Drawing.Size(115, 20)
        Me.tbRecTimeFrame.TabIndex = 60
        '
        'btnCalcTimeFrame
        '
        Me.btnCalcTimeFrame.Location = New System.Drawing.Point(20, 48)
        Me.btnCalcTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcTimeFrame.Name = "btnCalcTimeFrame"
        Me.btnCalcTimeFrame.Size = New System.Drawing.Size(81, 51)
        Me.btnCalcTimeFrame.TabIndex = 70
        Me.btnCalcTimeFrame.Text = "Muuda kasutusaegu"
        Me.btnCalcTimeFrame.UseVisualStyleBackColor = True
        '
        'lblSavedPer
        '
        Me.lblSavedPer.AutoSize = True
        Me.lblSavedPer.Location = New System.Drawing.Point(19, 181)
        Me.lblSavedPer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavedPer.Name = "lblSavedPer"
        Me.lblSavedPer.Size = New System.Drawing.Size(62, 13)
        Me.lblSavedPer.TabIndex = 77
        Me.lblSavedPer.Text = "Säästaksid:"
        '
        'lblAverageTF
        '
        Me.lblAverageTF.AutoSize = True
        Me.lblAverageTF.Location = New System.Drawing.Point(19, 159)
        Me.lblAverageTF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageTF.Name = "lblAverageTF"
        Me.lblAverageTF.Size = New System.Drawing.Size(109, 13)
        Me.lblAverageTF.TabIndex = 76
        Me.lblAverageTF.Text = "Soovituslik keskmine:"
        '
        'lblAverageNow
        '
        Me.lblAverageNow.AutoSize = True
        Me.lblAverageNow.Location = New System.Drawing.Point(19, 140)
        Me.lblAverageNow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageNow.Name = "lblAverageNow"
        Me.lblAverageNow.Size = New System.Drawing.Size(82, 13)
        Me.lblAverageNow.TabIndex = 75
        Me.lblAverageNow.Text = "Keskmine hind: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
        '
        'panelAdditionalRanges
        '
        Me.panelAdditionalRanges.Controls.Add(Me.Label5)
        Me.panelAdditionalRanges.Controls.Add(Me.ComboBox1)
        Me.panelAdditionalRanges.Controls.Add(Me.Label3)
        Me.panelAdditionalRanges.Controls.Add(Me.TextBox2)
        Me.panelAdditionalRanges.Controls.Add(Me.TextBox3)
        Me.panelAdditionalRanges.Controls.Add(Me.Label6)
        Me.panelAdditionalRanges.Controls.Add(Me.Label8)
        Me.panelAdditionalRanges.Controls.Add(Me.TextBox4)
        Me.panelAdditionalRanges.Location = New System.Drawing.Point(3, 657)
        Me.panelAdditionalRanges.Name = "panelAdditionalRanges"
        Me.panelAdditionalRanges.Size = New System.Drawing.Size(373, 49)
        Me.panelAdditionalRanges.TabIndex = 81
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(246, 24)
=======
        Me.cbTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimeFrame.FormattingEnabled = True
        Me.cbTimeFrame.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbTimeFrame.Location = New System.Drawing.Point(774, 45)
        Me.cbTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTimeFrame.Name = "cbTimeFrame"
        Me.cbTimeFrame.Size = New System.Drawing.Size(82, 21)
        Me.cbTimeFrame.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(275, 525)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(115, 20)
        Me.TextBox4.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
<<<<<<< HEAD
        Me.Label8.Location = New System.Drawing.Point(248, 10)
=======
        Me.Label8.Location = New System.Drawing.Point(277, 511)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "CO2 jalajälg:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
<<<<<<< HEAD
        Me.Label6.Location = New System.Drawing.Point(75, 26)
=======
        Me.Label6.Location = New System.Drawing.Point(104, 527)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "-"
        '
<<<<<<< HEAD
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(88, 24)
=======
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 511)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vali ajavahemik:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 525)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(68, 20)
        Me.TextBox3.TabIndex = 62
        '
        'TextBox2
        '
<<<<<<< HEAD
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(4, 24)
=======
        Me.TextBox2.Location = New System.Drawing.Point(33, 525)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 61
        '
<<<<<<< HEAD
=======
        'tbRecTimeFrame
        '
        Me.tbRecTimeFrame.Location = New System.Drawing.Point(771, 131)
        Me.tbRecTimeFrame.Margin = New System.Windows.Forms.Padding(2)
        Me.tbRecTimeFrame.Name = "tbRecTimeFrame"
        Me.tbRecTimeFrame.ReadOnly = True
        Me.tbRecTimeFrame.Size = New System.Drawing.Size(115, 20)
        Me.tbRecTimeFrame.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(766, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Soovitatav tarbimiseaeg:"
        '
        'shrinkButton
        '
        Me.shrinkButton.Location = New System.Drawing.Point(867, 255)
        Me.shrinkButton.Margin = New System.Windows.Forms.Padding(2)
        Me.shrinkButton.Name = "shrinkButton"
        Me.shrinkButton.Size = New System.Drawing.Size(17, 16)
        Me.shrinkButton.TabIndex = 58
        Me.shrinkButton.Text = "-"
        Me.shrinkButton.UseVisualStyleBackColor = True
        '
        'enlargeButton
        '
        Me.enlargeButton.Location = New System.Drawing.Point(867, 234)
        Me.enlargeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enlargeButton.Name = "enlargeButton"
        Me.enlargeButton.Size = New System.Drawing.Size(17, 16)
        Me.enlargeButton.TabIndex = 57
        Me.enlargeButton.Text = "+"
        Me.enlargeButton.UseVisualStyleBackColor = True
        '
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        'Label3
        '
        Me.Label3.AutoSize = True
<<<<<<< HEAD
        Me.Label3.Location = New System.Drawing.Point(156, 10)
=======
        Me.Label3.Location = New System.Drawing.Point(185, 511)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Graafiku valik:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tulpdiagramm", "Tabeldiagramm"})
<<<<<<< HEAD
        Me.ComboBox1.Location = New System.Drawing.Point(159, 23)
=======
        Me.ComboBox1.Location = New System.Drawing.Point(188, 524)
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Vali ajavahemik:"
        '
        'panelNavbar
        '
        Me.panelNavbar.Controls.Add(Me.homeButton)
        Me.panelNavbar.Controls.Add(Me.otsingButton)
        Me.panelNavbar.Controls.Add(Me.calcButton)
        Me.panelNavbar.Controls.Add(Me.vordlusButton)
        Me.panelNavbar.Controls.Add(Me.Label2)
        Me.panelNavbar.Location = New System.Drawing.Point(3, 3)
        Me.panelNavbar.Name = "panelNavbar"
        Me.panelNavbar.Size = New System.Drawing.Size(281, 54)
        Me.panelNavbar.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Hetkel valitud pakett: Börsipakett"
        '
        'vordlusButton
        '
        Me.vordlusButton.Location = New System.Drawing.Point(56, 4)
        Me.vordlusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.vordlusButton.Name = "vordlusButton"
        Me.vordlusButton.Size = New System.Drawing.Size(50, 20)
        Me.vordlusButton.TabIndex = 73
        Me.vordlusButton.Text = "Võrd"
        Me.vordlusButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
<<<<<<< HEAD
        Me.calcButton.Location = New System.Drawing.Point(110, 4)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(50, 20)
        Me.calcButton.TabIndex = 72
        Me.calcButton.Text = "Kalk"
        Me.calcButton.UseVisualStyleBackColor = True
=======
        Me.lblAverageNow.AutoSize = True
        Me.lblAverageNow.Location = New System.Drawing.Point(773, 159)
        Me.lblAverageNow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageNow.Name = "lblAverageNow"
        Me.lblAverageNow.Size = New System.Drawing.Size(82, 13)
        Me.lblAverageNow.TabIndex = 75
        Me.lblAverageNow.Text = "Keskmine hind: "
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        '
        'otsingButton
        '
<<<<<<< HEAD
        Me.otsingButton.Location = New System.Drawing.Point(164, 4)
        Me.otsingButton.Margin = New System.Windows.Forms.Padding(2)
        Me.otsingButton.Name = "otsingButton"
        Me.otsingButton.Size = New System.Drawing.Size(58, 20)
        Me.otsingButton.TabIndex = 74
        Me.otsingButton.Text = "Otsing"
        Me.otsingButton.UseVisualStyleBackColor = True
=======
        Me.lblAverageTF.AutoSize = True
        Me.lblAverageTF.Location = New System.Drawing.Point(773, 178)
        Me.lblAverageTF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverageTF.Name = "lblAverageTF"
        Me.lblAverageTF.Size = New System.Drawing.Size(109, 13)
        Me.lblAverageTF.TabIndex = 76
        Me.lblAverageTF.Text = "Soovituslik keskmine:"
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        '
        'homeButton
        '
<<<<<<< HEAD
        Me.homeButton.Location = New System.Drawing.Point(2, 4)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 20)
        Me.homeButton.TabIndex = 71
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'chartPanel
        '
        Me.chartPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartPanel.AutoSize = True
        Me.chartPanel.Location = New System.Drawing.Point(3, 63)
        Me.chartPanel.Name = "chartPanel"
        Me.chartPanel.Size = New System.Drawing.Size(944, 588)
        Me.chartPanel.TabIndex = 79
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.30431!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.69569!))
        Me.TableLayoutPanel1.Controls.Add(Me.chartPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.panelNavbar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panelAdditionalRanges, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.174312!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.82569!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1183, 709)
        Me.TableLayoutPanel1.TabIndex = 87
=======
        Me.lblSavedPer.AutoSize = True
        Me.lblSavedPer.Location = New System.Drawing.Point(773, 200)
        Me.lblSavedPer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavedPer.Name = "lblSavedPer"
        Me.lblSavedPer.Size = New System.Drawing.Size(62, 13)
        Me.lblSavedPer.TabIndex = 77
        Me.lblSavedPer.Text = "Säästaksid:"
        '
        'chartPanel
        '
        Me.chartPanel.Location = New System.Drawing.Point(34, 64)
        Me.chartPanel.Name = "chartPanel"
        Me.chartPanel.Size = New System.Drawing.Size(720, 420)
        Me.chartPanel.TabIndex = 79
        '
        'packageChart
        '
        ChartArea7.Name = "ChartArea1"
        Me.packageChart.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.packageChart.Legends.Add(Legend7)
        Me.packageChart.Location = New System.Drawing.Point(832, 565)
        Me.packageChart.Margin = New System.Windows.Forms.Padding(2)
        Me.packageChart.Name = "packageChart"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Me.packageChart.Series.Add(Series7)
        Me.packageChart.Size = New System.Drawing.Size(163, 122)
        Me.packageChart.TabIndex = 88
        Me.packageChart.Text = "Chart1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(830, 542)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Pakettide võrdlus:"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Filter 1", "Filter 2"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(883, 377)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(82, 34)
        Me.CheckedListBox2.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(880, 354)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Filtreeri pakette:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(880, 302)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Järjestamise viis:"
        '
        'jarjestamineComboBox
        '
        Me.jarjestamineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jarjestamineComboBox.FormattingEnabled = True
        Me.jarjestamineComboBox.Items.AddRange(New Object() {"A - Z", "Z - A", "Hind kasvav", "Hind kahanev"})
        Me.jarjestamineComboBox.Location = New System.Drawing.Point(883, 325)
        Me.jarjestamineComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.jarjestamineComboBox.Name = "jarjestamineComboBox"
        Me.jarjestamineComboBox.Size = New System.Drawing.Size(82, 21)
        Me.jarjestamineComboBox.TabIndex = 83
        '
        'compareButton
        '
        Me.compareButton.Location = New System.Drawing.Point(776, 464)
        Me.compareButton.Margin = New System.Windows.Forms.Padding(2)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(81, 20)
        Me.compareButton.TabIndex = 82
        Me.compareButton.Text = "Võrdle pakette"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'pakettCheckedListBox
        '
        Me.pakettCheckedListBox.CheckOnClick = True
        Me.pakettCheckedListBox.FormattingEnabled = True
        Me.pakettCheckedListBox.Location = New System.Drawing.Point(776, 325)
        Me.pakettCheckedListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.pakettCheckedListBox.Name = "pakettCheckedListBox"
        Me.pakettCheckedListBox.Size = New System.Drawing.Size(90, 124)
        Me.pakettCheckedListBox.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(773, 302)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Pakettide nimekiri:"
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1183, 709)
        Me.Controls.Add(Me.TableLayoutPanel1)
=======
        Me.ClientSize = New System.Drawing.Size(1246, 807)
        Me.Controls.Add(Me.packageChart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.jarjestamineComboBox)
        Me.Controls.Add(Me.compareButton)
        Me.Controls.Add(Me.pakettCheckedListBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chartPanel)
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
        Me.Controls.Add(Me.TextBox4)
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
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
<<<<<<< HEAD
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelAdditionalRanges.ResumeLayout(False)
        Me.panelAdditionalRanges.PerformLayout()
        Me.panelNavbar.ResumeLayout(False)
        Me.panelNavbar.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
=======
        CType(Me.packageChart, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> parent of 31733c6 (Dynamic window resize test)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
<<<<<<< HEAD
=======
    Friend WithEvents lblAverageNow As Label
    Friend WithEvents lblAverageTF As Label
    Friend WithEvents lblSavedPer As Label
    Friend WithEvents chartPanel As Panel
    Friend WithEvents packageChart As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
>>>>>>> parent of 31733c6 (Dynamic window resize test)
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents jarjestamineComboBox As ComboBox
    Friend WithEvents compareButton As Button
    Friend WithEvents pakettCheckedListBox As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAverageNow As Label
    Friend WithEvents lblAverageTF As Label
    Friend WithEvents lblSavedPer As Label
    Friend WithEvents btnCalcTimeFrame As Button
    Friend WithEvents tbRecTimeFrame As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTimeFrame As ComboBox
    Friend WithEvents panelAdditionalRanges As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents panelNavbar As Panel
    Friend WithEvents homeButton As Button
    Friend WithEvents otsingButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents vordlusButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents chartPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
