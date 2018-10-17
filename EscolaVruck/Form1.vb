Public Class Form1
    Private Sub ProfessoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessoresToolStripMenuItem.Click
        Dim frm As New CadProfessor
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub ProfessorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessorToolStripMenuItem.Click
        Dim frm As New ConProfessor
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub PessoasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoasToolStripMenuItem.Click
        Dim frm As New CadPessoas
        frm.ShowDialog()
        frm = Nothing

    End Sub


    Private Sub PessoasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PessoasToolStripMenuItem1.Click
        Dim frm As New ConPessoas
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub ClassificaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassificaçãoToolStripMenuItem.Click
        Dim frm As New cadClassificacao
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub ClassificaçãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClassificaçãoToolStripMenuItem1.Click
        Dim frm As New ConClassificacao
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub DisciplinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinasToolStripMenuItem.Click
        Dim frm As New CadDisciplina
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub DisciplinasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisciplinasToolStripMenuItem1.Click
        Dim frm As New ConDisciplina
        frm.ShowDialog()
        frm = Nothing
    End Sub



    Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click
        Dim frm As New CadCursos
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub CursosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem1.Click
        Dim frm As New ConCursos
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub AlunosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem.Click
        Dim frm As New CadAluno
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub AlunosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem1.Click
        Dim frm As New ConAlunosvb
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub MatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriculaToolStripMenuItem.Click
        Dim frm As New CadMatricula
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub RelaçãoDeDisciplinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaçãoDeDisciplinaToolStripMenuItem.Click
        gerarRelatorio("relDis")
    End Sub


    Sub gerarRelatorio(nomeRel As String)
        Try
            Select Case nomeRel
                Case "relDis"
                    'chamada de relatorio sem parametros
                    Dim rel As New RptDisciplinaECurso
                    Dim frm As New FrmRelatorios
                    frm.CrystalReportViewer1.ReportSource = rel
                    frm.Refresh()
                    frm.ShowDialog()
                    rel = Nothing
                    frm = Nothing
                Case "relMatricula"
                    'chamada de relatorio com parametros
                    Dim rel As New RptMatriculaAlunos
                    Dim frm As New FrmRelatorios
                    frm.CrystalReportViewer1.ReportSource = rel
                    'passagem de parametros
                    rel.ParameterFields(0).CurrentValues.AddValue(txtSemestre.Text)
                    rel.ParameterFields(1).CurrentValues.AddValue(txtAnoMatriculado.Text)
                    frm.Refresh()
                    frm.ShowDialog()
                    rel = Nothing
                    frm = Nothing
                'case para outros relatorios
                Case "relMatriculaTotal"
                    'chamada de relatorio com parametros
                    Dim rel As New RptMatriculaTotal
                    Dim frm As New FrmRelatorios
                    frm.CrystalReportViewer1.ReportSource = rel
                    'passagem de parametros
                    rel.ParameterFields(0).CurrentValues.AddValue(txtSemestre2.Text)
                    rel.ParameterFields(1).CurrentValues.AddValue(txtAno2.Text)
                    frm.Refresh()
                    frm.ShowDialog()
                    rel = Nothing
                    frm = Nothing
                    'case para outros relatorios

            End Select
        Catch ex As Exception
            MessageBox.Show("Erro ao gerar relatorio!")
        End Try

    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        If (GpRelatorioMatricula.Visible) Then
            'gerar relatorio de aniversariantes
            If (txtSemestre.Text = "" And txtAnoMatriculado.Text = "") Then
                MessageBox.Show("Informar os meses!")
            Else
                gerarRelatorio("relMatricula")
            End If
        End If
        'if (para outros relatorios)
        GpFiltro.Visible = False
        GpRelatorioMatricula.Visible = False
    End Sub

    Private Sub RelaçãoDeMatriculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaçãoDeMatriculaToolStripMenuItem.Click
        GpFiltro.Visible = True
        GpRelatorioMatricula.Visible = True
        MessageBox.Show("Informe só o Ano ex (1997 )  OBS E SEMESTRE EX ( 1 )")
    End Sub

    Private Sub btnProcurar2_Click(sender As Object, e As EventArgs) Handles btnProcurar2.Click
        If (gpFiltro2.Visible) Then
            'gerar relatorio de aniversariantes
            If (txtSemestre2.Text = "" And txtAno2.Text = "") Then
                MessageBox.Show("Informar os meses!")
            Else
                gerarRelatorio("relMatriculaTotal")
            End If
        End If
        'if (para outros relatorios)
        gpFiltro2.Visible = False
        GpRelação2.Visible = False
    End Sub

    Private Sub RelaçãoDeMatriculaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaçãoDeMatriculaTotalToolStripMenuItem.Click
        gpFiltro2.Visible = True
        GpRelação2.Visible = True
        MessageBox.Show("Informe só o Ano ex (1997 )  OBS E SEMESTRE EX ( 1 )")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("PROFESSORA ANA PAULA 
As Variaveis Do Tipo DATE OU DATETIME FORAM ALTERADAS PARA INT ! ENTÃO COLOCAR SÓ AO ANO EX ( 2016 )")
    End Sub
End Class
