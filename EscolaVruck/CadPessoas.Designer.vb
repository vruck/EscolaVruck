<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadPessoas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadPessoas))
        Me.gpdados = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtUfPessoas = New System.Windows.Forms.TextBox()
        Me.txtCidadePessoas = New System.Windows.Forms.TextBox()
        Me.mdtelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mddate = New System.Windows.Forms.MaskedTextBox()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.txtrg = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gpdados.SuspendLayout()
        Me.gpbotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpdados
        '
        Me.gpdados.Controls.Add(Me.Label9)
        Me.gpdados.Controls.Add(Me.Label8)
        Me.gpdados.Controls.Add(Me.TxtUfPessoas)
        Me.gpdados.Controls.Add(Me.txtCidadePessoas)
        Me.gpdados.Controls.Add(Me.mdtelefone)
        Me.gpdados.Controls.Add(Me.mddate)
        Me.gpdados.Controls.Add(Me.txtsexo)
        Me.gpdados.Controls.Add(Me.txtrg)
        Me.gpdados.Controls.Add(Me.txtcpf)
        Me.gpdados.Controls.Add(Me.txtnome)
        Me.gpdados.Controls.Add(Me.txtcodigo)
        Me.gpdados.Controls.Add(Me.Label7)
        Me.gpdados.Controls.Add(Me.Label6)
        Me.gpdados.Controls.Add(Me.Label5)
        Me.gpdados.Controls.Add(Me.Label4)
        Me.gpdados.Controls.Add(Me.Label3)
        Me.gpdados.Controls.Add(Me.Label2)
        Me.gpdados.Controls.Add(Me.Label1)
        Me.gpdados.Location = New System.Drawing.Point(14, 11)
        Me.gpdados.Name = "gpdados"
        Me.gpdados.Size = New System.Drawing.Size(667, 275)
        Me.gpdados.TabIndex = 3
        Me.gpdados.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "UF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cidade"
        '
        'TxtUfPessoas
        '
        Me.TxtUfPessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUfPessoas.Location = New System.Drawing.Point(70, 232)
        Me.TxtUfPessoas.Name = "TxtUfPessoas"
        Me.TxtUfPessoas.Size = New System.Drawing.Size(230, 21)
        Me.TxtUfPessoas.TabIndex = 19
        '
        'txtCidadePessoas
        '
        Me.txtCidadePessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidadePessoas.Location = New System.Drawing.Point(70, 206)
        Me.txtCidadePessoas.Name = "txtCidadePessoas"
        Me.txtCidadePessoas.Size = New System.Drawing.Size(230, 21)
        Me.txtCidadePessoas.TabIndex = 18
        '
        'mdtelefone
        '
        Me.mdtelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdtelefone.Location = New System.Drawing.Point(70, 180)
        Me.mdtelefone.Mask = "00000000000"
        Me.mdtelefone.Name = "mdtelefone"
        Me.mdtelefone.Size = New System.Drawing.Size(117, 21)
        Me.mdtelefone.TabIndex = 17
        '
        'mddate
        '
        Me.mddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mddate.Location = New System.Drawing.Point(152, 123)
        Me.mddate.Mask = "00000000000000000"
        Me.mddate.Name = "mddate"
        Me.mddate.Size = New System.Drawing.Size(100, 21)
        Me.mddate.TabIndex = 16
        '
        'txtsexo
        '
        Me.txtsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsexo.Location = New System.Drawing.Point(70, 153)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(31, 21)
        Me.txtsexo.TabIndex = 12
        '
        'txtrg
        '
        Me.txtrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrg.Location = New System.Drawing.Point(70, 97)
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(120, 21)
        Me.txtrg.TabIndex = 10
        '
        'txtcpf
        '
        Me.txtcpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpf.Location = New System.Drawing.Point(70, 71)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(151, 21)
        Me.txtcpf.TabIndex = 9
        '
        'txtnome
        '
        Me.txtnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.Location = New System.Drawing.Point(70, 45)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(496, 21)
        Me.txtnome.TabIndex = 8
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(70, 19)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(85, 21)
        Me.txtcodigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Data De Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
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
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(14, 292)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(667, 61)
        Me.gpbotoes.TabIndex = 2
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
        'CadPessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(695, 365)
        Me.Controls.Add(Me.gpdados)
        Me.Controls.Add(Me.gpbotoes)
        Me.Name = "CadPessoas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadPessoas"
        Me.gpdados.ResumeLayout(False)
        Me.gpdados.PerformLayout()
        Me.gpbotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpdados As GroupBox
    Friend WithEvents gpbotoes As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnaltera As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnincluir As Button
    Friend WithEvents mddate As MaskedTextBox
    Friend WithEvents btnlocalizar As Button
    Friend WithEvents txtsexo As TextBox
    Friend WithEvents txtrg As TextBox
    Friend WithEvents txtcpf As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mdtelefone As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtUfPessoas As TextBox
    Friend WithEvents txtCidadePessoas As TextBox
End Class
