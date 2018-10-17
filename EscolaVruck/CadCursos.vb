Imports Dominioo
Imports Business
Public Class CadCursos
    Public Sub limpacampos()
        txtcodigoCurso.Text = ""
        txtNomeCurso.Text = ""
        txtValorDeCredito.Text = ""
        txtSequencia.Text = ""
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
        txtcodigoCurso.Enabled = False

    End Sub

    Private Sub btnaltera_Click(sender As Object, e As EventArgs) Handles btnaltera.Click
        If (txtcodigoCurso.Text <> "") Then
            habilita(False)
            gpdados.Enabled = True
        Else
            MessageBox.Show("Não existe livro para alterar. Localize!")
        End If
    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        Try

            If (txtNomeCurso.Text <> "" And txtValorDeCredito.Text <> "" And txtSequencia.Text <> "") Then
                Dim objP As New Cursos
                Dim objB As New CursoBusiness

                objP.cur_nome = txtNomeCurso.Text
                objP.cur_valorDeCredito = txtValorDeCredito.Text
                objP.cur_sequencia = txtSequencia.Text

                If (txtcodigoCurso.Text = "") Then
                    'inserir
                    objB.inserir(objP)
                Else
                    objP.cur_codigo = txtcodigoCurso.Text
                    objP.cur_nome = txtNomeCurso.Text
                    objP.cur_valorDeCredito = txtValorDeCredito.Text
                    objB.alterar(objP)
                End If
                objB = Nothing
                objP = Nothing
                MessageBox.Show("Salvo com sucesso!")
                btncancelar_Click(sender, e)
                limpacampos()
            Else
                MessageBox.Show("Informar nome do curso e o valor do credito ")
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
            If (txtcodigoCurso.Text <> "") Then
                'excluir
                Dim objc As New Cursos
                Dim objci As New CursoBusiness
                objc.cur_codigo = txtcodigoCurso.Text
                objc.cur_nome = txtNomeCurso.Text
                objc.cur_valorDeCredito = txtValorDeCredito.Text
                objc.cur_sequencia = txtSequencia.Text
                objci.excluir(objc)
                objci = Nothing
                objc = Nothing
                MessageBox.Show("Excluido com sucesso!")
                btncancelar_Click(sender, e)
            Else
                MessageBox.Show("Não é possível excluir. Localize!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CadCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpdados.Enabled = False
    End Sub

    Private Sub btnlocalizarr_Click(sender As Object, e As EventArgs) Handles btnlocalizarr.Click
        Try
            Dim frm As New ConCursos
            frm.ShowDialog()
            If (frm.codigo <> 0) Then
                Dim objdis As Cursos = (New CursoBusiness).selecionar(frm.codigo)
                txtcodigoCurso.Text = objdis.cur_codigo
                txtNomeCurso.Text = objdis.cur_nome
                txtValorDeCredito.Text = objdis.cur_valorDeCredito
                txtSequencia.Text = objdis.cur_sequencia
                objdis = Nothing
            End If
            frm = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar: " & ex.Message)
        End Try
    End Sub
End Class