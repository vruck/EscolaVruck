<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadMatricula
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
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgDadosDisciplina = New System.Windows.Forms.DataGridView()
        Me.cbdiscipilna = New System.Windows.Forms.ComboBox()
        Me.btnlocalizarcurso = New System.Windows.Forms.Button()
        Me.txtCursonome = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtValorMatricula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDatamatricula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTurma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTurmo = New System.Windows.Forms.TextBox()
        Me.Turmo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LocalizarAluno = New System.Windows.Forms.Button()
        Me.TxtnomeAluno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtcodigoAluno = New System.Windows.Forms.TextBox()
        Me.txtcodigoMatricula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados.SuspendLayout()
        CType(Me.DgDadosDisciplina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpdados
        '
        Me.gpdados.Controls.Add(Me.btnremover)
        Me.gpdados.Controls.Add(Me.btnadicionar)
        Me.gpdados.Controls.Add(Me.Label8)
        Me.gpdados.Controls.Add(Me.DgDadosDisciplina)
        Me.gpdados.Controls.Add(Me.cbdiscipilna)
        Me.gpdados.Controls.Add(Me.btnlocalizarcurso)
        Me.gpdados.Controls.Add(Me.txtCursonome)
        Me.gpdados.Controls.Add(Me.txtcodigo)
        Me.gpdados.Controls.Add(Me.txtValorMatricula)
        Me.gpdados.Controls.Add(Me.Label7)
        Me.gpdados.Controls.Add(Me.txtSemestre)
        Me.gpdados.Controls.Add(Me.Label5)
        Me.gpdados.Controls.Add(Me.txtDatamatricula)
        Me.gpdados.Controls.Add(Me.Label4)
        Me.gpdados.Controls.Add(Me.TxtTurma)
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.txtTurmo)
        Me.gpdados.Controls.Add(Me.Turmo)
        Me.gpdados.Controls.Add(Me.Label6)
        Me.gpdados.Controls.Add(Me.LocalizarAluno)
        Me.gpdados.Controls.Add(Me.TxtnomeAluno)
        Me.gpdados.Controls.Add(Me.Label9)
        Me.gpdados.Controls.Add(Me.TxtcodigoAluno)
        Me.gpdados.Controls.Add(Me.txtcodigoMatricula)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Location = New System.Drawing.Point(12, 12)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(729, 560)
        Me.gpdados.TabIndex = 6
        Me.gpdados.TabStop = False
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(487, 259)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(180, 23)
        Me.btnremover.TabIndex = 57
        Me.btnremover.Text = "-"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(487, 230)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(180, 23)
        Me.btnadicionar.TabIndex = 56
        Me.btnadicionar.Text = "+"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Disciplina"
        '
        'DgDadosDisciplina
        '
        Me.DgDadosDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDadosDisciplina.Location = New System.Drawing.Point(9, 294)
        Me.DgDadosDisciplina.Name = "DgDadosDisciplina"
        Me.DgDadosDisciplina.Size = New System.Drawing.Size(658, 237)
        Me.DgDadosDisciplina.TabIndex = 54
        '
        'cbdiscipilna
        '
        Me.cbdiscipilna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbdiscipilna.FormattingEnabled = True
        Me.cbdiscipilna.Location = New System.Drawing.Point(12, 261)
        Me.cbdiscipilna.Name = "cbdiscipilna"
        Me.cbdiscipilna.Size = New System.Drawing.Size(216, 23)
        Me.cbdiscipilna.TabIndex = 53
        '
        'btnlocalizarcurso
        '
        Me.btnlocalizarcurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocalizarcurso.Location = New System.Drawing.Point(511, 66)
        Me.btnlocalizarcurso.Name = "btnlocalizarcurso"
        Me.btnlocalizarcurso.Size = New System.Drawing.Size(176, 23)
        Me.btnlocalizarcurso.TabIndex = 50
        Me.btnlocalizarcurso.Text = "Localização Curso"
        Me.btnlocalizarcurso.UseVisualStyleBackColor = True
        '
        'txtCursonome
        '
        Me.txtCursonome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCursonome.Location = New System.Drawing.Point(174, 66)
        Me.txtCursonome.Name = "txtCursonome"
        Me.txtCursonome.Size = New System.Drawing.Size(331, 21)
        Me.txtCursonome.TabIndex = 52
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(115, 66)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(53, 21)
        Me.txtcodigo.TabIndex = 51
        '
        'txtValorMatricula
        '
        Me.txtValorMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorMatricula.Location = New System.Drawing.Point(118, 204)
        Me.txtValorMatricula.Name = "txtValorMatricula"
        Me.txtValorMatricula.Size = New System.Drawing.Size(102, 21)
        Me.txtValorMatricula.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Valor"
        '
        'txtSemestre
        '
        Me.txtSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemestre.Location = New System.Drawing.Point(118, 176)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(157, 21)
        Me.txtSemestre.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Semestre"
        '
        'txtDatamatricula
        '
        Me.txtDatamatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatamatricula.Location = New System.Drawing.Point(118, 148)
        Me.txtDatamatricula.Name = "txtDatamatricula"
        Me.txtDatamatricula.Size = New System.Drawing.Size(118, 21)
        Me.txtDatamatricula.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Data Matricula"
        '
        'TxtTurma
        '
        Me.TxtTurma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTurma.Location = New System.Drawing.Point(116, 120)
        Me.TxtTurma.Name = "TxtTurma"
        Me.TxtTurma.Size = New System.Drawing.Size(94, 21)
        Me.TxtTurma.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Turma"
        '
        'txtTurmo
        '
        Me.txtTurmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurmo.Location = New System.Drawing.Point(115, 92)
        Me.txtTurmo.Name = "txtTurmo"
        Me.txtTurmo.Size = New System.Drawing.Size(176, 21)
        Me.txtTurmo.TabIndex = 41
        '
        'Turmo
        '
        Me.Turmo.AutoSize = True
        Me.Turmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Turmo.Location = New System.Drawing.Point(6, 99)
        Me.Turmo.Name = "Turmo"
        Me.Turmo.Size = New System.Drawing.Size(48, 15)
        Me.Turmo.TabIndex = 40
        Me.Turmo.Text = "Termo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Curso"
        '
        'LocalizarAluno
        '
        Me.LocalizarAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalizarAluno.Location = New System.Drawing.Point(511, 42)
        Me.LocalizarAluno.Name = "LocalizarAluno"
        Me.LocalizarAluno.Size = New System.Drawing.Size(176, 23)
        Me.LocalizarAluno.TabIndex = 7
        Me.LocalizarAluno.Text = "Localização Aluno"
        Me.LocalizarAluno.UseVisualStyleBackColor = True
        '
        'TxtnomeAluno
        '
        Me.TxtnomeAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtnomeAluno.Location = New System.Drawing.Point(174, 42)
        Me.TxtnomeAluno.Name = "TxtnomeAluno"
        Me.TxtnomeAluno.Size = New System.Drawing.Size(331, 21)
        Me.TxtnomeAluno.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 21
        '
        'TxtcodigoAluno
        '
        Me.TxtcodigoAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtcodigoAluno.Location = New System.Drawing.Point(115, 42)
        Me.TxtcodigoAluno.Name = "TxtcodigoAluno"
        Me.TxtcodigoAluno.Size = New System.Drawing.Size(53, 21)
        Me.TxtcodigoAluno.TabIndex = 8
        '
        'txtcodigoMatricula
        '
        Me.txtcodigoMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoMatricula.Location = New System.Drawing.Point(115, 16)
        Me.txtcodigoMatricula.Name = "txtcodigoMatricula"
        Me.txtcodigoMatricula.Size = New System.Drawing.Size(85, 21)
        Me.txtcodigoMatricula.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Aluno"
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
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(12, 578)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(729, 61)
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
        Me.btnlocalizar.Size = New System.Drawing.Size(171, 23)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localização matricula"
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
        'CadMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 651)
        Me.Controls.Add(Me.gpdados)
        Me.Controls.Add(Me.gpbotoes)
        Me.Name = "CadMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadMatricula"
        Me.gpdados.ResumeLayout(False)
        Me.gpdados.PerformLayout()
        CType(Me.DgDadosDisciplina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpdados As GroupBox
    Friend WithEvents LocalizarAluno As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtcodigoAluno As TextBox
    Friend WithEvents txtcodigoMatricula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbotoes As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnaltera As Button
    Friend WithEvents btnlocalizar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnincluir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTurmo As TextBox
    Friend WithEvents Turmo As Label
    Friend WithEvents txtValorMatricula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSemestre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDatamatricula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTurma As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlocalizarcurso As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DgDadosDisciplina As System.Windows.Forms.DataGridView
    Friend WithEvents cbdiscipilna As System.Windows.Forms.ComboBox
    Friend WithEvents txtCursonome As System.Windows.Forms.TextBox
    Friend WithEvents TxtnomeAluno As System.Windows.Forms.TextBox
    Friend WithEvents btnremover As System.Windows.Forms.Button
    Friend WithEvents btnadicionar As System.Windows.Forms.Button
End Class
