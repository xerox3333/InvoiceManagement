Imports System.IO

Public Class Invoice

    Private invoiceItems As New List(Of InvoiceItem)

    Private invoiceNo, invoiceDate As String
    Private purchaseNo As String
    Private customerNo As String
    Private billTo As String
    Private invoiceTotal, invoiceTax, invoiceSubtotal As String
    Private terms As String
    Private termsLength As String
    Private Author As String
    Private Notes As String
    Private Comments As String
    Private num_items As Integer

    'Constructor
    Public Sub New()


    End Sub

    Public Property pInvoiceNo As String

        Get
            Return invoiceNo
        End Get

        Set(ByVal value As String)
            invoiceNo = value
        End Set

    End Property

    Public Property pPurchaseNo As String

        Get
            Return purchaseNo
        End Get
        Set(ByVal value As String)
            purchaseNo = value
        End Set

    End Property

    Public Property pCustomerNo As String

        Get
            Return customerNo
        End Get
        Set(ByVal value As String)
            customerNo = value
        End Set

    End Property

    Public Property pInvoiceDate As String

        Get
            Return invoiceDate
        End Get
        Set(ByVal value As String)
            invoiceDate = value
        End Set

    End Property

    Public Property pBillTo As String

        Get
            Return billTo
        End Get
        Set(ByVal value As String)
            billTo = value
        End Set

    End Property

    Public Property pTerms As String

        Get
            Return terms
        End Get
        Set(ByVal value As String)
            terms = value
        End Set

    End Property

    Public Property pTermsLength As String

        Get
            Return termsLength
        End Get
        Set(ByVal value As String)
            termsLength = value
        End Set

    End Property

    Public Property pAuthor As String

        Get
            Return Author
        End Get
        Set(value As String)
            Author = value
        End Set

    End Property

    Public Property pNotes As String

        Get
            Return Notes
        End Get
        Set(value As String)
            Notes = value
        End Set

    End Property

    Public Property pComments As String

        Get
            Return Comments
        End Get
        Set(value As String)
            Comments = value
        End Set

    End Property

    Public Property pTotal As String

        Get
            Return invoiceTotal
        End Get
        Set(ByVal value As String)
            invoiceTotal = value
        End Set

    End Property

    Public Property pInvoiceTax As String

        Get
            Return invoiceTax
        End Get
        Set(ByVal value As String)
            invoiceTax = value
        End Set

    End Property

    Public Property pInvoiceSubtotal As String

        Get
            Return invoiceSubtotal
        End Get
        Set(ByVal value As String)
            invoiceSubtotal = value
        End Set

    End Property

    Public Property pNumItems As Integer

        Get
            Return num_items
        End Get
        Set(ByVal value As Integer)
            num_items = value
        End Set

    End Property

    Public Sub Additem(ByVal newItem As InvoiceItem)

        invoiceItems.Add(newItem)

    End Sub

    Public Function getItems()

        Return invoiceItems

    End Function

    Public Sub LogInvoiceToFile(ByVal invoice As Invoice, ByVal FileLocation As String)

        Dim FileName As String = "_" & invoice.pInvoiceNo & ".txt"
        Dim fullPath As String = Path.Combine(FileLocation, FileName)

        If Not System.IO.Directory.Exists(FileLocation) Then

            MkDir(FileLocation)
            If Not System.IO.File.Exists(fullPath) Then File.Create(fullPath).Dispose()

        End If

        Try

            Dim SW As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fullPath, True)

            For Each _property In GetType(Invoice).GetProperties()

                SW.Write(_property.Name.ToString() & ": ")
                SW.WriteLine(_property.GetValue(invoice, Nothing))

            Next

            SW.WriteLine("<--------------- INVOICE ITEMS --------------->")


            Dim currentItem = 0
            For Each _i In invoice.getItems()

                currentItem += 1
                SW.WriteLine("*********** Item " & currentItem.ToString & " ***********")

                For Each _property In GetType(InvoiceItem).GetProperties()

                    SW.Write(_property.Name.ToString() & ":")
                    SW.WriteLine(_property.GetValue(_i, Nothing))

                Next

            Next

            SW.WriteLine("######################### END OF INVOICE " & invoice.pInvoiceNo & " #########################")
            SW.WriteLine()


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
                        bw.Write(CStr(_property.GetValue(invoice, Nothing)))

                    End If

                Next

                For Each _i In invoice.getItems()

                    For Each _property In GetType(InvoiceItem).GetProperties()

                        If _property.PropertyType.FullName = "System.Single" Then

                            bw.Write(_property.Name)
                            bw.Write(CSng(_property.GetValue(_i, Nothing)))

                        ElseIf _property.PropertyType.FullName = "System.String" Then

                            bw.Write(_property.Name)
                            bw.Write(CStr(_property.GetValue(_i, Nothing)))

                        ElseIf _property.PropertyType.FullName = "System.Integer" Then

                            If _property.Name = "pNumItems" Then

                                bw.Write(_property.Name)
                                bw.Write(CInt(_property.GetValue(_i, Nothing)))

                            End If

                        End If

                    Next

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

    Public Overrides Function ToString() As String

        Dim info As String = ""

        info += "The details for invoice No: " & invoiceNo

        Return info

    End Function

End Class
