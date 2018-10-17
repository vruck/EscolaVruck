Imports Business
Imports Dominioo
Public Class ListaDisciplinasBusiness
    Public Sub inserir(obj As List_Disciplina)
        Try
            Dim dom As New ListaDisciplinaDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As List_Disciplina)
        Try
            Dim dom As New ListaDisciplinaDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As List_Disciplina)
        Try
            Dim dom As New ListaDisciplinaDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(descricao As String) As List(Of List_Disciplina)
        Try
            Return (New ListaDisciplinaDominio).selecionar(descricao)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As List_Disciplina
        Try
            Return (New ListaDisciplinaDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
