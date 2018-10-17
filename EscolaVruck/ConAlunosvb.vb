Imports Business
Imports Dominioo

Public Class ConAlunosvb
    Public codigo As Integer



    Public Sub consultar()
        Try
            Dim objc As New AlunoBusiness
            Dim lista As List(Of VwPessoasAlunos)
            lista = objc.selecionar(txtdescricao.Text)
            dgDados.DataSource = lista
            If (Not lista Is Nothing) Then
                dgDados.Columns(0).HeaderText = "Código"
                dgDados.Columns("pes_nome").HeaderText = "Nome"
                dgDados.Columns("al_ra").HeaderText = "Ra"
                dgDados.Columns("pes_cpf").HeaderText = "CPF"
                dgDados.Columns("pes_nome").Width = 200
                For i As Integer = 0 To dgDados.Columns.Count - 1
                    If (dgDados.Columns(i).Name <>
                        "pes_nome" And dgDados.Columns(i).Name <>
                        "al_ra" And dgDados.Columns(i).Name <> "pes_cpf") Then
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
        codigo = dgDados.Rows(e.RowIndex).Cells("al_codigo").Value
        Me.Close()
    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Dim frm As New CadAluno
        frm.ShowDialog()
        frm = Nothing
        consultar()
    End Sub


End Class