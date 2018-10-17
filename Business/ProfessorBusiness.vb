Imports Dominioo
Public Class ProfessorBusiness
    Public Sub inserir(obj As Professor)
        Try
            Dim dom As New ProfessorDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As Professor)
        Try
            Dim dom As New ProfessorDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As Professor)
        Try
            Dim dom As New ProfessorDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(descricao As String) As List(Of VwPessoasProfessor)
        Try
            Return (New ProfessorDominio).selecionar(descricao)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionar(codigo As Integer) As Professor
        Try
            Return (New ProfessorDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
