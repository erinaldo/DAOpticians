<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.bbSave = New DevExpress.XtraBars.BarButtonItem
        Me.bbNew = New DevExpress.XtraBars.BarButtonItem
        Me.bbDelete = New DevExpress.XtraBars.BarButtonItem
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
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit
        Me.cbeType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cbePaymentType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.meNote = New DevExpress.XtraEditors.MemoExEdit
        Me.seAmount = New DevExpress.XtraEditors.SpinEdit
        Me.lupExpenseType = New DevExpress.XtraEditors.LookUpEdit
        Me.deDate = New DevExpress.XtraEditors.DateEdit
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl
        Me.sbProcess = New DevExpress.XtraEditors.SimpleButton
        Me.deTo = New DevExpress.XtraEditors.DateEdit
        Me.deFrom = New DevExpress.XtraEditors.DateEdit
        Me.gcExpenses = New DevExpress.XtraGrid.GridControl
        Me.gvExpenses = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.dxvpExpenses = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTab1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbePaymentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lupExpenseType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.deTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxvpExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bbSave.Name = "bbSave"
        '
        'bbNew
        '
        Me.bbNew.Caption = "BarButtonItem2"
        Me.bbNew.Id = 1
        Me.bbNew.Name = "bbNew"
        '
        'bbDelete
        '
        Me.bbDelete.Caption = "BarButtonItem3"
        Me.bbDelete.Id = 2
        Me.bbDelete.Name = "bbDelete"
        '
        'bbDisplaySelected
        '
        Me.bbDisplaySelected.Caption = "BarButtonItem4"
        Me.bbDisplaySelected.Id = 3
        Me.bbDisplaySelected.Name = "bbDisplaySelected"
        '
        'bbPrint
        '
        Me.bbPrint.Caption = "BarButtonItem1"
        Me.bbPrint.Id = 6
        Me.bbPrint.Name = "bbPrint"
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
        Me.bbClose.Name = "bbClose"
        '
        'xTab1
        '
        Me.xTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xTab1.Location = New System.Drawing.Point(0, 48)
        Me.xTab1.Name = "xTab1"
        Me.xTab1.SelectedTabPage = Me.XtraTabPage1
        Me.xTab1.Size = New System.Drawing.Size(537, 283)
        Me.xTab1.TabIndex = 4
        Me.xTab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(528, 252)
        Me.XtraTabPage1.Text = "New Record"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtDescription)
        Me.LayoutControl1.Controls.Add(Me.cbeType)
        Me.LayoutControl1.Controls.Add(Me.cbePaymentType)
        Me.LayoutControl1.Controls.Add(Me.meNote)
        Me.LayoutControl1.Controls.Add(Me.seAmount)
        Me.LayoutControl1.Controls.Add(Me.lupExpenseType)
        Me.LayoutControl1.Controls.Add(Me.deDate)
        Me.LayoutControl1.Controls.Add(Me.lblID)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(528, 252)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtDescription
        '
        Me.txtDescription.EnterMoveNextControl = True
        Me.txtDescription.Location = New System.Drawing.Point(81, 63)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Properties.MaxLength = 50
        Me.txtDescription.Size = New System.Drawing.Size(180, 20)
        Me.txtDescription.StyleController = Me.LayoutControl1
        Me.txtDescription.TabIndex = 11
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Can not be blank"
        Me.dxvpExpenses.SetValidationRule(Me.txtDescription, ConditionValidationRule1)
        '
        'cbeType
        '
        Me.cbeType.EnterMoveNextControl = True
        Me.cbeType.Location = New System.Drawing.Point(81, 32)
        Me.cbeType.Name = "cbeType"
        Me.cbeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeType.Properties.Items.AddRange(New Object() {"OTHER INCOME", "EXPENSE"})
        Me.cbeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbeType.Size = New System.Drawing.Size(180, 20)
        Me.cbeType.StyleController = Me.LayoutControl1
        Me.cbeType.TabIndex = 10
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Can not be blank"
        Me.dxvpExpenses.SetValidationRule(Me.cbeType, ConditionValidationRule2)
        '
        'cbePaymentType
        '
        Me.cbePaymentType.EditValue = "CASH"
        Me.cbePaymentType.EnterMoveNextControl = True
        Me.cbePaymentType.Location = New System.Drawing.Point(81, 125)
        Me.cbePaymentType.Name = "cbePaymentType"
        Me.cbePaymentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbePaymentType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbePaymentType.Properties.Items.AddRange(New Object() {"CASH", "CHECK", "C.CARD"})
        Me.cbePaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbePaymentType.Size = New System.Drawing.Size(180, 20)
        Me.cbePaymentType.StyleController = Me.LayoutControl1
        Me.cbePaymentType.TabIndex = 8
        '
        'meNote
        '
        Me.meNote.EnterMoveNextControl = True
        Me.meNote.Location = New System.Drawing.Point(81, 218)
        Me.meNote.Name = "meNote"
        Me.meNote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meNote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meNote.Properties.PopupStartSize = New System.Drawing.Size(400, 150)
        Me.meNote.Properties.ShowIcon = False
        Me.meNote.Size = New System.Drawing.Size(180, 20)
        Me.meNote.StyleController = Me.LayoutControl1
        Me.meNote.TabIndex = 7
        '
        'seAmount
        '
        Me.seAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAmount.EnterMoveNextControl = True
        Me.seAmount.Location = New System.Drawing.Point(81, 187)
        Me.seAmount.Name = "seAmount"
        Me.seAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAmount.Properties.DisplayFormat.FormatString = "F"
        Me.seAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seAmount.Size = New System.Drawing.Size(180, 20)
        Me.seAmount.StyleController = Me.LayoutControl1
        Me.seAmount.TabIndex = 6
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater
        ConditionValidationRule3.ErrorText = "Must be greater than 0"
        ConditionValidationRule3.Value1 = New Decimal(New Integer() {0, 0, 0, 0})
        Me.dxvpExpenses.SetValidationRule(Me.seAmount, ConditionValidationRule3)
        '
        'lupExpenseType
        '
        Me.lupExpenseType.EnterMoveNextControl = True
        Me.lupExpenseType.Location = New System.Drawing.Point(81, 94)
        Me.lupExpenseType.Name = "lupExpenseType"
        Me.lupExpenseType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Save", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing)})
        Me.lupExpenseType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lupExpenseType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Expense Type", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.lupExpenseType.Properties.NullText = ""
        Me.lupExpenseType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lupExpenseType.Size = New System.Drawing.Size(180, 20)
        Me.lupExpenseType.StyleController = Me.LayoutControl1
        Me.lupExpenseType.TabIndex = 4
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.EnterMoveNextControl = True
        Me.deDate.Location = New System.Drawing.Point(81, 156)
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
        Me.deDate.Size = New System.Drawing.Size(180, 20)
        Me.deDate.StyleController = Me.LayoutControl1
        Me.deDate.TabIndex = 5
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(270, 7)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(252, 13)
        Me.lblID.StyleController = Me.LayoutControl1
        Me.lblID.TabIndex = 9
        Me.lblID.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(528, 252)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lupExpenseType
        Me.LayoutControlItem1.CustomizationFormText = "Expense Type"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 87)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem1.Text = "Expense Type"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 20)
        Me.LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.deDate
        Me.LayoutControlItem2.CustomizationFormText = "Date"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 149)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem2.Text = "Date"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.seAmount
        Me.LayoutControlItem3.CustomizationFormText = "Amount"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem3.Text = "Amount"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.meNote
        Me.LayoutControlItem4.CustomizationFormText = "Note"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 211)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(265, 39)
        Me.LayoutControlItem4.Text = "Note"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 20)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 25)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 25)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(263, 25)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(265, 25)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(261, 225)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbePaymentType
        Me.LayoutControlItem5.CustomizationFormText = "Payment Type"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 118)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem5.Text = "Payment Type"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lblID
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(263, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(263, 25)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbeType
        Me.LayoutControlItem7.CustomizationFormText = "Type"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem7.Text = "Type"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtDescription
        Me.LayoutControlItem8.CustomizationFormText = "Description"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(265, 31)
        Me.LayoutControlItem8.Text = "Description"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 20)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(528, 252)
        Me.XtraTabPage2.Text = "History Record"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.sbProcess)
        Me.LayoutControl2.Controls.Add(Me.deTo)
        Me.LayoutControl2.Controls.Add(Me.deFrom)
        Me.LayoutControl2.Controls.Add(Me.gcExpenses)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(528, 252)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'sbProcess
        '
        Me.sbProcess.Location = New System.Drawing.Point(364, 4)
        Me.sbProcess.Name = "sbProcess"
        Me.sbProcess.Size = New System.Drawing.Size(175, 28)
        Me.sbProcess.StyleController = Me.LayoutControl2
        Me.sbProcess.TabIndex = 6
        Me.sbProcess.Text = "Process"
        '
        'deTo
        '
        Me.deTo.EditValue = Nothing
        Me.deTo.Location = New System.Drawing.Point(216, 7)
        Me.deTo.Name = "deTo"
        Me.deTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTo.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTo.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.deTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTo.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.deTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deTo.Size = New System.Drawing.Size(140, 20)
        Me.deTo.StyleController = Me.LayoutControl2
        Me.deTo.TabIndex = 5
        '
        'deFrom
        '
        Me.deFrom.EditValue = Nothing
        Me.deFrom.Location = New System.Drawing.Point(36, 7)
        Me.deFrom.Name = "deFrom"
        Me.deFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFrom.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFrom.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.deFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deFrom.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.deFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFrom.Size = New System.Drawing.Size(140, 20)
        Me.deFrom.StyleController = Me.LayoutControl2
        Me.deFrom.TabIndex = 4
        '
        'gcExpenses
        '
        Me.gcExpenses.Location = New System.Drawing.Point(7, 40)
        Me.gcExpenses.MainView = Me.gvExpenses
        Me.gcExpenses.Name = "gcExpenses"
        Me.gcExpenses.Size = New System.Drawing.Size(539, 189)
        Me.gcExpenses.TabIndex = 0
        Me.gcExpenses.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExpenses, Me.GridView2})
        '
        'gvExpenses
        '
        Me.gvExpenses.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn7, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvExpenses.GridControl = Me.gcExpenses
        Me.gvExpenses.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Me.GridColumn5, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Expense ID", Me.GridColumn1, "")})
        Me.gvExpenses.Name = "gvExpenses"
        Me.gvExpenses.OptionsBehavior.Editable = False
        Me.gvExpenses.OptionsView.EnableAppearanceOddRow = True
        Me.gvExpenses.OptionsView.ShowAutoFilterRow = True
        Me.gvExpenses.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Expense ID"
        Me.GridColumn1.FieldName = "ExpenseID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Type"
        Me.GridColumn2.FieldName = "Type"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.SummaryItem.FieldName = "ExpenseType"
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Description"
        Me.GridColumn7.FieldName = "Description"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Payment Type"
        Me.GridColumn3.FieldName = "PaymentType"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Date"
        Me.GridColumn4.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "ExpenseDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Amount"
        Me.GridColumn5.DisplayFormat.FormatString = "F2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Amount"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Note"
        Me.GridColumn6.FieldName = "Note"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcExpenses
        Me.GridView2.Name = "GridView2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(552, 235)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.gcExpenses
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(550, 200)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.deFrom
        Me.LayoutControlItem10.CustomizationFormText = "From"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(180, 31)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(180, 31)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(180, 33)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "From"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(24, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.deTo
        Me.LayoutControlItem11.CustomizationFormText = "To"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(180, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(180, 31)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(180, 31)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(180, 33)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "To"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(24, 20)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.sbProcess
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(360, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(180, 33)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(180, 33)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlItem12.Size = New System.Drawing.Size(180, 33)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "LayoutControlItem12"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(540, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 33)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 331)
        Me.Controls.Add(Me.xTab1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmExpenses"
        Me.Text = "Other Income / Expenses"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTab1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbePaymentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lupExpenseType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.deTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxvpExpenses, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gcExpenses As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExpenses As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lupExpenseType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents seAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbePaymentType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dxvpExpenses As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cbeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
