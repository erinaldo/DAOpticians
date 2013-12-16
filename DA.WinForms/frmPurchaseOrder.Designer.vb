<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim ConditionValidatonRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidatonRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidatonRule
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.bbSave = New DevExpress.XtraBars.BarButtonItem
        Me.bbNew = New DevExpress.XtraBars.BarButtonItem
        Me.bbDisplaySelected = New DevExpress.XtraBars.BarButtonItem
        Me.bbPrint = New DevExpress.XtraBars.BarButtonItem
        Me.bbRefresh = New DevExpress.XtraBars.BarButtonItem
        Me.bbClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.xTab1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.gcPurchaseOrderDescription = New DevExpress.XtraGrid.GridControl
        Me.gvPurchaseOrderDescription = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.glupStockItems = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.meNote = New DevExpress.XtraEditors.MemoExEdit
        Me.teReferenceNo = New DevExpress.XtraEditors.TextEdit
        Me.dePurchaseOrderDate = New DevExpress.XtraEditors.DateEdit
        Me.lupSupplier = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPurchaseOrderID = New DevExpress.XtraEditors.LabelControl
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.gcPurchaseOrderHistory = New DevExpress.XtraGrid.GridControl
        Me.gvPurchaseOrderHistory = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dxvpSupplier = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bbDelete = New DevExpress.XtraBars.BarButtonItem
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTab1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcPurchaseOrderDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glupStockItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teReferenceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePurchaseOrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dePurchaseOrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lupSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcPurchaseOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPurchaseOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxvpSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbSave, Me.bbNew, Me.bbDisplaySelected, Me.bbPrint, Me.bbRefresh, Me.bbClose, Me.bbDelete})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDisplaySelected), New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.bbClose)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'bbSave
        '
        Me.bbSave.Caption = "BarButtonItem1"
        Me.bbSave.Id = 0
        Me.bbSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.bbSave.Name = "bbSave"
        '
        'bbNew
        '
        Me.bbNew.Caption = "BarButtonItem2"
        Me.bbNew.Id = 1
        Me.bbNew.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.bbNew.Name = "bbNew"
        '
        'bbDisplaySelected
        '
        Me.bbDisplaySelected.Caption = "BarButtonItem3"
        Me.bbDisplaySelected.Id = 2
        Me.bbDisplaySelected.Name = "bbDisplaySelected"
        '
        'bbPrint
        '
        Me.bbPrint.Caption = "BarButtonItem4"
        Me.bbPrint.Id = 3
        Me.bbPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.bbPrint.Name = "bbPrint"
        '
        'bbRefresh
        '
        Me.bbRefresh.Caption = "BarButtonItem5"
        Me.bbRefresh.Id = 4
        Me.bbRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.bbRefresh.Name = "bbRefresh"
        '
        'bbClose
        '
        Me.bbClose.Caption = "BarButtonItem6"
        Me.bbClose.Id = 5
        Me.bbClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
        Me.bbClose.Name = "bbClose"
        '
        'xTab1
        '
        Me.xTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xTab1.Location = New System.Drawing.Point(0, 48)
        Me.xTab1.Name = "xTab1"
        Me.xTab1.SelectedTabPage = Me.XtraTabPage1
        Me.xTab1.Size = New System.Drawing.Size(714, 399)
        Me.xTab1.TabIndex = 4
        Me.xTab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(705, 368)
        Me.XtraTabPage1.Text = "New Record"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gcPurchaseOrderDescription)
        Me.LayoutControl1.Controls.Add(Me.meNote)
        Me.LayoutControl1.Controls.Add(Me.teReferenceNo)
        Me.LayoutControl1.Controls.Add(Me.dePurchaseOrderDate)
        Me.LayoutControl1.Controls.Add(Me.lupSupplier)
        Me.LayoutControl1.Controls.Add(Me.lblPurchaseOrderID)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(705, 368)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gcPurchaseOrderDescription
        '
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.First.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.gcPurchaseOrderDescription.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.gcPurchaseOrderDescription.Location = New System.Drawing.Point(7, 93)
        Me.gcPurchaseOrderDescription.MainView = Me.gvPurchaseOrderDescription
        Me.gcPurchaseOrderDescription.Name = "gcPurchaseOrderDescription"
        Me.gcPurchaseOrderDescription.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.glupStockItems, Me.RepositoryItemSpinEdit1})
        Me.gcPurchaseOrderDescription.Size = New System.Drawing.Size(692, 269)
        Me.gcPurchaseOrderDescription.TabIndex = 9
        Me.gcPurchaseOrderDescription.UseEmbeddedNavigator = True
        Me.gcPurchaseOrderDescription.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderDescription})
        '
        'gvPurchaseOrderDescription
        '
        Me.gvPurchaseOrderDescription.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.gvPurchaseOrderDescription.GridControl = Me.gcPurchaseOrderDescription
        Me.gvPurchaseOrderDescription.Name = "gvPurchaseOrderDescription"
        Me.gvPurchaseOrderDescription.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvPurchaseOrderDescription.OptionsView.ShowFooter = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Stock ID"
        Me.GridColumn11.FieldName = "StockID"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Stock Code"
        Me.GridColumn1.ColumnEdit = Me.glupStockItems
        Me.GridColumn1.FieldName = "StockCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 124
        '
        'glupStockItems
        '
        Me.glupStockItems.AutoHeight = False
        Me.glupStockItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glupStockItems.DisplayMember = "StockID"
        Me.glupStockItems.ImmediatePopup = True
        Me.glupStockItems.Name = "glupStockItems"
        Me.glupStockItems.NullText = ""
        Me.glupStockItems.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.glupStockItems.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn14})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Stock Code"
        Me.GridColumn8.FieldName = "StockCode"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 96
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Description"
        Me.GridColumn9.FieldName = "Description"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 269
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Current Balance"
        Me.GridColumn10.FieldName = "StockBalance"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 128
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Stock ID"
        Me.GridColumn14.FieldName = "StockID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 397
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Required Quantity"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.GridColumn3.FieldName = "RequiredQuantity"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 105
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'meNote
        '
        Me.meNote.EnterMoveNextControl = True
        Me.meNote.Location = New System.Drawing.Point(429, 62)
        Me.meNote.Name = "meNote"
        Me.meNote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meNote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meNote.Properties.PopupStartSize = New System.Drawing.Size(400, 150)
        Me.meNote.Properties.ShowIcon = False
        Me.meNote.Size = New System.Drawing.Size(270, 20)
        Me.meNote.StyleController = Me.LayoutControl1
        Me.meNote.TabIndex = 8
        '
        'teReferenceNo
        '
        Me.teReferenceNo.EnterMoveNextControl = True
        Me.teReferenceNo.Location = New System.Drawing.Point(429, 31)
        Me.teReferenceNo.Name = "teReferenceNo"
        Me.teReferenceNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teReferenceNo.Size = New System.Drawing.Size(270, 20)
        Me.teReferenceNo.StyleController = Me.LayoutControl1
        Me.teReferenceNo.TabIndex = 7
        '
        'dePurchaseOrderDate
        '
        Me.dePurchaseOrderDate.EditValue = Nothing
        Me.dePurchaseOrderDate.EnterMoveNextControl = True
        Me.dePurchaseOrderDate.Location = New System.Drawing.Point(78, 62)
        Me.dePurchaseOrderDate.Name = "dePurchaseOrderDate"
        Me.dePurchaseOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dePurchaseOrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dePurchaseOrderDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dePurchaseOrderDate.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.dePurchaseOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePurchaseOrderDate.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.dePurchaseOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dePurchaseOrderDate.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.dePurchaseOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dePurchaseOrderDate.Size = New System.Drawing.Size(269, 20)
        Me.dePurchaseOrderDate.StyleController = Me.LayoutControl1
        Me.dePurchaseOrderDate.TabIndex = 6
        '
        'lupSupplier
        '
        Me.lupSupplier.EnterMoveNextControl = True
        Me.lupSupplier.Location = New System.Drawing.Point(78, 31)
        Me.lupSupplier.Name = "lupSupplier"
        Me.lupSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lupSupplier.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lupSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier", 50), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telephone", "Telephone", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lupSupplier.Properties.NullText = ""
        Me.lupSupplier.Size = New System.Drawing.Size(269, 20)
        Me.lupSupplier.StyleController = Me.LayoutControl1
        Me.lupSupplier.TabIndex = 5
        ConditionValidatonRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidatonRule1.ErrorText = "Can not be Blank"
        Me.dxvpSupplier.SetValidationRule(Me.lupSupplier, ConditionValidatonRule1)
        '
        'lblPurchaseOrderID
        '
        Me.lblPurchaseOrderID.Location = New System.Drawing.Point(7, 7)
        Me.lblPurchaseOrderID.Name = "lblPurchaseOrderID"
        Me.lblPurchaseOrderID.Size = New System.Drawing.Size(692, 13)
        Me.lblPurchaseOrderID.StyleController = Me.LayoutControl1
        Me.lblPurchaseOrderID.TabIndex = 4
        Me.lblPurchaseOrderID.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(705, 368)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lblPurchaseOrderID
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(703, 24)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lupSupplier
        Me.LayoutControlItem2.CustomizationFormText = "Supplier"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(351, 31)
        Me.LayoutControlItem2.Text = "Supplier"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dePurchaseOrderDate
        Me.LayoutControlItem3.CustomizationFormText = "Date"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(351, 31)
        Me.LayoutControlItem3.Text = "Date"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(66, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.teReferenceNo
        Me.LayoutControlItem4.CustomizationFormText = "Reference No"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(351, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(352, 31)
        Me.LayoutControlItem4.Text = "Reference No"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(66, 20)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.meNote
        Me.LayoutControlItem5.CustomizationFormText = "Note"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(351, 55)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(352, 31)
        Me.LayoutControlItem5.Text = "Note"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(66, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.gcPurchaseOrderDescription
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(703, 280)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcPurchaseOrderHistory)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(705, 392)
        Me.XtraTabPage2.Text = "History Data"
        '
        'gcPurchaseOrderHistory
        '
        Me.gcPurchaseOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPurchaseOrderHistory.Location = New System.Drawing.Point(0, 0)
        Me.gcPurchaseOrderHistory.MainView = Me.gvPurchaseOrderHistory
        Me.gcPurchaseOrderHistory.Name = "gcPurchaseOrderHistory"
        Me.gcPurchaseOrderHistory.Size = New System.Drawing.Size(705, 392)
        Me.gcPurchaseOrderHistory.TabIndex = 0
        Me.gcPurchaseOrderHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPurchaseOrderHistory})
        '
        'gvPurchaseOrderHistory
        '
        Me.gvPurchaseOrderHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.gvPurchaseOrderHistory.GridControl = Me.gcPurchaseOrderHistory
        Me.gvPurchaseOrderHistory.Name = "gvPurchaseOrderHistory"
        Me.gvPurchaseOrderHistory.OptionsBehavior.Editable = False
        Me.gvPurchaseOrderHistory.OptionsView.EnableAppearanceOddRow = True
        Me.gvPurchaseOrderHistory.OptionsView.ShowAutoFilterRow = True
        Me.gvPurchaseOrderHistory.OptionsView.ShowFooter = True
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Purchase Order ID"
        Me.GridColumn4.FieldName = "PurchaseOrderID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Supplier"
        Me.GridColumn5.FieldName = "Name"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Purchase Order Date"
        Me.GridColumn6.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "PurchaseOrderDate"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Reference No"
        Me.GridColumn7.FieldName = "ReferenceNo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Stock ID"
        Me.GridColumn12.FieldName = "StockID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Stock ID"
        Me.GridColumn13.FieldName = "StockID"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        '
        'bbDelete
        '
        Me.bbDelete.Caption = "BarButtonItem1"
        Me.bbDelete.Id = 7
        Me.bbDelete.Name = "bbDelete"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 447)
        Me.Controls.Add(Me.xTab1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmPurchaseOrder"
        Me.Text = "Purchase Order"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTab1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcPurchaseOrderDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glupStockItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teReferenceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePurchaseOrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dePurchaseOrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lupSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcPurchaseOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPurchaseOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxvpSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDisplaySelected As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents xTab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcPurchaseOrderHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPurchaseOrderHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lblPurchaseOrderID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lupSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dePurchaseOrderDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents teReferenceNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcPurchaseOrderDescription As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPurchaseOrderDescription As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents glupStockItems As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dxvpSupplier As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents bbDelete As DevExpress.XtraBars.BarButtonItem
End Class
