<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadDisciplina
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
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCursos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroDeCreditoDis = New System.Windows.Forms.TextBox()
        Me.txtCargaHorariaDis = New System.Windows.Forms.TextBox()
        Me.TxtNomeDis = New System.Windows.Forms.TextBox()
        Me.txtCodigoDis = New System.Windows.Forms.TextBox()
        Me.cbProfessor = New System.Windows.Forms.ComboBox()
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados.SuspendLayout()
        Me.gpbotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpdados
        '
        Me.gpdados.Controls.Add(Me.Label6)
        Me.gpdados.Controls.Add(Me.cbCursos)
        Me.gpdados.Controls.Add(Me.Label5)
        Me.gpdados.Controls.Add(Me.Label4)
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Controls.Add(Me.txtNumeroDeCreditoDis)
        Me.gpdados.Controls.Add(Me.txtCargaHorariaDis)
        Me.gpdados.Controls.Add(Me.TxtNomeDis)
        Me.gpdados.Controls.Add(Me.txtCodigoDis)
        Me.gpdados.Controls.Add(Me.cbProfessor)
        Me.gpdados.Location = New System.Drawing.Point(12, 12)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(658, 216)
        Me.gpdados.TabIndex = 0
        Me.gpdados.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Curso"
        '
        'cbCursos
        '
        Me.cbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCursos.FormattingEnabled = True
        Me.cbCursos.Location = New System.Drawing.Point(148, 131)
        Me.cbCursos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCursos.Name = "cbCursos"
        Me.cbCursos.Size = New System.Drawing.Size(390, 23)
        Me.cbCursos.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Professor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Numero Do Credito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Carga Horaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nome da Disciplina"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Codigo"
        '
        'txtNumeroDeCreditoDis
        '
        Me.txtNumeroDeCreditoDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeCreditoDis.Location = New System.Drawing.Point(148, 98)
        Me.txtNumeroDeCreditoDis.Name = "txtNumeroDeCreditoDis"
        Me.txtNumeroDeCreditoDis.Size = New System.Drawing.Size(123, 21)
        Me.txtNumeroDeCreditoDis.TabIndex = 30
        '
        'txtCargaHorariaDis
        '
        Me.txtCargaHorariaDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargaHorariaDis.Location = New System.Drawing.Point(148, 72)
        Me.txtCargaHorariaDis.Name = "txtCargaHorariaDis"
        Me.txtCargaHorariaDis.Size = New System.Drawing.Size(88, 21)
        Me.txtCargaHorariaDis.TabIndex = 29
        '
        'TxtNomeDis
        '
        Me.TxtNomeDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomeDis.Location = New System.Drawing.Point(148, 46)
        Me.TxtNomeDis.Name = "TxtNomeDis"
        Me.TxtNomeDis.Size = New System.Drawing.Size(239, 21)
        Me.TxtNomeDis.TabIndex = 28
        '
        'txtCodigoDis
        '
        Me.txtCodigoDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDis.Location = New System.Drawing.Point(148, 19)
        Me.txtCodigoDis.Name = "txtCodigoDis"
        Me.txtCodigoDis.Size = New System.Drawing.Size(63, 21)
        Me.txtCodigoDis.TabIndex = 27
        '
        'cbProfessor
        '
        Me.cbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProfessor.FormattingEnabled = True
        Me.cbProfessor.Location = New System.Drawing.Point(148, 160)
        Me.cbProfessor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProfessor.Name = "cbProfessor"
        Me.cbProfessor.Size = New System.Drawing.Size(390, 23)
        Me.cbProfessor.TabIndex = 26
        '
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(12, 235)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(667, 61)
        Me.gpbotoes.TabIndex = 3
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
        'CadDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 308)
        Me.Controls.Add(Me.gpbotoes)
        Me.Controls.Add(Me.gpdados)
        Me.Name = "CadDisciplina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadDisciplina"
        Me.gpdados.ResumeLayout(False)
        Me.gpdados.PerformLayout()
        Me.gpbotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpdados As GroupBox
    Friend WithEvents txtNumeroDeCreditoDis As TextBox
    Friend WithEvents txtCargaHorariaDis As TextBox
    Friend WithEvents TxtNomeDis As TextBox
    Friend WithEvents txtCodigoDis As TextBox
    Friend WithEvents cbProfessor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents cbCursos As ComboBox
End Class
