Public Class DisciplinaDominio
    Public Sub inserir(obj As disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.disciplina.Add(obj)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub alterar(obj As disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.Entry(obj).State =
                    EntityState.Modified
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub excluir(obj As disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.Entry(obj).State =
                    EntityState.Deleted
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function selecionar(descricao As String) As List(Of disciplina)
        Try
            Dim lista As List(Of disciplina)
            Using db As New EscolaVruckEntities1
                lista = (From d In db.disciplina
                         Where d.dis_nome.Contains(descricao)
                         Order By d.dis_nome Select d).ToList
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionarDisciplinas(codigo As Integer) As List(Of vwListaDisciplina)
        Try
            Dim lista As List(Of vwListaDisciplina)
            Using db As New EscolaVruckEntities1
                lista = (From d In db.vwListaDisciplina
                         Where d.cur_codigo = codigo).ToList
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function


#Region "add na tabela lista disciplina"
    Public Sub inserirListaDisciplina(obj As List_Disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.List_Disciplina.Add(obj)
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Public Function selecionar(codigo As Integer) As disciplina
        Try
            Dim obj As disciplina
            Using db As New EscolaVruckEntities1
                obj = (From d In db.disciplina
                       Where d.dis_codigo = codigo
                       Select d).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
