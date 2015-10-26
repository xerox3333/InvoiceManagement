Public Class GlobalVar

    Public Shared invoiceList As New List(Of Invoice)

    Public Shared invoicePath As String = ("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Data")
    Public Shared logPath As String = ("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Log")
    Public Shared previewFileLocation As String = ("C:\Users\" & getUserName() & "\Desktop")
    Public Shared previewFileName As String = ("preview.pdf")
    Public Shared no_options = 11

    Public Shared oOwnerName As String = ""
    Public Shared oCompanyName As String = "Company Name"
    Public Shared oCompanyAddress1 As String = "Company Address1"
    Public Shared oCompanyAddress2 As String = "Comany Address2"
    Public Shared oCompanyCity As String = "Town/City"
    Public Shared oCompanyPostcode As String = "Postcode"
    Public Shared oCompanyPhone As String = "Phone"
    Public Shared oCompanyMobile As String = "Mobile"
    Public Shared oCompanyEmail As String = "Email"
    Public Shared oWebsite As String = "Website"
    Public Shared oDescription As String = "Description"

    Public Shared Function getUserName() As String

        If TypeOf My.User.CurrentPrincipal Is System.Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If

    End Function

End Class
