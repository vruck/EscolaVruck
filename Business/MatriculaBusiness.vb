Imports Dominioo
Public Class MatriculaBusiness

#Region "Add na lista disciplina"
    Public Sub inserirListaDisciplina(obj As List_Disciplina)
        Try
            Dim dom As New MatriculaDominio()
            dom.inserirListaDisciplina(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub excluirDisciplina(obj As List_Disciplina)
        Try
            Dim dom As New MatriculaDominio()
            dom.excluirDisciplina(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function selecionarDisciplina(codigo As Integer) As List_Disciplina
        Try

            Return (New MatriculaDominio()).selecionarDisciplina(codigo)

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionarDisciplinaM(descricao As String) As List(Of List_Disciplina)
        Try

            Return (New MatriculaDominio()).selecionarDisciplinaM(descricao)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

    Public Sub inserir(obj As Matricula)
        Try
            Dim dom As New MatriculaDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As Matricula)
        Try
            Dim dom As New MatriculaDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As Matricula)
        Try
            Dim dom As New MatriculaDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(nome As String) As List(Of VwMatricula)
        Try
            Return (New MatriculaDominio).selecionar(nome)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As VwMatricula
        Try
            Return (New MatriculaDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionarExcluir(codigo As Integer) As Matricula
        Try
            Return (New MatriculaDominio).selecionarExcluir(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
