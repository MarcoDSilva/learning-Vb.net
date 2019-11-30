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
        Me.grp_basicOp = New System.Windows.Forms.GroupBox()
        Me.txt_AddName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_addQuantity = New System.Windows.Forms.TextBox()
        Me.cmb_addCategoria = New System.Windows.Forms.ComboBox()
        Me.btn_addProduct = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_delProduct = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delProduct = New System.Windows.Forms.Button()
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Add.SuspendLayout()
        Me.grp_basicOp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_info
        '
        Me.grid_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info.Location = New System.Drawing.Point(16, 15)
        Me.grid_info.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_info.Name = "grid_info"
        Me.grid_info.RowHeadersWidth = 51
        Me.grid_info.Size = New System.Drawing.Size(667, 492)
        Me.grid_info.TabIndex = 0
        '
        'btn_list
        '
        Me.btn_list.Location = New System.Drawing.Point(44, 35)
        Me.btn_list.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_list.Name = "btn_list"
        Me.btn_list.Size = New System.Drawing.Size(144, 28)
        Me.btn_list.TabIndex = 1
        Me.btn_list.Text = "Listar Elementos"
        Me.btn_list.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(195, 35)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(144, 28)
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
        Me.grp_Add.Location = New System.Drawing.Point(709, 120)
        Me.grp_Add.Name = "grp_Add"
        Me.grp_Add.Size = New System.Drawing.Size(363, 206)
        Me.grp_Add.TabIndex = 3
        Me.grp_Add.TabStop = False
        Me.grp_Add.Text = "Adicionar Produto"
        '
        'grp_basicOp
        '
        Me.grp_basicOp.Controls.Add(Me.btn_list)
        Me.grp_basicOp.Controls.Add(Me.btn_clear)
        Me.grp_basicOp.Location = New System.Drawing.Point(709, 15)
        Me.grp_basicOp.Name = "grp_basicOp"
        Me.grp_basicOp.Size = New System.Drawing.Size(363, 88)
        Me.grp_basicOp.TabIndex = 4
        Me.grp_basicOp.TabStop = False
        Me.grp_basicOp.Text = "Operações Básicas"
        '
        'txt_AddName
        '
        Me.txt_AddName.Location = New System.Drawing.Point(150, 39)
        Me.txt_AddName.Name = "txt_AddName"
        Me.txt_AddName.Size = New System.Drawing.Size(169, 22)
        Me.txt_AddName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantidade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoria:"
        '
        'txt_addQuantity
        '
        Me.txt_addQuantity.Location = New System.Drawing.Point(150, 77)
        Me.txt_addQuantity.Name = "txt_addQuantity"
        Me.txt_addQuantity.Size = New System.Drawing.Size(171, 22)
        Me.txt_addQuantity.TabIndex = 4
        '
        'cmb_addCategoria
        '
        Me.cmb_addCategoria.FormattingEnabled = True
        Me.cmb_addCategoria.Location = New System.Drawing.Point(150, 117)
        Me.cmb_addCategoria.Name = "cmb_addCategoria"
        Me.cmb_addCategoria.Size = New System.Drawing.Size(169, 24)
        Me.cmb_addCategoria.TabIndex = 5
        '
        'btn_addProduct
        '
        Me.btn_addProduct.Location = New System.Drawing.Point(79, 161)
        Me.btn_addProduct.Name = "btn_addProduct"
        Me.btn_addProduct.Size = New System.Drawing.Size(242, 23)
        Me.btn_addProduct.TabIndex = 6
        Me.btn_addProduct.Text = "Confirmar Inserção"
        Me.btn_addProduct.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_delProduct)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_delProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(716, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apagar Produto"
        '
        'cmb_delProduct
        '
        Me.cmb_delProduct.FormattingEnabled = True
        Me.cmb_delProduct.Location = New System.Drawing.Point(188, 40)
        Me.cmb_delProduct.Name = "cmb_delProduct"
        Me.cmb_delProduct.Size = New System.Drawing.Size(126, 24)
        Me.cmb_delProduct.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Id produto a apagar:"
        '
        'btn_delProduct
        '
        Me.btn_delProduct.Location = New System.Drawing.Point(72, 89)
        Me.btn_delProduct.Name = "btn_delProduct"
        Me.btn_delProduct.Size = New System.Drawing.Size(229, 23)
        Me.btn_delProduct.TabIndex = 9
        Me.btn_delProduct.Text = "Confirmar Apagar"
        Me.btn_delProduct.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_basicOp)
        Me.Controls.Add(Me.grp_Add)
        Me.Controls.Add(Me.grid_info)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "VisualBasic MarcoSilva"
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Add.ResumeLayout(False)
        Me.grp_Add.PerformLayout()
        Me.grp_basicOp.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
