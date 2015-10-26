''' <summary>
''' This class represents an invoice
''' </summary>

Public Class Invoice

    Private invoiceItems As List(Of InvoiceItem)

    Private invoiceNo, invoiceDate As String
    Private purchaseNo As String
    Private customerNo As String
    Private billTo As String
    Private invoiceTotal, invoiceTax, invoiceSubtotal As String
    Private terms As String
    Private termsLength As String
    Private Author As String
    Private Notes As String
    Private Comments As String

    'Constructor
    Public Sub New()



    End Sub

    Public Property pInvoiceNo As String

        Get
            Return invoiceNo
        End Get

        Set(ByVal value As String)
            invoiceNo = value
        End Set

    End Property

    Public Property pPurchaseNo As String

        Get
            Return purchaseNo
        End Get
        Set(ByVal value As String)
            purchaseNo = value
        End Set

    End Property

    Public Property pCustomerNo As String

        Get
            Return customerNo
        End Get
        Set(ByVal value As String)
            customerNo = value
        End Set

    End Property

    Public Property pInvoiceDate As String

        Get
            Return invoiceDate
        End Get
        Set(ByVal value As String)
            invoiceDate = value
        End Set

    End Property

    Public Property pBillTo As String

        Get
            Return billTo
        End Get
        Set(ByVal value As String)
            billTo = value
        End Set

    End Property

    Public Property pTerms As String

        Get
            Return terms
        End Get
        Set(ByVal value As String)
            terms = value
        End Set

    End Property

    Public Property pTermsLength As String

        Get
            Return termsLength
        End Get
        Set(ByVal value As String)
            termsLength = value
        End Set

    End Property

    Public Property pAuthor As String

        Get
            Return Author
        End Get
        Set(value As String)
            Author = value
        End Set

    End Property

    Public Property pNotes As String

        Get
            Return Notes
        End Get
        Set(value As String)
            Notes = value
        End Set

    End Property

    Public Property pComments As String

        Get
            Return Comments
        End Get
        Set(value As String)
            Comments = value
        End Set

    End Property

    Public Property pTotal As String

        Get
            Return invoiceTotal
        End Get
        Set(ByVal value As String)
            invoiceTotal = value
        End Set

    End Property

    Public Property pInvoiceTax As String

        Get
            Return invoiceTax
        End Get
        Set(value As String)
            invoiceTax = value
        End Set

    End Property

    Public Property pInvoiceSubtotal As String

        Get
            Return invoiceSubtotal
        End Get
        Set(value As String)
            invoiceSubtotal = value
        End Set

    End Property

    Public Overrides Function ToString() As String

        Dim info As String = ""

        info += "The details for invoice No: " & invoiceNo

        Return info

    End Function

End Class
