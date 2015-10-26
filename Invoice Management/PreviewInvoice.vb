Imports Invoice_Management.GlobalVar
Imports System.IO

Public Class PreviewInvoice

    Private Sub PreviewInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

        Dim FileLocation As String = previewFileLocation
        Dim FileName As String = previewFileName
        Dim FilePath As String = Path.Combine(FileLocation, FileName)

        'If CreateInvoice.IsHandleCreated Then

        If System.IO.File.Exists(FilePath) Then

            AxAcroPDF.LoadFile(FilePath)

        Else
            MsgBox("The preview file could not be found", MsgBoxStyle.Exclamation, "File Read Error ")

        End If

        'End If

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click

        openFile(previewFileLocation)

    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click

        saveFilePDF(previewFileLocation, previewFileName)

    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click

        AxAcroPDF.printAllFit(True)

    End Sub

    Private Sub CloseToolStripButton_Click(sender As Object, e As EventArgs) Handles CloseToolStripButton.Click

        Me.Hide()
        AxAcroPDF.Dispose()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub FormClose(sender As System.Object, e As System.EventArgs) Handles Me.Closing

        AxAcroPDF.Dispose()
        Me.Dispose()

    End Sub

    Private Sub openFile(ByVal openFileLocation As String)

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
                    SaveAsToolStripButton.Enabled = True

                    AxAcroPDF.LoadFile(selectedFile)

                End If

            ElseIf result = DialogResult.Cancel Or result = Windows.Forms.DialogResult.Abort Then

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub saveFilePDF(ByVal FolderLocation As String, ByVal FileName As String)

        Dim filePath As String = Path.Combine(FolderLocation, FileName)
        Dim saveDialog As SaveFileDialog = New SaveFileDialog

        saveDialog.CreatePrompt = False
        saveDialog.OverwritePrompt = True
        saveDialog.DefaultExt = "pdf"
        saveDialog.AddExtension = True
        saveDialog.Filter = "PDF File|*.pdf"
        saveDialog.InitialDirectory = FolderLocation

        Dim result As DialogResult = saveDialog.ShowDialog()

        If result = DialogResult.OK Then

            If AxAcroPDF.LoadFile(filePath) = True Then

                Dim saveLocation = saveDialog.FileName
                FileCopy(filePath, saveLocation)
                MsgBox("File Successfully Saved to " & saveLocation)

            End If

        End If

    End Sub

End Class