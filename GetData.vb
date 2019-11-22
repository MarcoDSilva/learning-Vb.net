Imports System.Data.SqlClient

Public Class GetData

    'the connection string
    Private Function SC()
        Return "Data Source=;
                Initial Catalog=DB_ProdutosMS_VBasic;
                User ID=;Password=;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False"
    End Function

    Public Function DBConnection(query As String) As DataSet
        'creates the connection  to the database
        Dim connection As New SqlConnection(SC)
        connection.Open()

        'creates the commands to extract the required data
        Dim command As SqlCommand = connection.CreateCommand()
        command.CommandText() = query

        'gets the table from the db and updates it in memory
        Dim adapter As New SqlDataAdapter(command)

        'data that will be returned from this method
        Dim data As New DataSet()
        adapter.Fill(data)

        'closes the connection
        connection.Close()

        Return data

    End Function



End Class
