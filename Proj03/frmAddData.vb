Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Public Class frmAddData

    Dim myconn As MySqlConnection

    Dim strIdxMarryStatus = ""
    Dim strIdxProvince = ""
    Dim strIdxAmphur = ""
    Dim strIdxTambol = ""
    Dim strIdxOcupation = ""
    Dim strnameSex As String = ""
    Dim intRowid As Integer = 0

    Private Sub frmAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCID.Focus()
        cboPrename.Items.Clear()
        Dim strPrename() As String = {"นาย", "นาง", "น.ส.", "ดช.", "ดญ."}
        For i As Integer = 0 To strPrename.Count - 1
            cboPrename.Items.Add(strPrename(i))
        Next
        connMySQL()

        DataGridView1.AllowUserToAddRows = False

        settingGrid()
        showMarryStatus()
        showOcupation()

        showProvince()

    End Sub





    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = vbOK Then
            myconn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub connMySQL()
        Try
            myconn = New MySqlConnection("server=localhost;" _
                                         & "uid=root;" _
                                         & "pwd=123456;" _
                                         & "port=3306;" _
                                         & "database=shop;")
            myconn.Open()
        Catch ex As Exception
            MsgBox("Database Connection error: " & ex.Message)
            Me.Close()
        End Try
    End Sub


    Private Sub showMarryStatus()
        Try
            Dim com As New MySqlCommand("SELECT IFNULL(mstatus_code,'')as mstatus_code,IFNULL(mstatus_desc,'') as mstatus_desc FROM l_mstatus ORDER BY mstatus_code ASC", myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                With cboMarryStatus
                    .DataSource = ds.Tables(0)
                    .DisplayMember = "mstatus_desc"
                    .ValueMember = "mstatus_code"
                    .SelectedIndex = -1
                    .Text = " เลือก "
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub showOcupation()
        Try
            Dim com As New MySqlCommand("SELECT IFNULL(OCCUPATION_CODE,'')as OCCUPATION_CODE,IFNULL(OCCUPATION_DESC,'') as OCCUPATION_DESC FROM l_occupation ORDER BY OCCUPATION_CODE ASC", myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                With cboOcupation
                    .DataSource = ds.Tables(0)
                    .DisplayMember = "OCCUPATION_DESC"
                    .ValueMember = "OCCUPATION_CODE"
                    .SelectedIndex = -1
                    .Text = " เลือก "
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
    End Sub



    Private Sub settingGrid()

        With DataGridView1
            .Name = "DataGridView1"
            .AutoSizeRowsMode = _
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub

    Private Sub showProvince()
        Try
            Dim com As New MySqlCommand("SELECT  IFNULL(PROVINCE_ID,'') as PROVINCE_ID , IFNULL(PROVINCE_NAME,'') as PROVINCE_NAME  FROM l_cat GROUP BY  PROVINCE_ID,PROVINCE_NAME ORDER BY PROVINCE_NAME ASC", myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                With cboProvince
                    .DataSource = ds.Tables(0)
                    .DisplayMember = "PROVINCE_NAME"
                    .ValueMember = "PROVINCE_ID"
                    .SelectedIndex = -1
                    .Text = " เลือก "
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub cboProvince_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboProvince.SelectionChangeCommitted
        strIdxProvince = cboProvince.SelectedValue.ToString
        showAmphur(strIdxProvince)
        cboAmphur.Enabled = True
        cboTambol.Enabled = False
        With cboTambol
            .SelectedIndex = -1
            .Text = ""
        End With
    End Sub


    Private Sub cboAmphur_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboAmphur.SelectionChangeCommitted
        strIdxProvince = cboProvince.SelectedValue.ToString
        strIdxAmphur = cboAmphur.SelectedValue.ToString
        showTambol(strIdxProvince, strIdxAmphur)
        cboTambol.Enabled = True
    End Sub

    Private Sub cboTambol_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTambol.SelectionChangeCommitted
        strIdxProvince = cboProvince.SelectedValue.ToString
        strIdxAmphur = cboAmphur.SelectedValue.ToString
        strIdxTambol = cboTambol.SelectedValue.ToString
        showZipCode(strIdxProvince, strIdxAmphur, strIdxTambol)
    End Sub

    Private Sub showAmphur(ByVal strIdxPV As String)
        Try
            Dim SQL As String = ""

            If strIdxPV <> "" Then
                SQL = "SELECT IFNULL(AMPHUR_ID,'') as AMPHUR_ID, IFNULL(AMPHUR_NAME,'') as AMPHUR_NAME FROM l_cat WHERE PROVINCE_ID = '" & strIdxPV & "' GROUP BY AMPHUR_NAME ORDER BY AMPHUR_ID asc "
            Else
                Exit Sub
            End If

            Dim com As New MySqlCommand(SQL, myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                With cboAmphur
                    .DataSource = ds.Tables(0)
                    .DisplayMember = "AMPHUR_NAME"
                    .ValueMember = "amphur_id"
                    .SelectedIndex = -1
                    .Text = " เลือก "
                End With
            End If


        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
        End Try
    End Sub


    Private Sub showTambol(ByVal strIdxPV As String, ByVal strIdxAmp As String)
        Try
            Dim SQL As String = ""

            If strIdxAmp <> "" Then
                SQL = "SELECT IFNULL(TAMBOL_ID,'') as TAMBOL_ID,IFNULL(TAMBOL_NAME,'') as TAMBOL_NAME FROM l_cat " &
                     "WHERE AMPHUR_ID='" & strIdxAmp & "' AND PROVINCE_ID ='" & strIdxPV & "'  " &
                    "GROUP BY TAMBOL_NAME " &
                        "ORDER BY TAMBOL_ID asc  "
            Else
                Exit Sub
            End If

            Dim com As New MySqlCommand(SQL, myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                With cboTambol
                    .DataSource = ds.Tables(0)
                    .DisplayMember = "TAMBOL_NAME"
                    .ValueMember = "TAMBOL_ID"
                    .SelectedIndex = -1
                    .Text = " เลือก "
                End With
            End If


        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
        End Try
    End Sub


    Private Sub showZipCode(ByVal strIdxPV As String, ByVal strIdxAmp As String, ByVal strIdxTB As String)
        Try
            Dim SQL As String = ""
            Console.Write(strIdxTB)
            Dim strLocationCode As String = strIdxPV & strIdxAmp & strIdxTB
            If strIdxTB <> "" OrElse strIdxAmp <> "" OrElse strIdxTB <> "" Then
                SQL = "SELECT IFNULL(zip,'') As zip " &
                    "FROM zipcode " &
                     "WHERE locationcode='" & strLocationCode & "' "
            Else
                Exit Sub
            End If

            Dim com As New MySqlCommand(SQL, myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtZipCode.Text = ds.Tables(0).Rows(0).Item("zip")
            Else
                txtZipCode.Text = "000000"
            End If


        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
        End Try
    End Sub


    Private Sub cboPrename_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboPrename.SelectionChangeCommitted

        Dim intSex As Integer = cboPrename.SelectedIndex

        Select Case intSex
            Case 0, 3
                radSexMan.Checked = True
                strnameSex = "ชาย"
            Case 1, 2, 4
                radSexWoman.Checked = True
                strnameSex = "หญิง"
            Case Else
                radSexMan.Checked = False
                radSexWoman.Checked = False
                strnameSex = ""
        End Select



    End Sub

    Private Sub cboBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles cboBirthDate.ValueChanged
        txtAge.Text = funcCaleAge(cboBirthDate.Value)
    End Sub

    Public Function funcCaleAge(ByVal dt As Date) As String
        Dim intYear As Integer
        intYear = DateDiff(DateInterval.Year, dt, Now.Date)
        Return intYear.ToString
    End Function



    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
            txtEmail.ForeColor = Color.Red
            txtEmail.Focus()
        Else
            txtEmail.ForeColor = Color.Black
        End If
    End Sub





    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        Try

            Dim strCID As String = txtCID.Text
            Dim strFname As String = txtFname.Text
            Dim strLname As String = txtLname.Text
            Dim dtBirthDate As Date = cboBirthDate.Value

            Dim strAge As String = txtAge.Text
            Dim strAddress As String = txtAddress.Text
            Dim strMubanNo As String = txtMubanNo.Text
            Dim strBanName As String = txtBanName.Text

            Dim strZipCode As String = txtZipCode.Text
            Dim strMobile As String = txtMobile.Text
            Dim strEmail As String = txtEmail.Text


            Dim strOcupation As String = cboOcupation.Text
            Dim strPrename As String = cboPrename.Text
            Dim strMarryStatus As String = cboMarryStatus.Text
            Dim strProvince As String = cboProvince.Text
            Dim strAmphur As String = cboAmphur.Text
            Dim strTambol As String = cboTambol.Text
            Dim strOcOther As String = txtOcOther.Text

            Dim IdxMarryStatus As String = ""
            Dim IdxProvince As String = ""
            Dim IdxAmphur As String = ""
            Dim IdxTambol As String = ""
            Dim IdxOcupation As String = ""
            Dim IdxPrename As String = ""
            Dim nameSex As String = strnameSex

            Console.Write(strCID)

            If txtCID.MaskCompleted = False Then
                MessageBox.Show("กรุณากรอกบัตรประชาชน")
                Exit Sub
            End If

            If cboPrename.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาใส่คำนำหน้า")
                Exit Sub
            Else
                IdxPrename = cboPrename.SelectedIndex.ToString()
            End If
            If strFname = "" Then
                MessageBox.Show("กรุณากรอก")
                Exit Sub
            End If
            If strLname = "" Then
                MessageBox.Show("กรุณานามสกุล")
                Exit Sub
            End If

            If cboMarryStatus.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาเลือกสถานะ")
                Exit Sub
            Else
                IdxMarryStatus = cboMarryStatus.SelectedValue.ToString()
            End If

            If strAge = "" Then
                MessageBox.Show("กรุณาวันเกิด")
                Exit Sub
            End If

            If cboOcupation.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาเลือกอาชีพ")
                Exit Sub
            Else
                IdxOcupation = cboOcupation.SelectedValue.ToString()
            End If

            If strAddress = "" Then
                MessageBox.Show("กรุณาที่อยู่")
                Exit Sub
            End If

            If strMubanNo = "" Then
                MessageBox.Show("กรุณาวันหมู่")
                Exit Sub
            End If

            If strBanName = "" Then
                MessageBox.Show("กรุณาวันบ้าน")
                Exit Sub
            End If

            If cboProvince.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาเลือกจังหวัด")
                Exit Sub
            Else
                IdxProvince = cboProvince.SelectedValue.ToString()
            End If

            If cboAmphur.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาเลือกอำเภอ")
                Exit Sub
            Else
                IdxAmphur = cboAmphur.SelectedValue.ToString()
            End If

            If cboTambol.SelectedIndex < 0 Then
                MessageBox.Show("กรุณาเลือกตำบล")
                Exit Sub
            Else
                IdxTambol = cboTambol.SelectedValue.ToString()
            End If

            If PictureBox1.Image Is Nothing Then
                MessageBox.Show("กรุณากรอกรูป")
                Exit Sub
            End If

            If txtMobile.MaskCompleted = False Then
                MessageBox.Show("กรุณาโทรศัพท์")
                Exit Sub
            End If

            If strEmail = "" Then
                MessageBox.Show("กรุณาวันอีเมล")
                Exit Sub
            End If
            Console.Write(IdxMarryStatus)
            Console.Write(IdxPrename)
            Console.Write(dtBirthDate)
            Dim ms As New MemoryStream
            Dim comd As New MySqlCommand
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim strSql As String = "INSERT INTO person(cid,prename,fname,lname,sex,age,birthdate,marrystatus,ocupation,ocother,adddress,mubanno,banname,tambol,amphur,province,zipcode,mobile,email,picture,prename_id,marrystatus_id,ocupation_id,tambol_id,amphur_id,province_id) VALUES(@cid,@prename,@fname,@lname,@sex,@age,@birthdate,@marrystatus,@ocupation,@ocother,@adddress,@mubanno,@banname,@tambol,@amphur,@province,@zipcode,@mobile,@email,@picture,@prename_id,@marrystatus_id,@ocupation_id,@tambol_id,@amphur_id,@province_id)"

            comd.Connection = myconn
            comd.CommandText = strSql

            comd.Parameters.AddWithValue("@cid", strCID)
            comd.Parameters.AddWithValue("@prename", strPrename)
            comd.Parameters.AddWithValue("@fname", strFname)
            comd.Parameters.AddWithValue("@lname", strLname)
            comd.Parameters.AddWithValue("@sex", nameSex)
            comd.Parameters.AddWithValue("@age", strAge)
            comd.Parameters.AddWithValue("@birthdate", dtBirthDate)
            comd.Parameters.AddWithValue("@marrystatus", strMarryStatus)
            comd.Parameters.AddWithValue("@ocupation", strOcupation)
            comd.Parameters.AddWithValue("@ocother", strOcOther)
            comd.Parameters.AddWithValue("@adddress", strAddress)
            comd.Parameters.AddWithValue("@mubanno", strMubanNo)
            comd.Parameters.AddWithValue("@banname", strBanName)
            comd.Parameters.AddWithValue("@tambol", strTambol)
            comd.Parameters.AddWithValue("@amphur", strAmphur)
            comd.Parameters.AddWithValue("@province", strProvince)
            comd.Parameters.AddWithValue("@zipcode", strZipCode)
            comd.Parameters.AddWithValue("@mobile", strMobile)
            comd.Parameters.AddWithValue("@email", strEmail)
            comd.Parameters.AddWithValue("@picture", ms.ToArray())

            comd.Parameters.AddWithValue("@prename_id", IdxPrename)
            comd.Parameters.AddWithValue("@marrystatus_id", IdxMarryStatus)
            comd.Parameters.AddWithValue("@ocupation_id", IdxOcupation)
            comd.Parameters.AddWithValue("@tambol_id", IdxTambol)
            comd.Parameters.AddWithValue("@amphur_id", IdxAmphur)
            comd.Parameters.AddWithValue("@province_id", IdxProvince)
            comd.ExecuteNonQuery()
            clearAll()

            displayDBGrid()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub clearAll()
        txtFname.Text = ""
        txtLname.Text = ""
        PictureBox1.Image = Nothing
        lblrowid.Text = ""
        txtOcOther.Text = ""
        radSexMan.Checked = False
        radSexWoman.Checked = False
        strnameSex = ""
        txtCID.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        cboBirthDate.Value = Now
        txtAge.Text = ""
        txtAddress.Text = ""
        txtMubanNo.Text = ""
        txtBanName.Text = ""

        txtZipCode.Text = ""
        txtMobile.Text = ""
        txtEmail.Text = ""
        With cboMarryStatus
            .SelectedIndex = -1
            .Text = " เลือก "
        End With
        With cboProvince
            .SelectedIndex = -1
            .Text = " เลือก "
        End With
        With cboAmphur
            .SelectedIndex = -1
            .Text = ""
        End With
        With cboTambol
            .SelectedIndex = -1
            .Text = ""
        End With
        With cboPrename
            .SelectedIndex = -1
            .Text = ""
        End With
        With cboOcupation
            .SelectedIndex = -1
            .Text = " เลือก "
        End With
        cboAmphur.Enabled = False
        cboTambol.Enabled = False
    End Sub


    Private Sub displayDBGrid()
        Try
            Dim SQL As String = ""
            SQL = "SELECT IFNULL(rowid,'') As rowid,  " &
                "IFNULL(cid,'') As cid, " &
                "IFNULL(prename,'') As prename, " &
                "IFNULL(fname,'') As fname, " &
                "IFNULL(lname,'') As lname, " &
                "IFNULL(sex,'') As sex, " &
                "IFNULL(age,'') As age, " &
                "IFNULL(birthdate,'9999-99-99') As birthdate, " &
                "IFNULL(marrystatus,'') As marrystatus, " &
                "IFNULL(ocupation,'') As ocupation, " &
                "IFNULL(ocother,'') As ocother, " &
                "IFNULL(adddress,'') As adddress, " &
                "IFNULL(mubanno,'') As mubanno, " &
                "IFNULL(banname,'') As banname, " &
                "IFNULL(tambol,'') As tambol, " &
                "IFNULL(amphur,'') As amphur, " &
                "IFNULL(province,'') As province, " &
                "IFNULL(zipcode,'') As zipcode, " &
                "IFNULL(mobile,'') As mobile, " &
                "IFNULL(email,'') As email, " &
                 "IFNULL(picture,'dbnull') As picture " &
                  "FROM person " &
                   " ORDER BY rowid DESC"
            Dim com As New MySqlCommand(SQL, myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    'Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
    '    Try
    '        If e.RowIndex >= 0 Then
    '            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
    '            Dim xid As Integer = row.Cells(0).Value
    '            Dim SQL1 As String = "DELETE FROM person WHERE rowid=" & xid & ""

    '            Dim com As New MySqlCommand
    '            com.Connection = myconn
    '            com.CommandText = SQL1
    '            com.ExecuteNonQuery()

    '        End If


    '        displayDBGrid()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Exit Sub
    '    End Try
    'End Sub
 


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim xid As Integer = row.Cells(0).Value
                Dim SQL1 As String = "SELECT IFNULL(rowid,'') As rowid,  " &
                     "IFNULL(cid,'') As cid, " &
                "IFNULL(prename,'') As prename, " &
                "IFNULL(fname,'') As fname, " &
                "IFNULL(lname,'') As lname, " &
                "IFNULL(sex,'') As sex, " &
                "IFNULL(age,'') As age, " &
                "IFNULL(birthdate,'9999-99-99') As birthdate, " &
                "IFNULL(marrystatus,'') As marrystatus, " &
                "IFNULL(ocupation,'') As ocupation, " &
                "IFNULL(ocother,'') As ocother, " &
                "IFNULL(adddress,'') As adddress, " &
                "IFNULL(mubanno,'') As mubanno, " &
                "IFNULL(banname,'') As banname, " &
                "IFNULL(tambol,'') As tambol, " &
                "IFNULL(amphur,'') As amphur, " &
                "IFNULL(province,'') As province, " &
                "IFNULL(zipcode,'') As zipcode, " &
                "IFNULL(mobile,'') As mobile, " &
                "IFNULL(email,'') As email, " &
                "IFNULL(picture,'dbnull') As picture, " &
                "IFNULL(prename_id,'') As prename_id, " &
                "IFNULL(marrystatus_id,'') As marrystatus_id, " &
                "IFNULL(ocupation_id,'') As ocupation_id, " &
                "IFNULL(tambol_id,'') As tambol_id, " &
                "IFNULL(amphur_id,'') As amphur_id, " &
                "IFNULL(province_id,'') As province_id " &
                    " FROM person WHERE rowid= " & xid & " "
                intRowid = xid
                lblrowid.Text = xid.ToString
                Dim com As New MySqlCommand(SQL1, myconn)
                Dim da As New MySqlDataAdapter(com)
                Dim ds As New DataSet()
                Dim thaiCulture As New System.Globalization.CultureInfo("th-TH")
                Dim engCulture As New System.Globalization.CultureInfo("en-US")
                Dim dtStr As String = ""
                Dim intsex As Integer
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    txtCID.Text = ds.Tables(0).Rows(0).Item("cid")
                    cboPrename.SelectedIndex = ds.Tables(0).Rows(0).Item("prename_id")
                    intsex = ds.Tables(0).Rows(0).Item("prename_id")
                    If intsex = 0 Or intsex = 3 Then
                        radSexMan.Checked = True
                    Else
                        radSexWoman.Checked = True
                    End If

                    txtFname.Text = ds.Tables(0).Rows(0).Item("fname")
                    txtLname.Text = ds.Tables(0).Rows(0).Item("lname")
                    txtOcOther.Text = ds.Tables(0).Rows(0).Item("ocother")

                    txtAge.Text = ds.Tables(0).Rows(0).Item("age")
                    txtAddress.Text = ds.Tables(0).Rows(0).Item("adddress")
                    txtMubanNo.Text = ds.Tables(0).Rows(0).Item("mubanno")
                    txtBanName.Text = ds.Tables(0).Rows(0).Item("banname")

                    txtZipCode.Text = ds.Tables(0).Rows(0).Item("zipcode")
                    txtMobile.Text = ds.Tables(0).Rows(0).Item("mobile")
                    txtEmail.Text = ds.Tables(0).Rows(0).Item("email")

                    dtStr = ds.Tables(0).Rows(0).Item("birthdate").ToString()
                   
                    Dim dateSelect As DateTime = DateTime.ParseExact(dtStr, "yyyy-MM-dd", engCulture)

                    cboBirthDate.Value = dateSelect

                    cboMarryStatus.SelectedValue = ds.Tables(0).Rows(0).Item("marrystatus_id")
                    cboOcupation.SelectedValue = ds.Tables(0).Rows(0).Item("ocupation_id")
                    cboPrename.SelectedIndex = ds.Tables(0).Rows(0).Item("prename_id")


                    cboAmphur.Enabled = True
                    cboTambol.Enabled = True
                    cboProvince.SelectedValue = ds.Tables(0).Rows(0).Item("province_id")
                    showAmphur(cboProvince.SelectedValue.ToString)
                    cboAmphur.SelectedValue = ds.Tables(0).Rows(0).Item("amphur_id")
                    showTambol(cboProvince.SelectedValue.ToString, cboAmphur.SelectedValue.ToString)
                    cboTambol.SelectedValue = ds.Tables(0).Rows(0).Item("tambol_id")

                 

                    Dim bytBLOBData() As Byte = ds.Tables(0).Rows(0).Item("picture")
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    PictureBox1.Image = Image.FromStream(stmBLOBData)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btnEditSaveData_Click(sender As Object, e As EventArgs) Handles btnEditSaveData.Click
        Try
            If lblrowid.Text = String.Empty Then
                MessageBox.Show("กรุณาเลือกรายการ", "DATA")
                Exit Sub
            End If


            Dim strCID As String = txtCID.Text
            Dim strFname As String = txtFname.Text
            Dim strLname As String = txtLname.Text
            Dim dtBirthDate As Date = cboBirthDate.Value


            Dim strAge As String = txtAge.Text
            Dim strAddress As String = txtAddress.Text
            Dim strMubanNo As String = txtMubanNo.Text
            Dim strBanName As String = txtBanName.Text

            Dim strZipCode As String = txtZipCode.Text
            Dim strMobile As String = txtMobile.Text
            Dim strEmail As String = txtEmail.Text


            Dim strOcupation As String = cboOcupation.Text
            Dim strPrename As String = cboPrename.Text
            Dim strMarryStatus As String = cboMarryStatus.Text
            Dim strProvince As String = cboProvince.Text
            Dim strAmphur As String = cboAmphur.Text
            Dim strTambol As String = cboTambol.Text
            Dim strOcOther As String = txtOcOther.Text

            Dim IdxMarryStatus As String = ""
            Dim IdxProvince As String = ""
            Dim IdxAmphur As String = ""
            Dim IdxTambol As String = ""
            Dim IdxOcupation As String = ""
            Dim IdxPrename As String = ""
            Dim nameSex As String = strnameSex


         

            Dim getid As Integer = intRowid
            Dim comd As New MySqlCommand
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim result As DialogResult = MessageBox.Show("คุณต้องแก้ไขใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = vbOK Then
                If txtCID.MaskCompleted = False Then
                    MessageBox.Show("กรุณากรอกบัตรประชาชน")
                    Exit Sub
                End If

                If cboPrename.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาใส่คำนำหน้า")
                    Exit Sub
                Else
                    IdxPrename = cboPrename.SelectedIndex.ToString()
                End If
                If strFname = "" Then
                    MessageBox.Show("กรุณากรอก")
                    Exit Sub
                End If
                If strLname = "" Then
                    MessageBox.Show("กรุณานามสกุล")
                    Exit Sub
                End If

                If cboMarryStatus.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาเลือกสถานะ")
                    Exit Sub
                Else
                    IdxMarryStatus = cboMarryStatus.SelectedValue.ToString()
                End If

                If strAge = "" Then
                    MessageBox.Show("กรุณาวันเกิด")
                    Exit Sub
                End If

                If cboOcupation.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาเลือกอาชีพ")
                    Exit Sub
                Else
                    IdxOcupation = cboOcupation.SelectedValue.ToString()
                End If

                If strAddress = "" Then
                    MessageBox.Show("กรุณาที่อยู่")
                    Exit Sub
                End If

                If strMubanNo = "" Then
                    MessageBox.Show("กรุณาวันหมู่")
                    Exit Sub
                End If

                If strBanName = "" Then
                    MessageBox.Show("กรุณาวันบ้าน")
                    Exit Sub
                End If

                If cboProvince.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาเลือกจังหวัด")
                    Exit Sub
                Else
                    IdxProvince = cboProvince.SelectedValue.ToString()
                End If

                If cboAmphur.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาเลือกอำเภอ")
                    Exit Sub
                Else
                    IdxAmphur = cboAmphur.SelectedValue.ToString()
                End If

                If cboTambol.SelectedIndex < 0 Then
                    MessageBox.Show("กรุณาเลือกตำบล")
                    Exit Sub
                Else
                    IdxTambol = cboTambol.SelectedValue.ToString()
                End If

                If PictureBox1.Image Is Nothing Then
                    MessageBox.Show("กรุณากรอกรูป")
                    Exit Sub
                End If

                If strMobile = "" Then
                    MessageBox.Show("กรุณาโทรศัพท์")
                    Exit Sub
                End If

                If strEmail = "" Then
                    MessageBox.Show("กรุณาวันอีเมล")
                    Exit Sub
                End If


                Dim strSql As String = "UPDATE  person SET " &
                     "cid=@cid, " &
                    "prename=@prename, " &
                    "fname=@fname, " &
                    "lname=@lname, " &
                    "sex=@sex, " &
                    "age=@age, " &
                    "birthdate=@birthdate, " &
                    "marrystatus=@marrystatus, " &
                    "ocupation=@ocupation, " &
                    "ocother=@ocother, " &
                    "adddress=@adddress, " &
                    "mubanno=@mubanno, " &
                    "banname=@banname, " &
                    "tambol=@tambol, " &
                    "amphur=@amphur, " &
                    "province=@province, " &
                    "zipcode=@zipcode, " &
                    "mobile=@mobile, " &
                    "email=@email, " &
                    "picture=@picture, " &
                     "prename_id=@prename_id, " &
                      "marrystatus_id=@marrystatus_id, " &
                       "tambol_id=@tambol_id, " &
                        "amphur_id=@amphur_id, " &
                         "province_id=@province_id " &
                " WHERE rowid=" & getid & " "
                With comd
                    .Connection = myconn
                    .CommandText = strSql
                    .Parameters.AddWithValue("@cid", strCID)
                    .Parameters.AddWithValue("@prename", strPrename)
                    .Parameters.AddWithValue("@fname", strFname)
                    .Parameters.AddWithValue("@lname", strLname)
                    .Parameters.AddWithValue("@sex", nameSex)
                    .Parameters.AddWithValue("@age", strAge)
                    .Parameters.AddWithValue("@birthdate", dtBirthDate)
                    .Parameters.AddWithValue("@marrystatus", strMarryStatus)
                    .Parameters.AddWithValue("@ocupation", strOcupation)
                    .Parameters.AddWithValue("@ocother", strOcOther)
                    .Parameters.AddWithValue("@adddress", strAddress)
                    .Parameters.AddWithValue("@mubanno", strMubanNo)
                    .Parameters.AddWithValue("@banname", strBanName)
                    .Parameters.AddWithValue("@tambol", strTambol)
                    .Parameters.AddWithValue("@amphur", strAmphur)
                    .Parameters.AddWithValue("@province", strProvince)
                    .Parameters.AddWithValue("@zipcode", strZipCode)
                    .Parameters.AddWithValue("@mobile", strMobile)
                    .Parameters.AddWithValue("@email", strEmail)
                    .Parameters.AddWithValue("@picture", ms.ToArray())

                    .Parameters.AddWithValue("@prename_id", IdxPrename)
                    .Parameters.AddWithValue("@marrystatus_id", IdxMarryStatus)
                    .Parameters.AddWithValue("@ocupation_id", IdxOcupation)
                    .Parameters.AddWithValue("@tambol_id", IdxTambol)
                    .Parameters.AddWithValue("@amphur_id", IdxAmphur)
                    .Parameters.AddWithValue("@province_id", IdxProvince)
                End With
                comd.ExecuteNonQuery()


                clearAll()

                displayDBGrid()
            End If
   
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        displayDBGrid()
        DataGridView1.Columns(20).Visible = False
    End Sub



    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub cboOcupation_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboOcupation.SelectionChangeCommitted
        strIdxOcupation = cboOcupation.SelectedValue.ToString
        txtOcOther.Text = ""
        If strIdxOcupation = "9998" Then
            txtOcOther.Enabled = True
        Else
            txtOcOther.Enabled = False
        End If

    End Sub

    Private Sub cboMarryStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMarryStatus.SelectionChangeCommitted
        strIdxMarryStatus = cboMarryStatus.SelectedValue.ToString
    End Sub

    Private Sub txtCID_Validated(sender As Object, e As EventArgs) Handles txtCID.Validated
        Dim regex As Regex = New Regex("^\d-\d{4}-\d{5}-\d{2}-\d$")
        Dim isValid As Boolean = regex.IsMatch(txtCID.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid CID.")
            txtCID.ForeColor = Color.Red
            txtCID.Focus()
        Else
            txtCID.ForeColor = Color.Black
        End If
    End Sub


    Private Sub cboPrename_Validated(sender As Object, e As EventArgs) Handles cboPrename.Validated
        If cboPrename.SelectedIndex < 0 Then
            ErrorProvider1.SetError(txtFname, " Please enter the text do not leave blank")
        Else
            ErrorProvider1.SetError(txtFname, "")
        End If
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = System.Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                PictureBox1.Image = Image.FromFile(path)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnShowImage_Click(sender As Object, e As EventArgs) Handles btnShowImage.Click
        displayDBGrid()
        DataGridView1.Columns(20).Visible = True
    End Sub

    Private Sub btnDeleteData_Click(sender As Object, e As EventArgs) Handles btnDeleteData.Click
        Try

            If lblrowid.Text = String.Empty Then
                MessageBox.Show("กรุณาเลือกรายการ", "DATA")
                Exit Sub
            End If

            Dim result As DialogResult = MessageBox.Show("คุณต้องลบใช่หรือไม่", "SetPrinter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = vbOK Then
                Dim SQL1 As String = "DELETE FROM person WHERE rowid=" & lblrowid.Text & ""
                Dim com As New MySqlCommand
                com.Connection = myconn
                com.CommandText = SQL1
                com.ExecuteNonQuery()

                displayDBGrid()
                clearAll()
            End If


      
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try

    End Sub


    Private Sub btnPrintData_Click(sender As Object, e As EventArgs) Handles btnPrintData.Click
        frmReportViewer.ShowDialog()
    End Sub

 
    Private Sub btnShowChart_Click(sender As Object, e As EventArgs) Handles btnShowChart.Click
        ShowChart()
    End Sub

    Private Sub ShowChart()
        Try
            Chart1.Series.Clear()
            Chart1.Titles.Clear()

            Chart1.Titles.Add("แผนภูมิแสดงจำนวนประชากร")

            'Chart1.ChartAreas(0).AxisX.LineWidth = 0
            'Chart1.ChartAreas(0).AxisY.LineWidth = 0
            'Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
            'Chart1.ChartAreas(0).AxisY.LabelStyle.Enabled = False
            'Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            'Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
            'Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False
            'Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = False
            'Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
            'Chart1.ChartAreas(0).AxisY.MajorTickMark.Enabled = False
            'Chart1.ChartAreas(0).AxisX.MinorTickMark.Enabled = False
            'Chart1.ChartAreas(0).AxisY.MinorTickMark.Enabled = False

            With Chart1.ChartAreas("ChartArea1")
                .AxisX.Title = "เดือน"
                .AxisY.Title = "จำนวน"
                .AxisX.MajorGrid.LineColor = Color.Green

            End With




            Chart1.Series.Add("Sex")

            With Chart1.Series("Sex").Points()
                .Add(13).AxisLabel = "hhh"
                .Add(17).AxisLabel = "kmmmkk"
                .Add(24).AxisLabel = "kllkk"
                .Add(34).AxisLabel = "k;;kk"
                .Add(15).AxisLabel = "ppkkk"
            End With



            Chart1.Series.Add("Age")
            Chart1.Series("Age").ChartType = DataVisualization.Charting.SeriesChartType.Line
            'Chart1.Series("Age")("PixelPointWidth") = "4"
            With Chart1.Series("Age")
                .BorderWidth = 4
                .MarkerSize = 4
                .MarkerColor = Color.Black
                .MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            End With
            With Chart1.Series("Age").Points()
                .Add(12).AxisLabel = "hhh"
                .Add(20).AxisLabel = "kmmmkk"
                .Add(15).AxisLabel = "kllkk"
                .Add(25).AxisLabel = "k;;kk"
                .Add(32).AxisLabel = "ppkkk"
            End With



            Chart1.Series("Age").IsValueShownAsLabel = True
            Chart1.Series("Sex").IsValueShownAsLabel = True
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
   



        'Dim dt As New DataTable
        'dt.Clear()
        'Dim drRpt As DataRow = Nothing


        'Dim Coulumn1 = New DataColumn("DataColumn1", Type.GetType("System.String"))
        'Dim Coulumn2 = New DataColumn("DataColumn2", Type.GetType("System.String"))
        'Dim Coulumn3 = New DataColumn("DataColumn3", Type.GetType("System.String"))
        'Dim Coulumn4 = New DataColumn("DataColumn4", Type.GetType("System.String"))


        'dt.Columns.Add(Coulumn1)
        'dt.Columns.Add(Coulumn2)
        'dt.Columns.Add(Coulumn3)
        'dt.Columns.Add(Coulumn4)


        'Dim strPrename() As String = {"นาย", "นาง", "น.ส.", "ดช.", "ดญ."}
        'For i As Integer = 0 To 5 - 1
        '    drRpt = dt.NewRow()
        '    drRpt("DataColumn1") = strPrename(i)
        '    drRpt("DataColumn2") = CInt(Math.Ceiling(Rnd() * 100)) + 1
        '    'drRpt("DataColumn3") = "3"
        '    'drRpt("DataColumn4") = "10"
        '    dt.Rows.Add(drRpt)
        'Next i

        'Console.Write(dt)

        'Try

        '    Chart1.Series.Add("Series1")
        '    Chart1.ChartAreas("ChartArea1").AxisX.Title = "Chart Area X Axis Label"
        '    Chart1.ChartAreas("ChartArea1").AxisY.Title = "Chart Area Y Axis Label"
        '    Chart1.Series("Series1").XValueMember = "DataColumn1"
        '    Chart1.Series("Series1").YValueMembers = "DataColumn2"
        '    Chart1.DataSource = dt
        '    Chart1.DataBind()
        'Catch ex As Exception
        '    MessageBox.Show("err" & ex.Message)
        '    Exit Sub
        'End Try

    End Sub

 

    Private Sub btnChart2_Click(sender As Object, e As EventArgs) Handles btnChart2.Click
        Try

            Dim cnt As Integer = 0
            Chart2.Series.Clear()
            Chart2.Titles.Clear()

            Chart2.Titles.Add("แผนภูมิแสดงจำนวนประชากร")

            Dim com As New MySqlCommand("SELECT * FROM playweek ", myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)

            cnt = ds.Tables(0).Rows.Count - 1

            Dim xPie(cnt) As Integer
            Dim xName(cnt) As String

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To cnt - 1
                    xName(i) = ds.Tables(0).Rows(i).Item("day")
                    xPie(i) = ds.Tables(0).Rows(i).Item("amount")
                Next
            End If


            'With Chart2.ChartAreas("ChartArea1")
            '    .AxisX.Title = "เดือน"
            '    .AxisY.Title = "จำนวน"
            '    .AxisX.MajorGrid.LineColor = Color.Green

            'End With



            Chart2.Series.Add("Age")
            Chart2.Series("Age").ChartType = DataVisualization.Charting.SeriesChartType.Pie
            'Chart1.Series("Age")("PixelPointWidth") = "4"
            'With Chart2.Series("Age")
            '    .BorderWidth = 4
            '    .MarkerSize = 4
            '    .MarkerColor = Color.Black
            '    .MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            'End With
            With Chart2.Series("Age").Points()
                For i As Integer = 0 To cnt - 1
                    .Add(xPie(i)).AxisLabel = xName(i)
                Next
                '.Add(12).AxisLabel = "A"
                '.Add(20).AxisLabel = "B"
                '.Add(15).AxisLabel = "C"
                '.Add(25).AxisLabel = "D"
                '.Add(32).AxisLabel = "E"
            End With

            Chart2.Series("Age").IsValueShownAsLabel = True


        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        clearAll()
    End Sub
End Class