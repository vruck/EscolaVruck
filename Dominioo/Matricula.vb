'------------------------------------------------------------------------------
' <auto-generated>
'    O código foi gerado a partir de um modelo.
'
'    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
'    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Matricula
    Public Property mat_codigo As Integer
    Public Property cur_codigo As Nullable(Of Integer)
    Public Property alu_codigo As Nullable(Of Integer)
    Public Property mat_termo As String
    Public Property mat_turma As String
    Public Property mat_ano As Nullable(Of Integer)
    Public Property mat_semestre As String
    Public Property mat_valor As Nullable(Of Decimal)

    Public Overridable Property Alunos As Alunos
    Public Overridable Property Cursos As Cursos
    Public Overridable Property disciplina As disciplina
    Public Overridable Property List_Disciplina As ICollection(Of List_Disciplina) = New HashSet(Of List_Disciplina)

End Class
