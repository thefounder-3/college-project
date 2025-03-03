Imports System.data
Imports system.data.oledb
Public Class Form7
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LIB.mdb"
    Dim sSQL = "SELECT * from ADDABOOK"
    Dim connCust As New OleDb.OleDbConnection(sConnectionString)
    Dim cmd As New OleDbCommand(sSQL, connCust)
    Dim da As New OleDb.OleDbDataAdapter(sSQL, connCust)
    Dim objDS As New DataSet("customer")

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objConn As New OleDb.OleDbConnection(sConnectionString)
        Dim strinsert As String
        strinsert = "insert into ADDABOOK values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
        Dim objCmd = New OleDb.OleDbCommand(strinsert, objConn)
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Try
                objConn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If objConn.State = ConnectionState.Open Then
                Try
                    objCmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            MsgBox("Record Added")
        Else
            MsgBox("One or more fields are blank.. Please fill.!")
        End If
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connCust.Open()

        da.Fill(objDS, "customer")
        connCust.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String = "delete from ADDABOOK where BOOKCODE =  " & TextBox1.Text & " "
        Dim objConn As New Data.OleDb.OleDbConnection(sConnectionString)
        Dim objCmd As New Data.OleDb.OleDbCommand(sql, objConn)
        Try
            objConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Ready for deleting record")
        If objConn.State = ConnectionState.Open Then
            Try
                objCmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        MsgBox("Record deleted")
        objConn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        inc = 0
        NavigateRecords()
        MsgBox("First Record")
    End Sub
    Private Sub NavigateRecords()
        TextBox1.Text = objDS.Tables("customer").Rows(inc).Item(0)
        TextBox2.Text = objDS.Tables("customer").Rows(inc).Item(1)
        TextBox3.Text = objDS.Tables("customer").Rows(inc).Item(2)
        TextBox4.Text = objDS.Tables("customer").Rows(inc).Item(3)
        TextBox5.Text = objDS.Tables("customer").Rows(inc).Item(4)
        TextBox6.Text = objDS.Tables("customer").Rows(inc).Item(5)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        Else
            MsgBox("First Record")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MaxRows = objDS.Tables("customer").Rows.Count
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No more records")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MaxRows = objDS.Tables("customer").Rows.Count
        inc = MaxRows - 1
        NavigateRecords()
        MsgBox("Last Record")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class


