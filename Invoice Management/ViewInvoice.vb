Public Class ViewInvoice

    Public Overrides Property MaximumSize As Size

    Private Sub ViewInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'InitializeComponent()
        Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))

        Me.TopLevel = False
        Main.SplitContainer1.Panel2.Controls.Add(Me)
        Call Main.DockWindow(Me)

    End Sub

    Private Sub ViewInvoice_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        If Me.WindowState = FormWindowState.Maximized Then

            Call Main.DockWindow(Me)

        End If

    End Sub

End Class