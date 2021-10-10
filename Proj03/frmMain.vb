Imports System.Array
Public Class frmMain

    Dim strMenuIdx(4) As String


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Nothing
        strMenuIdx(0) = "บันทักรายการข้อมูล"
        strMenuIdx(1) = "แสดงรายการข้อมูล"
        strMenuIdx(2) = "รายงานรายการข้อมูล"
        strMenuIdx(3) = "ตั้งค่าเครื่องพิมพ์และหน้ากระดาษ"

        Timer1.Start()
        'Dim arr = New String() {"abc", "mno", "xyz"}
        'arr.RemoveAt(1)

    End Sub

   

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        'PictureBox1.Image = ImageList1.Images(0)
        'btnInput.ForeColor = Color.Blue
        'btnDisplay.ForeColor = Color.Black
        'btnReport.ForeColor = Color.Black
        'btnSetPrinter.ForeColor = Color.Black
        'btnExit.ForeColor = Color.Black
        'PictureBox1.Image = My.Resources.input
        'lblDetailChoose.Text = strMenuIdx(0)
        Timer1.Stop()
        Me.Visible = False
        'frmInputData.ShowDialog()
        frmAddData.ShowDialog()
        Me.Visible = True
        Timer1.Start()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'btnInput.ForeColor = Color.Black
        'btnDisplay.ForeColor = Color.Blue
        'btnReport.ForeColor = Color.Black
        'btnSetPrinter.ForeColor = Color.Black
        'btnExit.ForeColor = Color.Black
        'PictureBox1.Image = My.Resources.map
        'lblDetailChoose.Text = strMenuIdx(1)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        'btnInput.ForeColor = Color.Black
        'btnDisplay.ForeColor = Color.Black
        'btnReport.ForeColor = Color.Blue
        'btnSetPrinter.ForeColor = Color.Black
        'btnExit.ForeColor = Color.Black
        'PictureBox1.Image = My.Resources.reportData
        'lblDetailChoose.Text = strMenuIdx(2)
    End Sub

    Private Sub btnSetPrinter_Click(sender As Object, e As EventArgs) Handles btnSetPrinter.Click
        'btnInput.ForeColor = Color.Black
        'btnDisplay.ForeColor = Color.Black
        'btnReport.ForeColor = Color.Black
        'btnSetPrinter.ForeColor = Color.Blue
        'btnExit.ForeColor = Color.Black
        'PictureBox1.Image = My.Resources.setprinter
        'lblDetailChoose.Text = strMenuIdx(3)

        'Me.Visible = False
        'frmSetting.ShowDialog()
        'Me.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnInput.ForeColor = Color.Black
        btnDisplay.ForeColor = Color.Black
        btnReport.ForeColor = Color.Black
        btnSetPrinter.ForeColor = Color.Black
        btnExit.ForeColor = Color.Blue
        PictureBox1.Image = Nothing
        lblDetailChoose.Text = ""
        Dim result As DialogResult = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnInput_MouseLeave(sender As Object, e As EventArgs) Handles btnInput.MouseLeave
        PictureBox1.Image = Nothing
        btnInput.BackColor = Color.Transparent
        lblDetailChoose.Text = ""
    End Sub

    Private Sub btnInput_MouseHover(sender As Object, e As EventArgs) Handles btnInput.MouseMove
        PictureBox1.Image = My.Resources.input
        btnInput.BackColor = Color.Green
        lblDetailChoose.Text = strMenuIdx(0)
    End Sub

    Private Sub btnDisplay_MouseLeave(sender As Object, e As EventArgs) Handles btnDisplay.MouseLeave
        btnDisplay.BackColor = Color.Transparent
        PictureBox1.Image = Nothing
        lblDetailChoose.Text = ""
    End Sub

    Private Sub btnDisplay_MouseHover(sender As Object, e As EventArgs) Handles btnDisplay.MouseMove
        PictureBox1.Image = My.Resources.map
        btnDisplay.BackColor = Color.Green
        lblDetailChoose.Text = strMenuIdx(1)
    End Sub

    Private Sub btnReport_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave
        btnReport.BackColor = Color.Transparent
        PictureBox1.Image = Nothing
        lblDetailChoose.Text = ""
    End Sub

    Private Sub btnReport_MouseHover(sender As Object, e As EventArgs) Handles btnReport.MouseMove
        PictureBox1.Image = My.Resources.reportData
        btnReport.BackColor = Color.Green
        lblDetailChoose.Text = strMenuIdx(2)
    End Sub

    Private Sub btnSetPrinter_MouseLeave(sender As Object, e As EventArgs) Handles btnSetPrinter.MouseLeave
        btnSetPrinter.BackColor = Color.Transparent
        PictureBox1.Image = Nothing
        lblDetailChoose.Text = ""
    End Sub

    Private Sub btnSetPrinter_MouseHover(sender As Object, e As EventArgs) Handles btnSetPrinter.MouseMove
        PictureBox1.Image = My.Resources.setprinter
        btnSetPrinter.BackColor = Color.Green
        lblDetailChoose.Text = strMenuIdx(3)
    End Sub


    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.Transparent
        PictureBox1.Image = Nothing
        lblDetailChoose.Text = ""
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseMove
        PictureBox1.Image = My.Resources.R
        btnExit.BackColor = Color.Red
        lblDetailChoose.Text = ""
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtClock.Text = Now
    End Sub
End Class
