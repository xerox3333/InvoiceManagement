Imports System.IO

Public Class Options

    Dim a As New GlobalVar

    Private Sub Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        'Main.SplitContainer1.Panel2.Controls.Add(Me)

        Dim width As Integer = My.Computer.Screen.WorkingArea.Width
        Dim height As Integer = My.Computer.Screen.WorkingArea.Height

        Me.Left = (width / 2) - (Me.Width / 2)
        Me.Top = (height / 2) - (Me.Height / 2)

        Me.TopMost = True

    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click

        Call SaveCompanyDetails()
        Call WriteDetailsToFile()

    End Sub

    Private Function ValidateFormData() As Boolean

        Dim errorString As String = ""

        With txtOwnerName

            If IsNumeric(.Text) Then

                errorString += "Owner Name must not be a number " & vbCrLf
                .BackColor = Color.Red

            ElseIf .Text.Length > 50 Then

                errorString += "The owner name cannot be longer than 50 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtCompanyName

            If .Text.Length > 50 Then

                errorString += "The company name cannot be longer than 50 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtStreetAddress

            If .Text.Length > 25 Then

                errorString += "The company Address cannot be longer than 25 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtStreetAddress2

            If .Text.Length > 25 Then

                errorString += "The company Address cannot be longer than 25 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtCity

            If .Text.Length > 20 Then

                errorString += "The company city cannot be longer than 25 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtPostcode

            If .Text.Length > 8 Then

                errorString += "The company Address cannot be longer than 8 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtPhone

            If .Text.Length > 12 Then

                errorString += "The company phone number cannot be longer than 12 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtMobile

            If .Text.Length > 12 Then


                errorString += "The company mobile number cannot be longer than 12 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtEmail

            If .Text.Length > 25 Then

                errorString += "The company Email Address cannot be longer than 25 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtWebsite

            If .Text.Length > 25 Then

                errorString += "The company website cannot be longer than 25 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        With txtDescription

            If .Text.Length > 100 Then

                errorString += "The company Description cannot be longer than 100 characters " & vbCrLf
                .BackColor = Color.Red

            Else
                .BackColor = Color.White

            End If

        End With

        If errorString = "" Then

            Return True

        Else

            Return False

        End If

    End Function

    Private Sub SaveCompanyDetails()

        If ValidateFormData() Then

            a.OwnerName = txtOwnerName.Text
            a.CompanyName = txtCompanyName.Text
            a.CompanyAddress1 = txtStreetAddress.Text
            a.CompanyAddress2 = txtStreetAddress2.Text
            a.CompanyCity = txtCity.Text
            a.CompanyPostcode = txtPostcode.Text
            a.CompanyPhone = txtPhone.Text
            a.CompanyMobile = txtMobile.Text
            a.CompanyEmail = txtEmail.Text
            a.Website = txtWebsite.Text
            a.Description = txtDescription.Text

        End If

    End Sub

    Private Sub WriteDetailsToFile()

        Dim FileLocation = "C:\Users\" & a.getUserName() & "\Documents\InvoiceManager\Preferences\Preferences.txt"

        If System.IO.File.Exists(FileLocation) = False Then

            MkDir("C:\Users\" & a.getUserName() & "\Documents\InvoiceManager\Preferences")
            File.Create(FileLocation & "\" & "Preferences.txt").Dispose()

        End If

        Dim SW As New System.IO.StreamWriter(FileLocation, False)

        SW.WriteLine(a.OwnerName)
        SW.WriteLine(a.CompanyName)
        SW.WriteLine(a.CompanyAddress1)
        SW.WriteLine(a.CompanyAddress2)
        SW.WriteLine(a.CompanyCity)
        SW.WriteLine(a.CompanyPostcode)
        SW.WriteLine(a.CompanyPhone)
        SW.WriteLine(a.CompanyMobile)
        SW.WriteLine(a.CompanyEmail)
        SW.WriteLine(a.Website)
        SW.WriteLine(a.Description)

        SW.Close()

        MsgBox("Company Details have been updated ", MsgBoxStyle.Information, "Company Details")

    End Sub

End Class