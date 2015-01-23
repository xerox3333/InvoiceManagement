Option Explicit On

Imports Invoice_Management.GlobalVar
Imports System.IO
Imports System.IO.StreamWriter
Imports System.IO.StreamReader
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class CreateInvoice

    Dim a As New GlobalVar

    'VARIABLES
    Dim num_rows As Integer = 0
    Dim num_invoices As Integer = 1
    Dim invoiceRecords(num_invoices) As Invoice
    Dim invoiceItems(num_invoices, num_rows) As InvoiceItem

    Private Structure Invoice

        Dim invoiceID As String, customerID As String
        Dim estimateID As String, purchaseID As String
        Dim invoiceDate As String, billToName As String
        Dim billToAddress As String, billToCity As String
        Dim billToPostcode As String, shipToName As String
        Dim shipToAddress, shipToCity As String
        Dim shipToPostcode As String
        Dim total As String
        Dim termsType As String
        Dim termsLength As Integer
        Dim createdBy As String
        Dim comments As String

    End Structure

    Private Structure InvoiceItem

        Dim item As String
        Dim qty As Single
        Dim unit As String
        Dim unitPrice As Single

        Dim price As Single

    End Structure

    ' START EVENT PROCEDURES ---------------------------------------------------------------------------------------------------------------

    Private Sub CreateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        Call ReadInvoiceFromFile(invoiceRecords, invoiceItems, a.INVOICE_FILE)

    End Sub

    Private Sub CreateInvoice_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If Me.WindowState = FormWindowState.Maximized Then

            Call Main.DockWindow(Me)

        End If

    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripButton.Click

        Call SaveInvoice(invoiceRecords, invoiceItems)

    End Sub

    Private Sub PreviewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PreviewToolStripButton.Click

        Dim num_rows As Integer = ItemsGrid.RowCount - 1

        If CheckFormData() = True Then

            'Call AddToInvoiceStruct(CheckFormData, invoiceRecords)
            'Call AddToInvoiceItemsStruct(CheckFormData, invoiceItems, num_rows)

            Call SaveInvoice(invoiceRecords, invoiceItems)

            Call CreatePDF(a.previewFileLocation, a.previewFileName, num_rows, invoiceRecords, invoiceItems, a.CompanyName, a.CompanyAddress1, a.CompanyAddress2, a.CompanyCity, a.CompanyPostcode, a.CompanyPhone, a.CompanyMobile, a.CompanyEmail)

            PreviewInvoice.Show(Main)

        End If

    End Sub

    Private Sub CloseToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripButton.Click

        '<clear form data>
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub PrintToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripButton.Click

    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click

    End Sub

    Private Sub HelpToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripButton.Click

    End Sub

    ' END EVENT PROCEDURES -----------------------------------------------------------------------------------------------------------------

    Private Sub SaveInvoice(ByVal invoices() As Invoice, ByVal items(,) As InvoiceItem)

        Dim tempArray(num_invoices, num_rows)

        If CheckFormData() = True Then

            ReDim Preserve invoices(num_invoices) 'Re-create the array with new space for another record

            'The 2D items array cannot be resized without clearing the data it contains so copy it to a temp 2D array

            Array.Copy(items, tempArray, items.Length - 1)

            num_invoices += 1
            num_rows = ItemsGrid.RowCount - 1

            ReDim items(num_invoices, num_rows)

            'Copy tempArray data back to ItemsArray
            For counter As Integer = 0 To num_invoices - 1

                For currentItem As Integer = 0 To num_rows - 1

                    items(counter, currentItem) = tempArray(counter, currentItem)

                Next

            Next


            'Save to data structure from form controls
            Call AddToInvoiceStruct(CheckFormData, invoiceRecords)
            Call AddToInvoiceItemsStruct(CheckFormData, invoiceItems, num_rows)

            Call WriteInvoiceToFile(a.INVOICE_FILE)

            'Clear contents of controls
            For Each Control In Me.Controls



            Next

        End If

    End Sub

    Private Sub WriteInvoiceToFile(ByVal FileLocation As String)

        If System.IO.File.Exists(FileLocation) = False Then

            MkDir("C:\Users\" & a.getUserName() & "\Documents\InvoiceManager\Data")
            File.Create("C:\Users\" & a.getUserName() & "\Documents\InvoiceManager\Data\InvoiceRecords.txt").Dispose()

        End If

        'Try

        Dim SW As New System.IO.StreamWriter(FileLocation, False)

        For counter As Integer = 0 To num_invoices - 1

            SW.Write("Invoice No:")
            SW.WriteLine(invoiceRecords(counter).invoiceID)

            SW.Write("Customer No:")
            SW.WriteLine(invoiceRecords(counter).customerID)

            SW.Write("Estimate No:")
            SW.WriteLine(invoiceRecords(counter).estimateID)

            SW.Write("Purchase No:")
            SW.WriteLine(invoiceRecords(counter).purchaseID)

            SW.Write("Invoice Date:")
            SW.WriteLine(invoiceRecords(counter).invoiceDate)

            SW.Write("Name:")
            SW.WriteLine(invoiceRecords(counter).billToName)

            SW.Write("Street Address:")
            SW.WriteLine(invoiceRecords(counter).billToAddress)

            SW.Write("City/Town:")
            SW.WriteLine(invoiceRecords(counter).billToCity)

            SW.Write("Postcode:")
            SW.WriteLine(invoiceRecords(counter).billToPostcode)

            SW.Write("Name:")
            SW.WriteLine(invoiceRecords(counter).shipToName)

            SW.Write("Street Address:")
            SW.WriteLine(invoiceRecords(counter).shipToAddress)

            SW.Write("City/Town:")
            SW.WriteLine(invoiceRecords(counter).shipToCity)

            SW.Write("Postcode:")
            SW.WriteLine(invoiceRecords(counter).shipToPostcode)

            SW.Write("Total:")
            SW.WriteLine(invoiceRecords(counter).total)

            SW.Write("Terms Type:")
            SW.WriteLine(invoiceRecords(counter).termsType)

            SW.Write("Terms Length:")
            SW.WriteLine(invoiceRecords(counter).termsLength)

            SW.Write("Created By:")
            SW.WriteLine(invoiceRecords(counter).createdBy)

            SW.Write("Comments:")
            SW.WriteLine(invoiceRecords(counter).comments)

            SW.WriteLine("##################### INVOICE ITEMS #####################")

            For currentItem As Integer = 0 To num_rows - 1

                'Write Invoice Items
                SW.WriteLine("<----Item No " & currentItem & " ---->")

                SW.Write("Item: ")
                SW.WriteLine(invoiceItems(counter, currentItem).item)

                SW.Write("Quantity: ")
                SW.WriteLine(invoiceItems(counter, currentItem).qty)

                SW.Write("Unit: ")
                SW.WriteLine(invoiceItems(counter, currentItem).unit)

                SW.Write("Unit Price: ")
                SW.WriteLine(invoiceItems(counter, currentItem).unitPrice)

                SW.Write("Price: ")
                SW.WriteLine(invoiceItems(counter, currentItem).price)

            Next

            SW.WriteLine("<--------------------------------END OF INVOICE " & invoiceRecords(counter).invoiceID & "-------------------------------->")

        Next

        SW.Close()
        MsgBox("Invoice " & invoiceRecords(num_invoices - 1).invoiceID & " Sucessfully Saved ", MsgBoxStyle.Information, "Invoice Saved ")

        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Writing to File")

        'Finally


        'End Try

    End Sub

    Private Sub ReadInvoiceFromFile(ByVal ReadInvoice() As Invoice, ByVal ReadInvoiceItems(,) As InvoiceItem, ByVal FileLocation As String)

        If System.IO.File.Exists(FileLocation) = False Then

            'Propmt for file location

        End If

        Try

            Dim Line As String
            Dim tempString(1) As String
            Dim SR As New System.IO.StreamReader(FileLocation)

            For counter As Integer = 0 To num_invoices - 1

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).invoiceID = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).customerID = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).estimateID = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).purchaseID = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).invoiceDate = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).billToName = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).billToAddress = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).billToCity = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).billToPostcode = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).shipToName = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).shipToAddress = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).shipToCity = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).shipToPostcode = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).total = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).termsType = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).termsLength = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).createdBy = tempString(1)

                Line = SR.ReadLine
                tempString = Split(Line, ":")
                ReadInvoice(counter).comments = tempString(1)

                SR.ReadLine()

                For currentItem As Integer = 0 To num_rows - 1

                    SR.ReadLine()
                    Line = SR.ReadLine
                    tempString = Split(Line, ":")
                    ReadInvoiceItems(counter, currentItem).item = tempString(1)

                    SR.ReadLine()
                    Line = SR.ReadLine
                    tempString = Split(Line, "")
                    ReadInvoiceItems(counter, currentItem).qty = tempString(1)

                    SR.ReadLine()
                    Line = SR.ReadLine
                    tempString = Split(Line, "")
                    ReadInvoiceItems(counter, currentItem).unit = tempString(1)

                    SR.ReadLine()
                    Line = SR.ReadLine
                    tempString = Split(Line, "")
                    ReadInvoiceItems(counter, currentItem).unitPrice = tempString(1)

                    SR.ReadLine()
                    Line = SR.ReadLine
                    tempString = Split(Line, "")
                    ReadInvoiceItems(counter, currentItem).price = tempString(1)

                Next

                SR.ReadLine()

            Next

            SR.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Reading From File")

        Finally

        End Try

    End Sub

    Private Sub AddToInvoiceStruct(ByVal Valid As Boolean, ByVal invoices As Invoice())

        If Valid = True Then

            'Add form values to array
            invoices(num_invoices - 1).customerID = txtCutomerID.Text
            invoices(num_invoices - 1).invoiceID = txtInvoiceNo.Text
            invoices(num_invoices - 1).purchaseID = txtPurchaseNo.Text
            invoices(num_invoices - 1).termsType = txtTerms.SelectedValue
            invoices(num_invoices - 1).termsLength = cboTermsLength.Value
            invoices(num_invoices - 1).invoiceDate = txtDate.Text
            invoices(num_invoices - 1).billToName = txtBillToName.Text
            invoices(num_invoices - 1).billToAddress = txtBillToAddress.Text
            invoices(num_invoices - 1).billToCity = txtBillToCity.Text
            invoices(num_invoices - 1).billToPostcode = txtBillToPostcode.Text
            invoices(num_invoices - 1).shipToName = txtShipToName.Text
            invoices(num_invoices - 1).shipToAddress = txtShipToAddress.Text
            invoices(num_invoices - 1).shipToCity = txtShipToCity.Text
            invoices(num_invoices - 1).shipToPostcode = txtShipToPostcode.Text

        End If

    End Sub

    Private Sub AddToInvoiceItemsStruct(ByVal Valid As Boolean, ByVal items As InvoiceItem(,), ByVal num_rows As Integer)

        If Valid = True Then

            For counter As Integer = 0 To num_rows - 1

                items(num_invoices - 1, counter).item = ItemsGrid.Item(0, counter).Value
                items(num_invoices - 1, counter).qty = ItemsGrid.Item(1, counter).Value
                items(num_invoices - 1, counter).unit = ItemsGrid.Item(2, counter).Value
                items(num_invoices - 1, counter).unitPrice = ItemsGrid.Item(3, counter).Value
                items(num_invoices - 1, counter).price = ItemsGrid.Item(4, counter).Value

            Next

        End If

    End Sub

    Private Function CheckFormData() As Boolean

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

        With txtTerms

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

                .Text = Nothing
                .BackColor = Color.Red
                errorString += "The Bill To Name must not be nothing" & vbCrLf

            Else
                .ForeColor = Color.White

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

        If errorString = "" Then

            Return True

        Else
            MsgBox(errorString, MsgBoxStyle.Exclamation, "Form validation error")

            errorString = ""
            Return False

        End If

    End Function

    Private Function getStringLength(ByVal cell As String)

        Dim temp() As String
        Dim length As Integer

        temp = Split(cell, "")
        length = temp.Length

        Return 0

    End Function

    Private Sub CreatePDF(ByVal saveLocation As String, ByVal saveName As String, ByVal num_rows As Integer, ByVal invoices As Invoice(), ByVal invoiceItems As InvoiceItem(,), ByVal companyName As String, ByVal companyAddress1 As String, ByVal companyAddress2 As String, ByVal companyCity As String, ByVal companyPostcode As String, ByVal companyPhone As String, ByVal companyMobile As String, ByVal companyEmail As String)

        Dim pdf As PdfDocument = New PdfDocument
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim g As XGraphics = XGraphics.FromPdfPage(pdfPage)
        Dim headerFont As XFont = New XFont("Calibri", 24, XFontStyle.Regular)
        Dim headerFont2 As XFont = New XFont("Calibri", 26, XFontStyle.Bold)
        Dim detailFont As XFont = New XFont("Calibri", 10, XFontStyle.Regular)
        Dim tableHeaderFont As XFont = New XFont("Calibri", 12, XFontStyle.Bold)
        Dim pen As XPen = New XPen(XColors.Black, 1)
        Dim pen2 As XPen = New XPen(XColors.Black, 2)

        'Invoice Header
        g.DrawRectangle(XBrushes.LightGray, New XRect(20, 20, (pdfPage.Width.Point - 40), 100)) 'Header background
        g.DrawRectangle(XBrushes.DarkGray, New XRect(20, 120, (pdfPage.Width.Point - 40), 15)) 'Header bottom
        g.DrawString("INVOICE", headerFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 110), 20, 100, 150), XStringFormats.TopLeft) 'INVOICE text

        g.DrawString(companyName, headerFont2, XBrushes.SteelBlue, New XRect(30, 50, 250, 0)) 'Company Name

        g.DrawString(companyAddress1, detailFont, XBrushes.WhiteSmoke, New XRect(30, 65, 100, 0)) 'Company address
        g.DrawString(companyAddress2, detailFont, XBrushes.WhiteSmoke, New XRect(30, 75, 100, 0))
        g.DrawString(companyCity, detailFont, XBrushes.WhiteSmoke, New XRect(30, 85, 100, 0))
        g.DrawString(companyPostcode, detailFont, XBrushes.WhiteSmoke, New XRect(30, 95, 100, 0))

        g.DrawString("Phone: " & companyPhone & "   " & "Mobile: " & companyMobile, detailFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 210), 65, 100, 0)) 'Contact details
        g.DrawString("Email: " & companyEmail, detailFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 210), 75, 100, 0))

        g.DrawRectangle(XBrushes.LightGray, New XRect(35, 155, 100, 80)) 'Customer Details background
        g.DrawString("Customer Info", detailFont, XBrushes.WhiteSmoke, New XRect(40, 165, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).billToName, detailFont, XBrushes.Black, New XRect(140, 170, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).billToAddress, detailFont, XBrushes.Black, New XRect(140, 190, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).billToCity, detailFont, XBrushes.Black, New XRect(140, 210, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).billToPostcode, detailFont, XBrushes.Black, New XRect(140, 230, 100, 0))

        g.DrawRectangle(XBrushes.LightGray, New XRect(275, 155, 100, 80)) 'Invoice Details background
        g.DrawString("Invoice Info ", detailFont, XBrushes.WhiteSmoke, New XRect(280, 165, 100, 0))
        g.DrawString("Date: ", detailFont, XBrushes.Black, New XRect(380, 170, 100, 0))
        g.DrawString("Invoice No: ", detailFont, XBrushes.Black, New XRect(380, 190, 100, 0))
        g.DrawString("Purchase No: ", detailFont, XBrushes.Black, New XRect(380, 210, 100, 0))

        g.DrawString(invoices(invoices.Length - 1).invoiceDate, detailFont, XBrushes.Black, New XRect(450, 170, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).invoiceID, detailFont, XBrushes.Black, New XRect(450, 190, 100, 0))
        g.DrawString(invoices(invoices.Length - 1).purchaseID, detailFont, XBrushes.Black, New XRect(450, 210, 100, 0))

        'Table Header
        g.DrawString("Item", tableHeaderFont, XBrushes.CadetBlue, New XRect(25, 255, 50, 0))
        g.DrawString("Qty", tableHeaderFont, XBrushes.CadetBlue, New XRect(215, 255, 50, 0))
        g.DrawString("Unit", tableHeaderFont, XBrushes.CadetBlue, New XRect(315, 255, 50, 0))
        g.DrawString("Unit Price", tableHeaderFont, XBrushes.CadetBlue, New XRect(415, 255, 50, 0))
        g.DrawString("Price", tableHeaderFont, XBrushes.CadetBlue, New XRect(515, 255, 50, 0))
        g.DrawLine(pen2, 20, 260, (pdfPage.Width.Point - 20), 260) 'Item Table Top

        Dim yPos As Integer = 260

        g.DrawLine(pen, 200, yPos, 200, ((num_rows * 20) + yPos))
        g.DrawLine(pen, 300, yPos, 300, ((num_rows * 20) + yPos))
        g.DrawLine(pen, 400, yPos, 400, ((num_rows * 20) + yPos))
        g.DrawLine(pen, 500, yPos, 500, ((num_rows * 20) + yPos))

        'Todo implement overflow page for table
        If num_rows > 20 Then

            num_rows = 20

        End If

        'For every item draw new row
        For counter As Integer = 0 To num_rows

            yPos += 20
            g.DrawLine(pen, 20, yPos, (pdfPage.Width.Point - 20), yPos)

        Next

        'Set y position to begin drawing Invoice Items into table
        yPos = 265

        'Draw item names on table
        For counter As Integer = 0 To num_rows - 2

            g.DrawString(invoiceItems(num_invoices - 1, counter).item, detailFont, XBrushes.Black, New XRect(20, (yPos + 10), 100, 0))
            g.DrawString(invoiceItems(num_invoices - 1, counter).qty, detailFont, XBrushes.Black, New XRect(210, (yPos + 10), 100, 0))
            g.DrawString(invoiceItems(num_invoices - 1, counter).unit, detailFont, XBrushes.Black, New XRect(310, (yPos + 10), 100, 0))
            g.DrawString(Format(invoiceItems(num_invoices - 1, counter).unitPrice, "Currency"), detailFont, XBrushes.Black, New XRect(410, (yPos + 10), 100, 0))
            g.DrawString(Format(invoiceItems(num_invoices - 1, counter).price, "Currency"), detailFont, XBrushes.Black, New XRect(510, (yPos + 10), 100, 0))
            yPos += 20

        Next

        pdf.Save(saveLocation & "\" & saveName)

    End Sub

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