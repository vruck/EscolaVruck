Public Class AlunosDominio
    Public Sub inserir(obj As Alunos)
        Try
            Using db As New EscolaVruckEntities1
                db.Alunos.Add(obj)
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As Alunos)
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

    Public Sub excluir(obj As Alunos)
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

    'Public Function selecionar(nome As String) As List(Of alunos)
    '    Try
    '        Dim lista As List(Of alunos)
    '        Using db As New EscolaToledoEntities
    '            lista = (From p In db.pessoas Join a In db.alunos
    '                     On p.pes_codigo Equals a.pes_codigo
    '                    Where p.pes_nome.Contains(nome)
    '                    Order By p.pes_nome Select a).ToList
    '        End Using
    '        Return lista

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function selecionar(nome As String) As List(Of VwPessoasAlunos)
        Try
            Dim lista As List(Of VwPessoasAlunos)
            Using db As New EscolaVruckEntities1
                lista = (From vw In db.VwPessoasAlunos
                         Where vw.pes_nome.Contains(nome)
                         Select vw).ToList()
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As Alunos
        Try
            Dim obj As Alunos
            Using db As New EscolaVruckEntities1
                obj = (From a In db.Alunos.Include("Pessoa")
                       Where a.al_codigo = codigo
                       Select a).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'validar se existem alunos para o pesCodigo
    Public Function buscarAlunos(pes_codigo As Integer) As Boolean
        Try
            Dim retorno As Boolean = False
            Dim lista As List(Of Alunos)
            Using db As New EscolaVruckEntities1
                lista = (From a In db.Alunos Where
                         a.pes_codigo = pes_codigo
                         Select a).ToList()
            End Using
            If (Not lista Is Nothing) Then
                If (lista.Count > 0) Then
                    retorno = True
                End If
            End If
            Return retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
