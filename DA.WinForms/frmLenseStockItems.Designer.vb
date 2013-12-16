<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLenseStockItems
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.cmbValue = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtValue = New DevExpress.XtraEditors.TextEdit
        Me.sbLoadPower = New DevExpress.XtraEditors.SimpleButton
        Me.gcStockList = New DevExpress.XtraGrid.GridControl
        Me.gvStockList = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.risePurchasePrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.riseSalesPrice = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.riseReorderLevel = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rileSupplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbSubGroup = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cbType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sbSave = New DevExpress.XtraEditors.SimpleButton
        Me.cbGroup = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.dxvpValidation = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cmbValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStockList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStockList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.risePurchasePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseSalesPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseReorderLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxvpValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmbValue)
        Me.LayoutControl1.Controls.Add(Me.txtValue)
        Me.LayoutControl1.Controls.Add(Me.sbLoadPower)
        Me.LayoutControl1.Controls.Add(Me.gcStockList)
        Me.LayoutControl1.Controls.Add(Me.cbSubGroup)
        Me.LayoutControl1.Controls.Add(Me.cbType)
        Me.LayoutControl1.Controls.Add(Me.sbSave)
        Me.LayoutControl1.Controls.Add(Me.cbGroup)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(808, 420)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmbValue
        '
        Me.cmbValue.Location = New System.Drawing.Point(210, 28)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbValue.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbValue.Properties.Items.AddRange(New Object() {"+", "-"})
        Me.cmbValue.Size = New System.Drawing.Size(189, 20)
        Me.cmbValue.StyleController = Me.LayoutControl1
        Me.cmbValue.TabIndex = 14
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(65, 28)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValue.Size = New System.Drawing.Size(134, 20)
        Me.txtValue.StyleController = Me.LayoutControl1
        Me.txtValue.TabIndex = 13
        '
        'sbLoadPower
        '
        Me.sbLoadPower.Location = New System.Drawing.Point(7, 149)
        Me.sbLoadPower.Name = "sbLoadPower"
        Me.sbLoadPower.Size = New System.Drawing.Size(114, 28)
        Me.sbLoadPower.StyleController = Me.LayoutControl1
        Me.sbLoadPower.TabIndex = 10
        Me.sbLoadPower.Text = "Load Default Power"
        '
        'gcStockList
        '
        Me.gcStockList.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcStockList.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcStockList.Location = New System.Drawing.Point(7, 188)
        Me.gcStockList.MainView = Me.gvStockList
        Me.gcStockList.Name = "gcStockList"
        Me.gcStockList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1, Me.RepositoryItemSpinEdit1, Me.risePurchasePrice, Me.riseSalesPrice, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.rileSupplier, Me.riseReorderLevel})
        Me.gcStockList.Size = New System.Drawing.Size(795, 193)
        Me.gcStockList.TabIndex = 9
        Me.gcStockList.UseEmbeddedNavigator = True
        Me.gcStockList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStockList})
        '
        'gvStockList
        '
        Me.gvStockList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn6, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn9, Me.GridColumn8, Me.GridColumn7})
        Me.gvStockList.GridControl = Me.gcStockList
        Me.gvStockList.Name = "gvStockList"
        Me.gvStockList.OptionsCustomization.AllowFilter = False
        Me.gvStockList.OptionsCustomization.AllowGroup = False
        Me.gvStockList.OptionsCustomization.AllowSort = False
        Me.gvStockList.OptionsMenu.EnableColumnMenu = False
        Me.gvStockList.OptionsSelection.MultiSelect = True
        Me.gvStockList.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStockList.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Power"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTimeEdit1
        Me.GridColumn1.FieldName = "Power"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowMove = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.PowderBlue
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.Caption = "Stock Code"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn6.FieldName = "StockCode"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowMove = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Description"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn5.FieldName = "StockDescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowMove = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Qty"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.GridColumn2.FieldName = "Qty"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowMove = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.MaxLength = 6
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Purchase Price"
        Me.GridColumn3.ColumnEdit = Me.risePurchasePrice
        Me.GridColumn3.FieldName = "PurchasePrice"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowMove = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'risePurchasePrice
        '
        Me.risePurchasePrice.AutoHeight = False
        Me.risePurchasePrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "+", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.risePurchasePrice.MaxLength = 6
        Me.risePurchasePrice.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.risePurchasePrice.Name = "risePurchasePrice"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Sales Price"
        Me.GridColumn4.ColumnEdit = Me.riseSalesPrice
        Me.GridColumn4.FieldName = "SalesPrice"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowMove = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'riseSalesPrice
        '
        Me.riseSalesPrice.AutoHeight = False
        Me.riseSalesPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "+", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.riseSalesPrice.MaxLength = 6
        Me.riseSalesPrice.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.riseSalesPrice.Name = "riseSalesPrice"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Reorder Level"
        Me.GridColumn9.ColumnEdit = Me.riseReorderLevel
        Me.GridColumn9.FieldName = "ReorderLevel"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowMove = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'riseReorderLevel
        '
        Me.riseReorderLevel.AutoHeight = False
        Me.riseReorderLevel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "+", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.riseReorderLevel.MaxLength = 6
        Me.riseReorderLevel.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.riseReorderLevel.Name = "riseReorderLevel"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Supplier"
        Me.GridColumn8.ColumnEdit = Me.rileSupplier
        Me.GridColumn8.FieldName = "SupplierID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowMove = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'rileSupplier
        '
        Me.rileSupplier.AutoHeight = False
        Me.rileSupplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "+", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.rileSupplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.rileSupplier.Name = "rileSupplier"
        Me.rileSupplier.NullText = ""
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Message"
        Me.GridColumn7.FieldName = "Message"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowMove = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'cbSubGroup
        '
        Me.cbSubGroup.Location = New System.Drawing.Point(65, 121)
        Me.cbSubGroup.Name = "cbSubGroup"
        Me.cbSubGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubGroup.Size = New System.Drawing.Size(334, 20)
        Me.cbSubGroup.StyleController = Me.LayoutControl1
        Me.cbSubGroup.TabIndex = 8
        '
        'cbType
        '
        Me.cbType.Location = New System.Drawing.Point(65, 59)
        Me.cbType.Name = "cbType"
        Me.cbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbType.Properties.Items.AddRange(New Object() {"SPH", "CYL", "BIFOCAL", "COMPOUND", "(-) ADD LENSE", "(+) SPH LENSES", "PROGRESSIVE", "PLANO"})
        Me.cbType.Size = New System.Drawing.Size(334, 20)
        Me.cbType.StyleController = Me.LayoutControl1
        Me.cbType.TabIndex = 7
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Required"
        Me.dxvpValidation.SetValidationRule(Me.cbType, ConditionValidationRule1)
        '
        'sbSave
        '
        Me.sbSave.Location = New System.Drawing.Point(607, 388)
        Me.sbSave.Name = "sbSave"
        Me.sbSave.Size = New System.Drawing.Size(199, 30)
        Me.sbSave.StyleController = Me.LayoutControl1
        Me.sbSave.TabIndex = 11
        Me.sbSave.Text = "Save"
        '
        'cbGroup
        '
        Me.cbGroup.Location = New System.Drawing.Point(65, 90)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGroup.Properties.Items.AddRange(New Object() {"NORMAL", "HMC", "P/GRAY", "B/GRAY"})
        Me.cbGroup.Size = New System.Drawing.Size(334, 20)
        Me.cbGroup.StyleController = Me.LayoutControl1
        Me.cbGroup.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.EmptySpaceItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(808, 420)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcStockList
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 181)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(806, 204)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Create Lense Stock"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(806, 181)
        Me.LayoutControlGroup2.Text = "Create Lense Stock"
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(119, 124)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(681, 33)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.sbLoadPower
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 33)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(118, 33)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(119, 33)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbSubGroup
        Me.LayoutControlItem2.CustomizationFormText = "Sub Group"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(400, 31)
        Me.LayoutControlItem2.Text = "Sub Group"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbGroup
        Me.LayoutControlItem3.CustomizationFormText = "Group"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(400, 31)
        Me.LayoutControlItem3.Text = "Group"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbType
        Me.LayoutControlItem4.CustomizationFormText = "Type"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(400, 31)
        Me.LayoutControlItem4.Text = "Type"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 20)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(400, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(400, 62)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(400, 62)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(400, 31)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(400, 93)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(400, 31)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtValue
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(200, 31)
        Me.LayoutControlItem8.Text = "Value"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmbValue
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(200, 31)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.sbSave
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(604, 385)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 33)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(97, 33)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(202, 33)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 385)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(403, 33)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(403, 385)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(201, 33)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmLenseStockItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.Name = "frmLenseStockItems"
        Me.Text = "Lense Stock"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cmbValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStockList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStockList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.risePurchasePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseSalesPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseReorderLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxvpValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbGroup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbSubGroup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcStockList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvStockList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbLoadPower As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents risePurchasePrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents riseSalesPrice As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents sbSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileSupplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dxvpValidation As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents riseReorderLevel As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbValue As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
End Class
