Public Class MatriculaDominio

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

    Public Sub excluirDisciplina(obj As List_Disciplina)
        Try
            Using db As New EscolaVruckEntities1
                db.Entry(obj).State = EntityState.Deleted
                db.SaveChanges()
            End Using

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function selecionarDisciplina(codigo As Integer) As List_Disciplina
        Try
            Dim obj As List_Disciplina
            Using db As New EscolaVruckEntities1
                obj = (From lt In db.List_Disciplina
                       Where lt.dis_codigo = codigo
                       Select lt).FirstOrDefault
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function selecionarDisciplinaM(descricao As Integer) As List(Of List_Disciplina)
        Try
            Dim obj As List(Of List_Disciplina)
            Using db As New EscolaVruckEntities1
                obj = (From lt In db.List_Disciplina.Include("Matricula").Include("disciplina")
                       Where lt.mat_codigo = descricao
                       Select lt).ToList()
            End Using
            Return obj

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


    Public Sub inserir(obj As Matricula)
        Try
            Using db As New EscolaVruckEntities1
                db.Matricula.Add(obj)
                db.SaveChanges()
            End Using
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub alterar(obj As Matricula)
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

    Public Sub excluir(obj As Matricula)
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
    Public Function selecionar(descricao As String) As List(Of VwMatricula)
        Try
            Dim lista As List(Of VwMatricula)
            Using db As New EscolaVruckEntities1
                lista = (From p In db.VwMatricula
                         Where p.pes_nome.Contains(descricao)
                         Order By p.pes_nome Select p).ToList
            End Using
            Return lista

        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Public Function selecionar(codigo As Integer) As VwMatricula
        Try
            Dim mat As VwMatricula
            Using db As New EscolaVruckEntities1
                mat = (From c In db.VwMatricula
                       Where c.mat_codigo = codigo
                       Select c).FirstOrDefault
            End Using
            Return mat
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionarExcluir(codigo As Integer) As Matricula
        Try
            Dim mat As Matricula
            Using db As New EscolaVruckEntities1
                mat = (From c In db.Matricula
                       Where c.mat_codigo = codigo
                       Select c).FirstOrDefault
            End Using
            Return mat
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
