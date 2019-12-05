Imports System.Data.SqlClient

Public Class GetData

    'the connection string
    Private Function SC()
        Return "Data Source=;
                Initial Catalog=;
                User ID=;Password=;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False"
    End Function

    Public Function ConnectionDB(query As String) As DataTable
        'creates the connection  to the database
        Dim connection As New SqlConnection(SC)
        connection.Open()

        'creates the commands to extract the required data
        Dim command As SqlCommand = connection.CreateCommand()
        command.CommandText() = query

        'gets the table from the db and updates it in memory
        Dim adapter As New SqlDataAdapter(command)

        'data that will be returned from this method
        Dim data As New DataTable()
        adapter.Fill(data)

        'closes the connection
        connection.Close()

        Return data

    End Function

    ''' <summary>
    ''' Lazy Method to add Data to the db - should be refactored to sanitize the data
    ''' But since it's always the same data that is added, it can be made like this
    ''' </summary>
    Public Sub AddData()
        Dim query As String = $"Insert into Viagem(viatura, dias, quilometros) values
                                (1,2,800),(2,1,300),(3,2,600),(1,1,400),(1,1,200);"
        ConnectionDB(query)

    End Sub

    ''' <summary>
    ''' Lazy Method to erase all data from the DB
    ''' </summary>
    Public Sub DeleteAllData()

        Dim query As String = $"Delete from Viagem where Viagem.id > 0;"
        ConnectionDB(query)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub DeleteData(id As String)

        Dim query As String = $"Delete from Viagem where Viagem.id = {id};"
        ConnectionDB(query)
    End Sub

    ''' <summary>
    ''' updating the db from the grid 
    ''' </summary>
    ''' <param name="marca"></param>
    ''' <param name="dias"></param>
    ''' <param name="quilometros"></param>
    ''' <param name="id"></param>
    Public Sub UpdateData(marca As String, dias As String, quilometros As String, id As String, id_veiculo As String)
        Dim query As String = $"Update Viagem set dias = {dias}, quilometros = {quilometros} 
                                where Viagem.id = {id};"

        Dim queryVeiculo = $"Update Viaturas set marca = '{marca}' where Viaturas.id = {id_veiculo};"


        Dim connection As New SqlConnection(SC)
        Dim command As SqlCommand

        connection.Open()
        command = New SqlCommand(query, connection)

        command.ExecuteNonQuery()

        'new command for the car
        command = New SqlCommand(queryVeiculo, connection)
        command.ExecuteNonQuery()

        connection.Close()

    End Sub
End Class
