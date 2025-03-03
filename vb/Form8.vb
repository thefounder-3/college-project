Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBDataSet3.ADDABOOK' table. You can move, or remove it, as needed.
        Me.ADDABOOKTableAdapter1.Fill(Me.LIBDataSet3.ADDABOOK)
        'TODO: This line of code loads data into the 'LIBDataSet2.ADDABOOK' table. You can move, or remove it, as needed.
        Me.ADDABOOKTableAdapter.Fill(Me.LIBDataSet2.ADDABOOK)

    End Sub
End Class