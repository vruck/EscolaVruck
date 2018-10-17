<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConProfessor
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
        Me.btncadastrar = New System.Windows.Forms.Button()
        Me.dgDados = New System.Windows.Forms.DataGridView()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncadastrar
        '
        Me.btncadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncadastrar.Location = New System.Drawing.Point(15, 307)
        Me.btncadastrar.Name = "btncadastrar"
        Me.btncadastrar.Size = New System.Drawing.Size(238, 54)
        Me.btncadastrar.TabIndex = 15
        Me.btncadastrar.Text = "Cadastrar Professor"
        Me.btncadastrar.UseVisualStyleBackColor = True
        '
        'dgDados
        '
        Me.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDados.Location = New System.Drawing.Point(15, 57)
        Me.dgDados.Name = "dgDados"
        Me.dgDados.Size = New System.Drawing.Size(717, 244)
        Me.dgDados.TabIndex = 14
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(15, 31)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(434, 20)
        Me.txtdescricao.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descrição"
        '
        'ConProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(759, 389)
        Me.Controls.Add(Me.btncadastrar)
        Me.Controls.Add(Me.dgDados)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConProfessor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConProfessor"
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncadastrar As Button
    Friend WithEvents dgDados As DataGridView
    Friend WithEvents txtdescricao As TextBox
    Friend WithEvents Label1 As Label
End Class
