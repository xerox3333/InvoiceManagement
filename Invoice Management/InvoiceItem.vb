''' <summary>
''' This class represents an invoice item
''' </summary>

Public Class InvoiceItem

    Private item As String
    Private qty As String
    Private unit As String
    Private unitPrice As Single
    Private Price As Single

    Public Sub New()



    End Sub

    Public Property pItem As String

        Get
            Return item
        End Get
        Set(ByVal value As String)
            item = value
        End Set

    End Property

    Public Property pQty As String

        Get
            Return qty
        End Get
        Set(ByVal value As String)
            qty = value
        End Set

    End Property

    Public Property pUnit As String

        Get
            Return unit
        End Get
        Set(ByVal value As String)
            unit = value
        End Set

    End Property

    Public Property pUnitPrice As Single

        Get
            Return unitPrice
        End Get
        Set(ByVal value As Single)
            unitPrice = value
        End Set

    End Property

    Public Property pPrice As Single

        Get
            Return Price
        End Get
        Set(value As Single)
            Price = value
        End Set

    End Property

End Class
