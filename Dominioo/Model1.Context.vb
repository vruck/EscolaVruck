﻿'------------------------------------------------------------------------------
' <auto-generated>
'    O código foi gerado a partir de um modelo.
'
'    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
'    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq

Partial Public Class EscolaVruckEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=EscolaVruckEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Alunos() As DbSet(Of Alunos)
    Public Property classificacao() As DbSet(Of classificacao)
    Public Property Cursos() As DbSet(Of Cursos)
    Public Property disciplina() As DbSet(Of disciplina)
    Public Property List_Disciplina() As DbSet(Of List_Disciplina)
    Public Property Matricula() As DbSet(Of Matricula)
    Public Property Pessoa() As DbSet(Of Pessoa)
    Public Property Professor() As DbSet(Of Professor)
    Public Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Property vwListaDisciplina() As DbSet(Of vwListaDisciplina)
    Public Property VwMatricula() As DbSet(Of VwMatricula)
    Public Property VwPessoasAlunos() As DbSet(Of VwPessoasAlunos)
    Public Property VwPessoasAlunosProfessoresClassficacao() As DbSet(Of VwPessoasAlunosProfessoresClassficacao)
    Public Property VwPessoasProfessor() As DbSet(Of VwPessoasProfessor)

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

    Public Overridable Function SpCursoDisciplina() As ObjectResult(Of SpCursoDisciplina_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SpCursoDisciplina_Result)("SpCursoDisciplina")
    End Function

    Public Overridable Function SpMatriculaRelatorio(semestre As Nullable(Of Integer), [date] As Nullable(Of Integer)) As ObjectResult(Of SpMatriculaRelatorio_Result)
        Dim semestreParameter As ObjectParameter = If(semestre.HasValue, New ObjectParameter("semestre", semestre), New ObjectParameter("semestre", GetType(Integer)))

        Dim dateParameter As ObjectParameter = If([date].HasValue, New ObjectParameter("date", [date]), New ObjectParameter("date", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SpMatriculaRelatorio_Result)("SpMatriculaRelatorio", semestreParameter, dateParameter)
    End Function

    Public Overridable Function SpmatriculaTotal(semestre As Nullable(Of Integer), [date] As Nullable(Of Integer)) As ObjectResult(Of SpmatriculaTotal_Result)
        Dim semestreParameter As ObjectParameter = If(semestre.HasValue, New ObjectParameter("semestre", semestre), New ObjectParameter("semestre", GetType(Integer)))

        Dim dateParameter As ObjectParameter = If([date].HasValue, New ObjectParameter("date", [date]), New ObjectParameter("date", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SpmatriculaTotal_Result)("SpmatriculaTotal", semestreParameter, dateParameter)
    End Function

End Class