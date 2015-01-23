Class GlobalVar

    Public INVOICE_FILE As String = ("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Data\InvoiceRecords.txt")
    Public previewFileLocation As String = ("C:\temp")
    Public previewFileName As String = ("preview.pdf")

    Public OwnerName As String = ""
    Public CompanyName As String = "Company Name"
    Public CompanyAddress1 As String = "Company Address1"
    Public CompanyAddress2 As String = "Comany Address2"
    Public CompanyCity As String = "Town/City"
    Public CompanyPostcode As String = "Postcode"
    Public CompanyPhone As String = "Phone"
    Public CompanyMobile As String = "Mobile"
    Public CompanyEmail As String = "Email"
    Public Website As String = "Website"

    Function getUserName() As String

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
