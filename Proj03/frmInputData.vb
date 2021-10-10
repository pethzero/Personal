Imports System.IO
Public Class frmInputData

    Private Sub frmInputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = vbOK Then
            Me.Close()
        End If
    End Sub


    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("workdata.txt")
        outFile.WriteLine(txtName.Text.Trim)
        outFile.Close()

        lstName.Items.Add(txtName.Text.Trim)
        lstName.Refresh()
        txtName.Text = String.Empty
        txtName.Focus()

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Dim inFile As IO.StreamReader


        If IO.File.Exists("workdata.txt") Then
            'inFile = IO.File.OpenText("workdata.txt")
            For Each line As String In File.ReadLines("workdata.txt")
                'Code here to read each line
                lstName.Items.Add(line)
            Next line


            'txtListName.Text = inFile.ReadToEnd
            'inFile.Close()
            'lstName.Items.Clear()
        Else
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtListName_TextChanged(sender As Object, e As EventArgs) Handles txtListName.TextChanged
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblsong1.Click

    End Sub

    Private Sub btnAddSongAll_Click(sender As Object, e As EventArgs) Handles btnAddSongAll.Click
        Dim song(4) As String

        song(0) = txtSong0.Text
        song(1) = txtSong1.Text
        song(2) = txtSong2.Text
        song(3) = txtSong3.Text
        song(4) = txtSong4.Text

        lstSong.Items.Clear()
        For Each line As String In song
            lstSong.Items.Add(line)
        Next line
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

        Dim song(4) As String

        song(0) = txtSong0.Text
        song(1) = txtSong1.Text
        song(2) = txtSong2.Text
        song(3) = txtSong3.Text
        song(4) = txtSong4.Text

        Array.Sort(song)
        lstSong.Items.Clear()
        For Each line As String In song
            lstSong.Items.Add(line)
        Next line
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim song(4) As String

        song(0) = txtSong0.Text
        song(1) = txtSong1.Text
        song(2) = txtSong2.Text
        song(3) = txtSong3.Text
        song(4) = txtSong4.Text

        lblIndexP.Text = ""
        Dim Onpass As Boolean = False
        Dim count As Integer = 0
        For Each line As String In song
            If song(count) = txtSearch.Text Then
                lblIndexP.Text += " " & count
                Onpass = True
            End If
            count += 1
        Next line

        If Onpass <> True Then
            lblIndexP.Text = "ไม่พบตำแหน่ง"
        End If

        'Dim result As String() = Array.FindAll(song, Function(s) s.Contains(txtSearch.Text))
        'Console.Write(result)

    End Sub


    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        If txtScore.Text = String.Empty Then
            MessageBox.Show("กรุณากรอกข้อมูล")
            txtScore.Focus()
            Exit Sub
        End If



        ' ''GradeProcess(txtScore.Text)
        GradeProcess1(txtScore.Text)
    End Sub

    Private Sub GradeProcess(ByVal gd As String)
        Dim numScore As Integer = CInt(gd.Trim)
        'A = 80-100
        'B = 60-79
        'C = 40-59
        'D = 20-39
        'E = 0-19
        If numScore > 79 Then
            txtGetGrade.Text = "A"
        ElseIf numScore > 59 Then
            txtGetGrade.Text = "B"
        ElseIf numScore > 39 Then
            txtGetGrade.Text = "C"
        ElseIf numScore > 19 Then
            txtGetGrade.Text = "D"
        Else
            txtGetGrade.Text = "E"
        End If
    End Sub

    Private Sub GradeProcess1(ByVal gd As String)
        Dim numScore As Integer = CInt(gd.Trim)
        'A = 80-100
        'B = 60-79
        'C = 40-59
        'D = 20-39
        'E = 20-39
        Select Case numScore
            Case Is >= 80
                txtGetGrade.Text = "A"
            Case 60 To 79
                txtGetGrade.Text = "B"
            Case 40 To 59
                txtGetGrade.Text = "C"
            Case 20 To 39
                txtGetGrade.Text = "D"
            Case Else
                txtGetGrade.Text = "E"
        End Select
    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        If txtNumberMutiple.Text = String.Empty Then
            MessageBox.Show("กรุณากรอกข้อมูล")
            txtNumberMutiple.Focus()
            Exit Sub
        End If



        ' ''GradeProcess(txtScore.Text)
        ProcessMutiply(txtNumberMutiple.Text)
    End Sub

    Private Sub ProcessMutiply(ByVal mp As String)
        Dim numMutiple As Integer = CInt(mp.Trim)

        txtMutiple.Text = ""
        For i As Integer = 1 To 12
            txtMutiple.Text &= numMutiple & " x " & i & " = " & (numMutiple * i).ToString & vbNewLine
        Next i


    End Sub


    Dim myStrings() As String
    Dim myStringElements As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'คำ
        'Dim i As Integer = TextBox2.TextLength

        'Dim value As String = ""
        'For Each line As String In TextBox2.Text
        '    If line <> " " Then
        '        value += line
        '    ElseIf line = " " Then
        '        AddElementToStringArray(value)
        '        value = ""

        '    End If
        'Next

        'If value <> "" Then
        '    AddElementToStringArray(value)
        'End If

        'Console.Write(myStrings)

        'Array.Sort(myStrings)
        'For i = LBound(myStrings) To UBound(myStrings)
        '    Console.Write(i)
        '    TextBox3.Text &= myStrings(i) & " " & vbCrLf
        'Next

        'แต่ละตัว
        Dim i As Integer = TextBox2.TextLength

        Dim value As String = ""
        For Each line As String In TextBox2.Text
            If line <> " " Then
                AddElementToStringArray(line)
            End If
        Next

        Array.Sort(myStrings)
        For i = LBound(myStrings) To UBound(myStrings)
            TextBox3.Text &= myStrings(i) & vbNewLine
        Next

    End Sub


    Public Sub AddElementToStringArray(ByVal stringToAdd As String)
        ReDim Preserve myStrings(myStringElements)
        myStrings(myStringElements) = stringToAdd
        myStringElements += 1
    End Sub


End Class