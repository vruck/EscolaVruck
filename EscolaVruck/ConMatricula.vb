Imports Dominioo
Imports Business
Public Class ConMatricula
    Public codigo As Integer



    Public Sub consultar()
        Try
            Dim objB As New MatriculaBusiness
            Dim lista As List(Of VwMatricula)
            lista = objB.selecionar(txtdescricao.Text)
            dgDados.DataSource = lista
            If (Not lista Is Nothing) Then
                dgDados.Columns("mat_codigo").HeaderText = "Código"
                dgDados.Columns("cur_nome").HeaderText = "Curso"
                dgDados.Columns("pes_nome").HeaderText = "Aluno"
                dgDados.Columns("mat_termo").HeaderText = "Termo"
                dgDados.Columns("mat_turma").HeaderText = "turma"
                dgDados.Columns("mat_ano").HeaderText = "Ano"
                dgDados.Columns("mat_semestre").HeaderText = "Semestre"
                dgDados.Columns("mat_valor").HeaderText = "Valor"
                dgDados.Columns(1).Width = 200
                For i As Integer = 0 To dgDados.Columns.Count - 1
                    If (dgDados.Columns(i).Name <> "mat_codigo" And dgDados.Columns(i).Name <>
                        "cur_nome" And dgDados.Columns(i).Name <>
                        "pes_nome" And dgDados.Columns(i).Name <>
                        "mat_turma" And dgDados.Columns(i).Name <> "mat_termo" And dgDados.Columns(i).Name <> "mat_ano" And dgDados.Columns(i).Name <> "mat_semestre" And dgDados.Columns(i).Name <> "mat_valor") Then
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
        codigo = dgDados.Rows(e.RowIndex).Cells("mat_codigo").Value
        Me.Close()
    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Dim frm As New CadMatricula
        frm.ShowDialog()
        frm = Nothing
        'atualizar a consulta
        consultar()
    End Sub

    Private Sub ConMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class