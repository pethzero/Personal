<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputData))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtListName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblIndexP = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lstSong = New System.Windows.Forms.ListBox()
        Me.btnAddSongAll = New System.Windows.Forms.Button()
        Me.lblsong5 = New System.Windows.Forms.Label()
        Me.lblsong4 = New System.Windows.Forms.Label()
        Me.lblsong2 = New System.Windows.Forms.Label()
        Me.lblsong3 = New System.Windows.Forms.Label()
        Me.lblsong1 = New System.Windows.Forms.Label()
        Me.txtSong3 = New System.Windows.Forms.TextBox()
        Me.txtSong4 = New System.Windows.Forms.TextBox()
        Me.txtSong1 = New System.Windows.Forms.TextBox()
        Me.txtSong2 = New System.Windows.Forms.TextBox()
        Me.txtSong0 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGetGrade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtMutiple = New System.Windows.Forms.TextBox()
        Me.txtNumberMutiple = New System.Windows.Forms.TextBox()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Proj03.My.Resources.Resources._2021_09_29_10_10_20
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(876, 633)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 43)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Proj03.My.Resources.Resources._2021_09_29_10_07_57
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(702, 633)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 43)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(29, 94)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(977, 523)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtListName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnRead)
        Me.TabPage1.Controls.Add(Me.lstName)
        Me.TabPage1.Controls.Add(Me.btnWrite)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(969, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Work No.1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtListName
        '
        Me.txtListName.Location = New System.Drawing.Point(471, 131)
        Me.txtListName.Multiline = True
        Me.txtListName.Name = "txtListName"
        Me.txtListName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtListName.Size = New System.Drawing.Size(315, 244)
        Me.txtListName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "List Name"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(646, 39)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(103, 41)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read to file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 16
        Me.lstName.Location = New System.Drawing.Point(125, 131)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(315, 244)
        Me.lstName.TabIndex = 4
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(482, 39)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(103, 41)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "Write to file"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(125, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(315, 22)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.lblIndexP)
        Me.TabPage2.Controls.Add(Me.lblPoint)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.btnSort)
        Me.TabPage2.Controls.Add(Me.lstSong)
        Me.TabPage2.Controls.Add(Me.btnAddSongAll)
        Me.TabPage2.Controls.Add(Me.lblsong5)
        Me.TabPage2.Controls.Add(Me.lblsong4)
        Me.TabPage2.Controls.Add(Me.lblsong2)
        Me.TabPage2.Controls.Add(Me.lblsong3)
        Me.TabPage2.Controls.Add(Me.lblsong1)
        Me.TabPage2.Controls.Add(Me.txtSong3)
        Me.TabPage2.Controls.Add(Me.txtSong4)
        Me.TabPage2.Controls.Add(Me.txtSong1)
        Me.TabPage2.Controls.Add(Me.txtSong2)
        Me.TabPage2.Controls.Add(Me.txtSong0)
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(969, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Work No.2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "จำนวนคงเหลือ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 31)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Move"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(609, 417)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 22)
        Me.TextBox1.TabIndex = 19
        '
        'lblIndexP
        '
        Me.lblIndexP.AutoSize = True
        Me.lblIndexP.Location = New System.Drawing.Point(614, 377)
        Me.lblIndexP.Name = "lblIndexP"
        Me.lblIndexP.Size = New System.Drawing.Size(0, 17)
        Me.lblIndexP.TabIndex = 18
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Location = New System.Drawing.Point(535, 377)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(62, 17)
        Me.lblPoint.TabIndex = 17
        Me.lblPoint.Text = "ตำแหน่งที่"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(399, 330)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 31)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(609, 334)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 22)
        Me.txtSearch.TabIndex = 15
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(316, 241)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(103, 30)
        Me.btnSort.TabIndex = 14
        Me.btnSort.Text = "Sort A-Z"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lstSong
        '
        Me.lstSong.FormattingEnabled = True
        Me.lstSong.ItemHeight = 16
        Me.lstSong.Location = New System.Drawing.Point(490, 50)
        Me.lstSong.Name = "lstSong"
        Me.lstSong.Size = New System.Drawing.Size(315, 244)
        Me.lstSong.TabIndex = 13
        '
        'btnAddSongAll
        '
        Me.btnAddSongAll.Location = New System.Drawing.Point(174, 241)
        Me.btnAddSongAll.Name = "btnAddSongAll"
        Me.btnAddSongAll.Size = New System.Drawing.Size(103, 30)
        Me.btnAddSongAll.TabIndex = 12
        Me.btnAddSongAll.Text = "Add Song All"
        Me.btnAddSongAll.UseVisualStyleBackColor = True
        '
        'lblsong5
        '
        Me.lblsong5.AutoSize = True
        Me.lblsong5.Location = New System.Drawing.Point(97, 198)
        Me.lblsong5.Name = "lblsong5"
        Me.lblsong5.Size = New System.Drawing.Size(57, 17)
        Me.lblsong5.TabIndex = 9
        Me.lblsong5.Text = "song(4)"
        '
        'lblsong4
        '
        Me.lblsong4.AutoSize = True
        Me.lblsong4.Location = New System.Drawing.Point(97, 165)
        Me.lblsong4.Name = "lblsong4"
        Me.lblsong4.Size = New System.Drawing.Size(57, 17)
        Me.lblsong4.TabIndex = 8
        Me.lblsong4.Text = "song(3)"
        '
        'lblsong2
        '
        Me.lblsong2.AutoSize = True
        Me.lblsong2.Location = New System.Drawing.Point(97, 99)
        Me.lblsong2.Name = "lblsong2"
        Me.lblsong2.Size = New System.Drawing.Size(57, 17)
        Me.lblsong2.TabIndex = 7
        Me.lblsong2.Text = "song(1)"
        '
        'lblsong3
        '
        Me.lblsong3.AutoSize = True
        Me.lblsong3.Location = New System.Drawing.Point(97, 132)
        Me.lblsong3.Name = "lblsong3"
        Me.lblsong3.Size = New System.Drawing.Size(57, 17)
        Me.lblsong3.TabIndex = 6
        Me.lblsong3.Text = "song(2)"
        '
        'lblsong1
        '
        Me.lblsong1.AutoSize = True
        Me.lblsong1.Location = New System.Drawing.Point(97, 63)
        Me.lblsong1.Name = "lblsong1"
        Me.lblsong1.Size = New System.Drawing.Size(57, 17)
        Me.lblsong1.TabIndex = 5
        Me.lblsong1.Text = "song(0)"
        '
        'txtSong3
        '
        Me.txtSong3.Location = New System.Drawing.Point(174, 162)
        Me.txtSong3.Name = "txtSong3"
        Me.txtSong3.Size = New System.Drawing.Size(275, 22)
        Me.txtSong3.TabIndex = 4
        '
        'txtSong4
        '
        Me.txtSong4.Location = New System.Drawing.Point(174, 195)
        Me.txtSong4.Name = "txtSong4"
        Me.txtSong4.Size = New System.Drawing.Size(275, 22)
        Me.txtSong4.TabIndex = 3
        '
        'txtSong1
        '
        Me.txtSong1.Location = New System.Drawing.Point(174, 96)
        Me.txtSong1.Name = "txtSong1"
        Me.txtSong1.Size = New System.Drawing.Size(275, 22)
        Me.txtSong1.TabIndex = 2
        '
        'txtSong2
        '
        Me.txtSong2.Location = New System.Drawing.Point(174, 129)
        Me.txtSong2.Name = "txtSong2"
        Me.txtSong2.Size = New System.Drawing.Size(275, 22)
        Me.txtSong2.TabIndex = 1
        '
        'txtSong0
        '
        Me.txtSong0.Location = New System.Drawing.Point(174, 63)
        Me.txtSong0.Name = "txtSong0"
        Me.txtSong0.Size = New System.Drawing.Size(275, 22)
        Me.txtSong0.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.txtScore)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtGetGrade)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.btnGrade)
        Me.TabPage3.ImageKey = "work.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(969, 494)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Work No.3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(134, 40)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(185, 22)
        Me.txtScore.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ได้เกรด"
        '
        'txtGetGrade
        '
        Me.txtGetGrade.Location = New System.Drawing.Point(134, 84)
        Me.txtGetGrade.Name = "txtGetGrade"
        Me.txtGetGrade.Size = New System.Drawing.Size(185, 22)
        Me.txtGetGrade.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ระบุคะแนน"
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(349, 31)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(93, 31)
        Me.btnGrade.TabIndex = 22
        Me.btnGrade.Text = "Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtMutiple)
        Me.TabPage4.Controls.Add(Me.txtNumberMutiple)
        Me.TabPage4.Controls.Add(Me.btnMultiple)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(969, 494)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Work No.4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtMutiple
        '
        Me.txtMutiple.Location = New System.Drawing.Point(82, 123)
        Me.txtMutiple.Multiline = True
        Me.txtMutiple.Name = "txtMutiple"
        Me.txtMutiple.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMutiple.Size = New System.Drawing.Size(506, 332)
        Me.txtMutiple.TabIndex = 31
        '
        'txtNumberMutiple
        '
        Me.txtNumberMutiple.Location = New System.Drawing.Point(196, 57)
        Me.txtNumberMutiple.Name = "txtNumberMutiple"
        Me.txtNumberMutiple.Size = New System.Drawing.Size(185, 22)
        Me.txtNumberMutiple.TabIndex = 30
        '
        'btnMultiple
        '
        Me.btnMultiple.Location = New System.Drawing.Point(82, 53)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(93, 31)
        Me.btnMultiple.TabIndex = 29
        Me.btnMultiple.Text = "สูตรคูณ"
        Me.btnMultiple.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "work.png")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(325, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(319, 55)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "INPUT DATA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proj03.My.Resources.Resources.mypcucyanlogo
        Me.PictureBox1.Location = New System.Drawing.Point(650, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(587, 129)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(319, 22)
        Me.TextBox2.TabIndex = 29
        Me.TextBox2.Text = "Window0  111 XZX  AA465A   LLL 125 SD"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 31)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Process"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(587, 170)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(319, 244)
        Me.TextBox3.TabIndex = 31
        '
        'frmInputData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 688)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmInputData"
        Me.Text = "บันทึกข้อมูล"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents txtListName As System.Windows.Forms.TextBox
    Friend WithEvents lblsong1 As System.Windows.Forms.Label
    Friend WithEvents txtSong3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSong4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSong1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSong2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSong0 As System.Windows.Forms.TextBox
    Friend WithEvents lblsong5 As System.Windows.Forms.Label
    Friend WithEvents lblsong4 As System.Windows.Forms.Label
    Friend WithEvents lblsong2 As System.Windows.Forms.Label
    Friend WithEvents lblsong3 As System.Windows.Forms.Label
    Friend WithEvents btnAddSongAll As System.Windows.Forms.Button
    Friend WithEvents lstSong As System.Windows.Forms.ListBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblPoint As System.Windows.Forms.Label
    Friend WithEvents lblIndexP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGrade As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGetGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtMutiple As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberMutiple As System.Windows.Forms.TextBox
    Friend WithEvents btnMultiple As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
