Module DatosGlobales

    Public Structure RegCliente

        Dim Codigo As Integer
        Dim Nombre As String
        Dim Limite As Decimal
        Dim Deuda As Decimal
    End Structure

    Public clientes(9) As RegCliente
    Public IND As Integer = 0


End Module
