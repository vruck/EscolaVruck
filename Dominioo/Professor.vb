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

Partial Public Class Professor
    Public Property pro_codigo As Integer
    Public Property pes_codigo As Nullable(Of Integer)
    Public Property class_codigo As Nullable(Of Integer)

    Public Overridable Property classificacao As classificacao
    Public Overridable Property disciplina As ICollection(Of disciplina) = New HashSet(Of disciplina)
    Public Overridable Property Pessoa As Pessoa

End Class