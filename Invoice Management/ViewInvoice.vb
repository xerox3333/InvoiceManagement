Imports Invoice_Management.GlobalVar

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

    Private Sub previewSelectedItem()

        If Not lstInvoices.FocusedItem Is Nothing Then

            Dim SelectedIndex As Integer = lstInvoices.FocusedItem.Index
            Dim selectedInvoice As Invoice = invoiceList(SelectedIndex)
            Dim newPreview As PDF = New PDF

            newPreview.drawInvoiceHeader(oCompanyName, oCompanyAddress1, oCompanyAddress2, oCompanyCity, oCompanyPostcode, oCompanyPhone, oCompanyMobile, oCompanyEmail)
            newPreview.drawDetails(getSelectedItemData(selectedInvoice))
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

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click

        previewSelectedItem()

    End Sub

    Private Sub ReloadToolStripButton_Click(sender As Object, e As EventArgs) Handles ReloadToolStripButton.Click

        ListInvoices()

    End Sub

    Private Sub CloseToolStripButton_Click(sender As Object, e As EventArgs) Handles CloseToolStripButton.Click

        Me.Close()
        Me.Dispose()

    End Sub

End Class