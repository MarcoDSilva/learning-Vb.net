<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grid_info = New System.Windows.Forms.DataGridView()
        Me.btn_list = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.grp_Add = New System.Windows.Forms.GroupBox()
        Me.btn_addProduct = New System.Windows.Forms.Button()
        Me.cmb_addCategoria = New System.Windows.Forms.ComboBox()
        Me.txt_addQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_AddName = New System.Windows.Forms.TextBox()
        Me.grp_basicOp = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_delProduct = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_delProduct = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_filterCategory = New System.Windows.Forms.ComboBox()
        Me.lbl_registos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_searchProduto = New System.Windows.Forms.TextBox()
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Add.SuspendLayout()
        Me.grp_basicOp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_info
        '
        Me.grid_info.AllowUserToAddRows = False
        Me.grid_info.AllowUserToDeleteRows = False
        Me.grid_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info.Location = New System.Drawing.Point(12, 12)
        Me.grid_info.Name = "grid_info"
        Me.grid_info.RowHeadersWidth = 51
        Me.grid_info.Size = New System.Drawing.Size(500, 400)
        Me.grid_info.TabIndex = 0
        '
        'btn_list
        '
        Me.btn_list.Location = New System.Drawing.Point(33, 28)
        Me.btn_list.Name = "btn_list"
        Me.btn_list.Size = New System.Drawing.Size(108, 23)
        Me.btn_list.TabIndex = 1
        Me.btn_list.Text = "Listar Elementos"
        Me.btn_list.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(146, 28)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(108, 23)
        Me.btn_clear.TabIndex = 2
        Me.btn_clear.Text = "Limpar Grid"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'grp_Add
        '
        Me.grp_Add.Controls.Add(Me.btn_addProduct)
        Me.grp_Add.Controls.Add(Me.cmb_addCategoria)
        Me.grp_Add.Controls.Add(Me.txt_addQuantity)
        Me.grp_Add.Controls.Add(Me.Label3)
        Me.grp_Add.Controls.Add(Me.Label2)
        Me.grp_Add.Controls.Add(Me.Label1)
        Me.grp_Add.Controls.Add(Me.txt_AddName)
        Me.grp_Add.Location = New System.Drawing.Point(532, 98)
        Me.grp_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_Add.Name = "grp_Add"
        Me.grp_Add.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_Add.Size = New System.Drawing.Size(272, 167)
        Me.grp_Add.TabIndex = 3
        Me.grp_Add.TabStop = False
        Me.grp_Add.Text = "Adicionar Produto"
        '
        'btn_addProduct
        '
        Me.btn_addProduct.Location = New System.Drawing.Point(59, 131)
        Me.btn_addProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_addProduct.Name = "btn_addProduct"
        Me.btn_addProduct.Size = New System.Drawing.Size(182, 20)
        Me.btn_addProduct.TabIndex = 6
        Me.btn_addProduct.Text = "Confirmar Inserção"
        Me.btn_addProduct.UseVisualStyleBackColor = True
        '
        'cmb_addCategoria
        '
        Me.cmb_addCategoria.FormattingEnabled = True
        Me.cmb_addCategoria.Location = New System.Drawing.Point(112, 95)
        Me.cmb_addCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_addCategoria.Name = "cmb_addCategoria"
        Me.cmb_addCategoria.Size = New System.Drawing.Size(128, 21)
        Me.cmb_addCategoria.TabIndex = 5
        '
        'txt_addQuantity
        '
        Me.txt_addQuantity.Location = New System.Drawing.Point(112, 63)
        Me.txt_addQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_addQuantity.Name = "txt_addQuantity"
        Me.txt_addQuantity.Size = New System.Drawing.Size(129, 20)
        Me.txt_addQuantity.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'txt_AddName
        '
        Me.txt_AddName.Location = New System.Drawing.Point(112, 32)
        Me.txt_AddName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AddName.Name = "txt_AddName"
        Me.txt_AddName.Size = New System.Drawing.Size(128, 20)
        Me.txt_AddName.TabIndex = 0
        '
        'grp_basicOp
        '
        Me.grp_basicOp.Controls.Add(Me.btn_list)
        Me.grp_basicOp.Controls.Add(Me.btn_clear)
        Me.grp_basicOp.Location = New System.Drawing.Point(532, 12)
        Me.grp_basicOp.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_basicOp.Name = "grp_basicOp"
        Me.grp_basicOp.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_basicOp.Size = New System.Drawing.Size(272, 72)
        Me.grp_basicOp.TabIndex = 4
        Me.grp_basicOp.TabStop = False
        Me.grp_basicOp.Text = "Operações Básicas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_delProduct)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_delProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(537, 283)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 117)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apagar Produto"
        '
        'btn_delProduct
        '
        Me.btn_delProduct.Location = New System.Drawing.Point(54, 72)
        Me.btn_delProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delProduct.Name = "btn_delProduct"
        Me.btn_delProduct.Size = New System.Drawing.Size(172, 23)
        Me.btn_delProduct.TabIndex = 9
        Me.btn_delProduct.Text = "Confirmar Apagar"
        Me.btn_delProduct.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Id produto a apagar:"
        '
        'cmb_delProduct
        '
        Me.cmb_delProduct.FormattingEnabled = True
        Me.cmb_delProduct.Location = New System.Drawing.Point(141, 32)
        Me.cmb_delProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_delProduct.Name = "cmb_delProduct"
        Me.cmb_delProduct.Size = New System.Drawing.Size(96, 21)
        Me.cmb_delProduct.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_searchProduto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmb_filterCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(819, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 138)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Por Categoria:"
        '
        'cmb_filterCategory
        '
        Me.cmb_filterCategory.FormattingEnabled = True
        Me.cmb_filterCategory.Location = New System.Drawing.Point(121, 28)
        Me.cmb_filterCategory.Name = "cmb_filterCategory"
        Me.cmb_filterCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmb_filterCategory.TabIndex = 0
        '
        'lbl_registos
        '
        Me.lbl_registos.AutoSize = True
        Me.lbl_registos.Location = New System.Drawing.Point(12, 421)
        Me.lbl_registos.Name = "lbl_registos"
        Me.lbl_registos.Size = New System.Drawing.Size(91, 13)
        Me.lbl_registos.TabIndex = 7
        Me.lbl_registos.Text = "Total de registos: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Procurar Produto:"
        '
        'txt_searchProduto
        '
        Me.txt_searchProduto.Location = New System.Drawing.Point(121, 72)
        Me.txt_searchProduto.Name = "txt_searchProduto"
        Me.txt_searchProduto.Size = New System.Drawing.Size(121, 20)
        Me.txt_searchProduto.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 450)
        Me.Controls.Add(Me.lbl_registos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_basicOp)
        Me.Controls.Add(Me.grp_Add)
        Me.Controls.Add(Me.grid_info)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VisualBasic MarcoSilva"
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Add.ResumeLayout(False)
        Me.grp_Add.PerformLayout()
        Me.grp_basicOp.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_info As DataGridView
    Friend WithEvents btn_list As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents grp_Add As GroupBox
    Friend WithEvents cmb_addCategoria As ComboBox
    Friend WithEvents txt_addQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_AddName As TextBox
    Friend WithEvents grp_basicOp As GroupBox
    Friend WithEvents btn_addProduct As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_delProduct As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_delProduct As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_filterCategory As ComboBox
    Friend WithEvents lbl_registos As Label
    Friend WithEvents txt_searchProduto As TextBox
    Friend WithEvents Label6 As Label
End Class