<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddData
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblrowid = New System.Windows.Forms.Label()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cboPrename = New System.Windows.Forms.ComboBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.cboAmphur = New System.Windows.Forms.ComboBox()
        Me.cboTambol = New System.Windows.Forms.ComboBox()
        Me.cboOcupation = New System.Windows.Forms.ComboBox()
        Me.cboMarryStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSexWoman = New System.Windows.Forms.RadioButton()
        Me.radSexMan = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBanName = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMubanNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOcOther = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCID = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rowid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.btnEditSaveData = New System.Windows.Forms.Button()
        Me.btnPrintData = New System.Windows.Forms.Button()
        Me.btnDeleteData = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnShowImage = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnShowChart = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnChart2 = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblrowid)
        Me.Panel1.Controls.Add(Me.btnChooseImage)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cboBirthDate)
        Me.Panel1.Controls.Add(Me.cboPrename)
        Me.Panel1.Controls.Add(Me.cboProvince)
        Me.Panel1.Controls.Add(Me.cboAmphur)
        Me.Panel1.Controls.Add(Me.cboTambol)
        Me.Panel1.Controls.Add(Me.cboOcupation)
        Me.Panel1.Controls.Add(Me.cboMarryStatus)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtLname)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtMobile)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtZipCode)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBanName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtMubanNo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtOcOther)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtFname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 529)
        Me.Panel1.TabIndex = 0
        '
        'lblrowid
        '
        Me.lblrowid.AutoSize = True
        Me.lblrowid.Location = New System.Drawing.Point(575, 19)
        Me.lblrowid.Name = "lblrowid"
        Me.lblrowid.Size = New System.Drawing.Size(0, 17)
        Me.lblrowid.TabIndex = 44
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Location = New System.Drawing.Point(497, 467)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(85, 31)
        Me.btnChooseImage.TabIndex = 6
        Me.btnChooseImage.Text = "เลือกภาพ"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(467, 248)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 17)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "ภาพถ่าย"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(415, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'cboBirthDate
        '
        Me.cboBirthDate.Location = New System.Drawing.Point(125, 132)
        Me.cboBirthDate.Name = "cboBirthDate"
        Me.cboBirthDate.Size = New System.Drawing.Size(181, 22)
        Me.cboBirthDate.TabIndex = 6
        '
        'cboPrename
        '
        Me.cboPrename.FormattingEnabled = True
        Me.cboPrename.Location = New System.Drawing.Point(125, 66)
        Me.cboPrename.Name = "cboPrename"
        Me.cboPrename.Size = New System.Drawing.Size(56, 24)
        Me.cboPrename.TabIndex = 2
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(128, 393)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(221, 24)
        Me.cboProvince.TabIndex = 15
        '
        'cboAmphur
        '
        Me.cboAmphur.Enabled = False
        Me.cboAmphur.FormattingEnabled = True
        Me.cboAmphur.Location = New System.Drawing.Point(128, 357)
        Me.cboAmphur.Name = "cboAmphur"
        Me.cboAmphur.Size = New System.Drawing.Size(221, 24)
        Me.cboAmphur.TabIndex = 14
        '
        'cboTambol
        '
        Me.cboTambol.Enabled = False
        Me.cboTambol.FormattingEnabled = True
        Me.cboTambol.Location = New System.Drawing.Point(128, 321)
        Me.cboTambol.Name = "cboTambol"
        Me.cboTambol.Size = New System.Drawing.Size(221, 24)
        Me.cboTambol.TabIndex = 13
        '
        'cboOcupation
        '
        Me.cboOcupation.FormattingEnabled = True
        Me.cboOcupation.Location = New System.Drawing.Point(210, 167)
        Me.cboOcupation.Name = "cboOcupation"
        Me.cboOcupation.Size = New System.Drawing.Size(230, 24)
        Me.cboOcupation.TabIndex = 8
        '
        'cboMarryStatus
        '
        Me.cboMarryStatus.FormattingEnabled = True
        Me.cboMarryStatus.Location = New System.Drawing.Point(340, 63)
        Me.cboMarryStatus.Name = "cboMarryStatus"
        Me.cboMarryStatus.Size = New System.Drawing.Size(121, 24)
        Me.cboMarryStatus.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSexWoman)
        Me.GroupBox1.Controls.Add(Me.radSexMan)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 81)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพศ"
        '
        'radSexWoman
        '
        Me.radSexWoman.AutoSize = True
        Me.radSexWoman.Enabled = False
        Me.radSexWoman.Location = New System.Drawing.Point(7, 49)
        Me.radSexWoman.Name = "radSexWoman"
        Me.radSexWoman.Size = New System.Drawing.Size(54, 21)
        Me.radSexWoman.TabIndex = 1
        Me.radSexWoman.TabStop = True
        Me.radSexWoman.Text = "หญิง"
        Me.radSexWoman.UseVisualStyleBackColor = True
        '
        'radSexMan
        '
        Me.radSexMan.AutoSize = True
        Me.radSexMan.Enabled = False
        Me.radSexMan.Location = New System.Drawing.Point(7, 22)
        Me.radSexMan.Name = "radSexMan"
        Me.radSexMan.Size = New System.Drawing.Size(50, 21)
        Me.radSexMan.TabIndex = 0
        Me.radSexMan.TabStop = True
        Me.radSexMan.Text = "ชาย"
        Me.radSexMan.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(467, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 17)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "ปี"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(322, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 17)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "อายุ"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(356, 132)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(105, 22)
        Me.txtAge.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "วันเดือนปีเกิด"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(340, 98)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(158, 22)
        Me.txtLname.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(128, 493)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(221, 22)
        Me.txtEmail.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(67, 496)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "email"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(128, 461)
        Me.txtMobile.Mask = "000-000-0000"
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(154, 22)
        Me.txtMobile.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 464)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "โทรศัพท์มือถือ"
        '
        'txtZipCode
        '
        Me.txtZipCode.Enabled = False
        Me.txtZipCode.Location = New System.Drawing.Point(128, 428)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 22)
        Me.txtZipCode.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 431)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 17)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "รหัสไปรษณีย์"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(60, 397)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "จังหวัด"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "อำเภอ/เขต"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 321)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ตำบล"
        '
        'txtBanName
        '
        Me.txtBanName.Location = New System.Drawing.Point(128, 285)
        Me.txtBanName.Name = "txtBanName"
        Me.txtBanName.Size = New System.Drawing.Size(221, 22)
        Me.txtBanName.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(77, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "บ้าน"
        '
        'txtMubanNo
        '
        Me.txtMubanNo.Location = New System.Drawing.Point(280, 248)
        Me.txtMubanNo.Name = "txtMubanNo"
        Me.txtMubanNo.Size = New System.Drawing.Size(100, 22)
        Me.txtMubanNo.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "หมูที่"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 248)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtAddress.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ที่อยู่"
        '
        'txtOcOther
        '
        Me.txtOcOther.Enabled = False
        Me.txtOcOther.Location = New System.Drawing.Point(210, 206)
        Me.txtOcOther.Name = "txtOcOther"
        Me.txtOcOther.Size = New System.Drawing.Size(230, 22)
        Me.txtOcOther.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "อื่น ๆ ระบุ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "อาชีพ"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(125, 98)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(158, 22)
        Me.txtFname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ชื่อ สกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "สถานะสมรส"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "คำนำหน้า"
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(125, 28)
        Me.txtCID.Mask = "0-0000-00000-00-0"
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(225, 22)
        Me.txtCID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขบัตรปชช. "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rowid, Me.fname, Me.lname, Me.birthdate})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(611, 500)
        Me.DataGridView1.TabIndex = 1
        '
        'rowid
        '
        Me.rowid.DataPropertyName = "rowid"
        Me.rowid.HeaderText = "รหัส"
        Me.rowid.Name = "rowid"
        Me.rowid.ReadOnly = True
        '
        'fname
        '
        Me.fname.DataPropertyName = "fname"
        Me.fname.HeaderText = "ชื่อ"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'lname
        '
        Me.lname.DataPropertyName = "lname"
        Me.lname.HeaderText = "สกุล"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        '
        'birthdate
        '
        Me.birthdate.DataPropertyName = "birthdate"
        Me.birthdate.HeaderText = "วันเดือนปีเดกิด"
        Me.birthdate.Name = "birthdate"
        Me.birthdate.ReadOnly = True
        '
        'btnAddData
        '
        Me.btnAddData.Location = New System.Drawing.Point(12, 582)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(95, 34)
        Me.btnAddData.TabIndex = 0
        Me.btnAddData.Text = "เพิ่มข้อมูล"
        Me.btnAddData.UseVisualStyleBackColor = True
        '
        'btnEditSaveData
        '
        Me.btnEditSaveData.Location = New System.Drawing.Point(129, 582)
        Me.btnEditSaveData.Name = "btnEditSaveData"
        Me.btnEditSaveData.Size = New System.Drawing.Size(98, 34)
        Me.btnEditSaveData.TabIndex = 1
        Me.btnEditSaveData.Text = "แก้ไข"
        Me.btnEditSaveData.UseVisualStyleBackColor = True
        '
        'btnPrintData
        '
        Me.btnPrintData.Location = New System.Drawing.Point(538, 582)
        Me.btnPrintData.Name = "btnPrintData"
        Me.btnPrintData.Size = New System.Drawing.Size(83, 34)
        Me.btnPrintData.TabIndex = 3
        Me.btnPrintData.Text = "พิมพ์"
        Me.btnPrintData.UseVisualStyleBackColor = True
        '
        'btnDeleteData
        '
        Me.btnDeleteData.Location = New System.Drawing.Point(247, 582)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(114, 34)
        Me.btnDeleteData.TabIndex = 2
        Me.btnDeleteData.Text = "ลบข้อมูล"
        Me.btnDeleteData.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1130, 574)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 46)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(668, 574)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 34)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnShowImage
        '
        Me.btnShowImage.Location = New System.Drawing.Point(767, 574)
        Me.btnShowImage.Name = "btnShowImage"
        Me.btnShowImage.Size = New System.Drawing.Size(93, 34)
        Me.btnShowImage.TabIndex = 6
        Me.btnShowImage.Text = "Show"
        Me.btnShowImage.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(630, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 535)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnShowChart)
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnShowChart
        '
        Me.btnShowChart.Location = New System.Drawing.Point(496, 430)
        Me.btnShowChart.Name = "btnShowChart"
        Me.btnShowChart.Size = New System.Drawing.Size(93, 34)
        Me.btnShowChart.TabIndex = 8
        Me.btnShowChart.Text = "Show"
        Me.btnShowChart.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.AxisX.Title = "SSSSSS"
        ChartArea1.AxisY.Title = "XXXX"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(611, 500)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "รายงาน"
        Me.Chart1.Titles.Add(Title1)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnChart2)
        Me.TabPage3.Controls.Add(Me.Chart2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(617, 506)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnChart2
        '
        Me.btnChart2.Location = New System.Drawing.Point(514, 430)
        Me.btnChart2.Name = "btnChart2"
        Me.btnChart2.Size = New System.Drawing.Size(93, 34)
        Me.btnChart2.TabIndex = 8
        Me.btnChart2.Text = "Show"
        Me.btnChart2.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(3, 3)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(611, 500)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(381, 582)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(114, 34)
        Me.btnClearAll.TabIndex = 8
        Me.btnClearAll.Text = "ล้างข้อมูล"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'frmAddData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 650)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnShowImage)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrintData)
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnEditSaveData)
        Me.Controls.Add(Me.btnAddData)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทึกแก้ไข"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMubanNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOcOther As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBanName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cboAmphur As System.Windows.Forms.ComboBox
    Friend WithEvents cboTambol As System.Windows.Forms.ComboBox
    Friend WithEvents cboOcupation As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarryStatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSexWoman As System.Windows.Forms.RadioButton
    Friend WithEvents radSexMan As System.Windows.Forms.RadioButton
    Friend WithEvents cboBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPrename As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddData As System.Windows.Forms.Button
    Friend WithEvents btnEditSaveData As System.Windows.Forms.Button
    Friend WithEvents btnPrintData As System.Windows.Forms.Button
    Friend WithEvents btnDeleteData As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnShowImage As System.Windows.Forms.Button
    Friend WithEvents lblrowid As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnShowChart As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnChart2 As System.Windows.Forms.Button
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents rowid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents birthdate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
