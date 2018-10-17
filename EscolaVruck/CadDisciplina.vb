Imports Dominioo
Imports Business
Public Class CadDisciplina

    Public Sub limpacampos()
        txtCargaHorariaDis.Text = ""
        txtCodigoDis.Text = ""
        TxtNomeDis.Text = ""
        txtNumeroDeCreditoDis.Text = ""
        cbProfessor.SelectedValue = ""


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
        If (txtCodigoDis.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True
        Else
            MessageBox.Show("Não existe livro para alterar. Localize!")
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (TxtNomeDis.Text <> "" And txtCargaHorariaDis.Text <> "" And txtNumeroDeCreditoDis.Text <> "" And cbProfessor.Text <> "") Then
                Dim objdis As New disciplina
                Dim objd As New DisciplinaBusiness

                objdis.dis_nome = TxtNomeDis.Text
                objdis.dis_cargaHoraria = txtCargaHorariaDis.Text
                objdis.dis_numeroCredito = txtNumeroDeCreditoDis.Text
                objdis.pro_codigo = cbProfessor.SelectedValue

                If (txtCodigoDis.Text = "") Then
                    'inserir
                    objd.inserir(objdis)
                Else
                    'alterar
                    objdis.dis_codigo = txtCodigoDis.Text
                    objdis.dis_nome = TxtNomeDis.Text
                    objdis.dis_cargaHoraria = txtCargaHorariaDis.Text
                    objdis.dis_numeroCredito = txtNumeroDeCreditoDis.Text
                    objd.alterar(objdis)
                End If
                objd = Nothing
                objdis = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click(sender, e)
            Else
                MessageBox.Show("Informar o campo Nome e Carga Horaria e Numero do Credito ")
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
            If (txtCodigoDis.Text <> "") Then
                'excluir
                Dim objdis As New disciplina
                Dim objd As New DisciplinaBusiness

                objdis.dis_codigo = txtCodigoDis.Text
                objdis.dis_nome = TxtNomeDis.Text
                objdis.dis_cargaHoraria = txtCargaHorariaDis.Text
                objdis.dis_numeroCredito = txtNumeroDeCreditoDis.Text
                objdis.pro_codigo = cbProfessor.SelectedValue

                objd.excluir(objdis)
                objd = Nothing
                objdis = Nothing
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
            Dim frm As New ConDisciplina
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim objdis As disciplina = (New DisciplinaBusiness).selecionar(frm.codigo)
                txtCodigoDis.Text = objdis.dis_codigo
                TxtNomeDis.Text = objdis.dis_nome
                txtCargaHorariaDis.Text = objdis.dis_cargaHoraria
                txtNumeroDeCreditoDis.Text = objdis.dis_numeroCredito
                objdis = Nothing
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub

    Private Sub CadDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objc As New CursoBusiness
            cbCursos.DataSource = objc.selecionar("")
            cbCursos.DisplayMember = "cur_nome"
            cbCursos.ValueMember = "cur_codigo"
            Dim objp As New ProfessorBusiness
            cbProfessor.DataSource = objp.selecionar("")
            cbProfessor.DisplayMember = "pes_nome"
            cbProfessor.ValueMember = "pro_codigo"
            objp = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados " & ex.Message)
        End Try

        gpdados.Enabled = False
        txtCodigoDis.Enabled = False
    End Sub


End Class