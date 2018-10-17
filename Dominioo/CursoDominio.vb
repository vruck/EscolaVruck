Public Class CursoDominio
    Public Sub inserir(obj As Cursos)
        Try
            Using db As New EscolaVruckEntities1
                db.Cursos.Add(obj)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As Cursos)
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

    Public Sub excluir(obj As Cursos)
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


    Public Function selecionar(descricao As String) As List(Of Cursos)
        Try
            Dim lista As List(Of Cursos)
            Using db As New EscolaVruckEntities1
                lista = (From c In db.Cursos
                         Where c.cur_nome.Contains(descricao)
                         Order By c.cur_nome
                         Select c).ToList
            End Using
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As Cursos
        Try
            Dim cur As Cursos
            Using db As New EscolaVruckEntities1
                cur = (From c In db.Cursos
                       Where c.cur_codigo = codigo
                       Select c).FirstOrDefault
            End Using
            Return cur
        Catch ex As Exception
            Throw ex
        End Try
    End Function

   
End Class
