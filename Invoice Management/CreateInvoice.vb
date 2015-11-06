Option Explicit On

Imports Invoice_Management.GlobalVar
Imports System.IO

Public Class CreateInvoice

    'VARIABLES
    Public num_invoices As Integer = 1
    Public num_rows As Integer
    Public inv As New Invoice()

    Private Sub CreateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.MaximumSize = New Size(Me.Width, Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

    End Sub

    Private Sub PreviewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PreviewToolStripButton.Click

        If Application.OpenForms().OfType(Of PreviewInvoice).Any Then

            PreviewInvoice.Close()

        End If

        ItemsGrid.EndEdit()
        If checkFormData() Then

            Dim invoicePreview As New Invoice
            Dim newPreview As PDF = New PDF

            getFormData(invoicePreview)
            newPreview.drawInvoiceHeader(oCompanyName, oCompanyAddress1, oCompanyAddress2, oCompanyCity, oCompanyPostcode, oCompanyPhone, oCompanyMobile, oCompanyEmail)
            newPreview.drawDetails(invoicePreview)
            'TODO: Draw the rest of the PDF
            newPreview.SavePDF(previewFileLocation, previewFileName)

            PreviewInvoice.Show(Main)

        End If

    End Sub


    Private Sub CloseToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripButton.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click

        Call SaveInvoice()

    End Sub

    Private Sub chkSameAsBill_CheckedChanged(sender As System.Object, e As System.EventArgs)

        If chkSameAsBill.Checked Then

            txtShipTo.Text = txtBillTo.Text

        Else
            txtShipTo.Clear()

        End If


    End Sub

    Private Sub getFormData(ByVal newInvoice As Invoice)

        newInvoice.pInvoiceNo = txtInvoiceNo.Text
        newInvoice.pPurchaseNo = txtPurchaseNo.Text
        newInvoice.pCustomerNo = cboCustomer.Text
        newInvoice.pInvoiceDate = cboDate.Text
        newInvoice.pPurchaseNo = txtPurchaseNo.Text
        newInvoice.pBillTo = txtBillTo.Text
        newInvoice.pTerms = cboTerms.Text
        newInvoice.pTermsLength = cboTermsLength.Value
        newInvoice.pAuthor = txtAuthor.Text
        newInvoice.pNotes = txtNotes.Text
        newInvoice.pComments = txtComments.Text
        newInvoice.pInvoiceTax = txtTax.Text
        newInvoice.pInvoiceSubtotal = txtSubtotal.Text
        newInvoice.pTotal = txtTotal.Text
        newInvoice.pNumItems = ItemsGrid.RowCount() - 1 'Get the number of items in the table so we know how many inv items to expect when read from file
        'MsgBox(ItemsGrid.RowCount())

        For row As Integer = 0 To ItemsGrid.RowCount() - 2

            Dim item As InvoiceItem = New InvoiceItem
            'MsgBox(ItemsGrid.Rows(row).Cells(0).Value)
            item.pItem = ItemsGrid.Rows(row).Cells(0).Value
            item.pQty = ItemsGrid.Rows(row).Cells(1).Value
            item.pUnit = ItemsGrid.Rows(row).Cells(2).Value
            item.pUnitPrice = ItemsGrid.Rows(row).Cells(3).Value
            item.pPrice = ItemsGrid.Rows(row).Cells(4).Value

            newInvoice.Additem(item) 'Append each item to the items list

        Next

        invoiceList.Add(newInvoice) 'Append the new invoice to the invoice list

    End Sub

    Private Sub SaveInvoice()

        Dim timeStamp As String
        Dim d As String = DatePart(DateInterval.Day, Date.Now)
        Dim m As String = DatePart(DateInterval.Month, Date.Now)
        Dim y As String = DatePart(DateInterval.Year, Date.Now)

        timeStamp = d & "-" & m & "-" & y

        ItemsGrid.EndEdit()

        'If checkFormData() = "" Then

        Dim newInvoice As New Invoice()

        Call getFormData(newInvoice) 'Add data to instance of Invoice
        newInvoice.writeInvoiceToFile(newInvoice, invoicePath, timeStamp & "_Invoice_" & newInvoice.pInvoiceNo)
        newInvoice.LogInvoiceToFile(newInvoice, logPath)

        num_invoices += 1

        'Else
        '    'Display error string
        '    MsgBox("Test")
        '    MsgBox(checkFormData, , "Form Validation Error ")
        'End If

    End Sub

    Public Function readInvoiceFromFile(ByVal FolderLocation As String, ByVal FileName As String, ByRef invoices As List(Of Invoice))

        Dim invoice As Invoice = New Invoice
        Dim invoiceItem As InvoiceItem = New InvoiceItem
        Dim FilePath As String

        FilePath = Path.Combine(FolderLocation, FileName)

        If System.IO.File.Exists(FilePath) Then

            Try
                Dim fs As FileStream = New FileStream(FilePath, FileMode.Open)
                Dim br As BinaryReader = New BinaryReader(fs)
                Dim line As String = ""
                Dim line2 As String = ""

                Main.ListBox1.ForeColor = Color.Green
                Main.ListBox1.Items.Add("Found invoice file " & FilePath)
                Main.ListBox1.ForeColor = Color.Black

                For Each _property In GetType(Invoice).GetProperties()

                    If _property.PropertyType.FullName = "System.Single" Then

                        line = br.ReadString()
                        line2 = br.ReadSingle()
                        Main.ListBox1.Items.Add(line & ": " & line2)

                        _property.SetValue(invoice, line2, Nothing)

                    ElseIf _property.PropertyType.FullName = "System.String" Then

                        line = br.ReadString()
                        line2 = br.ReadString()
                        Main.ListBox1.Items.Add(line & ": " & line2)

                        _property.SetValue(invoice, line2, Nothing)

                    ElseIf _property.PropertyType.FullName = "System.Integer" Then

                        If _property.Name = "pNumItems" Then

                            line = br.ReadString()
                            line2 = br.ReadInt32()
                            invoice.pNumItems = line2
                            Main.ListBox1.Items.Add(line & ": " & line2)

                        End If

                    End If

                Next

                For _i As Integer = 0 To invoice.pNumItems()

                    Main.ListBox1.Items.Add("__________________ ITEMS __________________")

                    For Each _property In GetType(InvoiceItem).GetProperties()

                        If _property.PropertyType.FullName = "System.Single" Then

                            line = br.ReadString()
                            line2 = br.ReadSingle()
                            Main.ListBox1.Items.Add(line & ": " & line2)

                            _property.SetValue(invoiceItem, CSng(line2), Nothing)

                        ElseIf _property.PropertyType.FullName = "System.String"

                            line = br.ReadString()
                            line2 = br.ReadString()
                            Main.ListBox1.Items.Add(line & ": " & line2)

                            _property.SetValue(invoiceItem, CStr(line2), Nothing)

                        End If

                    Next

                Next

                Main.ListBox1.Items.Add("")

                fs.Close()
                br.Close()

                Return invoice

            Catch ex As Exception
                MsgBox("An error occured reading the file from directory: " & FilePath & ". " & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "IO Error")
                Main.ListBox1.Items.Add("An error occured reading the file: " & FilePath)
            Finally

            End Try

        Else
            MsgBox("The invoice file at: " & FilePath & " Could not be found " & vbCrLf & "Make sure the file exists and is not corrupt ", MsgBoxStyle.Exclamation, "File not Found")
        End If

        Return Nothing

    End Function

    Private Function checkFormData() As Boolean

        Dim errorString As String = ""
        Dim control As Control

        For Each control In Me.Controls

            If TypeOf control Is TextBox Then

                Dim t As TextBox = CType(control, TextBox)
                If t.Text = "" Then
                    errorString = "Please complete the marked fields "
                End If


            ElseIf TypeOf control Is DateTimePicker Then

                Dim t As DateTimePicker = CType(control, DateTimePicker)
                If t.Value = Nothing Then

                End If


            ElseIf TypeOf control Is ComboBox Then

                Dim t As ComboBox = CType(control, ComboBox)
                If t.SelectedValue = "" Then
                    errorString = "Please complete the marked fields "
                End If

            End If

        Next

        If errorString = "" Then Return True Else Return False

    End Function

    Private Function getStringLength(ByVal cell As String)

        Dim temp() As String
        Dim length As Integer

        temp = Split(cell, "")
        length = temp.Length

        Return 0

    End Function

End Class