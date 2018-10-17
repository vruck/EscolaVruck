﻿Imports Business
Imports Dominioo

Public Class ConCursos

    Public codigo As Integer
    Public nome As String



    Public Sub consultar()
        Try
            Dim objB As New CursoBusiness
            Dim lista As List(Of Cursos)
            lista = objB.selecionar(txtdescricao.Text)
            dgDados.DataSource = lista
            If (Not lista Is Nothing) Then
                dgDados.Columns(0).HeaderText = "Código"
                dgDados.Columns(1).HeaderText = "Disciplina Codigo"
                dgDados.Columns(2).HeaderText = "Valor De Credito"
                dgDados.Columns(3).HeaderText = "Sequencia "

                dgDados.Columns(1).Width = 200
                For i As Integer = 4 To dgDados.Columns.Count - 1
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
        nome = dgDados.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub

    Private Sub btncadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Dim frm As New CadCursos
        frm.ShowDialog()
        frm = Nothing
        'atualizar a consulta
        consultar()
    End Sub


End Class