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

    Public Sub initInvoices()

        For Each file As String In My.Computer.FileSystem.GetFiles(invoicePath)

            invoiceList.Add(readInvoiceFromFile(invoicePath, file.ToString, invoiceList))

        Next

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
            'Draw the rest of the PDF
            newPreview.SavePDF(previewFileLocation, previewFileName)

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

        Call getFormData(newInvoice) 'Add data to instance of Invoice
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

        Try

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

                    If _property.PropertyType.FullName = "System.Single" Then

                        bw.Write(_property.Name)
                        bw.Write(CSng(_property.GetValue(invoice, Nothing)))

                    ElseIf _property.PropertyType.FullName = "System.String" Then

                        bw.Write(_property.Name)
                        bw.Write(_property.GetValue(invoice, Nothing))

                    End If

                Next

                fs.Close()
                bw.Close()

                MsgBox("Invoice " & invoice.pInvoiceNo & " Successfully Saved! ", MsgBoxStyle.Information, "Saved")

            End If

        Catch ex As Exception
            MsgBox("Somthing went wrong while trying to save the invoice to file." & vbCrLf & "You can try to amend this error in:" & Location & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Somthing went wrong ")

        Finally

        End Try

    End Sub

    Private Function readLastInvoiceFromFile(ByVal FolderLocation As String)

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

    Public Function readInvoiceFromFile(ByVal FolderLocation As String, ByVal FileName As String, ByRef invoices As List(Of Invoice))

        Dim invoice As Invoice = New Invoice
        Dim FilePath As String

        FilePath = Path.Combine(FolderLocation, FileName)

        If System.IO.File.Exists(FilePath) Then

            'Try
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

                ElseIf _property.PropertyType.FullName = "System.String" Then

                    line = br.ReadString()
                    line2 = br.ReadString()
                    Main.ListBox1.Items.Add(line & ": " & line2)

                End If

                _property.SetValue(invoice, line2, Nothing)
                'Main.ListBox1.Items.Add(line & ": " & line2)

            Next

            Main.ListBox1.Items.Add("")

                fs.Close()
                br.Close()

                Return invoice

                'Catch ex As Exception
                '    MsgBox("An error occured reading the file from directory: " & FilePath & ". " & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "IO Error")
                'Finally
                '    Main.ListBox1.ForeColor = Color.Red
                '    Main.ListBox1.Items.Add("An error occured reading the file: " & FilePath)
                '    Main.ListBox1.ForeColor = Color.Black
                'End Try

                Else
            MsgBox("The invoice file at: " & FilePath & " Could not be found " & vbCrLf & "Make sure the file exists and is not corrupt ", MsgBoxStyle.Exclamation, "File not Found")
        End If

        Return Nothing

    End Function

    'Protected Overrides Sub OnPaint(e As PaintEventArgs)

    '    Dim g As Graphics = e.Graphics
    '    Dim penRed As New Pen(Color.Red, 2.0)

    '    For Each control In Me.Controls

    '        If TypeOf control Is TextBox Then

    '            Dim t As TextBox = CType(control, TextBox)
    '            g.DrawRectangle(penRed, New Rectangle(t.Location, t.Size))

    '        End If

    '    Next

    '    penRed.Dispose()

    'End Sub

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

    Private Sub chkSameAsBill_CheckedChanged(sender As System.Object, e As System.EventArgs)

        If chkSameAsBill.Checked Then

            txtShipTo.Text = txtBillTo.Text

        Else
            txtShipTo.Clear()

        End If


    End Sub

End Class