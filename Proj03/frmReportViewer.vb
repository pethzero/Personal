Imports MySql.Data.MySqlClient
Public Class frmReportViewer


    Dim myconn As MySqlConnection
    Dim dsRpt As New DataSet
    Dim CurrentReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()


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

    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connMySQL()

        Dim dt As New DataTable
        dt.Clear()
        Dim drRpt As DataRow = Nothing

        Dim Coulumn1 = New DataColumn("DataColumn1", Type.GetType("System.String"))
        Dim Coulumn2 = New DataColumn("DataColumn2", Type.GetType("System.String"))
        Dim Coulumn3 = New DataColumn("DataColumn3", Type.GetType("System.String"))
        Dim Coulumn4 = New DataColumn("DataColumn4", Type.GetType("System.String"))
        Dim Coulumn5 = New DataColumn("DataColumn5", Type.GetType("System.String"))
        Dim Coulumn6 = New DataColumn("DataColumn6", Type.GetType("System.String"))
        'Dim Coulumn7 = New DataColumn("DataColumn7", Type.GetType("System.String"))

        dt.Columns.Add(Coulumn1)
        dt.Columns.Add(Coulumn2)
        dt.Columns.Add(Coulumn3)
        dt.Columns.Add(Coulumn4)
        dt.Columns.Add(Coulumn5)
        dt.Columns.Add(Coulumn6)
        'dt.Columns.Add(Coulumn7)
        Try
            Dim com As New MySqlCommand("SELECT * FROM person ORDER BY ROWID DESC", myconn)
            Dim da As New MySqlDataAdapter(com)
            Dim ds As New DataSet()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    dsRpt.Tables.Clear()
                    drRpt = dt.NewRow()
                    drRpt("DataColumn1") = (i + 1).ToString
                    drRpt("DataColumn2") = ds.Tables(0).Rows(i).Item("fname")
                    drRpt("DataColumn3") = ds.Tables(0).Rows(i).Item("lname")
                    drRpt("DataColumn4") = ds.Tables(0).Rows(i).Item("birthdate")
                    drRpt("DataColumn5") = "100.50"
                    drRpt("DataColumn6") = "5"
                    'drRpt("DataColumn7")
                    dt.Rows.Add(drRpt)
                    dsRpt.Tables.Add(dt)
                Next i

            End If
        Catch ex As Exception
            MessageBox.Show("err" & ex.Message)
            Exit Sub
        End Try

        Me.ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\rptPerson.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        CurrentReportDataSource.Name = "DataSet1"
        CurrentReportDataSource.value = dsRpt.Tables(0)
        Me.ReportViewer1.LocalReport.DataSources.Add(CurrentReportDataSource)
        Me.ReportViewer1.RefreshReport()

        myconn.Close()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class