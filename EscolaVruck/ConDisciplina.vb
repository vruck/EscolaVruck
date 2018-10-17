Imports Business
Imports Dominioo
Public Class ConDisciplina
    Public codigo As Integer



    Public Sub consultar()
        Try
            Dim objB As New DisciplinaBusiness
            Dim lista As List(Of disciplina)
            lista = objB.selecionar(txtdescricao.Text)
            dgDados.DataSource = lista
            If (Not lista Is Nothing) Then
                dgDados.Columns(0).HeaderText = "Código"
                dgDados.Columns(1).HeaderText = "Nome"
                dgDados.Columns(2).HeaderText = "Carga Horaria"
                dgDados.Columns(3).HeaderText = "Numero De Credito"
                dgDados.Columns(4).HeaderText = "Professor"
                dgDados.Columns(1).Width = 200
                For i As Integer = 5 To dgDados.Columns.Count - 1
                    dgDados.Columns(i).Visible = False
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
        codigo = dgDados.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Dim frm As New CadDisciplina
        frm.ShowDialog()
        frm = Nothing
        'atualizar a consulta
        consultar()
    End Sub

    Private Sub ConDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class