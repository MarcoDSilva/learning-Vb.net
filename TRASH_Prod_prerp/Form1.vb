Public Class Form1



    Private Sub btn_list_Click(sender As Object, e As EventArgs) Handles btn_list.Click
        Dim connection As New GetData

        Dim query As String = "select * from Produtos"
        grid_info.DataSource = connection.DBConnection(query).Tables(0)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
