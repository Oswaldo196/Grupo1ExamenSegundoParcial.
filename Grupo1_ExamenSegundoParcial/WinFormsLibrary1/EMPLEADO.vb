Public Class EMPLEADO
    Inherits PERSONA

    'ATRIBUTOS
    Private _tipoContrato As String
    Private _sueldo As Double
    Private _cedula As String

    'PROPIEDADES 
    Public Property TipoCotrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value
        End Set
    End Property

    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property
    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    'OPERACIONES 
    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.TipoCotrato = "1") Then
            Me.Sueldo = sueldoBase + 350
        ElseIf (Me.TipoCotrato = "2") Then
            Me.Sueldo = sueldoBase + 500
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
