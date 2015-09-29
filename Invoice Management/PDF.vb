Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
'Imports AcroPDFLib

Public Class PDF

    Private pdf As PdfDocument = New PdfDocument
    Private pdfPage As PdfPage = pdf.AddPage
    Private g As XGraphics = XGraphics.FromPdfPage(pdfPage)

    'Fonts
    Private headerFont As XFont = New XFont("Calibri", 24, XFontStyle.Regular)
    Private headerFont2 As XFont = New XFont("Calibri", 26, XFontStyle.Bold)
    Private detailFont As XFont = New XFont("Calibri", 10, XFontStyle.Regular)
    Private tableHeaderFont As XFont = New XFont("Calibri", 12, XFontStyle.Bold)
    Private pen As XPen = New XPen(XColors.Black, 1)
    Private pen2 As XPen = New XPen(XColors.Black, 2)

    Public Property pHeaderFont As XFont

        Get
            Return headerFont
        End Get
        Set(value As XFont)
            headerFont = value
        End Set

    End Property

    Public Sub drawInvoiceHeader(ByVal companyName As String, ByVal CompanyAddress1 As String, ByVal companyAddress2 As String, companyCity As String, ByVal companyPostcode As String, ByVal companyphone As String, ByVal companymobile As String, ByVal companyEmail As String)

        'Invoice Header
        g.DrawRectangle(XBrushes.LightGray, New XRect(20, 20, (pdfPage.Width.Point - 40), 100)) 'Header background       (X, Y, WIDTH, HEIGHT)
        g.DrawRectangle(XBrushes.DarkGray, New XRect(20, 120, (pdfPage.Width.Point - 40), 15)) 'Header bottom
        g.DrawString("INVOICE", headerFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 110), 20, 100, 150), XStringFormats.TopLeft) 'INVOICE text

        g.DrawString(companyName, headerFont2, XBrushes.SteelBlue, New XRect(30, 50, 250, 0)) 'Company Name

        g.DrawString(CompanyAddress1, detailFont, XBrushes.WhiteSmoke, New XRect(30, 65, 100, 0)) 'Company address
        g.DrawString(companyAddress2, detailFont, XBrushes.WhiteSmoke, New XRect(30, 75, 100, 0))
        g.DrawString(companyCity, detailFont, XBrushes.WhiteSmoke, New XRect(30, 85, 100, 0))
        g.DrawString(companyPostcode, detailFont, XBrushes.WhiteSmoke, New XRect(30, 95, 100, 0))

        g.DrawString("Phone: " & companyphone & "   " & "Mobile: " & companymobile, detailFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 210), 65, 100, 0)) 'Contact details
        g.DrawString("Email: " & companyEmail, detailFont, XBrushes.WhiteSmoke, New XRect((pdfPage.Width.Point - 210), 75, 100, 0))

    End Sub

    Public Sub drawDetails(ByVal invoice As Invoice)

        g.DrawRectangle(XBrushes.LightGray, New XRect(35, 155, 100, 80)) 'Customer Details background
        g.DrawString("Customer Info", detailFont, XBrushes.WhiteSmoke, New XRect(40, 165, 100, 0))
        g.DrawString(invoice.pBillingName, detailFont, XBrushes.Black, New XRect(140, 170, 100, 0))
        g.DrawString(invoice.pBillingAddress1, detailFont, XBrushes.Black, New XRect(140, 190, 100, 0))
        g.DrawString(invoice.pBillingCity, detailFont, XBrushes.Black, New XRect(140, 210, 100, 0))
        g.DrawString(invoice.pBillingPostcode, detailFont, XBrushes.Black, New XRect(140, 230, 100, 0))

        g.DrawRectangle(XBrushes.LightGray, New XRect(275, 155, 100, 80)) 'Invoice Details background
        g.DrawString("Invoice Info ", detailFont, XBrushes.WhiteSmoke, New XRect(280, 165, 100, 0))
        g.DrawString("Date: ", detailFont, XBrushes.Black, New XRect(380, 170, 100, 0))
        g.DrawString("Invoice No: ", detailFont, XBrushes.Black, New XRect(380, 190, 100, 0))
        g.DrawString("Purchase No: ", detailFont, XBrushes.Black, New XRect(380, 210, 100, 0))

        g.DrawString(invoice.pInvoiceDate, detailFont, XBrushes.Black, New XRect(450, 170, 100, 0))
        g.DrawString(invoice.pInvoiceNo, detailFont, XBrushes.Black, New XRect(450, 190, 100, 0))
        g.DrawString(invoice.pPurchaseNo, detailFont, XBrushes.Black, New XRect(450, 210, 100, 0))

    End Sub

    Public Sub drawTableHeader(ByVal num_rows As Integer, ByVal items() As InvoiceItem)

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
        For i As Integer = 0 To num_rows

            yPos += 20
            g.DrawLine(pen, 20, yPos, (pdfPage.Width.Point - 20), yPos)

        Next

        'Set y position to begin drawing Invoice Items into table
        yPos = 265

        'Draw item names on table
        For i As Integer = 0 To num_rows - 1

            g.DrawString(items(i).pItem, detailFont, XBrushes.Black, New XRect(20, (yPos + 10), 100, 0))
            g.DrawString(items(i).pQty, detailFont, XBrushes.Black, New XRect(210, (yPos + 10), 100, 0))
            g.DrawString(items(i).pUnit, detailFont, XBrushes.Black, New XRect(310, (yPos + 10), 100, 0))
            g.DrawString(Format(items(i).pUnitPrice, "Currency"), detailFont, XBrushes.Black, New XRect(410, (yPos + 10), 100, 0))
            g.DrawString(Format(items(i).pPrice, "Currency"), detailFont, XBrushes.Black, New XRect(510, (yPos + 10), 100, 0))
            yPos += 20

        Next

    End Sub

    Public Sub SavePDF(ByVal location As String, ByVal fileName As String)

        pdf.Save(location & "\" & fileName)

    End Sub

End Class
