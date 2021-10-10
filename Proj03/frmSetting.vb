Public Class frmSetting
    Dim strPrint() As String = {"CANNON", "EPSON", "BROTHER", "HP"}
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 3
            cboPrinter.Items.Add(strPrint(i))
        Next i
        cboPrinter.SelectedIndex = 1
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("คุณต้องบันทึกข้อมูลใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If result = vbOK Then
            MessageBox.Show("บันทึกเรียบร้อย","SetPrinter",MessageBoxButtons.OK,MessageBoxIcon.Information)
        End If
    End Sub

End Class