Imports Business
Imports Dominioo

Public Class CadProfessor
    Public Sub limpacampos()
        txtcpf.Text = ""
        txtrg.Text = ""
        txtcodigoprofessor.Text = ""
        txtcodpessoa.Text = ""
        cbClassificação.Text = ""
    End Sub

    Public Sub habilita(valor As Boolean)
        btnincluir.Enabled = valor
        btnaltera.Enabled = valor
        btnsalvar.Enabled = Not valor
        btnexcluir.Enabled = valor
        btnlocalizar.Enabled = valor
        btncancelar.Enabled = Not valor
    End Sub
    Private Sub CadProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim objCC As New ClassificacaoBusiness
            cbClassificação.DataSource = objCC.selecionar("")
            cbClassificação.DisplayMember = "cla_nome"
            cbClassificação.ValueMember = "cla_codigo"
            objCC = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados " & ex.Message)
        End Try
        gbDados.Enabled = False
    End Sub

    Private Sub btnlocalizar_Click(sender As Object, e As EventArgs) Handles btnlocalizar.Click
        Try
            Dim frm As New ConProfessor
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim pro As Professor = (New ProfessorBusiness).selecionar(frm.codigo)
                txtcodigoprofessor.Text = pro.pro_codigo
                txtcpf.Text = pro.Pessoa.pes_cpf
                txtcodpessoa.Text = pro.pes_codigo
                txtnomepessoa.Text = pro.Pessoa.pes_nome
                txtrg.Text = pro.Pessoa.pes_rg
                cbClassificação.SelectedValue = pro.class_codigo
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
        txtcpf.Enabled = False
        txtrg.Enabled = False
    End Sub

    Private Sub btnincluir_Click_1(sender As Object, e As EventArgs) Handles btnincluir.Click
        limpacampos()
        habilita(False)
        gbDados.Enabled = True
        txtcpf.Enabled = False
        txtrg.Enabled = False
    End Sub

    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpacampos()
        habilita(True)
        gbDados.Enabled = False
    End Sub

    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If (txtcodigoprofessor.Text <> "") Then
            habilita(False)
            gbDados.Enabled = True
           
        Else
            MessageBox.Show("Não existe essa Pessoa para alterar. Localize!")
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (txtnomepessoa.Text <> "" And txtcpf.Text <> "") Then
                Dim objpro As New Professor
                Dim objB As New ProfessorBusiness
                objpro.class_codigo = cbClassificação.SelectedValue
                objpro.pes_codigo = txtcodpessoa.Text
                If (txtcodigoprofessor.Text = "") Then
                    'inserir
                    objB.inserir(objpro)
                Else
                    'alterar
                    objpro.pro_codigo = txtcodigoprofessor.Text
                    'pro_codigo
                    'codigo da classi
                    objB.alterar(objpro)
                End If
                objB = Nothing
                objpro = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click_1(sender, e)
                limpacampos()
            Else
                MessageBox.Show("Informar informe os campos vazios ")
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnlocalizarPessoa_Click_1(sender As Object, e As EventArgs) Handles btnlocalizarPessoa.Click
        Dim frm As New ConPessoas
        frm.ShowDialog()
        If (frm.codigo <> 0) Then
            Dim codigoPes As Integer = frm.codigo
            Dim objPesBus As New PessoasBusiness
            Dim objP As Pessoa
            objP = objPesBus.selecionar(codigoPes)
            txtcodpessoa.Text = objP.pes_codigo
            txtnomepessoa.Text = objP.pes_nome
            txtcpf.Text = objP.pes_cpf
            txtrg.Text = objP.pes_rg
            objP = Nothing
            objPesBus = Nothing
        End If
        frm = Nothing
    End Sub


  
    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Try
            If (txtcodigoprofessor.Text <> "") Then
                'excluir
                Dim objP As New Professor
                Dim objB As New ProfessorBusiness
                objP = objB.selecionar(
                    Integer.Parse(txtcodigoprofessor.Text))

                objP.pro_codigo = txtcodigoprofessor.Text
                objB.excluir(objP)
                objB = Nothing
                objP = Nothing
                MessageBox.Show("Excluido com sucesso!")
                btncancelar_Click_1(sender, e)
            Else
                MessageBox.Show("Não é possível excluir. Localize!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    
 
End Class