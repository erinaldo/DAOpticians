<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOrder
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
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.bbSave = New DevExpress.XtraBars.BarButtonItem
        Me.bbNew = New DevExpress.XtraBars.BarButtonItem
        Me.bbDelete = New DevExpress.XtraBars.BarButtonItem
        Me.bbDisplaySelected = New DevExpress.XtraBars.BarButtonItem
        Me.bbRefresh = New DevExpress.XtraBars.BarButtonItem
        Me.bbClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.xTab1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.seOthers = New DevExpress.XtraEditors.SpinEdit
        Me.sePP = New DevExpress.XtraEditors.SpinEdit
        Me.seBTT = New DevExpress.XtraEditors.SpinEdit
        Me.seVAT = New DevExpress.XtraEditors.SpinEdit
        Me.seCMNO = New DevExpress.XtraEditors.SpinEdit
        Me.leSupplierID = New DevExpress.XtraEditors.LookUpEdit
        Me.seAmount = New DevExpress.XtraEditors.SpinEdit
        Me.deDate = New DevExpress.XtraEditors.DateEdit
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.gcPOrder = New DevExpress.XtraGrid.GridControl
        Me.gvPOrder = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dxvpPOrder = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bbPrint = New DevExpress.XtraBars.BarButtonItem
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTab1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.seOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seCMNO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSupplierID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcPOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxvpPOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbSave, Me.bbNew, Me.bbDelete, Me.bbDisplaySelected, Me.bbRefresh, Me.bbClose, Me.bbPrint})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDisplaySelected), New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.bbClose)})
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
        'bbDelete
        '
        Me.bbDelete.Caption = "BarButtonItem3"
        Me.bbDelete.Id = 2
        Me.bbDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.bbDelete.Name = "bbDelete"
        '
        'bbDisplaySelected
        '
        Me.bbDisplaySelected.Caption = "BarButtonItem4"
        Me.bbDisplaySelected.Id = 3
        Me.bbDisplaySelected.Name = "bbDisplaySelected"
        '
        'bbRefresh
        '
        Me.bbRefresh.Caption = "BarButtonItem5"
        Me.bbRefresh.Id = 4
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
        Me.xTab1.Size = New System.Drawing.Size(676, 411)
        Me.xTab1.TabIndex = 4
        Me.xTab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(667, 380)
        Me.XtraTabPage1.Text = "New Record"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.seOthers)
        Me.LayoutControl1.Controls.Add(Me.sePP)
        Me.LayoutControl1.Controls.Add(Me.seBTT)
        Me.LayoutControl1.Controls.Add(Me.seVAT)
        Me.LayoutControl1.Controls.Add(Me.seCMNO)
        Me.LayoutControl1.Controls.Add(Me.leSupplierID)
        Me.LayoutControl1.Controls.Add(Me.seAmount)
        Me.LayoutControl1.Controls.Add(Me.deDate)
        Me.LayoutControl1.Controls.Add(Me.lblID)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(667, 380)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'seOthers
        '
        Me.seOthers.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seOthers.EnterMoveNextControl = True
        Me.seOthers.Location = New System.Drawing.Point(257, 279)
        Me.seOthers.Name = "seOthers"
        Me.seOthers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seOthers.Size = New System.Drawing.Size(197, 20)
        Me.seOthers.StyleController = Me.LayoutControl1
        Me.seOthers.TabIndex = 5
        '
        'sePP
        '
        Me.sePP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePP.EnterMoveNextControl = True
        Me.sePP.Location = New System.Drawing.Point(257, 248)
        Me.sePP.Name = "sePP"
        Me.sePP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePP.Size = New System.Drawing.Size(197, 20)
        Me.sePP.StyleController = Me.LayoutControl1
        Me.sePP.TabIndex = 4
        '
        'seBTT
        '
        Me.seBTT.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seBTT.EnterMoveNextControl = True
        Me.seBTT.Location = New System.Drawing.Point(257, 217)
        Me.seBTT.Name = "seBTT"
        Me.seBTT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seBTT.Size = New System.Drawing.Size(197, 20)
        Me.seBTT.StyleController = Me.LayoutControl1
        Me.seBTT.TabIndex = 3
        '
        'seVAT
        '
        Me.seVAT.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seVAT.EnterMoveNextControl = True
        Me.seVAT.Location = New System.Drawing.Point(257, 186)
        Me.seVAT.Name = "seVAT"
        Me.seVAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seVAT.Size = New System.Drawing.Size(197, 20)
        Me.seVAT.StyleController = Me.LayoutControl1
        Me.seVAT.TabIndex = 2
        '
        'seCMNO
        '
        Me.seCMNO.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seCMNO.EnterMoveNextControl = True
        Me.seCMNO.Location = New System.Drawing.Point(257, 124)
        Me.seCMNO.Name = "seCMNO"
        Me.seCMNO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seCMNO.Size = New System.Drawing.Size(197, 20)
        Me.seCMNO.StyleController = Me.LayoutControl1
        Me.seCMNO.TabIndex = 0
        '
        'leSupplierID
        '
        Me.leSupplierID.EnterMoveNextControl = True
        Me.leSupplierID.Location = New System.Drawing.Point(257, 62)
        Me.leSupplierID.Name = "leSupplierID"
        Me.leSupplierID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSupplierID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Supplier Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.leSupplierID.Properties.NullText = ""
        Me.leSupplierID.Size = New System.Drawing.Size(197, 20)
        Me.leSupplierID.StyleController = Me.LayoutControl1
        Me.leSupplierID.TabIndex = 10
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Can not be blank"
        Me.dxvpPOrder.SetValidationRule(Me.leSupplierID, ConditionValidationRule1)
        '
        'seAmount
        '
        Me.seAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAmount.EnterMoveNextControl = True
        Me.seAmount.Location = New System.Drawing.Point(257, 155)
        Me.seAmount.Name = "seAmount"
        Me.seAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAmount.Properties.DisplayFormat.FormatString = "F"
        Me.seAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seAmount.Size = New System.Drawing.Size(197, 20)
        Me.seAmount.StyleController = Me.LayoutControl1
        Me.seAmount.TabIndex = 1
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.EnterMoveNextControl = True
        Me.deDate.Location = New System.Drawing.Point(257, 93)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.deDate.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.deDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDate.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.deDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deDate.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.deDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDate.Size = New System.Drawing.Size(197, 20)
        Me.deDate.StyleController = Me.LayoutControl1
        Me.deDate.TabIndex = 5
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Can not be blank"
        Me.dxvpPOrder.SetValidationRule(Me.deDate, ConditionValidationRule2)
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(214, 38)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(240, 13)
        Me.lblID.StyleController = Me.LayoutControl1
        Me.lblID.TabIndex = 9
        Me.lblID.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem3, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(667, 380)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lblID
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(207, 31)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(251, 24)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.leSupplierID
        Me.LayoutControlItem7.CustomizationFormText = "Supplier"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(207, 55)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem7.Text = "Supplier"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.deDate
        Me.LayoutControlItem2.CustomizationFormText = "Date"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(207, 86)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem2.Text = "Date"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.seCMNO
        Me.LayoutControlItem8.CustomizationFormText = "CMNO"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(207, 117)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem8.Text = "CMNO"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.seVAT
        Me.LayoutControlItem9.CustomizationFormText = "VAT"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(207, 179)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem9.Text = "VAT"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.seAmount
        Me.LayoutControlItem3.CustomizationFormText = "Amount"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(207, 148)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem3.Text = "Amount"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.seBTT
        Me.LayoutControlItem10.CustomizationFormText = "BTT"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(207, 210)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem10.Text = "BTT"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.sePP
        Me.LayoutControlItem11.CustomizationFormText = "PP"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(207, 241)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(251, 31)
        Me.LayoutControlItem11.Text = "PP"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(38, 20)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.seOthers
        Me.LayoutControlItem12.CustomizationFormText = "Others"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(207, 272)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(251, 106)
        Me.LayoutControlItem12.Text = "Others"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(38, 20)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(458, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(207, 378)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(207, 378)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(207, 0)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(0, 31)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 31)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(251, 31)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcPOrder)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(667, 404)
        Me.XtraTabPage2.Text = "History Record"
        '
        'gcPOrder
        '
        Me.gcPOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPOrder.Location = New System.Drawing.Point(0, 0)
        Me.gcPOrder.MainView = Me.gvPOrder
        Me.gcPOrder.Name = "gcPOrder"
        Me.gcPOrder.Size = New System.Drawing.Size(667, 404)
        Me.gcPOrder.TabIndex = 0
        Me.gcPOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOrder, Me.GridView2})
        '
        'gvPOrder
        '
        Me.gvPOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.gvPOrder.GridControl = Me.gcPOrder
        Me.gvPOrder.Name = "gvPOrder"
        Me.gvPOrder.OptionsBehavior.Editable = False
        Me.gvPOrder.OptionsView.EnableAppearanceOddRow = True
        Me.gvPOrder.OptionsView.ShowAutoFilterRow = True
        Me.gvPOrder.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "POID"
        Me.GridColumn1.FieldName = "POID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Supplier Name"
        Me.GridColumn2.FieldName = "Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.SummaryItem.FieldName = "SupplierID"
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Date"
        Me.GridColumn3.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Date"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CMNO"
        Me.GridColumn4.DisplayFormat.FormatString = "F2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "CMNO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Amount"
        Me.GridColumn5.DisplayFormat.FormatString = "F2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Amount"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "VAT"
        Me.GridColumn6.DisplayFormat.FormatString = "F2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "VAT"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "BTT"
        Me.GridColumn7.DisplayFormat.FormatString = "F2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "BTT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "PP"
        Me.GridColumn8.DisplayFormat.FormatString = "F2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "PP"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Others"
        Me.GridColumn9.DisplayFormat.FormatString = "F2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Others"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcPOrder
        Me.GridView2.Name = "GridView2"
        '
        'bbPrint
        '
        Me.bbPrint.Caption = "BarButtonItem1"
        Me.bbPrint.Id = 6
        Me.bbPrint.Name = "bbPrint"
        '
        'frmPOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 459)
        Me.Controls.Add(Me.xTab1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmPOrder"
        Me.Text = "Purchase Order"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTab1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.seOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seCMNO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSupplierID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcPOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxvpPOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDisplaySelected As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents xTab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcPOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents seAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dxvpPOrder As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leSupplierID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents seVAT As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seCMNO As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents seOthers As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sePP As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seBTT As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bbPrint As DevExpress.XtraBars.BarButtonItem
End Class
