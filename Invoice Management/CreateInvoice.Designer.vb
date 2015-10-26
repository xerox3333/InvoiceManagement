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
        Me.ItemsGrid = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboTax = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPurchaseNo = New System.Windows.Forms.TextBox()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.txtBillTo = New System.Windows.Forms.TextBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkSameAsBill = New System.Windows.Forms.CheckBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtShipTo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCreateFrom = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCreateFrom = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.cboDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboTermsLength = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboTerms = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnAddDiscount = New System.Windows.Forms.Button()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtComments = New System.Windows.Forms.TextBox()
        CType(Me.ItemsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.cboTermsLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemsGrid
        '
        Me.ItemsGrid.AllowUserToResizeRows = False
        Me.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Qty, Me.Unit, Me.Unit_Price, Me.Price})
        Me.ItemsGrid.Location = New System.Drawing.Point(12, 313)
        Me.ItemsGrid.Name = "ItemsGrid"
        Me.ItemsGrid.Size = New System.Drawing.Size(843, 168)
        Me.ItemsGrid.TabIndex = 15
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label19.Location = New System.Drawing.Point(483, 608)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 18)
        Me.Label19.TabIndex = 141
        Me.Label19.Text = "Invoice Total:"
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(0, 0, 750, 0)
        Me.Label20.Size = New System.Drawing.Size(932, 25)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Create An Invoice"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(12, 487)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(98, 27)
        Me.btnAddItem.TabIndex = 166
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotes.Location = New System.Drawing.Point(3, 3)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(338, 68)
        Me.txtNotes.TabIndex = 16
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.HideSelection = False
        Me.txtTotal.Location = New System.Drawing.Point(658, 608)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(153, 20)
        Me.txtTotal.TabIndex = 61
        Me.txtTotal.Text = "0.00"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.HideSelection = False
        Me.txtTax.Location = New System.Drawing.Point(658, 568)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(153, 20)
        Me.txtTax.TabIndex = 172
        Me.txtTax.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label15.Location = New System.Drawing.Point(483, 568)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 173
        Me.Label15.Text = "Sales Tax:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.HideSelection = False
        Me.txtSubtotal.Location = New System.Drawing.Point(658, 542)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(153, 20)
        Me.txtSubtotal.TabIndex = 174
        Me.txtSubtotal.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label16.Location = New System.Drawing.Point(483, 542)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 18)
        Me.Label16.TabIndex = 175
        Me.Label16.Text = "SubTotal:"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(863, 39)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(480, 221)
        Me.TabControl1.TabIndex = 176
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboTax)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtPurchaseNo)
        Me.TabPage1.Controls.Add(Me.btnEditCustomer)
        Me.TabPage1.Controls.Add(Me.txtBillTo)
        Me.TabPage1.Controls.Add(Me.cboCustomer)
        Me.TabPage1.Controls.Add(Me.btnAddCustomer)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(472, 195)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Billing"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboTax
        '
        Me.cboTax.FormattingEnabled = True
        Me.cboTax.Items.AddRange(New Object() {"Default", "Exempt"})
        Me.cboTax.Location = New System.Drawing.Point(105, 162)
        Me.cboTax.Name = "cboTax"
        Me.cboTax.Size = New System.Drawing.Size(160, 21)
        Me.cboTax.TabIndex = 183
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 14)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "PO Number:"
        '
        'txtPurchaseNo
        '
        Me.txtPurchaseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseNo.HideSelection = False
        Me.txtPurchaseNo.Location = New System.Drawing.Point(105, 136)
        Me.txtPurchaseNo.Name = "txtPurchaseNo"
        Me.txtPurchaseNo.Size = New System.Drawing.Size(160, 20)
        Me.txtPurchaseNo.TabIndex = 180
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCustomer.Location = New System.Drawing.Point(398, 20)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(38, 23)
        Me.btnEditCustomer.TabIndex = 179
        Me.btnEditCustomer.Text = "Edit Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'txtBillTo
        '
        Me.txtBillTo.Location = New System.Drawing.Point(105, 49)
        Me.txtBillTo.Multiline = True
        Me.txtBillTo.Name = "txtBillTo"
        Me.txtBillTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBillTo.Size = New System.Drawing.Size(243, 83)
        Me.txtBillTo.TabIndex = 178
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(105, 22)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(243, 21)
        Me.cboCustomer.TabIndex = 177
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(354, 20)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(38, 23)
        Me.btnAddCustomer.TabIndex = 176
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Customer:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 14)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Bill To:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox12)
        Me.TabPage2.Controls.Add(Me.ComboBox5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.chkSameAsBill)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.txtShipTo)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 195)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Shipping"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.HideSelection = False
        Me.TextBox12.Location = New System.Drawing.Point(105, 162)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(67, 20)
        Me.TextBox12.TabIndex = 193
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Default", "Exempt"})
        Me.ComboBox5.Location = New System.Drawing.Point(178, 162)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox5.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 14)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "Shipping Cost:"
        '
        'chkSameAsBill
        '
        Me.chkSameAsBill.AutoSize = True
        Me.chkSameAsBill.Location = New System.Drawing.Point(354, 23)
        Me.chkSameAsBill.Name = "chkSameAsBill"
        Me.chkSameAsBill.Size = New System.Drawing.Size(96, 17)
        Me.chkSameAsBill.TabIndex = 190
        Me.chkSameAsBill.Text = "Same as billing"
        Me.chkSameAsBill.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Default", "Exempt"})
        Me.ComboBox4.Location = New System.Drawing.Point(105, 136)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox4.TabIndex = 189
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 14)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "Ship By:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "Tracking Ref:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.HideSelection = False
        Me.TextBox3.Location = New System.Drawing.Point(105, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 20)
        Me.TextBox3.TabIndex = 186
        '
        'txtShipTo
        '
        Me.txtShipTo.Location = New System.Drawing.Point(105, 23)
        Me.txtShipTo.Multiline = True
        Me.txtShipTo.Name = "txtShipTo"
        Me.txtShipTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShipTo.Size = New System.Drawing.Size(243, 83)
        Me.txtShipTo.TabIndex = 185
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "Ship To:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnCreateFrom)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.cboCreateFrom)
        Me.TabPage3.Controls.Add(Me.txtAuthor)
        Me.TabPage3.Controls.Add(Me.txtInvoiceNo)
        Me.TabPage3.Controls.Add(Me.cboDate)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.cboTermsLength)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.cboTerms)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(339, 191)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Invoice"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnCreateFrom
        '
        Me.btnCreateFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateFrom.Location = New System.Drawing.Point(266, 20)
        Me.btnCreateFrom.Name = "btnCreateFrom"
        Me.btnCreateFrom.Size = New System.Drawing.Size(38, 23)
        Me.btnCreateFrom.TabIndex = 184
        Me.btnCreateFrom.Text = "Add Customer"
        Me.btnCreateFrom.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 14)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "Create From:"
        '
        'cboCreateFrom
        '
        Me.cboCreateFrom.FormattingEnabled = True
        Me.cboCreateFrom.Location = New System.Drawing.Point(119, 22)
        Me.cboCreateFrom.Name = "cboCreateFrom"
        Me.cboCreateFrom.Size = New System.Drawing.Size(141, 21)
        Me.cboCreateFrom.TabIndex = 184
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.HideSelection = False
        Me.txtAuthor.Location = New System.Drawing.Point(119, 152)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(130, 20)
        Me.txtAuthor.TabIndex = 66
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.HideSelection = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(119, 49)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(185, 20)
        Me.txtInvoiceNo.TabIndex = 61
        '
        'cboDate
        '
        Me.cboDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cboDate.Location = New System.Drawing.Point(119, 98)
        Me.cboDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.cboDate.Name = "cboDate"
        Me.cboDate.Size = New System.Drawing.Size(185, 20)
        Me.cboDate.TabIndex = 63
        Me.cboDate.Value = New Date(2014, 11, 24, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 14)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Invoice Number:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 155)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 14)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Author:"
        '
        'cboTermsLength
        '
        Me.cboTermsLength.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTermsLength.Location = New System.Drawing.Point(264, 125)
        Me.cboTermsLength.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTermsLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cboTermsLength.Name = "cboTermsLength"
        Me.cboTermsLength.Size = New System.Drawing.Size(40, 20)
        Me.cboTermsLength.TabIndex = 65
        Me.cboTermsLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 14)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Date Due:"
        '
        'cboTerms
        '
        Me.cboTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Items.AddRange(New Object() {"Pay in Days", "Pay in Weeks", "Pay in Months"})
        Me.cboTerms.Location = New System.Drawing.Point(119, 125)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(140, 21)
        Me.cboTerms.TabIndex = 64
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 14)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "Payment Terms:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(508, 90)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(347, 217)
        Me.TabControl2.TabIndex = 177
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Location = New System.Drawing.Point(116, 487)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(98, 27)
        Me.btnRemoveItem.TabIndex = 178
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnAddDiscount
        '
        Me.btnAddDiscount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDiscount.Location = New System.Drawing.Point(220, 487)
        Me.btnAddDiscount.Name = "btnAddDiscount"
        Me.btnAddDiscount.Size = New System.Drawing.Size(98, 27)
        Me.btnAddDiscount.TabIndex = 179
        Me.btnAddDiscount.Text = "Add Discount"
        Me.btnAddDiscount.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Location = New System.Drawing.Point(12, 542)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(352, 100)
        Me.TabControl3.TabIndex = 180
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtNotes)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(344, 74)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Notes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtComments)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(344, 74)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Private Comments"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComments.Location = New System.Drawing.Point(3, 3)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(338, 68)
        Me.txtComments.TabIndex = 17
        '
        'CreateInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(863, 671)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.btnAddDiscount)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ItemsGrid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CreateInvoice"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Invoice"
        CType(Me.ItemsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.cboTermsLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
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
    Friend WithEvents ItemsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cboTax As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPurchaseNo As TextBox
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents txtBillTo As TextBox
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents cboCreateFrom As ComboBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents cboDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cboTermsLength As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents cboTerms As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents btnCreateFrom As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnAddDiscount As Button
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtComments As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkSameAsBill As CheckBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtShipTo As TextBox
    Friend WithEvents Label5 As Label
End Class
