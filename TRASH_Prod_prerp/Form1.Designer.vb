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
        Me.grid_info = New System.Windows.Forms.DataGridView()
        Me.btn_list = New System.Windows.Forms.Button()
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_info
        '
        Me.grid_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_info.Location = New System.Drawing.Point(12, 12)
        Me.grid_info.Name = "grid_info"
        Me.grid_info.Size = New System.Drawing.Size(500, 292)
        Me.grid_info.TabIndex = 0
        '
        'btn_list
        '
        Me.btn_list.Location = New System.Drawing.Point(532, 12)
        Me.btn_list.Name = "btn_list"
        Me.btn_list.Size = New System.Drawing.Size(108, 23)
        Me.btn_list.TabIndex = 1
        Me.btn_list.Text = "Listar Elementos"
        Me.btn_list.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_list)
        Me.Controls.Add(Me.grid_info)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grid_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid_info As DataGridView
    Friend WithEvents btn_list As Button
End Class
