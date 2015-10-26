Public Class Customer

    Private customerNo As String
    Private customerName As String
    Private customerAddress As String
    Private customerPhone As String
    Private customerEmail As String

    Public Property pCustomerNo As String

        Get
            Return customerNo
        End Get
        Set(value As String)
            customerNo = value
        End Set

    End Property

    Public Property pCustomerName As String

        Get
            Return customerName
        End Get
        Set(value As String)
            customerName = value
        End Set

    End Property

    Public Property pCustomerAddress As String

        Get
            Return customerAddress
        End Get
        Set(value As String)
            customerAddress = value
        End Set

    End Property

    Public Property pCustomerPhone As String

        Get
            Return customerPhone
        End Get
        Set(value As String)
            customerPhone = value
        End Set

    End Property

    Public Property pCustomerEmail As String

        Get
            Return customerEmail
        End Get
        Set(value As String)
            customerEmail = value
        End Set

    End Property

End Class
