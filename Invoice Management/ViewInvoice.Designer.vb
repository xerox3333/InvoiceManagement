﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dateHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.invoiceNoHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customerNoHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstInvoices = New System.Windows.Forms.ListView()
        Me.purchaseNoHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.commentsHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReloadToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateHeader
        '
        Me.dateHeader.Text = "Date"
        Me.dateHeader.Width = 100
        '
        'invoiceNoHeader
        '
        Me.invoiceNoHeader.Text = "Invoice No"
        Me.invoiceNoHeader.Width = 100
        '
        'customerNoHeader
        '
        Me.customerNoHeader.Text = "Customer No"
        Me.customerNoHeader.Width = 100
        '
        'totalHeader
        '
        Me.totalHeader.Text = "Total"
        Me.totalHeader.Width = 100
        '
        'lstInvoices
        '
        Me.lstInvoices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.invoiceNoHeader, Me.purchaseNoHeader, Me.customerNoHeader, Me.dateHeader, Me.totalHeader, Me.commentsHeader})
        Me.lstInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstInvoices.FullRowSelect = True
        Me.lstInvoices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstInvoices.HideSelection = False
        Me.lstInvoices.Location = New System.Drawing.Point(0, 39)
        Me.lstInvoices.MultiSelect = False
        Me.lstInvoices.Name = "lstInvoices"
        Me.lstInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstInvoices.Size = New System.Drawing.Size(784, 422)
        Me.lstInvoices.TabIndex = 7
        Me.lstInvoices.UseCompatibleStateImageBehavior = False
        Me.lstInvoices.View = System.Windows.Forms.View.Details
        '
        'purchaseNoHeader
        '
        Me.purchaseNoHeader.Text = "Puchase No"
        Me.purchaseNoHeader.Width = 76
        '
        'commentsHeader
        '
        Me.commentsHeader.Text = "Comments"
        Me.commentsHeader.Width = 93
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStrip1.BackgroundImage = Global.Invoice_Management.My.Resources.Resources.bg
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveAsToolStripButton, Me.PrintToolStripButton, Me.ReloadToolStripButton, Me.toolStripSeparator, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator2, Me.CloseToolStripButton, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 39)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.open_icon
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(84, 36)
        Me.OpenToolStripButton.Text = "&Preview"
        '
        'SaveAsToolStripButton
        '
        Me.SaveAsToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.save_icon
        Me.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsToolStripButton.Name = "SaveAsToolStripButton"
        Me.SaveAsToolStripButton.Size = New System.Drawing.Size(86, 36)
        Me.SaveAsToolStripButton.Text = "S&ave As"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.printer_icon
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(69, 36)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'ReloadToolStripButton
        '
        Me.ReloadToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.refreshIcon
        Me.ReloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReloadToolStripButton.Name = "ReloadToolStripButton"
        Me.ReloadToolStripButton.Size = New System.Drawing.Size(81, 36)
        Me.ReloadToolStripButton.Text = "Reload"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.Enabled = False
        Me.CopyToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.copy_icon
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(72, 36)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.Enabled = False
        Me.PasteToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.paste_icon
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(73, 36)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'CloseToolStripButton
        '
        Me.CloseToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.close_icon
        Me.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolStripButton.Name = "CloseToolStripButton"
        Me.CloseToolStripButton.Size = New System.Drawing.Size(74, 36)
        Me.CloseToolStripButton.Text = "&Close"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.Faq_icon
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(68, 36)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'ViewInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lstInvoices)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ViewInvoice"
        Me.ShowIcon = False
        Me.Text = "View Invoice"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dateHeader As ColumnHeader
    Friend WithEvents invoiceNoHeader As ColumnHeader
    Friend WithEvents customerNoHeader As ColumnHeader
    Friend WithEvents totalHeader As ColumnHeader
    Friend WithEvents lstInvoices As ListView
    Friend WithEvents commentsHeader As ColumnHeader
    Friend WithEvents purchaseNoHeader As ColumnHeader
    Friend WithEvents ReloadToolStripButton As ToolStripButton
End Class
