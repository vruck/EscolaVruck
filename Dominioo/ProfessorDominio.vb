Public Class ProfessorDominio
    Public Sub inserir(obj As Professor)
        Try
            Using db As New EscolaVruckEntities1
                db.Professor.Add(obj)
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As Professor)
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

    Public Sub excluir(obj As Professor)
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
    Public Function selecionar(nome As String) As List(Of VwPessoasProfessor)
        Try
            Dim lista As List(Of VwPessoasProfessor)
            Using db As New EscolaVruckEntities1
                lista = (From vw In db.VwPessoasProfessor
                         Where vw.pes_nome.Contains(nome)
                         Select vw).ToList()
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionar(codigo As Integer) As Professor
        Try
            Dim obj As Professor
            Using db As New EscolaVruckEntities1
                obj = (From p In db.Professor.Include("Pessoa")
                       Where p.pro_codigo = codigo
                       Select p).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
