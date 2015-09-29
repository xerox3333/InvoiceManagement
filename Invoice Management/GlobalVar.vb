Public Class GlobalVar

    Public Shared INVOICE_FILE As String = ("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Data\InvoiceRecords.txt")
    Public Shared previewFileLocation As String = ("C:\temp")
    Public Shared previewFileName As String = ("preview.pdf")

    Public Shared OwnerName As String = ""
    Public Shared CompanyName As String = "Company Name"
    Public Shared CompanyAddress1 As String = "Company Address1"
    Public Shared CompanyAddress2 As String = "Comany Address2"
    Public Shared CompanyCity As String = "Town/City"
    Public Shared CompanyPostcode As String = "Postcode"
    Public Shared CompanyPhone As String = "Phone"
    Public Shared CompanyMobile As String = "Mobile"
    Public Shared CompanyEmail As String = "Email"
    Public Shared Website As String = "Website"
    Public Shared Description As String = "Description"

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
