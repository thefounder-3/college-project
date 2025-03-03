Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBDataSet4.BOOKRETURN' table. You can move, or remove it, as needed.
        Me.BOOKRETURNTableAdapter1.Fill(Me.LIBDataSet4.BOOKRETURN)
        'TODO: This line of code loads data into the 'LIBDataSet1.BOOKRETURN' table. You can move, or remove it, as needed.
        Me.BOOKRETURNTableAdapter.Fill(Me.LIBDataSet1.BOOKRETURN)

    End Sub
End Class