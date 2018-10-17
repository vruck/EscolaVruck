Public Class ListaDisciplinaDominio
    Public Sub inserir(obj As List_Disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.List_Disciplina.Add(obj)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As List_Disciplina)
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

    Public Sub excluir(obj As List_Disciplina)
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

    Public Function selecionar(codigo As Integer) As List_Disciplina
        Try
            Dim obj As List_Disciplina
            Using db As New EscolaVruckEntities1
                obj = (From lt In db.List_Disciplina
                       Where lt.list_codigo = codigo
                       Select lt).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionar(descricao As String) As List(Of List_Disciplina)
        Try
            Dim obj As List(Of List_Disciplina)
            Using db As New EscolaVruckEntities1
                obj = (From lt In db.List_Disciplina.Include("Matricula").Include("disciplina")
                       Where lt.disciplina.dis_nome = descricao
                       Select lt).ToList()
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
