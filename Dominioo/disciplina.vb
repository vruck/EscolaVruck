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

Partial Public Class disciplina
    Public Property dis_codigo As String
    Public Property dis_nome As String
    Public Property dis_cargaHoraria As Nullable(Of Integer)
    Public Property dis_numeroCredito As Nullable(Of Integer)
    Public Property pro_codigo As Nullable(Of Integer)
    Public Property cur_codigo As Nullable(Of Integer)

    Public Overridable Property Professor As Professor
    Public Overridable Property List_Disciplina As ICollection(Of List_Disciplina) = New HashSet(Of List_Disciplina)
    Public Overridable Property Matricula As ICollection(Of Matricula) = New HashSet(Of Matricula)

End Class
