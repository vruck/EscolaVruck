Imports Dominioo
Public Class ClassificacaoBusiness
    Public Sub inserir(obj As classificacao)
        Try

            Dim dom As New ClassificacaoDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub alterar(obj As classificacao)
        Try

            Dim dom As New ClassificacaoDominio
                dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As classificacao)
        Try
            Dim dom As New ClassificacaoDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(nome As String) As List(Of classificacao)
        Try
            Return (New ClassificacaoDominio).selecionar(nome)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As classificacao
        Try
            Return (New ClassificacaoDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
