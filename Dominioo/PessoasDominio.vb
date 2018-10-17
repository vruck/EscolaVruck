Public Class PessoasDominio
    Public Sub inserir(obj As Pessoa)
        Try
            Using db As New EscolaVruckEntities1
                db.Pessoa.Add(obj)
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As Pessoa)
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

    Public Sub excluir(obj As Pessoa)
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

    Public Function selecionar(descricao As String) As List(Of Pessoa)
        Try
            Dim lista As List(Of Pessoa)
            Using db As New EscolaVruckEntities1
                lista = (From p In db.Pessoa
                         Where p.pes_nome.Contains(descricao)
                         Order By p.pes_nome Select p).ToList
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As Pessoa
        Try
            Dim obj As Pessoa
            Using db As New EscolaVruckEntities1
                obj = (From p In db.Pessoa
                       Where p.pes_codigo = codigo
                       Select p).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
