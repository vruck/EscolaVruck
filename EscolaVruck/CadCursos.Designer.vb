<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadCursos))
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btnlocalizarr = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSequencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorDeCredito = New System.Windows.Forms.TextBox()
        Me.txtNomeCurso = New System.Windows.Forms.TextBox()
        Me.txtcodigoCurso = New System.Windows.Forms.TextBox()
        Me.gpbotoes.SuspendLayout()
        Me.gpdados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btnlocalizarr)
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(572, 12)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(186, 290)
        Me.gpbotoes.TabIndex = 3
        Me.gpbotoes.TabStop = False
        '
        'btnlocalizarr
        '
        Me.btnlocalizarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocalizarr.Location = New System.Drawing.Point(18, 188)
        Me.btnlocalizarr.Name = "btnlocalizarr"
        Me.btnlocalizarr.Size = New System.Drawing.Size(136, 23)
        Me.btnlocalizarr.TabIndex = 7
        Me.btnlocalizarr.Text = "Localizar"
        Me.btnlocalizarr.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(18, 246)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(139, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluir.Location = New System.Drawing.Point(21, 217)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(136, 23)
        Me.btnexcluir.TabIndex = 3
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnaltera
        '
        Me.btnaltera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaltera.Location = New System.Drawing.Point(21, 46)
        Me.btnaltera.Name = "btnaltera"
        Me.btnaltera.Size = New System.Drawing.Size(136, 23)
        Me.btnaltera.TabIndex = 2
        Me.btnaltera.Text = "Alterar"
        Me.btnaltera.UseVisualStyleBackColor = True
        '
        'btnlocalizar
        '
        Me.btnlocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocalizar.Location = New System.Drawing.Point(759, 20)
        Me.btnlocalizar.Name = "btnlocalizar"
        Me.btnlocalizar.Size = New System.Drawing.Size(96, 23)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localização"
        Me.btnlocalizar.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.Location = New System.Drawing.Point(21, 76)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(136, 23)
        Me.btnsalvar.TabIndex = 1
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnincluir
        '
        Me.btnincluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Location = New System.Drawing.Point(21, 16)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(136, 23)
        Me.btnincluir.TabIndex = 0
        Me.btnincluir.Text = "Incluir"
        Me.btnincluir.UseVisualStyleBackColor = True
        '
        'gpdados
        '
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.txtSequencia)
        Me.gpdados.Controls.Add(Me.Label4)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Controls.Add(Me.txtValorDeCredito)
        Me.gpdados.Controls.Add(Me.txtNomeCurso)
        Me.gpdados.Controls.Add(Me.txtcodigoCurso)
        Me.gpdados.Location = New System.Drawing.Point(12, 12)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(551, 156)
        Me.gpdados.TabIndex = 4
        Me.gpdados.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Sequencia"
        '
        'txtSequencia
        '
        Me.txtSequencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequencia.Location = New System.Drawing.Point(146, 101)
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.Size = New System.Drawing.Size(52, 21)
        Me.txtSequencia.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Valor Do Credito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome Do Curso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo"
        '
        'txtValorDeCredito
        '
        Me.txtValorDeCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorDeCredito.Location = New System.Drawing.Point(146, 75)
        Me.txtValorDeCredito.Name = "txtValorDeCredito"
        Me.txtValorDeCredito.Size = New System.Drawing.Size(118, 21)
        Me.txtValorDeCredito.TabIndex = 3
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCurso.Location = New System.Drawing.Point(146, 45)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(372, 21)
        Me.txtNomeCurso.TabIndex = 1
        '
        'txtcodigoCurso
        '
        Me.txtcodigoCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCurso.Location = New System.Drawing.Point(146, 19)
        Me.txtcodigoCurso.Name = "txtcodigoCurso"
        Me.txtcodigoCurso.Size = New System.Drawing.Size(81, 21)
        Me.txtcodigoCurso.TabIndex = 0
        '
        'CadCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(770, 325)
        Me.Controls.Add(Me.gpdados)
        Me.Controls.Add(Me.gpbotoes)
        Me.Name = "CadCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadCursos"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorDeCredito As TextBox
    Friend WithEvents txtNomeCurso As TextBox
    Friend WithEvents txtcodigoCurso As TextBox
    Friend WithEvents btnlocalizarr As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSequencia As TextBox
End Class
