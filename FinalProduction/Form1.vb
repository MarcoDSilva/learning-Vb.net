Public Class Form1

    Private Db As New GetData()

    ''' <summary>
    ''' erases the data from the db
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EliminarRegistosDaBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles strip_EliminateRegisters.Click
        Db.DeleteAllData()
        RefreshGrid()
        RefreshCombo()
    End Sub

    ''' <summary>
    ''' creates the new db registers required for the production
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LançarNaBDOsRegistosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles strip_AddRegisters.Click
        Db.AddData()
        RefreshGrid()
        RefreshCombo()
    End Sub

    ''' <summary>
    ''' gets the database info and uploads it to a grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub strip_CopyToGrid_Click(sender As Object, e As EventArgs) Handles strip_CopyToGrid.Click
        RefreshGrid()
        RefreshCombo()
    End Sub

    ''' <summary>
    ''' clears the grid info
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub strip_CleanGrid_Click(sender As Object, e As EventArgs) Handles strip_CleanGrid.Click
        grid_cars.Columns.Clear()
    End Sub

    ''' <summary>
    ''' Refreshes the grid info
    ''' </summary>
    Private Sub RefreshGrid()
        Dim query = "select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura;"
        grid_cars.DataSource = Db.ConnectionDB(query)

        'to lock the ID row , avoiding the user to update the id by accident
        For index = 0 To grid_cars.Rows.Count() - 1
            grid_cars.Rows(index).Cells(0).ReadOnly = True
        Next

        If rdBtn_1day.Checked Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura AND dias = 1;")
        End If

        If rdBtn_2days.Checked Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura AND dias = 2;")
        End If

        If rdBtn_3days.Checked Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura AND dias >= 3;")
        End If
    End Sub

    ''' <summary>
    ''' Refreshes the Combo that contains the respective car names
    ''' </summary>
    Private Sub RefreshCombo()
        Dim query = "select * from Viaturas"
        cmb_Viatura.DataSource = Db.ConnectionDB(query)
        cmb_Viatura.DisplayMember = "marca"
        cmb_Viatura.ValueMember = "id"

        cmb_VeiculosViagem.DataSource = Db.ConnectionDB(query)
        cmb_VeiculosViagem.DisplayMember = "marca"
        cmb_VeiculosViagem.ValueMember = "id"

        Dim queryDelete = "select * from Viagem"
        cmb_idViagem_Apagar.DataSource = Db.ConnectionDB(queryDelete)
        cmb_idViagem_Apagar.DisplayMember = "id"
        cmb_idViagem_Apagar.ValueMember = "id"

    End Sub

    'Form on load methods
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCombo()
    End Sub

    ''' <summary>
    ''' Returns the total kms made by the selected vehicle
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmb_Viatura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Viatura.SelectedIndexChanged
        Try
            Dim id As Integer = cmb_Viatura.SelectedValue
            Dim query = $"Select Sum(quilometros) from Viagem where viatura = {id};"

            Dim qms As String = Db.ConnectionDB(query).Rows(0)(0).ToString

            If id > 0 Then
                lbl_qms.Text = "Quilometros totais da viatura: " + qms
            End If

        Catch ex As Exception
            'nothing
        End Try


    End Sub

    ''' <summary>
    ''' returns the total of trips that chosen vehicle has made
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmb_VeiculosViagem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_VeiculosViagem.SelectedIndexChanged
        Try
            Dim id As Integer = cmb_VeiculosViagem.SelectedValue
            Dim veiculo = cmb_VeiculosViagem.Text
            Dim query = $"Select count(*) from Viagem where viatura = {id} and dias = 2;"

            Dim dias As String = Db.ConnectionDB(query).Rows(0)(0).ToString

            If id > 0 Then
                lbl_Viagens.Text = $"A viatura {veiculo} fez {dias} viagens de 2 dias."
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' returns the car with the most mileage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim veiculo = Db.ConnectionDB("Select top 1 c.marca from Viagem v,Viaturas c
                                        where c.id = v.viatura
                                        GROUP BY c.marca
                                        Order by sum(v.quilometros) desc").Rows(0)(0)

        lbl_CarroMaisQms.Text = $"O carro com mais qms é o carro: {veiculo}."
    End Sub


    ''' <summary>
    ''' updates the db from the grid, after being changed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ActualizaBDRegistoCorrenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizaBDRegistoCorrenteToolStripMenuItem.Click
        Dim id = GetGridValue(0)
        Dim marca = GetGridValue(1)
        Dim dias = GetGridValue(2)
        Dim qms = GetGridValue(3)

        Dim id_veiculo = Db.ConnectionDB($"Select viatura from Viagem where Viagem.id = {id};").Rows(0)(0).ToString

        Db.UpdateData(marca, dias, qms, id, id_veiculo)
        RefreshGrid()
    End Sub

    ''' <summary>
    ''' takes the value from the current selected grid to apply to the update bd function
    ''' </summary>
    ''' <param name="cell"></param>
    ''' <returns></returns>
    Public Function GetGridValue(cell As Integer)
        Return grid_cars.CurrentRow.Cells(cell).Value.ToString
    End Function

    ''' <summary>
    ''' Deletes the selected trip
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_apagarViagem_Click(sender As Object, e As EventArgs) Handles btn_apagarViagem.Click
        Db.DeleteData(cmb_idViagem_Apagar.SelectedValue.ToString)
        RefreshGrid()
        RefreshCombo()
    End Sub

    '======================================== radio btn start ===================================
    Private Sub rdBtn_all_CheckedChanged(sender As Object, e As EventArgs)
        RefreshGrid()
    End Sub

    Private Sub rdBtn_1day_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtn_1day.CheckedChanged
        RefreshGrid()
    End Sub

    Private Sub rdBtn_2plus_CheckedChanged(sender As Object, e As EventArgs) Handles rdBtn_2days.CheckedChanged
        RefreshGrid()
    End Sub
    '======================================== radio btn end ===================================

    ''' <summary>
    ''' combo to refresh the grid with the registers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmb_escolheDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_escolheDias.SelectedIndexChanged
        If cmb_escolheDias.SelectedItem.Equals("Todos os Registos") Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura;")
        End If

        If cmb_escolheDias.SelectedItem.Equals("Um dia") Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura AND dias = 1;")
        End If

        If cmb_escolheDias.SelectedItem.Equals("Dois ou mais") Then
            grid_cars.DataSource = Db.ConnectionDB("select v.id,c.marca,v.dias,v.quilometros from Viagem v, Viaturas c 
                        WHERE c.id = v.viatura AND dias >= 2;")
        End If
    End Sub
End Class
