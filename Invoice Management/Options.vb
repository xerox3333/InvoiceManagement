Imports Invoice_Management.GlobalVar
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

            oOwnerName = txtOwnerName.Text
            oCompanyName = txtCompanyName.Text
            oCompanyAddress1 = txtStreetAddress.Text
            oCompanyAddress2 = txtStreetAddress2.Text
            oCompanyCity = txtCity.Text
            oCompanyPostcode = txtPostcode.Text
            oCompanyPhone = txtPhone.Text
            oCompanyMobile = txtMobile.Text
            oCompanyEmail = txtEmail.Text
            oWebsite = txtWebsite.Text
            oDescription = txtDescription.Text

        End If

    End Sub

    Private Sub WriteDetailsToFile()

        Dim FileLocation = "C:\Users\" & getUserName() & "\Documents\InvoiceManager\Preferences\Preferences.txt"

        If System.IO.File.Exists(FileLocation) = False Then

            MkDir("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Preferences")
            File.Create(FileLocation & "\" & "Preferences.txt").Dispose()

        End If

        Dim SW As New System.IO.StreamWriter(FileLocation, False)

        SW.WriteLine(oOwnerName)
        SW.WriteLine(oCompanyName)
        SW.WriteLine(oCompanyAddress1)
        SW.WriteLine(oCompanyAddress2)
        SW.WriteLine(oCompanyCity)
        SW.WriteLine(oCompanyPostcode)
        SW.WriteLine(oCompanyPhone)
        SW.WriteLine(oCompanyMobile)
        SW.WriteLine(oCompanyEmail)
        SW.WriteLine(oWebsite)
        SW.WriteLine(oDescription)

        SW.Close()

        MsgBox("Company Details have been updated ", MsgBoxStyle.Information, "Company Details")

    End Sub

End Class