Imports System.IO

''' <summary>
''' This class represents an invoice
''' </summary>

Public Class Invoice

    Private invoiceItems As List(Of InvoiceItem)

    Private invoiceNo, invoiceDate As String
    Private estimateNo, estimateDate As String
    Private purchaseNo As String
    Private customerNo As String
    Private billingName, billingAddress1, billingAddress2, billingCity, billingPostcode As String
    Private invoiceTotal As String
    Private terms As String
    Private termsLength As String

    'Constructor
    Public Sub New()



    End Sub

    'Public Property pAddInvoiceItem As InvoiceItem

    '    Get
    '        Return invoiceItems(0)
    '    End Get
    '    Set(ByVal value As InvoiceItem)
    '        invoiceItems.Add(value)
    '    End Set

    'End Property

    Public Property pInvoiceNo As String

        Get
            Return invoiceNo
        End Get

        Set(ByVal value As String)
            invoiceNo = value
        End Set

    End Property

    Public Property pEstimateNo As String

        Get
            Return estimateNo
        End Get
        Set(ByVal value As String)
            estimateNo = value
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

    Public Property pEstimateDate As String

        Get
            Return estimateDate
        End Get
        Set(ByVal value As String)
            estimateDate = value
        End Set

    End Property

    Public Property pBillingName As String

        Get
            Return billingName
        End Get
        Set(ByVal value As String)
            billingName = value
        End Set

    End Property

    Public Property pBillingAddress1 As String

        Get
            Return billingAddress1
        End Get
        Set(ByVal value As String)
            billingAddress1 = value
        End Set

    End Property

    Public Property pBillingAddress2 As String

        Get
            Return billingAddress2
        End Get
        Set(ByVal value As String)
            billingAddress2 = value
        End Set

    End Property

    Public Property pBillingCity As String

        Get
            Return billingCity
        End Get
        Set(ByVal value As String)
            billingCity = value
        End Set

    End Property

    Public Property pBillingPostcode As String

        Get
            Return billingPostcode
        End Get
        Set(ByVal value As String)
            billingPostcode = value
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

    Public Property pTotal As String

        Get
            Return invoiceTotal
        End Get
        Set(ByVal value As String)
            invoiceTotal = value
        End Set

    End Property

    Public Overrides Function ToString() As String

        Dim info As String = ""

        info += "The details for invoice No: " + invoiceNo + " Estimate No: " + estimateNo

        Return info

    End Function

End Class
