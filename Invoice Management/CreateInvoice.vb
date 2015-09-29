Option Explicit On

Imports Invoice_Management.GlobalVar
Imports System.IO
Imports System.IO.StreamWriter
Imports System.IO.StreamReader
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class CreateInvoice

    'VARIABLES
    Public num_rows As Integer = 0
    Public num_invoices As Integer = 1
    Public invoiceList As New List(Of Invoice)

    Private Sub CreateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        Call ReadInvoiceFromFile(invoiceList, INVOICE_FILE)
        'Initialise variables

    End Sub

    Private Sub CreateInvoice_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If Me.WindowState = FormWindowState.Maximized Then

            Call Main.DockWindow(Me)

        End If

    End Sub

    Private Sub PreviewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PreviewToolStripButton.Click

        If Application.OpenForms().OfType(Of PreviewInvoice).Any Then

            PreviewInvoice.Close()

        End If

        num_rows = ItemsGrid.RowCount - 1

        Dim tempInvoice(1) As Invoice
        Dim tempInvoiceItems(1, num_rows) As InvoiceItem

        ItemsGrid.EndEdit()

        If CheckFormData() = True Then

            'Dim pdf As New PDF(a.previewFileLocation, a.previewFileName, 1, num_rows, tempInvoice, tempInvoiceItems, a.CompanyName, a.CompanyAddress1, a.CompanyAddress2, a.CompanyCity, a.CompanyPostcode, a.CompanyPhone, a.CompanyMobile, a.CompanyEmail)

            PreviewInvoice.Show(Main)

        End If

    End Sub

    Private Sub CloseToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripButton.Click

        '<clear form data>
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub SaveInvoice(ByRef invoices() As Invoice, ByRef items(,) As InvoiceItem)

        ItemsGrid.EndEdit()

        If CheckFormData() = "" Then

            Dim invoice As New Invoice()
            Dim pdf As New PDF()

            num_invoices += 1

            Call getFormData(invoice)

            invoiceList.Add(invoice)

        Else
            'Display error string

        End If

    End Sub

    Public Sub writeInvoiceToFile(ByVal Location As String)

        Dim fs As FileStream = New FileStream(Location, FileMode.Append)
        Dim bw As New BinaryWriter(fs)

        'Loop through all the properties in Invoice Class and output to Binary File
        For Each _property In GetType(Invoice).GetProperties()

            bw.Write(_property.Name)

        Next


    End Sub

    Private Sub getFormData(ByVal invoice As Invoice)

        invoice.pInvoiceNo = txtInvoiceNo.Text
        invoice.pEstimateNo = txtEstimateNo.Text
        invoice.pPurchaseNo = txtPurchaseNo.Text

    End Sub

    Private Sub WriteInvoiceToFile(ByVal invoice As Invoice, ByVal item() As InvoiceItem, ByVal FileLocation As String)

        If System.IO.File.Exists(FileLocation) = False Then

            MkDir("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Data")
            File.Create("C:\Users\" & getUserName() & "\Documents\InvoiceManager\Data\Invoices.txt").Dispose()

        End If

        'Try

        Dim SW As New System.IO.StreamWriter(FileLocation, True)

        SW.Write("Invoice No:")
        SW.WriteLine(invoice.pInvoiceNo)

        SW.Write("Customer No:")
        SW.WriteLine(invoice.pCustomerNo)

        SW.Write("Estimate No:")
        SW.WriteLine(invoice.pEstimateNo)

        SW.Write("Purchase No:")
        SW.WriteLine(invoice.pPurchaseNo)

        SW.Write("Invoice Date:")
        SW.WriteLine(invoice.pInvoiceDate)

        SW.Write("Name:")
        SW.WriteLine(invoice.pBillingName)

        SW.Write("Street Address:")
        SW.WriteLine(invoice.pBillingAddress1)

        SW.Write("City/Town:")
        SW.WriteLine(invoice.pBillingCity)

        SW.Write("Postcode:")
        SW.WriteLine(invoice.pBillingPostcode)

        SW.Write("Total:")
        SW.WriteLine(invoice.pTotal)

        SW.Write("Terms Type:")
        SW.WriteLine(invoice.pTerms)

        SW.Write("Terms Length:")
        SW.WriteLine(invoice.pTermsLength)

        SW.WriteLine("##################### INVOICE ITEMS #####################")

        SW.WriteLine("<--------------------------------END OF INVOICE " & invoice.pInvoiceNo & "-------------------------------->")


        SW.Close()
        MsgBox("Invoice " & invoice.pInvoiceNo & " Sucessfully Saved ", MsgBoxStyle.Information, "Invoice Saved ")

        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Writing to File")

        'Finally


        'End Try

    End Sub

    Private Sub ReadInvoiceFromFile(ByVal InvoiceList As List(Of Invoice), ByVal FileLocation As String)

        If System.IO.File.Exists(FileLocation) = False Then

            'Propmt for file location

        End If

        'Try

        Dim Line As String
        Dim tempString(1) As String
        Dim SR As New System.IO.StreamReader(FileLocation)

        'For i As Integer = 0 To num_invoices - 1

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).invoiceID = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).customerID = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).estimateID = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).purchaseID = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).invoiceDate = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).billToName = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).billToAddress = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).billToCity = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).billToPostcode = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).shipToName = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).shipToAddress = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).shipToCity = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).shipToPostcode = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).total = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).termsType = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).termsLength = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).createdBy = tempString(1)

        'Line = SR.ReadLine
        'tempString = Split(Line, ":")
        'Invoices(i).comments = tempString(1)

        '    SR.ReadLine()

        '    Dim currentItem As Integer = 0

        '    For currentItem = 0 To num_items - 1

        '        SR.ReadLine()
        '        Line = SR.ReadLine
        '        tempString = Split(Line, ":")
        '        items(i, currentItem).item = tempString(1)

        '        SR.ReadLine()
        '        Line = SR.ReadLine
        '        tempString = Split(Line, "")
        '        Items(i, currentItem).qty = tempString(1)

        '        SR.ReadLine()
        '        Line = SR.ReadLine
        '        tempString = Split(Line, "")
        '        Items(i, currentItem).unit = tempString(1)

        '        SR.ReadLine()
        '        Line = SR.ReadLine
        '        tempString = Split(Line, "")
        '        Items(i, currentItem).unitPrice = tempString(1)

        '        SR.ReadLine()
        '        Line = SR.ReadLine
        '        tempString = Split(Line, "")
        '        Items(i, currentItem).Price = tempString(1)

        '    Next

        '    SR.ReadLine()

        'Next

        'SR.Close()

        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Reading From File")

        'Finally

        'End Try

    End Sub

    Private Function CheckFormData() As String

        Dim errorString As String = ""

        With txtCutomerID

            If IsNumeric(.Text) And .TextLength <= 8 Then

                .BackColor = Color.White

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The customer number must not be nothing" & vbCrLf

            Else
                .BackColor = Color.Red
                errorString += "The customer number must be less than 9 characters and be a number" & vbCrLf

            End If

        End With

        With txtInvoiceNo

            If IsNumeric(.Text) And .TextLength <= 8 Then

                .BackColor = Color.White

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The invoice number must not be nothing" & vbCrLf

            Else
                .BackColor = Color.Red
                errorString += "The invoice number must be less than 9 characters and be a number" & vbCrLf

            End If

        End With

        With txtPurchaseNo

            If IsNumeric(.Text) And .TextLength <= 8 Then
                .BackColor = Color.White

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The purchase number must not be nothing" & vbCrLf

            Else
                .BackColor = Color.Red
                errorString += "The purchase number must be less than 9 characters and be a number" & vbCrLf

            End If

        End With

        With cboTerms

            If (.Text) = Nothing Then

                .BackColor = Color.Red
                errorString += "The terms of payment type must be selected" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With cboTermsLength

            If .Value < 1 Or .Value > 100 Then

                .BackColor = Color.Red
                errorString += "The Terms Length must be between 1 and 100" & vbCrLf

            ElseIf .Value = Nothing Then
                .BackColor = Color.Red
                errorString += "The Terms Length must not be nothing" & vbCrLf

            Else

                .BackColor = Color.White

            End If

        End With

        With txtBillToName

            If (.Text) = Nothing Then

                .BackColor = Color.Red
                errorString += "The Bill To Name must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtBillToAddress

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Street address must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Bill To Street Address must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White


            End If

        End With

        With txtBillToCity

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Bill To City must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Bill To City must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtBillToPostcode

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Postcode must be 8 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Bill To Postcode must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtShipToName

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Ship To Name must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Ship To Name must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtShipToAddress

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Ship To Street address must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Ship To Street Address must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtShipToCity

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Ship To City must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Ship To City must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        With txtShipToPostcode

            If (.TextLength > 50) Then

                .BackColor = Color.Red
                errorString += "The Ship To Postcode must be 50 characters or less" & vbCrLf

            ElseIf .Text = Nothing Then
                .BackColor = Color.Red
                errorString += "The Ship to Postcode must not be nothing" & vbCrLf

            Else
                .BackColor = Color.White

            End If

        End With

        'Validate datagrid view
        For row As Integer = 0 To num_rows - 1
            For col As Integer = 0 To 4
                If ItemsGrid.Item(col, row).Value = Nothing Then
                    'check for empty cells 
                End If
            Next

            If getStringLength(ItemsGrid.Item(0, row).Value) > 50 Then

                errorString += "Item " & row & " must be 50 characters or less" & vbCrLf

            ElseIf getStringLength(ItemsGrid.Item(1, row).Value) > 10 Then

                errorString += "Item " & row & "qty must be 10 characters or less" & vbCrLf

            End If

        Next

        Return errorString

    End Function

    Private Function getStringLength(ByVal cell As String)

        Dim temp() As String
        Dim length As Integer

        temp = Split(cell, "")
        length = temp.Length

        Return 0

    End Function

    Private Sub chkSameAsBill_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSameAsBill.CheckedChanged

        If chkSameAsBill.Checked = True Then

            txtShipToName.Text = txtBillToName.Text
            txtShipToAddress.Text = txtBillToAddress.Text
            txtShipToCity.Text = txtBillToCity.Text
            txtShipToPostcode.Text = txtBillToPostcode.Text

        Else
            txtShipToName.Clear()
            txtShipToAddress.Clear()
            txtShipToCity.Clear()
            txtShipToPostcode.Clear()

        End If


    End Sub

End Class