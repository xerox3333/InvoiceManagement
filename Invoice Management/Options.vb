Public Class Options

    Private Sub Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.MaximumSize = New Size(Main.getDockWidth(Main.SplitContainer1.Panel2), Main.getDockHeight(Main.SplitContainer1.Panel2))
        'Main.SplitContainer1.Panel2.Controls.Add(Me)

        Dim width As Integer = My.Computer.Screen.WorkingArea.Width
        Dim height As Integer = My.Computer.Screen.WorkingArea.Height

        Me.Left = (width / 2) - (Me.Width / 2)
        Me.Top = (height / 2) - (Me.Height / 2)

        Me.TopMost = True

    End Sub

    Private Function ValidateFormData() As Boolean



        Return True

    End Function

    Private Sub SaveCompanyDetails()

        If ValidateFormData() = True Then



        End If

    End Sub

End Class