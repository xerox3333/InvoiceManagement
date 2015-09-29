<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateInvoice
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPurchaseNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTerms = New System.Windows.Forms.ComboBox()
        Me.cboTermsLength = New System.Windows.Forms.NumericUpDown()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ItemsGrid = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEstimateNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBillToPostcode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBillToCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBillToAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBillToName = New System.Windows.Forms.TextBox()
        Me.chkSameAsBill = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtShipToPostcode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtShipToCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtShipToAddress = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtShipToName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCutomerID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.cboTermsLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ToolStrip1.BackgroundImage = Global.Invoice_Management.My.Resources.Resources.bg
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.SaveAsToolStripButton, Me.PreviewToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator2, Me.CloseToolStripButton, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(937, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "CreateInvoiceToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.File_add_icon1
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(66, 36)
        Me.NewToolStripButton.Text = "New"
        '
        'SaveAsToolStripButton
        '
        Me.SaveAsToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.save_icon
        Me.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsToolStripButton.Name = "SaveAsToolStripButton"
        Me.SaveAsToolStripButton.Size = New System.Drawing.Size(70, 36)
        Me.SaveAsToolStripButton.Text = "S&ave"
        '
        'PreviewToolStripButton
        '
        Me.PreviewToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.Search_icon1
        Me.PreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PreviewToolStripButton.Name = "PreviewToolStripButton"
        Me.PreviewToolStripButton.Size = New System.Drawing.Size(84, 36)
        Me.PreviewToolStripButton.Text = "Preview"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.Invoice_Management.My.Resources.Resources.printer_icon
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(69, 36)
        Me.PrintToolStripButton.Text = "&Print"
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
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.HideSelection = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(126, 38)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(130, 20)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Invoice No:"
        '
        'txtPurchaseNo
        '
        Me.txtPurchaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseNo.HideSelection = False
        Me.txtPurchaseNo.Location = New System.Drawing.Point(126, 91)
        Me.txtPurchaseNo.Name = "txtPurchaseNo"
        Me.txtPurchaseNo.Size = New System.Drawing.Size(130, 20)
        Me.txtPurchaseNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Purchase No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Terms:"
        '
        'cboTerms
        '
        Me.cboTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Items.AddRange(New Object() {"Pay in Days", "Pay in Weeks", "Pay in Months"})
        Me.cboTerms.Location = New System.Drawing.Point(126, 143)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(112, 21)
        Me.cboTerms.TabIndex = 5
        '
        'cboTermsLength
        '
        Me.cboTermsLength.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTermsLength.Location = New System.Drawing.Point(243, 144)
        Me.cboTermsLength.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTermsLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cboTermsLength.Name = "cboTermsLength"
        Me.cboTermsLength.Size = New System.Drawing.Size(40, 20)
        Me.cboTermsLength.TabIndex = 6
        Me.cboTermsLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatedBy.HideSelection = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(126, 170)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(130, 20)
        Me.txtCreatedBy.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 14)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Created By:"
        '
        'ItemsGrid
        '
        Me.ItemsGrid.AllowUserToResizeRows = False
        Me.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Qty, Me.Unit, Me.Unit_Price, Me.Price})
        Me.ItemsGrid.Location = New System.Drawing.Point(12, 363)
        Me.ItemsGrid.Name = "ItemsGrid"
        Me.ItemsGrid.Size = New System.Drawing.Size(909, 330)
        Me.ItemsGrid.TabIndex = 17
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 500
        Me.Item.Name = "Item"
        Me.Item.Width = 500
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MinimumWidth = 75
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 75
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.MinimumWidth = 75
        Me.Unit.Name = "Unit"
        Me.Unit.Width = 75
        '
        'Unit_Price
        '
        Me.Unit_Price.HeaderText = "Unit Price"
        Me.Unit_Price.MinimumWidth = 90
        Me.Unit_Price.Name = "Unit_Price"
        Me.Unit_Price.Width = 90
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 90
        Me.Price.Name = "Price"
        Me.Price.Width = 90
        '
        'txtDate
        '
        Me.txtDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(126, 116)
        Me.txtDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(157, 20)
        Me.txtDate.TabIndex = 4
        Me.txtDate.Value = New Date(2014, 11, 24, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtEstimateNo)
        Me.GroupBox1.Controls.Add(Me.txtCreatedBy)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPurchaseNo)
        Me.GroupBox1.Controls.Add(Me.cboTermsLength)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboTerms)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(607, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 205)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 14)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Estimate No:"
        '
        'txtEstimateNo
        '
        Me.txtEstimateNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimateNo.HideSelection = False
        Me.txtEstimateNo.Location = New System.Drawing.Point(126, 64)
        Me.txtEstimateNo.Name = "txtEstimateNo"
        Me.txtEstimateNo.Size = New System.Drawing.Size(130, 20)
        Me.txtEstimateNo.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Postcode:"
        '
        'txtBillToPostcode
        '
        Me.txtBillToPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillToPostcode.HideSelection = False
        Me.txtBillToPostcode.Location = New System.Drawing.Point(123, 185)
        Me.txtBillToPostcode.Name = "txtBillToPostcode"
        Me.txtBillToPostcode.Size = New System.Drawing.Size(156, 20)
        Me.txtBillToPostcode.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 14)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "City/Town:"
        '
        'txtBillToCity
        '
        Me.txtBillToCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillToCity.HideSelection = False
        Me.txtBillToCity.Location = New System.Drawing.Point(123, 159)
        Me.txtBillToCity.Name = "txtBillToCity"
        Me.txtBillToCity.Size = New System.Drawing.Size(156, 20)
        Me.txtBillToCity.TabIndex = 115
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 14)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Street Address:"
        '
        'txtBillToAddress
        '
        Me.txtBillToAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillToAddress.HideSelection = False
        Me.txtBillToAddress.Location = New System.Drawing.Point(123, 133)
        Me.txtBillToAddress.Name = "txtBillToAddress"
        Me.txtBillToAddress.Size = New System.Drawing.Size(156, 20)
        Me.txtBillToAddress.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 14)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Customer Name:"
        '
        'txtBillToName
        '
        Me.txtBillToName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillToName.HideSelection = False
        Me.txtBillToName.Location = New System.Drawing.Point(123, 107)
        Me.txtBillToName.Name = "txtBillToName"
        Me.txtBillToName.Size = New System.Drawing.Size(156, 20)
        Me.txtBillToName.TabIndex = 113
        '
        'chkSameAsBill
        '
        Me.chkSameAsBill.AutoSize = True
        Me.chkSameAsBill.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSameAsBill.Location = New System.Drawing.Point(425, 208)
        Me.chkSameAsBill.Name = "chkSameAsBill"
        Me.chkSameAsBill.Size = New System.Drawing.Size(141, 18)
        Me.chkSameAsBill.TabIndex = 134
        Me.chkSameAsBill.Text = "Same as Bill Address"
        Me.chkSameAsBill.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(309, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 14)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Postcode:"
        '
        'txtShipToPostcode
        '
        Me.txtShipToPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToPostcode.HideSelection = False
        Me.txtShipToPostcode.Location = New System.Drawing.Point(411, 182)
        Me.txtShipToPostcode.Name = "txtShipToPostcode"
        Me.txtShipToPostcode.Size = New System.Drawing.Size(155, 20)
        Me.txtShipToPostcode.TabIndex = 133
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(309, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 14)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "City/Town:"
        '
        'txtShipToCity
        '
        Me.txtShipToCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToCity.HideSelection = False
        Me.txtShipToCity.Location = New System.Drawing.Point(411, 156)
        Me.txtShipToCity.Name = "txtShipToCity"
        Me.txtShipToCity.Size = New System.Drawing.Size(155, 20)
        Me.txtShipToCity.TabIndex = 132
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(309, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 14)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "Street Address:"
        '
        'txtShipToAddress
        '
        Me.txtShipToAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToAddress.HideSelection = False
        Me.txtShipToAddress.Location = New System.Drawing.Point(411, 130)
        Me.txtShipToAddress.Name = "txtShipToAddress"
        Me.txtShipToAddress.Size = New System.Drawing.Size(155, 20)
        Me.txtShipToAddress.TabIndex = 131
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(309, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 14)
        Me.Label16.TabIndex = 135
        Me.Label16.Text = "Customer Name:"
        '
        'txtShipToName
        '
        Me.txtShipToName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToName.HideSelection = False
        Me.txtShipToName.Location = New System.Drawing.Point(411, 104)
        Me.txtShipToName.Name = "txtShipToName"
        Me.txtShipToName.Size = New System.Drawing.Size(155, 20)
        Me.txtShipToName.TabIndex = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.chkSameAsBill)
        Me.GroupBox2.Controls.Add(Me.txtCutomerID)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtShipToPostcode)
        Me.GroupBox2.Controls.Add(Me.txtBillToName)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtShipToCity)
        Me.GroupBox2.Controls.Add(Me.txtBillToAddress)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtShipToAddress)
        Me.GroupBox2.Controls.Add(Me.txtBillToCity)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtShipToName)
        Me.GroupBox2.Controls.Add(Me.txtBillToPostcode)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 250)
        Me.GroupBox2.TabIndex = 139
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(309, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 18)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "Ship To:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Bill To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Customer No:"
        '
        'txtCutomerID
        '
        Me.txtCutomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCutomerID.HideSelection = False
        Me.txtCutomerID.Location = New System.Drawing.Point(105, 40)
        Me.txtCutomerID.Name = "txtCutomerID"
        Me.txtCutomerID.Size = New System.Drawing.Size(130, 20)
        Me.txtCutomerID.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 23)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Invoice Items"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(705, 715)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 23)
        Me.Label19.TabIndex = 141
        Me.Label19.Text = "Invoice Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(825, 715)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 23)
        Me.lblTotal.TabIndex = 142
        Me.lblTotal.Text = "£0.00"
        '
        'CreateInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(954, 741)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ItemsGrid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CreateInvoice"
        Me.ShowIcon = False
        Me.Text = "Invoice"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.cboTermsLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTerms As System.Windows.Forms.ComboBox
    Friend WithEvents cboTermsLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ItemsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBillToPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBillToCity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBillToAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBillToName As System.Windows.Forms.TextBox
    Friend WithEvents chkSameAsBill As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtShipToPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtShipToCity As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtShipToAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtShipToName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCutomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEstimateNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
