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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfessoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassificaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfessorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassificaçãoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaçãoDeDisciplinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaçãoDeMatriculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaçãoDeMatriculaTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GpFiltro = New System.Windows.Forms.GroupBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.GpRelatorioMatricula = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnoMatriculado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.gpFiltro2 = New System.Windows.Forms.GroupBox()
        Me.btnProcurar2 = New System.Windows.Forms.Button()
        Me.GpRelação2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAno2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSemestre2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GpFiltro.SuspendLayout()
        Me.GpRelatorioMatricula.SuspendLayout()
        Me.gpFiltro2.SuspendLayout()
        Me.GpRelação2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.RelatoriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(894, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PessoasToolStripMenuItem, Me.AlunosToolStripMenuItem, Me.ProfessoresToolStripMenuItem, Me.CursosToolStripMenuItem, Me.DisciplinasToolStripMenuItem, Me.ClassificaçãoToolStripMenuItem, Me.MatriculaToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastros"
        '
        'PessoasToolStripMenuItem
        '
        Me.PessoasToolStripMenuItem.Name = "PessoasToolStripMenuItem"
        Me.PessoasToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PessoasToolStripMenuItem.Text = "Pessoas"
        '
        'AlunosToolStripMenuItem
        '
        Me.AlunosToolStripMenuItem.Name = "AlunosToolStripMenuItem"
        Me.AlunosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AlunosToolStripMenuItem.Text = "Alunos"
        '
        'ProfessoresToolStripMenuItem
        '
        Me.ProfessoresToolStripMenuItem.Name = "ProfessoresToolStripMenuItem"
        Me.ProfessoresToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProfessoresToolStripMenuItem.Text = "Professores"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'DisciplinasToolStripMenuItem
        '
        Me.DisciplinasToolStripMenuItem.Name = "DisciplinasToolStripMenuItem"
        Me.DisciplinasToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DisciplinasToolStripMenuItem.Text = "Disciplinas"
        '
        'ClassificaçãoToolStripMenuItem
        '
        Me.ClassificaçãoToolStripMenuItem.Name = "ClassificaçãoToolStripMenuItem"
        Me.ClassificaçãoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClassificaçãoToolStripMenuItem.Text = "Classificação"
        '
        'MatriculaToolStripMenuItem
        '
        Me.MatriculaToolStripMenuItem.Name = "MatriculaToolStripMenuItem"
        Me.MatriculaToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MatriculaToolStripMenuItem.Text = "Matricula"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PessoasToolStripMenuItem1, Me.AlunosToolStripMenuItem1, Me.ProfessorToolStripMenuItem, Me.CursosToolStripMenuItem1, Me.DisciplinasToolStripMenuItem1, Me.ClassificaçãoToolStripMenuItem1})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PessoasToolStripMenuItem1
        '
        Me.PessoasToolStripMenuItem1.Name = "PessoasToolStripMenuItem1"
        Me.PessoasToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.PessoasToolStripMenuItem1.Text = "Pessoas"
        '
        'AlunosToolStripMenuItem1
        '
        Me.AlunosToolStripMenuItem1.Name = "AlunosToolStripMenuItem1"
        Me.AlunosToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.AlunosToolStripMenuItem1.Text = "Alunos"
        '
        'ProfessorToolStripMenuItem
        '
        Me.ProfessorToolStripMenuItem.Name = "ProfessorToolStripMenuItem"
        Me.ProfessorToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProfessorToolStripMenuItem.Text = "Professores"
        '
        'CursosToolStripMenuItem1
        '
        Me.CursosToolStripMenuItem1.Name = "CursosToolStripMenuItem1"
        Me.CursosToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.CursosToolStripMenuItem1.Text = "Cursos"
        '
        'DisciplinasToolStripMenuItem1
        '
        Me.DisciplinasToolStripMenuItem1.Name = "DisciplinasToolStripMenuItem1"
        Me.DisciplinasToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.DisciplinasToolStripMenuItem1.Text = "Disciplinas"
        '
        'ClassificaçãoToolStripMenuItem1
        '
        Me.ClassificaçãoToolStripMenuItem1.Name = "ClassificaçãoToolStripMenuItem1"
        Me.ClassificaçãoToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ClassificaçãoToolStripMenuItem1.Text = "Classificação"
        '
        'RelatoriosToolStripMenuItem
        '
        Me.RelatoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelaçãoDeDisciplinaToolStripMenuItem, Me.RelaçãoDeMatriculaToolStripMenuItem, Me.RelaçãoDeMatriculaTotalToolStripMenuItem})
        Me.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        Me.RelatoriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatoriosToolStripMenuItem.Text = "Relatorios"
        '
        'RelaçãoDeDisciplinaToolStripMenuItem
        '
        Me.RelaçãoDeDisciplinaToolStripMenuItem.Name = "RelaçãoDeDisciplinaToolStripMenuItem"
        Me.RelaçãoDeDisciplinaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.RelaçãoDeDisciplinaToolStripMenuItem.Text = "Relação De Disciplina"
        '
        'RelaçãoDeMatriculaToolStripMenuItem
        '
        Me.RelaçãoDeMatriculaToolStripMenuItem.Name = "RelaçãoDeMatriculaToolStripMenuItem"
        Me.RelaçãoDeMatriculaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.RelaçãoDeMatriculaToolStripMenuItem.Text = "Relação De Matricula"
        '
        'RelaçãoDeMatriculaTotalToolStripMenuItem
        '
        Me.RelaçãoDeMatriculaTotalToolStripMenuItem.Name = "RelaçãoDeMatriculaTotalToolStripMenuItem"
        Me.RelaçãoDeMatriculaTotalToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.RelaçãoDeMatriculaTotalToolStripMenuItem.Text = "Relação De Matricula Total"
        '
        'GpFiltro
        '
        Me.GpFiltro.Controls.Add(Me.btnProcurar)
        Me.GpFiltro.Controls.Add(Me.GpRelatorioMatricula)
        Me.GpFiltro.Location = New System.Drawing.Point(12, 40)
        Me.GpFiltro.Name = "GpFiltro"
        Me.GpFiltro.Size = New System.Drawing.Size(287, 241)
        Me.GpFiltro.TabIndex = 1
        Me.GpFiltro.TabStop = False
        Me.GpFiltro.Visible = False
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(53, 193)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(162, 43)
        Me.btnProcurar.TabIndex = 2
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'GpRelatorioMatricula
        '
        Me.GpRelatorioMatricula.Controls.Add(Me.Label2)
        Me.GpRelatorioMatricula.Controls.Add(Me.txtAnoMatriculado)
        Me.GpRelatorioMatricula.Controls.Add(Me.Label1)
        Me.GpRelatorioMatricula.Controls.Add(Me.txtSemestre)
        Me.GpRelatorioMatricula.Location = New System.Drawing.Point(7, 19)
        Me.GpRelatorioMatricula.Name = "GpRelatorioMatricula"
        Me.GpRelatorioMatricula.Size = New System.Drawing.Size(273, 168)
        Me.GpRelatorioMatricula.TabIndex = 0
        Me.GpRelatorioMatricula.TabStop = False
        Me.GpRelatorioMatricula.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ano Matriculado"
        '
        'txtAnoMatriculado
        '
        Me.txtAnoMatriculado.Location = New System.Drawing.Point(46, 97)
        Me.txtAnoMatriculado.Name = "txtAnoMatriculado"
        Me.txtAnoMatriculado.Size = New System.Drawing.Size(162, 20)
        Me.txtAnoMatriculado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Semestre"
        '
        'txtSemestre
        '
        Me.txtSemestre.Location = New System.Drawing.Point(46, 55)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(162, 20)
        Me.txtSemestre.TabIndex = 0
        '
        'gpFiltro2
        '
        Me.gpFiltro2.Controls.Add(Me.btnProcurar2)
        Me.gpFiltro2.Controls.Add(Me.GpRelação2)
        Me.gpFiltro2.Location = New System.Drawing.Point(321, 40)
        Me.gpFiltro2.Name = "gpFiltro2"
        Me.gpFiltro2.Size = New System.Drawing.Size(287, 241)
        Me.gpFiltro2.TabIndex = 3
        Me.gpFiltro2.TabStop = False
        Me.gpFiltro2.Visible = False
        '
        'btnProcurar2
        '
        Me.btnProcurar2.Location = New System.Drawing.Point(53, 193)
        Me.btnProcurar2.Name = "btnProcurar2"
        Me.btnProcurar2.Size = New System.Drawing.Size(162, 43)
        Me.btnProcurar2.TabIndex = 2
        Me.btnProcurar2.Text = "Procurar"
        Me.btnProcurar2.UseVisualStyleBackColor = True
        '
        'GpRelação2
        '
        Me.GpRelação2.Controls.Add(Me.Label3)
        Me.GpRelação2.Controls.Add(Me.txtAno2)
        Me.GpRelação2.Controls.Add(Me.Label4)
        Me.GpRelação2.Controls.Add(Me.txtSemestre2)
        Me.GpRelação2.Location = New System.Drawing.Point(7, 19)
        Me.GpRelação2.Name = "GpRelação2"
        Me.GpRelação2.Size = New System.Drawing.Size(273, 168)
        Me.GpRelação2.TabIndex = 0
        Me.GpRelação2.TabStop = False
        Me.GpRelação2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ano Matriculado"
        '
        'txtAno2
        '
        Me.txtAno2.Location = New System.Drawing.Point(46, 97)
        Me.txtAno2.Name = "txtAno2"
        Me.txtAno2.Size = New System.Drawing.Size(162, 20)
        Me.txtAno2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Semestre"
        '
        'txtSemestre2
        '
        Me.txtSemestre2.Location = New System.Drawing.Point(46, 55)
        Me.txtSemestre2.Name = "txtSemestre2"
        Me.txtSemestre2.Size = New System.Drawing.Size(162, 20)
        Me.txtSemestre2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(894, 321)
        Me.Controls.Add(Me.gpFiltro2)
        Me.Controls.Add(Me.GpFiltro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GpFiltro.ResumeLayout(False)
        Me.GpRelatorioMatricula.ResumeLayout(False)
        Me.GpRelatorioMatricula.PerformLayout()
        Me.gpFiltro2.ResumeLayout(False)
        Me.GpRelação2.ResumeLayout(False)
        Me.GpRelação2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PessoasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfessoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisciplinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassificaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PessoasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlunosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfessorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisciplinasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassificaçãoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaçãoDeDisciplinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaçãoDeMatriculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GpFiltro As GroupBox
    Friend WithEvents GpRelatorioMatricula As GroupBox
    Friend WithEvents btnProcurar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSemestre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnoMatriculado As TextBox
    Friend WithEvents RelaçãoDeMatriculaTotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gpFiltro2 As GroupBox
    Friend WithEvents btnProcurar2 As Button
    Friend WithEvents GpRelação2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAno2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSemestre2 As TextBox
End Class
