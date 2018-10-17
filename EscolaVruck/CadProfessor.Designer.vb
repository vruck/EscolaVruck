<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadProfessor
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
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.txtrg = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlocalizarPessoa = New System.Windows.Forms.Button()
        Me.txtnomepessoa = New System.Windows.Forms.TextBox()
        Me.cbClassificação = New System.Windows.Forms.ComboBox()
        Me.txtcodpessoa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigoprofessor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbotoes = New System.Windows.Forms.GroupBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnaltera = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.gbDados.SuspendLayout()
        Me.gpbotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDados
        '
        Me.gbDados.Controls.Add(Me.txtrg)
        Me.gbDados.Controls.Add(Me.txtcpf)
        Me.gbDados.Controls.Add(Me.Label4)
        Me.gbDados.Controls.Add(Me.Label2)
        Me.gbDados.Controls.Add(Me.btnlocalizarPessoa)
        Me.gbDados.Controls.Add(Me.txtnomepessoa)
        Me.gbDados.Controls.Add(Me.cbClassificação)
        Me.gbDados.Controls.Add(Me.txtcodpessoa)
        Me.gbDados.Controls.Add(Me.Label6)
        Me.gbDados.Controls.Add(Me.Label3)
        Me.gbDados.Controls.Add(Me.txtcodigoprofessor)
        Me.gbDados.Controls.Add(Me.Label1)
        Me.gbDados.Location = New System.Drawing.Point(6, 12)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(849, 274)
        Me.gbDados.TabIndex = 3
        Me.gbDados.TabStop = False
        '
        'txtrg
        '
        Me.txtrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrg.Location = New System.Drawing.Point(69, 140)
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(120, 21)
        Me.txtrg.TabIndex = 28
        '
        'txtcpf
        '
        Me.txtcpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpf.Location = New System.Drawing.Point(69, 114)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(151, 21)
        Me.txtcpf.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "RG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "CPF"
        '
        'btnlocalizarPessoa
        '
        Me.btnlocalizarPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlocalizarPessoa.Location = New System.Drawing.Point(524, 81)
        Me.btnlocalizarPessoa.Name = "btnlocalizarPessoa"
        Me.btnlocalizarPessoa.Size = New System.Drawing.Size(199, 23)
        Me.btnlocalizarPessoa.TabIndex = 16
        Me.btnlocalizarPessoa.Text = "Localizar Pessoas"
        Me.btnlocalizarPessoa.UseVisualStyleBackColor = True
        '
        'txtnomepessoa
        '
        Me.txtnomepessoa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtnomepessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomepessoa.Location = New System.Drawing.Point(120, 82)
        Me.txtnomepessoa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnomepessoa.Multiline = True
        Me.txtnomepessoa.Name = "txtnomepessoa"
        Me.txtnomepessoa.ReadOnly = True
        Me.txtnomepessoa.Size = New System.Drawing.Size(387, 20)
        Me.txtnomepessoa.TabIndex = 14
        '
        'cbClassificação
        '
        Me.cbClassificação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassificação.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassificação.FormattingEnabled = True
        Me.cbClassificação.Location = New System.Drawing.Point(21, 195)
        Me.cbClassificação.Margin = New System.Windows.Forms.Padding(4)
        Me.cbClassificação.Name = "cbClassificação"
        Me.cbClassificação.Size = New System.Drawing.Size(390, 23)
        Me.cbClassificação.TabIndex = 19
        '
        'txtcodpessoa
        '
        Me.txtcodpessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodpessoa.Location = New System.Drawing.Point(26, 82)
        Me.txtcodpessoa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodpessoa.Name = "txtcodpessoa"
        Me.txtcodpessoa.ReadOnly = True
        Me.txtcodpessoa.Size = New System.Drawing.Size(86, 21)
        Me.txtcodpessoa.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Classificação"
        '
        'txtcodigoprofessor
        '
        Me.txtcodigoprofessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoprofessor.Location = New System.Drawing.Point(25, 37)
        Me.txtcodigoprofessor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodigoprofessor.Name = "txtcodigoprofessor"
        Me.txtcodigoprofessor.ReadOnly = True
        Me.txtcodigoprofessor.Size = New System.Drawing.Size(132, 21)
        Me.txtcodigoprofessor.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Código"
        '
        'gpbotoes
        '
        Me.gpbotoes.Controls.Add(Me.btncancelar)
        Me.gpbotoes.Controls.Add(Me.btnexcluir)
        Me.gpbotoes.Controls.Add(Me.btnaltera)
        Me.gpbotoes.Controls.Add(Me.btnlocalizar)
        Me.gpbotoes.Controls.Add(Me.btnsalvar)
        Me.gpbotoes.Controls.Add(Me.btnincluir)
        Me.gpbotoes.Location = New System.Drawing.Point(12, 306)
        Me.gpbotoes.Name = "gpbotoes"
        Me.gpbotoes.Size = New System.Drawing.Size(843, 61)
        Me.gpbotoes.TabIndex = 4
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
        Me.btnlocalizar.Size = New System.Drawing.Size(208, 23)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localização Professor"
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
        'CadProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 418)
        Me.Controls.Add(Me.gpbotoes)
        Me.Controls.Add(Me.gbDados)
        Me.Name = "CadProfessor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadProfessor"
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.gpbotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDados As GroupBox
    Friend WithEvents txtrg As TextBox
    Friend WithEvents txtcpf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnlocalizarPessoa As Button
    Friend WithEvents txtnomepessoa As TextBox
    Friend WithEvents cbClassificação As ComboBox
    Friend WithEvents txtcodpessoa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcodigoprofessor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbotoes As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnaltera As Button
    Friend WithEvents btnlocalizar As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnincluir As Button
End Class
