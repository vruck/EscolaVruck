Imports Business
Imports Dominioo
Public Class CadAluno
    Public Sub limpacampos()
        txtcodigo.Text = ""
        TxtcodigoPessoa.Text = ""
        TxtnomePessoa.Text = ""
        TxtRa.Text = ""
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpacampos()
        habilita(True)
        gpdados.Enabled = False
    End Sub

    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If (txtcodigo.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True

        Else
            MessageBox.Show("Não existe esse aluno para alterar. Localize!")
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (TxtRa.Text <> "") Then
                Dim objalu As New Alunos
                Dim obja As New AlunoBusiness
                objalu.pes_codigo = TxtcodigoPessoa.Text
                objalu.al_ra = TxtRa.Text
                If (txtcodigo.Text = "") Then
                    'inserir
                    obja.inserir(objalu)
                Else
                    'altera
                    objalu.al_codigo = txtcodigo.Text
                    objalu.al_ra = TxtRa.Text

                    obja.alterar(objalu)
                End If
                obja = Nothing
                objalu = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click(sender, e)
                limpacampos()
            Else
                MessageBox.Show("Informar os campo vazio !")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Try
            If (txtcodigo.Text <> "") Then
                'excluir
                Dim objP As New Alunos
                Dim objB As New AlunoBusiness
                objP = objB.selecionar(
                    Integer.Parse(txtcodigo.Text))

                objP.al_codigo = txtcodigo.Text
                objB.excluir(objP)
                objB = Nothing
                objP = Nothing
                MessageBox.Show("Excluido com sucesso!")
                btncancelar_Click(sender, e)
            Else
                MessageBox.Show("Não é possível excluir. Localize!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnlocalizar_Click(sender As Object, e As EventArgs) Handles btnlocalizar.Click
        Dim frm As New ConAlunosvb
        frm.ShowDialog()
        If (frm.codigo <> 0) Then
            Dim codigoPes As Integer = frm.codigo
            Dim objPesBus As New AlunoBusiness
            Dim objP As New Alunos
            objP = objPesBus.selecionar(codigoPes)
            txtcodigo.Text = objP.al_codigo
            TxtcodigoPessoa.Text = objP.pes_codigo
            TxtnomePessoa.Text = objP.Pessoa.pes_nome
            TxtRa.Text = objP.al_ra

            objP = Nothing
            objPesBus = Nothing
        End If
        frm = Nothing
    End Sub

    Private Sub CadAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpdados.Enabled = False
        txtcodigo.Enabled = False
        TxtcodigoPessoa.Enabled = False
        TxtnomePessoa.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New ConPessoas
        frm.ShowDialog()
        If (frm.codigo <> 0) Then
            Dim codigoPes As Integer = frm.codigo
            Dim objPesBus As New PessoasBusiness
            Dim objP As Pessoa
            objP = objPesBus.selecionar(codigoPes)
            TxtcodigoPessoa.Text = objP.pes_codigo
            TxtnomePessoa.Text = objP.pes_nome

            objP = Nothing
            objPesBus = Nothing
        End If
        frm = Nothing
    End Sub
End Class