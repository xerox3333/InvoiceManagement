Option Explicit On

Public Class Main

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        SplitContainer1.Panel1MinSize = 192

        'test()

    End Sub

    Sub test()

        Dim i As New Invoice()
        Dim pdf1 As New PDF()
        Dim invitem As New InvoiceItem()
        Dim invItem2 As New InvoiceItem()

        i.pInvoiceNo = "00291"
        i.pEstimateNo = "000"
        i.pCustomerNo = "000"
        i.pPurchaseNo = "000"
        i.pInvoiceDate = "12/01/15"
        i.pEstimateDate = "10/ 01/15"
        i.pBillingName = "Craig Forbes"
        i.pBillingAddress1 = "27 Strathburn Gardens"
        i.pBillingAddress2 = ""
        i.pBillingCity = "Inverurie"
        i.pBillingPostcode = "AB51 4RY"
        i.pTerms = "30 Days"
        i.pTermsLength = 30
        i.pTotal = 120.0

        Dim invoiceList As New List(Of Invoice)
        Dim itemsList As New List(Of InvoiceItem)

        invitem.pItem = "Things"
        invitem.pQty = "1"
        invitem.pUnit = "EA"
        invitem.pUnitPrice = "12.00"
        invitem.pPrice = "12.00"

        invItem2.pItem = "Stuff"
        invItem2.pQty = "5"
        invItem2.pUnit = "EA"
        invItem2.pUnitPrice = "1.00"
        invItem2.pPrice = "5.00"


        itemsList.Add(invitem)
        itemsList.Add(invItem2)
        invoiceList.Add(i)

        MsgBox(i.ToString)


        pdf1.drawInvoiceHeader("Bobs Company", "27 Strathburn Gardens", "Inverurie", "Aberdeenshire", "AB51 0NF", "01467671554", "07841377715", "bob@company.com")
        pdf1.SavePDF("C:\Users\Craig\Desktop", "PDF1_Test.pdf")

        i.WriteInvoiceToFile("C:\Users\Craig\Desktop\test.bin")

        i.readInvoiceFromFile(invoiceList, "C:\Users\Craig\Desktop\test.bin")

        CreateInvoice.LogInvoiceToFile(i, itemsList, "C:\Users\Craig\Desktop\testLog.txt")


    End Sub

    Private Sub Main_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If CreateInvoice.IsHandleCreated = True Then
            Call DockWindow(CreateInvoice)

        End If

        If ViewInvoice.IsHandleCreated = True Then
            Call DockWindow(ViewInvoice)

        End If

    End Sub

    Public Function getDockWidth(ByVal panel As System.Windows.Forms.SplitterPanel)

        Dim Width As Integer
        Width = panel.Width

        Return Width

    End Function

    Public Function getDockHeight(ByVal panel As System.Windows.Forms.SplitterPanel)

        Dim Height As Integer
        Height = panel.Height - 30

        Return Height

    End Function

    Public Sub DockWindow(ByVal Form As System.Windows.Forms.Form)

        Dim Height As Integer = My.Computer.Screen.Bounds.Height
        Dim Width As Integer = My.Computer.Screen.Bounds.Width

        Form.WindowState = FormWindowState.Normal
        Form.BringToFront()
        Form.Left = 1
        Form.Top = 1

        If Width >= 1280 And Height >= 900 Then
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 45)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        ElseIf (Width <= 1366 And Width > 1280) And (Height >= 768 And Height < 900) Then
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 40)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        Else
            Form.Width = getDockWidth(SplitContainer1.Panel2)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        End If

    End Sub

    Public Sub WindowMaximize(ByVal sender As System.Object, e As System.EventArgs) Handles Me.AutoSizeChanged

        Call DockWindow(CreateInvoice)

    End Sub

    Private Sub cmdCreateInvoice_Click(sender As System.Object, e As System.EventArgs) Handles cmdCreateInvoice.Click

        CreateInvoice.Show()
        CreateInvoice.Focus()
        CreateInvoice.BringToFront()

    End Sub

    Private Sub cmdViewInvoice_Click(sender As System.Object, e As System.EventArgs) Handles cmdViewInvoice.Click

        ViewInvoice.Show()
        ViewInvoice.Focus()
        ViewInvoice.BringToFront()

    End Sub

    Private Sub cmdOptions_Click(sender As System.Object, e As System.EventArgs) Handles cmdOptions.Click

        Options.Show()
        Options.Focus()
        Options.BringToFront()

    End Sub

End Class
