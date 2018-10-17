<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadClassificacao
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
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.txtNomeClassificacao = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbotoes.SuspendLayout()
        Me.gpdados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(12, 205)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(685, 61)
        Me.gpbotoes.TabIndex = 5
        Me.gpbotoes.TabStop = False
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(440, 19)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluir.Location = New System.Drawing.Point(332, 19)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnexcluir.TabIndex = 3
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnaltera
        '
        Me.btnaltera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaltera.Location = New System.Drawing.Point(125, 20)
        Me.btnaltera.Name = "btnaltera"
        Me.btnaltera.Size = New System.Drawing.Size(75, 23)
        Me.btnaltera.TabIndex = 2
        Me.btnaltera.Text = "Alterar"
        Me.btnaltera.UseVisualStyleBackColor = True
        '
        'btnlocalizar
        '
        Me.btnlocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocalizar.Location = New System.Drawing.Point(552, 19)
        Me.btnlocalizar.Name = "btnlocalizar"
        Me.btnlocalizar.Size = New System.Drawing.Size(96, 23)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localização"
        Me.btnlocalizar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.Location = New System.Drawing.Point(224, 20)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnsalvar.TabIndex = 1
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnincluir
        '
        Me.btnincluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Location = New System.Drawing.Point(24, 20)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(75, 23)
        Me.btnincluir.TabIndex = 0
        Me.btnincluir.Text = "Incluir"
        Me.btnincluir.UseVisualStyleBackColor = True
        '
        'gpdados
        '
        Me.gpdados.Controls.Add(Me.txtuf)
        Me.gpdados.Controls.Add(Me.txtNomeClassificacao)
        Me.gpdados.Controls.Add(Me.txtcodigo)
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Location = New System.Drawing.Point(24, 2)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(667, 197)
        Me.gpdados.TabIndex = 6
        Me.gpdados.TabStop = False
        '
        'txtuf
        '
        Me.txtuf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuf.Location = New System.Drawing.Point(76, 68)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.Size = New System.Drawing.Size(151, 21)
        Me.txtuf.TabIndex = 9
        '
        'txtNomeClassificacao
        '
        Me.txtNomeClassificacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeClassificacao.Location = New System.Drawing.Point(76, 42)
        Me.txtNomeClassificacao.Name = "txtNomeClassificacao"
        Me.txtNomeClassificacao.Size = New System.Drawing.Size(496, 21)
        Me.txtNomeClassificacao.TabIndex = 8
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(76, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(85, 21)
        Me.txtcodigo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'cadClassificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 278)
        Me.Controls.Add(Me.gpdados)
        Me.Controls.Add(Me.gpbotoes)
        Me.Name = "cadClassificacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadClassificacao"
        Me.gpbotoes.ResumeLayout(False)
        Me.gpdados.ResumeLayout(False)
        Me.gpdados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbotoes As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnaltera As Button
    Friend WithEvents btnlocalizar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnincluir As Button
    Friend WithEvents gpdados As GroupBox
    Friend WithEvents txtuf As TextBox
    Friend WithEvents txtNomeClassificacao As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
