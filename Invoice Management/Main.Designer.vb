<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdViewEstimate = New System.Windows.Forms.Button()
        Me.cmdCreateEstimate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdViewInvoice = New System.Windows.Forms.Button()
        Me.cmdCreateInvoice = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenExistingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdOptions)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel1MinSize = 192
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1087, 593)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 150)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customers"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 52)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "View Customers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add Customer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(18, 525)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(163, 52)
        Me.cmdOptions.TabIndex = 6
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdViewEstimate)
        Me.GroupBox2.Controls.Add(Me.cmdCreateEstimate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 150)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estimates"
        '
        'cmdViewEstimate
        '
        Me.cmdViewEstimate.Location = New System.Drawing.Point(6, 86)
        Me.cmdViewEstimate.Name = "cmdViewEstimate"
        Me.cmdViewEstimate.Size = New System.Drawing.Size(163, 52)
        Me.cmdViewEstimate.TabIndex = 3
        Me.cmdViewEstimate.Text = "View Estimates"
        Me.cmdViewEstimate.UseVisualStyleBackColor = True
        '
        'cmdCreateEstimate
        '
        Me.cmdCreateEstimate.Location = New System.Drawing.Point(6, 28)
        Me.cmdCreateEstimate.Name = "cmdCreateEstimate"
        Me.cmdCreateEstimate.Size = New System.Drawing.Size(163, 52)
        Me.cmdCreateEstimate.TabIndex = 2
        Me.cmdCreateEstimate.Text = "Create Estimate"
        Me.cmdCreateEstimate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdViewInvoice)
        Me.GroupBox1.Controls.Add(Me.cmdCreateInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoices"
        '
        'cmdViewInvoice
        '
        Me.cmdViewInvoice.Location = New System.Drawing.Point(6, 86)
        Me.cmdViewInvoice.Name = "cmdViewInvoice"
        Me.cmdViewInvoice.Size = New System.Drawing.Size(163, 52)
        Me.cmdViewInvoice.TabIndex = 1
        Me.cmdViewInvoice.Text = "View Invoices"
        Me.cmdViewInvoice.UseVisualStyleBackColor = True
        '
        'cmdCreateInvoice
        '
        Me.cmdCreateInvoice.Location = New System.Drawing.Point(6, 28)
        Me.cmdCreateInvoice.Name = "cmdCreateInvoice"
        Me.cmdCreateInvoice.Size = New System.Drawing.Size(163, 52)
        Me.cmdCreateInvoice.TabIndex = 0
        Me.cmdCreateInvoice.Text = "Create Invoice"
        Me.cmdCreateInvoice.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 500)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(889, 93)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(736, 564)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Copyright (C) 2014 Craig Forbes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.MenuStrip1.BackgroundImage = Global.Invoice_Management.My.Resources.Resources.bg
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1087, 39)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenExistingToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExportToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 35)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New Invoice"
        '
        'OpenExistingToolStripMenuItem
        '
        Me.OpenExistingToolStripMenuItem.Name = "OpenExistingToolStripMenuItem"
        Me.OpenExistingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenExistingToolStripMenuItem.Text = "Edit Invoice"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDFToolStripMenuItem, Me.PNGToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.PNGToolStripMenuItem.Text = "PNG"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 35)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 35)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 35)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 632)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Invoice Manager v0.0.1  |  Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdOptions As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdViewEstimate As System.Windows.Forms.Button
    Friend WithEvents cmdCreateEstimate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdViewInvoice As System.Windows.Forms.Button
    Friend WithEvents cmdCreateInvoice As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenExistingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
