Public Class Form2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim USERNAME, PASSWORD As String
        USERNAME = TextBox1.Text
        PASSWORD = TextBox2.Text
        If USERNAME = "bca" And PASSWORD = "library" Then
            Form1.LogInToolStripMenuItem.Enabled = False
            Form1.BOOKISSUEToolStripMenuItem.Enabled = True
            Form1.BOOKRETURNToolStripMenuItem.Enabled = True
            Form1.ADDABOOKToolStripMenuItem.Enabled = True
            Form1.BOOKINFORMATIONToolStripMenuItem1.Enabled = True
            Form1.REPORTToolStripMenuItem.Enabled = True
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("PLEASE RE-ENTER THE USERNAME AND PASSWORD")


        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class