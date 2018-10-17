Imports Dominioo
Imports Business

Public Class cadClassificacao
    Public Sub limpacampos()
        txtcodigo.Text = ""
        txtNomeClassificacao.Text = ""
        txtuf.Text = ""
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
        If (txtcodigo.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True
        Else
            MessageBox.Show("Não existe livro para alterar. Localize!")
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (txtNomeClassificacao.Text <> "" And txtuf.Text <> "") Then
                Dim objcli As New classificacao
                Dim objc As New ClassificacaoBusiness
                objcli.cla_nome = txtNomeClassificacao.Text
                objcli.cla_uf = txtuf.Text
                If (txtcodigo.Text = "") Then
                    'inserir
                    objc.inserir(objcli)
                Else
                    'alterar
                    objcli.cla_codigo = txtcodigo.Text
                    objc.alterar(objcli)
                End If
                objc = Nothing
                objcli = Nothing
                MessageBox.Show("Salvo com sucesso!")

            Else
                MessageBox.Show("Informar o nome e o cpf")
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpacampos()
        habilita(True)
        gpdados.Enabled = False
    End Sub

    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Try
            If (txtcodigo.Text <> "") Then
                'excluir
                Dim objci As New classificacao
                Dim objc As New ClassificacaoBusiness
                objci.cla_nome = txtNomeClassificacao.Text
                objci.cla_uf = txtuf.Text

                objc.excluir(objci)
                objc = Nothing
                objci = Nothing
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
        Try
            Dim frm As New ConClassificacao
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim cla As classificacao = (New ClassificacaoBusiness).selecionar(frm.codigo)
                txtcodigo.Text = cla.cla_codigo
                txtNomeClassificacao.Text = cla.cla_nome
                txtuf.Text = cla.cla_uf

            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub


End Class