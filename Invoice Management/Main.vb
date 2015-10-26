Option Explicit On

Imports Invoice_Management.GlobalVar
Imports System.IO

Public Class Main

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        SplitContainer1.Panel1MinSize = 192

        CreateInvoice.initInvoices()

    End Sub

    Public Sub WindowMaximize(ByVal sender As System.Object, e As System.EventArgs) Handles Me.AutoSizeChanged

        DockWindow(CreateInvoice)

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
        Height = panel.Height - ListBox1.Height

        Return Height

    End Function

    Public Sub DockWindow(ByVal Form As System.Windows.Forms.Form)

        Dim Height As Integer = My.Computer.Screen.Bounds.Height
        Dim Width As Integer = My.Computer.Screen.Bounds.Width

        Form.WindowState = FormWindowState.Normal
        Form.BringToFront()
        Form.Left = 1
        Form.Top = 1

        If (Width >= 1024 And Height >= 768) AndAlso (Width < 1280 And Height < 900) Then
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 70)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        ElseIf (Width >= 1280 And Height >= 900) AndAlso (Width < 1920 And Height < 1080) Then
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 50)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        ElseIf (Width >= 1920 And Height >= 1080) AndAlso (Width < 2560 And Height < 1440) Then
            'Size for standard 1080p HD resoluion
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 15)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        ElseIf Width >= 2560 And Height >= 1440 Then
            'Size for very large resolutions
            Form.Width = getDockWidth(SplitContainer1.Panel2)
            Form.Height = getDockHeight(SplitContainer1.Panel2)

        End If

    End Sub

    Private Sub LoadCompanyDetails(ByVal FileLocation As String, ByVal FileName As String)

        Dim FilePath As String = Path.Combine(FileLocation, FileName)
        Dim sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader(FilePath)
        Dim line As String = ""

        'Quick and dirty reads the users company data back from a saved txt file
        line = sr.ReadLine()
        oOwnerName = line
        line = sr.ReadLine()
        oCompanyName = line
        line = sr.ReadLine()
        oCompanyAddress1 = line
        line = sr.ReadLine()
        oCompanyAddress2 = line
        line = sr.ReadLine()
        oCompanyCity = line
        line = sr.ReadLine()
        oCompanyPostcode = line
        line = sr.ReadLine()
        oCompanyPhone = line
        line = sr.ReadLine()
        oCompanyMobile = line
        line = sr.ReadLine()
        oCompanyEmail = line
        line = sr.ReadLine()
        oWebsite = line
        line = sr.ReadLine()
        oDescription = line

    End Sub


End Class
