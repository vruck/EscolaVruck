Imports Business
Imports Dominioo

Public Class CadPessoas
    Public Sub limpacampos()
        txtcpf.Text = ""
        txtcodigo.Text = ""
        txtrg.Text = ""
        txtnome.Text = ""
        mddate.Text = ""
        txtsexo.Text = ""
        txtCidadePessoas.Text = ""
        TxtUfPessoas.Text = ""
        mdtelefone.Text = ""

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
        txtcodigo.Enabled = False
        gpdados.Enabled = True
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If (txtcodigo.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True
        Else
            MessageBox.Show("Não existe Pessoa para alterar. Localize!")
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (txtnome.Text <> "" And txtcpf.Text <> "" And txtrg.Text <> "" And txtsexo.Text <> "" And mddate.Text <> "" And mdtelefone.Text <> "" And txtCidadePessoas.Text <> "" And TxtUfPessoas.Text <> "") Then
                Dim objP As New Pessoa
                Dim objB As New PessoasBusiness

                objP.pes_cpf = txtcpf.Text
                objP.pes_nome = txtnome.Text
                objP.pes_datnascimento = mddate.Text
                objP.pes_sexo = txtsexo.Text
                objP.pes_rg = txtrg.Text
                objP.pes_telefone = mdtelefone.Text
                objP.pes_cidade = txtCidadePessoas.Text
                objP.pes_uf = TxtUfPessoas.Text
                If (txtcodigo.Text = "") Then
                    'inserir
                    objB.inserir(objP)
                Else
                    'alterar
                    objP.pes_codigo = txtcodigo.Text
                    objP.pes_cpf = txtcpf.Text
                    objP.pes_nome = txtnome.Text
                    objP.pes_datnascimento = mddate.Text
                    objP.pes_sexo = txtsexo.Text
                    objP.pes_rg = txtrg.Text
                    objP.pes_telefone = mdtelefone.Text
                    objP.pes_cidade = txtCidadePessoas.Text
                    objP.pes_uf = TxtUfPessoas.Text
                    objB.alterar(objP)
                End If
                objB = Nothing
                objP = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click(sender, e)
                limpacampos()
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
                Dim objP As New Pessoa
                Dim objB As New PessoasBusiness
                objP = objB.selecionar(
                    Integer.Parse(txtcodigo.Text))

                objP.pes_cpf = txtcpf.Text
                objP.pes_nome = txtnome.Text
                objP.pes_datnascimento = mddate.Text
                objP.pes_sexo = txtsexo.Text
                objP.pes_rg = txtrg.Text
                objP.pes_telefone = mdtelefone.Text
                objP.pes_cidade = txtCidadePessoas.Text
                objP.pes_uf = TxtUfPessoas.Text

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
        Try
            Dim frm As New ConPessoas
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim pes As Pessoa = (New PessoasBusiness).selecionar(frm.codigo)
                txtcodigo.Text = pes.pes_codigo
                txtcpf.Text = pes.pes_cpf
                mddate.Text = pes.pes_datnascimento
                txtnome.Text = pes.pes_nome
                txtrg.Text = pes.pes_rg
                txtsexo.Text = pes.pes_sexo
                mdtelefone.Text = pes.pes_telefone
                txtCidadePessoas.Text = pes.pes_cidade
                TxtUfPessoas.Text = pes.pes_uf

                pes = Nothing
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub

    Private Sub CadPessoas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpdados.Enabled = False
    End Sub


End Class