Option Explicit On

Imports Invoice_Management.GlobalVar
Imports Invoice_Management.Invoice
Imports Invoice_Management.InvoiceItem
Imports System.IO
Imports System.IO.FileStream
Imports System.IO.StreamWriter
Imports System.IO.StreamReader
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class CreateInvoice

    'VARIABLES
    Public num_rows As Integer = 0
    Public num_invoices As Integer = 1
    'Dim invoice As New Invoice
    Public invoiceList As New List(Of Invoice)
    Public invoiceItems As New List(Of InvoiceItem)

    Private Sub CreateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        'Call invoice.readInvoiceFromFile(invoiceList, "C:\Users\Craig\Desktop\test.bin")
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

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click

        Call SaveInvoice()

    End Sub

    Private Sub getFormData(ByVal invoice As Invoice, ByVal item As InvoiceItem)

        invoice.pInvoiceNo = txtInvoiceNo.Text
        invoice.pEstimateNo = txtEstimateNo.Text
        invoice.pPurchaseNo = txtPurchaseNo.Text
        invoice.pCustomerNo = txtCutomerID.Text
        invoice.pInvoiceDate = txtDate.Text
        invoice.pEstimateDate = ""
        invoice.pPurchaseNo = txtPurchaseNo.Text
        invoice.pBillingName = txtBillToName.Text
        invoice.pBillingAddress1 = txtBillToAddress.Text
        invoice.pBillingAddress2 = ""
        invoice.pBillingCity = txtBillToCity.Text
        invoice.pBillingPostcode = txtBillToPostcode.Text
        invoice.pTerms = cboTerms.Text
        invoice.pTermsLength = cboTermsLength.Value

        invoiceList.Add(invoice) 'Append the new invoice to the invoice list

        'For row As Integer = 0 To ItemsGrid.Rows.Count - 1

        '    item.pItem = ItemsGrid.Rows(0).Cells(0).Value
        '    item.pQty = ItemsGrid.Rows(0).Cells(1).Value
        '    item.pUnit = ItemsGrid.Rows(0).Cells(2).Value
        '    item.pUnitPrice = ItemsGrid.Rows(0).Cells(3).Value
        '    item.pPrice = ItemsGrid.Rows(0).Cells(4).Value

        '    invoice.pAddInvoiceItem = item 'Append each item to the items list

        'Next

    End Sub

    Private Sub SaveInvoice()

        ItemsGrid.EndEdit()

        'If checkFormData() = "" Then

        Dim newInvoice As New Invoice
        Dim newInvoiceItem As New InvoiceItem
        Call getFormData(newInvoice, newInvoiceItem) 'Add data to instance of Invoice
        Call newInvoice.writeInvoiceToFile("C:\Users\Craig\Desktop")

        num_invoices += 1

        MsgBox("Invoice Successfully Saved! ", MsgBoxStyle.Information, "Saved")

        'Else
        '    'Display error string
        '    MsgBox("Test")
        '    MsgBox(checkFormData, , "Form Validation Error ")
        'End If

    End Sub

    Public Sub LogInvoiceToFile(ByVal invoice As Invoice, ByVal items As List(Of InvoiceItem), ByVal FileLocation As String)

        If Not System.IO.File.Exists(FileLocation) Then

            'MkDir(FileLocation)
            File.Create(FileLocation).Dispose()

        End If

        Try

            Dim SW As New System.IO.StreamWriter(FileLocation, True)

            For Each _property In GetType(Invoice).GetProperties

                SW.Write(_property.Name.ToString & ": ")
                SW.WriteLine(_property.GetValue(invoice, Nothing))

            Next

            SW.WriteLine("<--------------- INVOICE ITEMS --------------->")

            For i As Integer = 0 To items.Count - 1

                SW.WriteLine("*********** Item " & i.ToString & " ***********")

                For Each _property In GetType(InvoiceItem).GetProperties

                    SW.Write(_property.Name.ToString & ": ")
                    SW.WriteLine(_property.GetValue(items(i), Nothing))

                Next

            Next

            SW.WriteLine("######################### END OF INVOICE " & invoice.pInvoiceNo & " #########################")


            SW.Close()
            MsgBox("Invoice " & invoice.pInvoiceNo & " Sucessfully Logged to File " & vbCrLf & FileLocation, MsgBoxStyle.Information, "Invoice Logged ")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Writing to File")

        Finally
            'Clean up files


        End Try

    End Sub

    Private Function checkFormData() As String

        Dim errorString As String = ""
        Dim control As Control

        For Each control In Me.Controls

            If control.GetType() Is GetType(TextBox) Then

                Dim t As TextBox = CType(control, TextBox)
                If t.Text = "" Then
                    t.BackColor = Color.Red()
                    errorString += ""
                End If

            End If
            If control.GetType() Is GetType(DateTimePicker) Then

                Dim t As DateTimePicker = CType(control, DateTimePicker)
                If t.Value = Nothing Then

                End If

            End If

        Next

        Return errorString

    End Function

    'Private Function CheckFormData() As String

    '    Dim errorString As String = ""

    '    With txtCutomerID

    '        If IsNumeric(.Text) And .TextLength <= 8 Then

    '            .BackColor = Color.White

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The customer number must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.Red
    '            errorString += "The customer number must be less than 9 characters and be a number" & vbCrLf

    '        End If

    '    End With

    '    With txtInvoiceNo

    '        If IsNumeric(.Text) And .TextLength <= 8 Then

    '            .BackColor = Color.White

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The invoice number must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.Red
    '            errorString += "The invoice number must be less than 9 characters and be a number" & vbCrLf

    '        End If

    '    End With

    '    With txtPurchaseNo

    '        If IsNumeric(.Text) And .TextLength <= 8 Then
    '            .BackColor = Color.White

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The purchase number must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.Red
    '            errorString += "The purchase number must be less than 9 characters and be a number" & vbCrLf

    '        End If

    '    End With

    '    With cboTerms

    '        If (.Text) = Nothing Then

    '            .BackColor = Color.Red
    '            errorString += "The terms of payment type must be selected" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With cboTermsLength

    '        If .Value < 1 Or .Value > 100 Then

    '            .BackColor = Color.Red
    '            errorString += "The Terms Length must be between 1 and 100" & vbCrLf

    '        ElseIf .Value = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Terms Length must not be nothing" & vbCrLf

    '        Else

    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtBillToName

    '        If (.Text) = Nothing Then

    '            .BackColor = Color.Red
    '            errorString += "The Bill To Name must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtBillToAddress

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Street address must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Bill To Street Address must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White


    '        End If

    '    End With

    '    With txtBillToCity

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Bill To City must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Bill To City must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtBillToPostcode

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Postcode must be 8 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Bill To Postcode must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtShipToName

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Ship To Name must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Ship To Name must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtShipToAddress

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Ship To Street address must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Ship To Street Address must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtShipToCity

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Ship To City must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Ship To City must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    With txtShipToPostcode

    '        If (.TextLength > 50) Then

    '            .BackColor = Color.Red
    '            errorString += "The Ship To Postcode must be 50 characters or less" & vbCrLf

    '        ElseIf .Text = Nothing Then
    '            .BackColor = Color.Red
    '            errorString += "The Ship to Postcode must not be nothing" & vbCrLf

    '        Else
    '            .BackColor = Color.White

    '        End If

    '    End With

    '    'Validate datagrid view
    '    For row As Integer = 0 To num_rows - 1
    '        For col As Integer = 0 To 4
    '            If ItemsGrid.Item(col, row).Value = Nothing Then
    '                'check for empty cells 
    '            End If
    '        Next

    '        If getStringLength(ItemsGrid.Item(0, row).Value) > 50 Then

    '            errorString += "Item " & row & " must be 50 characters or less" & vbCrLf

    '        ElseIf getStringLength(ItemsGrid.Item(1, row).Value) > 10 Then

    '            errorString += "Item " & row & "qty must be 10 characters or less" & vbCrLf

    '        End If

    '    Next

    '    Return errorString

    'End Function

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