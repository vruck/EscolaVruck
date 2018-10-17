Imports Dominioo

Public Class AlunoBusiness
    Public Sub inserir(obj As Alunos)
        Try
            Dim dom As New AlunosDominio

            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As Alunos)
        Try
            Dim dom As New AlunosDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As Alunos)
        Try
            Dim dom As New AlunosDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(nome As String) As List(Of VwPessoasAlunos)
        Try
            Return (New AlunosDominio).selecionar(nome)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As Alunos
        Try
            Return (New AlunosDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

   

End Class
