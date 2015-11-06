Imports Invoice_Management.GlobalVar
Imports System.IO

Public Class ViewInvoice

    Public Overrides Property MaximumSize As Size

    Private Sub ViewInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'InitializeComponent()
        Me.MaximumSize = New Size(Me.Width, Main.getDockHeight(Main.SplitContainer1.Panel2))

        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        ListInvoices()

    End Sub

    Private Sub ViewInvoice_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If Me.WindowState = FormWindowState.Maximized Then

            Call Main.DockWindow(Me)

        End If

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click

        'Find corisponding invoice
        Dim invoice As Invoice = New Invoice
        Dim selectedIndex As Integer = lstInvoices.FocusedItem.Index
        invoice = invoiceList(selectedIndex)

        previewSelectedItem(invoice)

    End Sub

    Private Sub ReloadToolStripButton_Click(sender As Object, e As EventArgs) Handles ReloadToolStripButton.Click

        ListInvoices()

    End Sub

    Private Sub CloseToolStripButton_Click(sender As Object, e As EventArgs) Handles CloseToolStripButton.Click

        Close()
        Dispose()

    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click

        If lstInvoices.FocusedItem Is Nothing Then

            MsgBox("Please select an item to preview ", MsgBoxStyle.Information, "No invoice selected")

        Else

            Dim saveLocation As String
            Dim saveName As String
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog

            saveFileDialog.CreatePrompt = False
            saveFileDialog.OverwritePrompt = True
            saveFileDialog.DefaultExt = "pdf"
            saveFileDialog.AddExtension = True
            saveFileDialog.Filter = "PDF File|*.pdf"
            saveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

            Dim result As DialogResult = saveFileDialog.ShowDialog()

            If result = DialogResult.OK Then

                saveLocation = System.IO.Path.GetDirectoryName(saveFileDialog.FileName)
                saveName = saveFileDialog.FileName
                Main.ListBox1.Items.Add("Got new save path as: " & saveLocation)
                CopyToLocation(previewFileLocation, previewFileName, saveLocation, saveName)

            End If

        End If

    End Sub

    Private Sub ListInvoices()

        Dim tempInvoices As List(Of Invoice) = invoiceList

        lstInvoices.Items.Clear()

        For i As Integer = 0 To tempInvoices.Count() - 1

            lstInvoices.Items.Add(tempInvoices(i).pInvoiceNo)
            lstInvoices.Items(i).SubItems.Add(tempInvoices(i).pPurchaseNo)
            lstInvoices.Items(i).SubItems.Add(tempInvoices(i).pCustomerNo)
            lstInvoices.Items(i).SubItems.Add(tempInvoices(i).pInvoiceDate)
            lstInvoices.Items(i).SubItems.Add(tempInvoices(i).pTotal)
            lstInvoices.Items(i).SubItems.Add(tempInvoices(i).pComments)

        Next

    End Sub

    Private Sub previewSelectedItem(ByVal invoice As Invoice)

        If Not lstInvoices.FocusedItem Is Nothing Then

            Dim SelectedIndex As Integer = lstInvoices.FocusedItem.Index
            Dim selectedInvoice As Invoice = invoiceList(SelectedIndex)
            Dim newPreview As PDF = New PDF

            newPreview.drawInvoiceHeader(oCompanyName, oCompanyAddress1, oCompanyAddress2, oCompanyCity, oCompanyPostcode, oCompanyPhone, oCompanyMobile, oCompanyEmail)
            newPreview.drawDetails(getSelectedItemData(selectedInvoice))
            newPreview.drawTableHeader(invoice.pNumItems(), invoice.getItems())
            'draw rest of PDF
            newPreview.SavePDF(previewFileLocation, previewFileName)

            PreviewInvoice.Show(Main)

        Else
            MsgBox("Please select an item to preview ", MsgBoxStyle.Information, "No invoice selected ")
        End If

    End Sub

    Private Function getSelectedItemData(ByVal invoice As Invoice)

        Dim newInvoice As Invoice = New Invoice

        newInvoice.pInvoiceNo = invoice.pInvoiceNo
        newInvoice.pPurchaseNo = invoice.pPurchaseNo
        newInvoice.pCustomerNo = invoice.pCustomerNo
        newInvoice.pInvoiceDate = invoice.pInvoiceDate
        newInvoice.pPurchaseNo = invoice.pPurchaseNo
        newInvoice.pBillTo = invoice.pBillTo
        newInvoice.pTerms = invoice.pTerms
        newInvoice.pTermsLength = invoice.pTermsLength
        newInvoice.pAuthor = invoice.pAuthor
        newInvoice.pNotes = invoice.pNotes
        newInvoice.pComments = invoice.pComments
        newInvoice.pInvoiceTax = invoice.pInvoiceTax
        newInvoice.pInvoiceSubtotal = invoice.pInvoiceSubtotal
        newInvoice.pTotal = invoice.pTotal

        Return newInvoice

    End Function

    Private Sub CopyToLocation(ByVal Location As String, ByVal fileName As String, ByVal NewLocation As String, ByVal newFileName As String)

        Dim fullPath As String = Path.Combine(Location, fileName)
        Dim fullSavePath As String = Path.Combine(NewLocation, newFileName)

        If Not My.Computer.FileSystem.FileExists(fullPath) Then

            MsgBox("No file could be found at the location: " & fullPath & "Please preview a file before Saving As", MsgBoxStyle.Exclamation, "Could not copy file")

        ElseIf Not My.Computer.FileSystem.GetFileInfo(fullPath).Extension = (".pdf") Then

            MsgBox("The specified file to copy is not a valid invoice, Please preview the file first", MsgBoxStyle.Exclamation, "Invalid File")

        Else

            Try
                'If My.Computer.FileSystem.DirectoryExists(fullSavePath) Then

                My.Computer.FileSystem.CopyFile(fullPath, fullSavePath)
                Main.ListBox1.Items.Add("File copied from:" & fullPath & " to: " & fullSavePath)

                'Else
                'MsgBox("The location you specified could not be accessed, Please select a diferent location", MsgBoxStyle.Exclamation, "Could not save file")

                'End If

            Catch ex As Exception
                MsgBox("An error occured copying the preview file to a new location: " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error - Could not copy file")
            Finally

            End Try

        End If

    End Sub

End Class