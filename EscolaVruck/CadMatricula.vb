Imports Dominioo
Imports Business
Public Class CadMatricula

    Public tabelaDisciplina As New List(Of ListaDisciplinamodel)

    Public Sub limpacampos()
        TxtcodigoAluno.Text = ""
        txtcodigoMatricula.Text = ""
        txtDatamatricula.Text = ""
        TxtnomeAluno.Text = ""
        txtSemestre.Text = ""
        TxtTurma.Text = ""
        txtTurmo.Text = ""
        txtValorMatricula.Text = ""
        tabelaDisciplina.Clear()
        DgDadosDisciplina.DataSource = Nothing
    End Sub
    Public Sub habilita(valor As Boolean)
        btnincluir.Enabled = valor
        btnaltera.Enabled = valor
        btnsalvar.Enabled = Not valor
        btnexcluir.Enabled = valor
        btnlocalizar.Enabled = valor
        btncancelar.Enabled = Not valor
    End Sub
    Private Sub btnincluir_Click(sender As Object, e As EventArgs) Handles btnincluir.Click
        limpacampos()
        habilita(False)
        gpdados.Enabled = True
    End Sub
    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If (txtcodigoMatricula.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True
        Else
            MessageBox.Show("Não existe essa Matricula para alterar. Localize!")
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpacampos()
        habilita(True)
        gpdados.Enabled = False
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (txtDatamatricula.Text <> "" And txtSemestre.Text <> "" And TxtTurma.Text <> "" And txtTurmo.Text <> "" And txtValorMatricula.Text <> "") Then
                Dim objmat As New Matricula
                Dim objm As New MatriculaBusiness

                objmat.mat_valor = txtValorMatricula.Text
                objmat.cur_codigo = txtcodigo.Text
                objmat.alu_codigo = TxtcodigoAluno.Text

                objmat.mat_ano = txtDatamatricula.Text
                objmat.mat_semestre = txtSemestre.Text
                objmat.mat_termo = txtTurmo.Text
                objmat.mat_turma = TxtTurma.Text

                If (txtcodigoMatricula.Text = "") Then
                    'inserir
                    objm.inserir(objmat)
                    For Each item As ListaDisciplinamodel In tabelaDisciplina
                        Dim objDis As New List_Disciplina

                        objDis.dis_codigo = item.dis_codigo
                        objDis.mat_codigo = objmat.mat_codigo

                        objm.inserirListaDisciplina(objDis)
                    Next
                Else
                    'alterar
                    objmat.mat_codigo = txtcodigoMatricula.Text
                    objmat.mat_ano = txtDatamatricula.Text
                    objmat.mat_semestre = txtSemestre.Text
                    objmat.mat_termo = txtTurmo.Text
                    objmat.mat_turma = TxtTurma.Text
                    objm.alterar(objmat)

                    Dim ListaD As List(Of List_Disciplina) = objm.selecionarDisciplinaM(txtcodigoMatricula.Text)
                    For Each item As List_Disciplina In ListaD
                        objm.excluirDisciplina(item)
                    Next

                    For Each item As ListaDisciplinamodel In tabelaDisciplina
                        Dim objL As New List_Disciplina
                        objL.mat_codigo = objmat.mat_codigo
                        objL.dis_codigo = item.dis_codigo
                        objm.inserirListaDisciplina(objL)

                    Next

                End If
                objm = Nothing
                objmat = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click(sender, e)
            Else
                MessageBox.Show("Informar Todos os campos !! ")
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Try
            If (txtcodigoMatricula.Text <> "") Then
                'excluir
                Dim objmat As New Matricula
                Dim objm As New MatriculaBusiness

                objmat = objm.selecionarExcluir(
                    Integer.Parse(txtcodigoMatricula.Text))

                objmat.mat_ano = txtDatamatricula.Text
                objmat.mat_semestre = txtSemestre.Text
                objmat.mat_termo = txtTurmo.Text
                objmat.mat_turma = TxtTurma.Text

                Dim listaD As List(Of List_Disciplina) = objm.selecionarDisciplinaM(txtcodigoMatricula.Text)
                For Each item As List_Disciplina In listaD
                    objm.excluirDisciplina(item)
                Next
                objm.excluir(objmat)
                objm = Nothing
                objmat = Nothing
                MessageBox.Show("Excluido com sucesso!")
                btncancelar_Click(sender, e)
            Else
                MessageBox.Show("Não é possível excluir. Localize!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CadMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        gpdados.Enabled = False
        txtcodigoMatricula.Enabled = False
        TxtcodigoAluno.Enabled = False
        TxtnomeAluno.Enabled = False
        txtcodigo.Enabled = False
        txtCursonome.Enabled = False


    End Sub

    Private Sub LocalizarAluno_Click(sender As Object, e As EventArgs) Handles LocalizarAluno.Click
        Dim frm As New ConAlunosvb
        frm.ShowDialog()
        If (frm.codigo <> 0) Then
            Dim codigoPes As Integer = frm.codigo
            Dim objPesBus As New AlunoBusiness
            Dim objP As New Alunos
            objP = objPesBus.selecionar(codigoPes)
            TxtcodigoAluno.Text = objP.al_codigo
            TxtnomeAluno.Text = objP.Pessoa.pes_nome


            objP = Nothing
            objPesBus = Nothing
        End If
        frm = Nothing
    End Sub

    Private Sub btnlocalizar_Click(sender As Object, e As EventArgs) Handles btnlocalizar.Click
        Try
            Dim aux As New MatriculaBusiness
            Dim frm As New ConMatricula
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim objmat As VwMatricula = (New MatriculaBusiness).selecionar(frm.codigo)

                TxtcodigoAluno.Text = objmat.al_codigo
                txtcodigoMatricula.Text = objmat.mat_codigo
                txtcodigo.Text = objmat.cur_codigo

                txtCursonome.Text = objmat.cur_nome
                TxtnomeAluno.Text = objmat.pes_nome
                txtDatamatricula.Text = objmat.mat_ano
                txtSemestre.Text = objmat.mat_semestre
                TxtTurma.Text = objmat.mat_turma
                txtTurmo.Text = objmat.mat_termo
                txtValorMatricula.Text = objmat.mat_valor

                Dim listaD As List(Of List_Disciplina) = aux.selecionarDisciplinaM(objmat.mat_codigo)
                For Each item As List_Disciplina In listaD
                    Dim objDis As New ListaDisciplinamodel
                    objDis.mat_codigo = item.mat_codigo
                    objDis.dis_codigo = item.dis_codigo
                    tabelaDisciplina.Add(objDis)
                Next
                DgDadosDisciplina.DataSource = Nothing
                DgDadosDisciplina.DataSource = tabelaDisciplina
                objmat = Nothing
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnlocalizarcurso_Click(sender As Object, e As EventArgs) Handles btnlocalizarcurso.Click
        Try
            Dim frm As New ConCursos
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim objdis As List(Of vwListaDisciplina) = (New DisciplinaBusiness).selecionarDisciplinas(frm.codigo)
                cbdiscipilna.DataSource = objdis
                cbdiscipilna.ValueMember = "dis_codigo"
                cbdiscipilna.DisplayMember = "dis_nome"
                txtCursonome.Text = frm.nome
                txtcodigo.Text = frm.codigo

                objdis = Nothing
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub


    Private Sub btnadicionar_Click(sender As Object, e As EventArgs) Handles btnadicionar.Click
        If (cbdiscipilna.Text <> "") Then
            'verificar se ja não existe o desconto
            Dim encontrou As Boolean = False
            For Each item As ListaDisciplinamodel In tabelaDisciplina

                If (item.dis_codigo = cbdiscipilna.SelectedValue) Then
                    encontrou = True
                End If
            Next
            If (Not encontrou) Then
                'adicionar na lista
                Dim tipo As New ListaDisciplinamodel

                tipo.dis_codigo = cbdiscipilna.SelectedValue
                tabelaDisciplina.Add(tipo)


                'e vincular a lista na gridview
                DgDadosDisciplina.DataSource = Nothing
                DgDadosDisciplina.DataSource = tabelaDisciplina
                'atualizar a grid
                DgDadosDisciplina.Refresh()


            End If

        Else
            MessageBox.Show("informar o desconto e a situação!")
        End If

    End Sub

    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        Dim index As Integer
        'descobrir o indice da linha selecionada
        For Each item As DataGridViewRow In DgDadosDisciplina.Rows
            If (item.Selected) Then
                index = item.Index
            End If
        Next
        'remover da lista
        tabelaDisciplina.RemoveAt(index)
        'atualizar grid
        DgDadosDisciplina.DataSource = Nothing
        DgDadosDisciplina.DataSource = tabelaDisciplina
    End Sub

 
End Class