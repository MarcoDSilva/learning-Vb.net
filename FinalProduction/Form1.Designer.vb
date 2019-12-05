<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grid_cars = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BD1A3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_EliminateRegisters = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_AddRegisters = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_CopyToGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_CleanGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_qms = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Viatura = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_VeiculosViagem = New System.Windows.Forms.ComboBox()
        Me.lbl_Viagens = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_CarroMaisQms = New System.Windows.Forms.Label()
        Me.ActualizaBDRegistoCorrenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_idViagem_Apagar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_apagarViagem = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdBtn_1day = New System.Windows.Forms.RadioButton()
        Me.rdBtn_2days = New System.Windows.Forms.RadioButton()
        Me.rdBtn_3days = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmb_escolheDias = New System.Windows.Forms.ComboBox()
        CType(Me.grid_cars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_cars
        '
        Me.grid_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_cars.Location = New System.Drawing.Point(12, 40)
        Me.grid_cars.Name = "grid_cars"
        Me.grid_cars.Size = New System.Drawing.Size(474, 240)
        Me.grid_cars.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BD1A3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BD1A3ToolStripMenuItem
        '
        Me.BD1A3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strip_EliminateRegisters, Me.strip_AddRegisters, Me.strip_CopyToGrid, Me.strip_CleanGrid, Me.ActualizaBDRegistoCorrenteToolStripMenuItem})
        Me.BD1A3ToolStripMenuItem.Name = "BD1A3ToolStripMenuItem"
        Me.BD1A3ToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.BD1A3ToolStripMenuItem.Text = "BD e grid - 1 a 4 / 8"
        '
        'strip_EliminateRegisters
        '
        Me.strip_EliminateRegisters.Name = "strip_EliminateRegisters"
        Me.strip_EliminateRegisters.Size = New System.Drawing.Size(263, 22)
        Me.strip_EliminateRegisters.Text = "1 - Eliminar Registos da BD"
        '
        'strip_AddRegisters
        '
        Me.strip_AddRegisters.Name = "strip_AddRegisters"
        Me.strip_AddRegisters.Size = New System.Drawing.Size(263, 22)
        Me.strip_AddRegisters.Text = "2 - Lançar na BD os registos"
        '
        'strip_CopyToGrid
        '
        Me.strip_CopyToGrid.Name = "strip_CopyToGrid"
        Me.strip_CopyToGrid.Size = New System.Drawing.Size(263, 22)
        Me.strip_CopyToGrid.Text = "3 - Copiar registos da BD para a grid"
        '
        'strip_CleanGrid
        '
        Me.strip_CleanGrid.Name = "strip_CleanGrid"
        Me.strip_CleanGrid.Size = New System.Drawing.Size(263, 22)
        Me.strip_CleanGrid.Text = "4 - Limpar a grid"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_qms)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_Viatura)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Viaturas Q5"
        '
        'lbl_qms
        '
        Me.lbl_qms.AutoSize = True
        Me.lbl_qms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qms.Location = New System.Drawing.Point(6, 58)
        Me.lbl_qms.Name = "lbl_qms"
        Me.lbl_qms.Size = New System.Drawing.Size(201, 16)
        Me.lbl_qms.TabIndex = 2
        Me.lbl_qms.Text = "Quilometros totais da viatura: xxx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escolha a Viatura"
        '
        'cmb_Viatura
        '
        Me.cmb_Viatura.FormattingEnabled = True
        Me.cmb_Viatura.Location = New System.Drawing.Point(125, 24)
        Me.cmb_Viatura.Name = "cmb_Viatura"
        Me.cmb_Viatura.Size = New System.Drawing.Size(105, 21)
        Me.cmb_Viatura.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmb_VeiculosViagem)
        Me.GroupBox2.Controls.Add(Me.lbl_Viagens)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 87)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Viagens 2 dias - Q6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escolha a Viatura"
        '
        'cmb_VeiculosViagem
        '
        Me.cmb_VeiculosViagem.FormattingEnabled = True
        Me.cmb_VeiculosViagem.Location = New System.Drawing.Point(125, 24)
        Me.cmb_VeiculosViagem.Name = "cmb_VeiculosViagem"
        Me.cmb_VeiculosViagem.Size = New System.Drawing.Size(95, 21)
        Me.cmb_VeiculosViagem.TabIndex = 1
        '
        'lbl_Viagens
        '
        Me.lbl_Viagens.AutoSize = True
        Me.lbl_Viagens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Viagens.Location = New System.Drawing.Point(9, 58)
        Me.lbl_Viagens.Name = "lbl_Viagens"
        Me.lbl_Viagens.Size = New System.Drawing.Size(214, 16)
        Me.lbl_Viagens.TabIndex = 0
        Me.lbl_Viagens.Text = "A viatura X fez X viagens de 2 dias."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.lbl_CarroMaisQms)
        Me.GroupBox3.Location = New System.Drawing.Point(501, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 86)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Q7 - Veiculo que mais qms efetuou"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Obtém Veiculo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_CarroMaisQms
        '
        Me.lbl_CarroMaisQms.AutoSize = True
        Me.lbl_CarroMaisQms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CarroMaisQms.Location = New System.Drawing.Point(6, 56)
        Me.lbl_CarroMaisQms.Name = "lbl_CarroMaisQms"
        Me.lbl_CarroMaisQms.Size = New System.Drawing.Size(228, 16)
        Me.lbl_CarroMaisQms.TabIndex = 0
        Me.lbl_CarroMaisQms.Text = "O carro com mais qms é o carro:  xxx."
        '
        'ActualizaBDRegistoCorrenteToolStripMenuItem
        '
        Me.ActualizaBDRegistoCorrenteToolStripMenuItem.Name = "ActualizaBDRegistoCorrenteToolStripMenuItem"
        Me.ActualizaBDRegistoCorrenteToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.ActualizaBDRegistoCorrenteToolStripMenuItem.Text = "8 - Actualiza BD - Registo Corrente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_apagarViagem)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cmb_idViagem_Apagar)
        Me.GroupBox4.Location = New System.Drawing.Point(510, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 100)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Q9 - Eliminar Viagem"
        '
        'cmb_idViagem_Apagar
        '
        Me.cmb_idViagem_Apagar.FormattingEnabled = True
        Me.cmb_idViagem_Apagar.Location = New System.Drawing.Point(166, 29)
        Me.cmb_idViagem_Apagar.Name = "cmb_idViagem_Apagar"
        Me.cmb_idViagem_Apagar.Size = New System.Drawing.Size(59, 21)
        Me.cmb_idViagem_Apagar.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Id da viagem a apagar:"
        '
        'btn_apagarViagem
        '
        Me.btn_apagarViagem.Location = New System.Drawing.Point(83, 56)
        Me.btn_apagarViagem.Name = "btn_apagarViagem"
        Me.btn_apagarViagem.Size = New System.Drawing.Size(99, 23)
        Me.btn_apagarViagem.TabIndex = 2
        Me.btn_apagarViagem.Text = "Apagar Viagem"
        Me.btn_apagarViagem.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdBtn_3days)
        Me.GroupBox5.Controls.Add(Me.rdBtn_2days)
        Me.GroupBox5.Controls.Add(Me.rdBtn_1day)
        Me.GroupBox5.Location = New System.Drawing.Point(535, 257)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 87)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Q10 - X dias"
        '
        'rdBtn_1day
        '
        Me.rdBtn_1day.AutoSize = True
        Me.rdBtn_1day.Location = New System.Drawing.Point(6, 28)
        Me.rdBtn_1day.Name = "rdBtn_1day"
        Me.rdBtn_1day.Size = New System.Drawing.Size(48, 17)
        Me.rdBtn_1day.TabIndex = 1
        Me.rdBtn_1day.TabStop = True
        Me.rdBtn_1day.Text = "1 dia"
        Me.rdBtn_1day.UseVisualStyleBackColor = True
        '
        'rdBtn_2days
        '
        Me.rdBtn_2days.AutoSize = True
        Me.rdBtn_2days.Location = New System.Drawing.Point(80, 28)
        Me.rdBtn_2days.Name = "rdBtn_2days"
        Me.rdBtn_2days.Size = New System.Drawing.Size(53, 17)
        Me.rdBtn_2days.TabIndex = 2
        Me.rdBtn_2days.TabStop = True
        Me.rdBtn_2days.Text = "2 dias"
        Me.rdBtn_2days.UseVisualStyleBackColor = True
        '
        'rdBtn_3days
        '
        Me.rdBtn_3days.AutoSize = True
        Me.rdBtn_3days.Location = New System.Drawing.Point(148, 28)
        Me.rdBtn_3days.Name = "rdBtn_3days"
        Me.rdBtn_3days.Size = New System.Drawing.Size(53, 17)
        Me.rdBtn_3days.TabIndex = 3
        Me.rdBtn_3days.TabStop = True
        Me.rdBtn_3days.Text = "3 dias"
        Me.rdBtn_3days.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmb_escolheDias)
        Me.GroupBox6.Location = New System.Drawing.Point(534, 357)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(241, 66)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Q11 - Combo Opções"
        '
        'cmb_escolheDias
        '
        Me.cmb_escolheDias.FormattingEnabled = True
        Me.cmb_escolheDias.Items.AddRange(New Object() {"Todos os Registos", "Um dia", "Dois ou mais"})
        Me.cmb_escolheDias.Location = New System.Drawing.Point(60, 27)
        Me.cmb_escolheDias.Name = "cmb_escolheDias"
        Me.cmb_escolheDias.Size = New System.Drawing.Size(121, 21)
        Me.cmb_escolheDias.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grid_cars)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grid_cars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_cars As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BD1A3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strip_EliminateRegisters As ToolStripMenuItem
    Friend WithEvents strip_AddRegisters As ToolStripMenuItem
    Friend WithEvents strip_CopyToGrid As ToolStripMenuItem
    Friend WithEvents strip_CleanGrid As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_qms As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Viatura As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_VeiculosViagem As ComboBox
    Friend WithEvents lbl_Viagens As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_CarroMaisQms As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ActualizaBDRegistoCorrenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_idViagem_Apagar As ComboBox
    Friend WithEvents btn_apagarViagem As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdBtn_2days As RadioButton
    Friend WithEvents rdBtn_1day As RadioButton
    Friend WithEvents rdBtn_3days As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cmb_escolheDias As ComboBox
End Class
