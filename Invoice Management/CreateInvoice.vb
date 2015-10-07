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
    Private invoiceList As New List(Of Invoice)
    Public num_invoices As Integer = 1
    Public num_rows As Integer
    Public inv As New Invoice()

    Private Sub CreateInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

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

    Private Sub getFormData(ByVal newInvoice As Invoice, ByVal item As InvoiceItem)

        newInvoice.pInvoiceNo = txtInvoiceNo.Text
        newInvoice.pEstimateNo = txtEstimateNo.Text
        newInvoice.pPurchaseNo = txtPurchaseNo.Text
        newInvoice.pCustomerNo = txtCutomerID.Text
        newInvoice.pInvoiceDate = txtDate.Text
        newInvoice.pEstimateDate = ""
        newInvoice.pPurchaseNo = txtPurchaseNo.Text
        newInvoice.pBillingName = txtBillToName.Text
        newInvoice.pBillingAddress1 = txtBillToAddress.Text
        newInvoice.pBillingAddress2 = ""
        newInvoice.pBillingCity = txtBillToCity.Text
        newInvoice.pBillingPostcode = txtBillToPostcode.Text
        newInvoice.pTerms = cboTerms.Text
        newInvoice.pTermsLength = cboTermsLength.Value
        newInvoice.pTotal = "0"

        invoiceList.Add(newInvoice) 'Append the new invoice to the invoice list

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

        Dim timeStamp As String
        Dim d As String = DatePart(DateInterval.Day, Date.Now)
        Dim m As String = DatePart(DateInterval.Month, Date.Now)
        Dim y As String = DatePart(DateInterval.Year, Date.Now)

        timeStamp = d & "-" & m & "-" & y

        ItemsGrid.EndEdit()

        'If checkFormData() = "" Then

        Dim newInvoice As New Invoice()
        Dim newInvoiceItem As New InvoiceItem
        Call getFormData(newInvoice, newInvoiceItem) 'Add data to instance of Invoice
        Call writeInvoiceToFile(newInvoice, invoicePath, timeStamp & "_Invoice_" & newInvoice.pInvoiceNo)
        Call LogInvoiceToFile(newInvoice, logPath)

        num_invoices += 1

        'Else
        '    'Display error string
        '    MsgBox("Test")
        '    MsgBox(checkFormData, , "Form Validation Error ")
        'End If

    End Sub

    Public Sub LogInvoiceToFile(ByVal invoice As Invoice, ByVal FileLocation As String)

        If Not System.IO.File.Exists(FileLocation & "\" & invoice.pInvoiceNo & ".txt") Then

            'MkDir(FileLocation)
            File.Create(FileLocation & "\" & invoice.pInvoiceNo & ".txt").Dispose()
        Else


        End If

        Try

            Dim SW As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(FileLocation, True)

            For Each _property In GetType(Invoice).GetProperties

                SW.Write(_property.Name.ToString() & ": ")
                SW.WriteLine(_property.GetValue(invoice, Nothing))

            Next

            'SW.WriteLine("<--------------- INVOICE ITEMS --------------->")

            'For i As Integer = 0 To items.Count - 1

            '    SW.WriteLine("*********** Item " & i.ToString & " ***********")

            '    For Each _property In GetType(InvoiceItem).GetProperties

            '        SW.Write(_property.Name.ToString & ": ")
            '        SW.WriteLine(_property.GetValue(items(i), Nothing))

            '    Next

            'Next

            SW.WriteLine("######################### END OF INVOICE " & invoice.pInvoiceNo & " #########################")


            SW.Close()
            Main.ListBox1.Items.Add("Invoice " & invoice.pInvoiceNo & " Sucessfully Logged to File " & vbCrLf & FileLocation)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Writing to File")

        Finally
            'Clean up files


        End Try

    End Sub

    Public Sub writeInvoiceToFile(ByVal invoice As Invoice, ByVal Location As String, ByRef FileName As String)

        Dim FileLocation As String = Location & "\" & FileName & ".bin"
        Dim SaveDialog As SaveFileDialog = New SaveFileDialog

        'Check that the data folder is created in users documents directory
        If Not Directory.Exists(Location) Then

            MkDir(Location)

        End If

        'Try

        SaveDialog.CreatePrompt = False
            SaveDialog.OverwritePrompt = True
            SaveDialog.FileName = FileName
            SaveDialog.DefaultExt = "bin"
            SaveDialog.AddExtension = True
            SaveDialog.Filter = "Invoice file|*.bin"
            SaveDialog.InitialDirectory = Location

            Dim result As DialogResult = SaveDialog.ShowDialog()

            If result = DialogResult.OK Then

                Dim fs As FileStream = New FileStream(FileLocation, FileMode.OpenOrCreate)
                Dim bw As New BinaryWriter(fs)

            'Loop through all the properties in Invoice Class and output to Binary File
            For Each _property In GetType(Invoice).GetProperties()

                bw.Write(_property.Name)
                bw.Write(_property.GetValue(invoice, Nothing))

            Next

            fs.Close()
                bw.Close()

                MsgBox("Invoice " & invoice.pInvoiceNo & " Successfully Saved! ", MsgBoxStyle.Information, "Saved")

            End If

        'Catch ex As Exception
        'MsgBox("Somthing went wrong while trying to save the invoice to file." & vbCrLf & "You can try to amend this error in:" & Location & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Somthing went wrong ")

        'Finally

        'End Try

    End Sub

    Public Function readLastInvoiceFromFile(ByVal FolderLocation As String)

        Main.ListBox1.Items.Clear()
        Dim invoice As Invoice = New Invoice
        Dim files = My.Computer.FileSystem.GetFiles(FolderLocation, FileIO.SearchOption.SearchTopLevelOnly, "*.bin")

        For Each file As String In files

            Dim fs As FileStream = New FileStream(file, FileMode.Open)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim line As String = ""
            Dim line2 As String = ""

            Main.ListBox1.Items.Add("Found invoice file " & file.ToString)

            For Each _property In GetType(Invoice).GetProperties()

                line = br.ReadString()
                line2 = br.ReadString()
                _property.SetValue(invoice, line2, Nothing)
                Main.ListBox1.Items.Add(line & ": " & line2)

            Next

            fs.Close()
            br.Close()

            Main.ListBox1.Items.Add("")

        Next

        Return invoice

    End Function

    Private Function readInvoiceFromFile(ByVal FolderLocation As String, ByVal FileName As String)

        Dim invoice As Invoice = New Invoice
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

                    line = br.ReadString()
                    line2 = br.ReadString()
                    _property.SetValue(invoice, line2, Nothing)
                    Main.ListBox1.Items.Add(line & ": " & line2)

                Next

                Main.ListBox1.Items.Add("")

                fs.Close()
                br.Close()

                Return invoice

            Catch ex As Exception
                MsgBox("An error occured reading the file from directory: " & FilePath & ". " & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "IO Error")
            Finally
                Main.ListBox1.ForeColor = Color.Red
                Main.ListBox1.Items.Add("An error occured reading the file: " & FilePath)
                Main.ListBox1.ForeColor = Color.Black
            End Try

        Else
            MsgBox("The invoice file at: " & FilePath & " Could not be found " & vbCrLf & "Make sure the file exists and is not corrupt ", MsgBoxStyle.Exclamation, "File not Found")
        End If

        Return Nothing

    End Function

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