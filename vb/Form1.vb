Public Class Form1

    Private Sub LogInToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem1.Click
        Form2.Show()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If LogInToolStripMenuItem.Enabled = True Then

            BOOKISSUEToolStripMenuItem.Enabled = False
            BOOKRETURNToolStripMenuItem.Enabled = False
            ADDABOOKToolStripMenuItem.Enabled = False
            BOOKINFORMATIONToolStripMenuItem1.Enabled = False
            REPORTToolStripMenuItem.Enabled = False



        End If




    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        If LogOutToolStripMenuItem.Enabled = True Then
            BOOKISSUEToolStripMenuItem.Enabled = False
            Me.BOOKRETURNToolStripMenuItem.Enabled = False
            Me.ADDABOOKToolStripMenuItem.Enabled = False
            Me.BOOKINFORMATIONToolStripMenuItem1.Enabled = False
            Me.LogInToolStripMenuItem.Enabled = True

        End If



    End Sub

    Private Sub OPENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub VIEWDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWDATAToolStripMenuItem.Click
        Form4.Show()

    End Sub

    Private Sub OPENToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem1.Click
        Form5.Show()

    End Sub

    Private Sub VIEWDATAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWDATAToolStripMenuItem1.Click
        Form6.Show()

    End Sub

    Private Sub OPENToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem2.Click
        Form7.Show()

    End Sub

    Private Sub VIEWDATAToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWDATAToolStripMenuItem2.Click
        Form8.Show()

    End Sub

    Private Sub BOOKINFORMATIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKINFORMATIONToolStripMenuItem1.Click

    End Sub
    Private Sub OPENToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENToolStripMenuItem3.Click
        Form9.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        Me.Close()



    End Sub

    Private Sub CLOSEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub CLOSEToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem2.Click
        Me.Close()

    End Sub

    Private Sub CLOSEToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem3.Click
        Me.Close()

    End Sub

    Private Sub ADDBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDBOOKToolStripMenuItem.Click
        Form10.Show()

    End Sub

    Private Sub BOOKINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKINFORMATIONToolStripMenuItem.Click
        Form11.Show()

    End Sub

    Private Sub BOOKISSUEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKISSUEToolStripMenuItem1.Click
        Form12.Show()
    End Sub

    Private Sub BOOKRETURNToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKRETURNToolStripMenuItem1.Click
        Form13.Show()

    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub
End Class