Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBDataSet5.BOOKISSUE' table. You can move, or remove it, as needed.
        Me.BOOKISSUETableAdapter1.Fill(Me.LIBDataSet5.BOOKISSUE)
        'TODO: This line of code loads data into the 'LIBDataSet.BOOKISSUE' table. You can move, or remove it, as needed.
        Me.BOOKISSUETableAdapter.Fill(Me.LIBDataSet.BOOKISSUE)

    End Sub
End Class