<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadAluno))
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtnomePessoa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRa = New System.Windows.Forms.TextBox()
        Me.TxtcodigoPessoa = New System.Windows.Forms.TextBox()
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
        Me.gpbotoes.Location = New System.Drawing.Point(13, 179)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(729, 61)
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
        Me.btnlocalizar.Size = New System.Drawing.Size(171, 23)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localização Aluno"
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
        Me.gpdados.Controls.Add(Me.Button1)
        Me.gpdados.Controls.Add(Me.TxtnomePessoa)
        Me.gpdados.Controls.Add(Me.Label9)
        Me.gpdados.Controls.Add(Me.TxtRa)
        Me.gpdados.Controls.Add(Me.TxtcodigoPessoa)
        Me.gpdados.Controls.Add(Me.txtcodigo)
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Location = New System.Drawing.Point(13, 12)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(729, 139)
        Me.gpdados.TabIndex = 4
        Me.gpdados.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(523, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Localização Pessoas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtnomePessoa
        '
        Me.TxtnomePessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtnomePessoa.Location = New System.Drawing.Point(174, 45)
        Me.TxtnomePessoa.Name = "TxtnomePessoa"
        Me.TxtnomePessoa.Size = New System.Drawing.Size(331, 21)
        Me.TxtnomePessoa.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 21
        '
        'TxtRa
        '
        Me.TxtRa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRa.Location = New System.Drawing.Point(115, 71)
        Me.TxtRa.Name = "TxtRa"
        Me.TxtRa.Size = New System.Drawing.Size(151, 21)
        Me.TxtRa.TabIndex = 9
        '
        'TxtcodigoPessoa
        '
        Me.TxtcodigoPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtcodigoPessoa.Location = New System.Drawing.Point(115, 45)
        Me.TxtcodigoPessoa.Name = "TxtcodigoPessoa"
        Me.TxtcodigoPessoa.Size = New System.Drawing.Size(53, 21)
        Me.TxtcodigoPessoa.TabIndex = 8
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(115, 19)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(85, 21)
        Me.txtcodigo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Pessoa"
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
        'CadAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(791, 252)
        Me.Controls.Add(Me.gpdados)
        Me.Controls.Add(Me.gpbotoes)
        Me.Name = "CadAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadAluno"
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
    Friend WithEvents TxtnomePessoa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRa As TextBox
    Friend WithEvents TxtcodigoPessoa As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
