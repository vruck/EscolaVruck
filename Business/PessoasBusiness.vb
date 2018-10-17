Imports Dominioo

Public Class PessoasBusiness
    Public Sub inserir(obj As Pessoa)
        Try
            If (VerificaCPF(obj.pes_cpf)) Then
                Dim dom As New PessoasDominio
                dom.inserir(obj)
                dom = Nothing
            Else
                'gerar um erro
                Throw New Exception("CPF inválido!")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub alterar(obj As Pessoa)
        Try
            If (VerificaCPF(obj.pes_cpf)) Then
                Dim dom As New PessoasDominio
                dom.alterar(obj)
                dom = Nothing
            Else
                'gerar um erro
                Throw New Exception("CPF inválido!")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluir(obj As Pessoa)
        Try
            'validar se existem alunos com este pes_codigo
            Dim domAluno As New AlunosDominio
            If (Not domAluno.buscarAlunos(obj.pes_codigo)) Then
                Dim dom As New PessoasDominio
                dom.excluir(obj)
                dom = Nothing
            Else
                'existem alunos associados
                'gerar um erro
                Throw New Exception("Não é possível concluir a exclusão, pois, existem alunos associados a esta pessoa!")
            End If
            domAluno = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionar(nome As String) As List(Of Pessoa)
        Try
            Return (New PessoasDominio).selecionar(nome)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function selecionar(codigo As Integer) As Pessoa
        Try
            Return (New PessoasDominio).selecionar(codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function VerificaCPF(ByVal strCPFCliente As String) As Boolean
        Dim strCPFOriginal As String = strCPFCliente.Replace(".", "").Replace("-", "")
        Dim strCPF As String = Mid(strCPFOriginal, 1, 9)
        Dim strCPFTemp As String
        Dim intSoma As Integer
        Dim intResto As Integer
        Dim strDigito As String
        Dim intMultiplicador As Integer = 10
        Const constIntMultiplicador As Integer = 11
        Dim i As Integer
        For i = 0 To strCPF.ToString.Length - 1
            intSoma += CInt(strCPF.ToString.Chars(i).ToString) * intMultiplicador
            intMultiplicador -= 1
        Next
        If (intSoma Mod constIntMultiplicador) < 2 Then
            intResto = 0
        Else
            intResto = constIntMultiplicador - (intSoma Mod constIntMultiplicador)
        End If
        strDigito = intResto
        intSoma = 0
        strCPFTemp = strCPF & strDigito
        intMultiplicador = 11
        For i = 0 To strCPFTemp.Length - 1
            intSoma += CInt(strCPFTemp.Chars(i).ToString) * intMultiplicador
            intMultiplicador -= 1
        Next
        If (intSoma Mod constIntMultiplicador) < 2 Then

            intResto = 0
        Else
            intResto = constIntMultiplicador - (intSoma Mod constIntMultiplicador)
        End If
        strDigito &= intResto
        If strDigito = Mid(strCPFOriginal, 10, strCPFOriginal.Length) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
