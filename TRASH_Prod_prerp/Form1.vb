''' <summary>
''' Made by Marco Silva at 30/11/2019 
''' Preparation for the VBnet production that uses CRUD operations
''' </summary>
Public Class Form1

    'Class that makes the connection to the SQL DB
    Dim connection As New GetData

    'Lists all the database information onto a grid
    Private Sub btn_list_Click(sender As Object, e As EventArgs) Handles btn_list.Click
        RefreshGrid()
    End Sub

    'Clears the grid info (not the database items)
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        grid_info.Columns.Clear()
    End Sub


    ''' <summary>
    ''' Form load for the comboboxes dropdown
    ''' We query the "Categorias" table, feed it as datasource to the combo
    ''' then we define "nome" as displaymember and "id" as valuemember
    ''' We also block the grid info to readonly, since we don't want the user to touch the data from it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        RefreshCombo()
        grid_info.ReadOnly = True

    End Sub

    ''' <summary>
    ''' Adds the respective product to the db
    ''' 
    ''' After the combo is filled (at the form load) and this button is selected
    ''' We take the strings from the textboxes for both product name and quantity
    ''' and the value of the member selected from the combobox (ID of the respective Category)
    ''' With this, we make a query and add that item to the list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_addProduct_Click(sender As Object, e As EventArgs) Handles btn_addProduct.Click

        Dim name As String = txt_AddName.Text
        Dim quantity As String = txt_addQuantity.Text
        Dim selectedCategory As String = cmb_addCategoria.SelectedValue

        connection.AddData(name, quantity, selectedCategory)
        RefreshGrid()
        RefreshCombo()
        RefreshLabel()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_delProduct_Click(sender As Object, e As EventArgs) Handles btn_delProduct.Click

        Dim id As String = cmb_delProduct.SelectedValue
        connection.DeleteData(id)
        RefreshGrid()
        RefreshCombo()
        RefreshLabel()
    End Sub

    ''' <summary>
    ''' attention needed for the fact that the combobox since it's being loaded before the db
    ''' the value that comes from it is not valid. To fix this
    ''' we can use a try catch or a tryparse to parse the value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmb_filterCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filterCategory.SelectedIndexChanged
        Dim id As String
        Try
            id = cmb_filterCategory.SelectedValue
        Catch ex As Exception
            id = 0
        End Try

        Dim query As String = $"select * from Produtos where Produtos.categoria = {id};"
        grid_info.DataSource = connection.DBConnection(query).Tables(0)
        RefreshLabel()

    End Sub

    'METHOD TO REFRESH THE GRID
    Private Sub RefreshGrid()
        Dim query As String = "select p.id, p.nome, p.quantidade, c.nome as categoria 
                                from Produtos p, Categorias c
                                where c.id = p.categoria"

        grid_info.DataSource = connection.DBConnection(query).Tables(0)
        RefreshLabel()
    End Sub


    Private Sub RefreshCombo()
        'combobox for category products (add new elements query)
        Dim query As String = "select * from Categorias"
        cmb_addCategoria.DataSource = connection.DBConnection(query).Tables(0)
        cmb_addCategoria.DisplayMember = "nome"
        cmb_addCategoria.ValueMember = "id"

        'using same query for the combo to filter by categoires
        cmb_filterCategory.DataSource = connection.DBConnection(query).Tables(0)
        cmb_filterCategory.DisplayMember = "nome"
        cmb_filterCategory.ValueMember = "id"


        'combobox for deleting products
        Dim queryDeletion = "select * from Produtos"
        cmb_delProduct.DataSource = connection.DBConnection(queryDeletion).Tables(0)
        cmb_delProduct.DisplayMember = "nome"
        cmb_delProduct.ValueMember = "id"

    End Sub

    Private Sub RefreshLabel()
        Dim total As Integer = grid_info.Rows.Count()
        lbl_registos.Text = "Total de registos:  " + total.ToString
    End Sub

    ''' <summary>
    ''' Search for the product with the correspondent name or close to it
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_searchProduto_TextChanged(sender As Object, e As EventArgs) Handles txt_searchProduto.TextChanged
        Dim product = txt_searchProduto.Text
        Dim query = $"select * from Produtos p where p.nome like '%{product}%'"
        grid_info.DataSource = connection.DBConnection(query).Tables(0)

    End Sub
End Class