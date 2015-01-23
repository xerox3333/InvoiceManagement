Option Explicit On

Public Class Main

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        SplitContainer1.Panel1MinSize = 192

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
            Form.Width = getDockWidth(SplitContainer1.Panel2) - ((getDockWidth(SplitContainer1.Panel2) / 100) * 50)
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
