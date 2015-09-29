Imports Invoice_Management.GlobalVar

Public Class PreviewInvoice

    Dim a As New GlobalVar

    Private Sub PreviewInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))

        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        Dim FileLocation As String = previewFileLocation
        Dim FileName As String = previewFileName

        If CreateInvoice.IsHandleCreated = True Then

            AxAcroPDF.LoadFile(FileLocation & "\" & FileName)

        End If

    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click

        'Copy image in preview location to Invoices Folder

    End Sub

    Private Function openFile(ByVal openFileLocation As String, ByVal loadedFile As String, ByVal fileIsOpen As Boolean)

        'This routine takes the file location of the file to be opened and checks if the open button is pressed on the open file dialog window_
        'the file specified in the open file dialog is then checked to make sure it exists before loading the file into AxAcroPDF control

        Dim desktopPath As String
        Dim selectedFile As String

        desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Try

            OpenFileDialog1.Title = "Select a file to preview"
            OpenFileDialog1.InitialDirectory = desktopPath
            Dim result = OpenFileDialog1.ShowDialog()

            If result = DialogResult.OK Or result = DialogResult.Yes Then

                If OpenFileDialog1.CheckFileExists = False Then

                    MsgBox("The file specified does not exist", MsgBoxStyle.OkOnly, "File does not exist")

                ElseIf OpenFileDialog1.CheckPathExists = False Then

                    MsgBox("The path specified does not exist", MsgBoxStyle.OkOnly, "Path does not exist")

                Else

                    selectedFile = OpenFileDialog1.FileName
                    loadedFile = selectedFile
                    SaveAsToolStripButton.Enabled = True

                    AxAcroPDF.LoadFile(selectedFile)
                    fileIsOpen = True

                End If

            ElseIf result = DialogResult.Cancel Or result = Windows.Forms.DialogResult.Abort Then

                Return 0

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return fileIsOpen

    End Function

End Class