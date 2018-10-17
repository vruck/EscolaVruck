Public Class ClassificacaoDominio
    Public Sub inserir(obj As classificacao)
        Try
            Using db As New EscolaVruckEntities1
                db.classificacao.Add(obj)
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As classificacao)
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

    Public Sub excluir(obj As classificacao)
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

    Public Function selecionar(nome As String) As List(Of classificacao)
        Try
            Dim lista As List(Of classificacao)
            Using db As New EscolaVruckEntities1
                lista = (From vw In db.classificacao
                         Where vw.cla_nome.Contains(nome)
                         Select vw).ToList()
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As classificacao
        Try
            Dim obj As classificacao
            Using db As New EscolaVruckEntities1
                obj = (From c In db.classificacao.Include("classificacao")
                       Where c.cla_codigo = codigo
                       Select c).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
