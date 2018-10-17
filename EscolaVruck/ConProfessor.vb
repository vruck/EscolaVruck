Imports Business
Imports Dominioo
Public Class ConProfessor
    Public codigo As Integer



    Public Sub consultar()
        Try
            Dim objc As New ProfessorBusiness
            Dim lista As List(Of VwPessoasProfessor)
            lista = objc.selecionar(txtdescricao.Text)
            dgDados.DataSource = lista
            If (Not lista Is Nothing) Then
                dgDados.Columns("pes_nome").HeaderText = "Nome"
                dgDados.Columns("cla_nome").HeaderText = "Classificação"
                dgDados.Columns("cla_uf").HeaderText = "UF"
                dgDados.Columns("pes_nome").Width = 200
                For i As Integer = 0 To dgDados.Columns.Count - 1
                    If (dgDados.Columns(i).Name <>
                        "pes_nome" And dgDados.Columns(i).Name <>
                        "cla_nome" And dgDados.Columns(i).Name <>
                        "cla_uf") Then
                        dgDados.Columns(i).Visible = False
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar " & ex.Message)
        End Try
    End Sub

    Private Sub txtdescricao_KeyUp(sender As Object, e As KeyEventArgs) Handles txtdescricao.KeyUp
        consultar()
    End Sub

    Private Sub dgDados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDados.CellDoubleClick
        codigo = dgDados.Rows(e.RowIndex).Cells("pro_codigo").Value
        Me.Close()
    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Dim frm As New CadAluno
        frm.ShowDialog()
        frm = Nothing
        'atualizar a consulta
        consultar()
    End Sub

    Private Sub ConProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class