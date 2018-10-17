Imports Dominioo
Public Class DisciplinaBusiness
    Public Sub inserir(obj As disciplina)
        Try

            Dim dom As New DisciplinaDominio
            dom.inserir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub alterar(obj As disciplina)
        Try
            Dim dom As New DisciplinaDominio
            dom.alterar(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As disciplina)
        Try
            Dim dom As New DisciplinaDominio
            dom.excluir(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(nome As String) As List(Of disciplina)
        Try
            Return (New DisciplinaDominio).selecionar(nome)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#Region "Add na lista disciplina"
    Public Sub inserirListaDisciplina(obj As List_Disciplina)
        Try
            Dim dom As New DisciplinaDominio()
            dom.inserirListaDisciplina(obj)
            dom = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region





    Public Function selecionarDisciplinas(codigo As Integer) As List(Of vwListaDisciplina)
        Try
            Return (New DisciplinaDominio).selecionarDisciplinas(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As disciplina
        Try
            Return (New DisciplinaDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
