Imports Dominioo
Public Class CursoBusiness
    Public Sub inserir(obj As Cursos)
        Try
            Dim dom As New CursoDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As Cursos)
        Try
            Dim dom As New CursoDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As Cursos)
        Try
            Dim dom As New CursoDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(descricao As String) As List(Of Cursos)
        Try
            Return (New CursoDominio).selecionar(descricao)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionar(codigo As Integer) As Cursos
        Try
            Return (New CursoDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
