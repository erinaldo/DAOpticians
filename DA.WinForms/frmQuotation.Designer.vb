<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotation
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.bbSave = New DevExpress.XtraBars.BarButtonItem
        Me.bbNew = New DevExpress.XtraBars.BarButtonItem
        Me.bbDelete = New DevExpress.XtraBars.BarButtonItem
        Me.bbDisplaySelected = New DevExpress.XtraBars.BarButtonItem
        Me.bbPrint1 = New DevExpress.XtraBars.BarButtonItem
        Me.bbRefresh = New DevExpress.XtraBars.BarButtonItem
        Me.bbClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.bbPrint = New DevExpress.XtraBars.BarButtonItem
        Me.bbShowAll = New DevExpress.XtraBars.BarButtonItem
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.xTab1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.teValidDays = New DevExpress.XtraEditors.TextEdit
        Me.lblID = New DevExpress.XtraEditors.LabelControl
        Me.teQuotationNo = New DevExpress.XtraEditors.TextEdit
        Me.teName = New DevExpress.XtraEditors.TextEdit
        Me.meNote = New DevExpress.XtraEditors.MemoExEdit
        Me.seOther = New DevExpress.XtraEditors.SpinEdit
        Me.teAddress3 = New DevExpress.XtraEditors.TextEdit
        Me.tePrescription = New DevExpress.XtraEditors.TextEdit
        Me.teAddress2 = New DevExpress.XtraEditors.TextEdit
        Me.teAddress1 = New DevExpress.XtraEditors.TextEdit
        Me.teOccupation = New DevExpress.XtraEditors.TextEdit
        Me.seTotalAmount = New DevExpress.XtraEditors.SpinEdit
        Me.seAge = New DevExpress.XtraEditors.SpinEdit
        Me.deQuotationDate = New DevExpress.XtraEditors.DateEdit
        Me.teFirm = New DevExpress.XtraEditors.TextEdit
        Me.seFrame = New DevExpress.XtraEditors.SpinEdit
        Me.seLense = New DevExpress.XtraEditors.SpinEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.gcQuotations = New DevExpress.XtraGrid.GridControl
        Me.gvQuotations = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dxvpQuotations = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTab1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.teValidDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teQuotationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seOther.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAddress3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePrescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAddress2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teOccupation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTotalAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deQuotationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFirm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seFrame.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLense.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcQuotations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQuotations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxvpQuotations, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbSave, Me.bbNew, Me.bbDelete, Me.bbClose, Me.bbPrint, Me.bbShowAll, Me.bbDisplaySelected, Me.bbRefresh, Me.bbPrint1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDisplaySelected), New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrint1), New DevExpress.XtraBars.LinkPersistInfo(Me.bbRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.bbClose)})
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
        'bbDelete
        '
        Me.bbDelete.Caption = "BarButtonItem3"
        Me.bbDelete.Id = 2
        Me.bbDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.bbDelete.Name = "bbDelete"
        '
        'bbDisplaySelected
        '
        Me.bbDisplaySelected.Caption = "BarButtonItem2"
        Me.bbDisplaySelected.Id = 6
        Me.bbDisplaySelected.Name = "bbDisplaySelected"
        '
        'bbPrint1
        '
        Me.bbPrint1.Caption = "BarButtonItem1"
        Me.bbPrint1.Id = 8
        Me.bbPrint1.Name = "bbPrint1"
        '
        'bbRefresh
        '
        Me.bbRefresh.Caption = "BarButtonItem3"
        Me.bbRefresh.Id = 7
        Me.bbRefresh.Name = "bbRefresh"
        '
        'bbClose
        '
        Me.bbClose.Caption = "BarButtonItem4"
        Me.bbClose.Id = 3
        Me.bbClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W))
        Me.bbClose.Name = "bbClose"
        '
        'bbPrint
        '
        Me.bbPrint.Caption = "BarButtonItem1"
        Me.bbPrint.Id = 4
        Me.bbPrint.Name = "bbPrint"
        '
        'bbShowAll
        '
        Me.bbShowAll.Caption = "BarButtonItem1"
        Me.bbShowAll.Id = 5
        Me.bbShowAll.Name = "bbShowAll"
        '
        'xTab1
        '
        Me.xTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xTab1.Location = New System.Drawing.Point(0, 24)
        Me.xTab1.Name = "xTab1"
        Me.xTab1.SelectedTabPage = Me.XtraTabPage1
        Me.xTab1.Size = New System.Drawing.Size(1028, 536)
        Me.xTab1.TabIndex = 4
        Me.xTab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1019, 505)
        Me.XtraTabPage1.Text = "New Record"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.teValidDays)
        Me.LayoutControl1.Controls.Add(Me.lblID)
        Me.LayoutControl1.Controls.Add(Me.teQuotationNo)
        Me.LayoutControl1.Controls.Add(Me.teName)
        Me.LayoutControl1.Controls.Add(Me.meNote)
        Me.LayoutControl1.Controls.Add(Me.seOther)
        Me.LayoutControl1.Controls.Add(Me.teAddress3)
        Me.LayoutControl1.Controls.Add(Me.tePrescription)
        Me.LayoutControl1.Controls.Add(Me.teAddress2)
        Me.LayoutControl1.Controls.Add(Me.teAddress1)
        Me.LayoutControl1.Controls.Add(Me.teOccupation)
        Me.LayoutControl1.Controls.Add(Me.seTotalAmount)
        Me.LayoutControl1.Controls.Add(Me.seAge)
        Me.LayoutControl1.Controls.Add(Me.deQuotationDate)
        Me.LayoutControl1.Controls.Add(Me.teFirm)
        Me.LayoutControl1.Controls.Add(Me.seFrame)
        Me.LayoutControl1.Controls.Add(Me.seLense)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsFocus.EnableAutoTabOrder = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1019, 505)
        Me.LayoutControl1.TabIndex = 27
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'teValidDays
        '
        Me.teValidDays.EnterMoveNextControl = True
        Me.teValidDays.Location = New System.Drawing.Point(607, 217)
        Me.teValidDays.Name = "teValidDays"
        Me.teValidDays.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teValidDays.Size = New System.Drawing.Size(406, 20)
        Me.teValidDays.StyleController = Me.LayoutControl1
        Me.teValidDays.TabIndex = 13
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(7, 7)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(1006, 13)
        Me.lblID.StyleController = Me.LayoutControl1
        Me.lblID.TabIndex = 17
        '
        'teQuotationNo
        '
        Me.teQuotationNo.EnterMoveNextControl = True
        Me.teQuotationNo.Location = New System.Drawing.Point(130, 62)
        Me.teQuotationNo.Name = "teQuotationNo"
        Me.teQuotationNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teQuotationNo.Properties.MaxLength = 20
        Me.teQuotationNo.Size = New System.Drawing.Size(343, 20)
        Me.teQuotationNo.StyleController = Me.LayoutControl1
        Me.teQuotationNo.TabIndex = 0
        '
        'teName
        '
        Me.teName.EnterMoveNextControl = True
        Me.teName.Location = New System.Drawing.Point(130, 93)
        Me.teName.Name = "teName"
        Me.teName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teName.Size = New System.Drawing.Size(343, 20)
        Me.teName.StyleController = Me.LayoutControl1
        Me.teName.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Can not be blank"
        Me.dxvpQuotations.SetValidationRule(Me.teName, ConditionValidationRule1)
        '
        'meNote
        '
        Me.meNote.EnterMoveNextControl = True
        Me.meNote.Location = New System.Drawing.Point(607, 279)
        Me.meNote.Name = "meNote"
        Me.meNote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meNote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meNote.Properties.ShowIcon = False
        Me.meNote.Properties.ShowPopupShadow = False
        Me.meNote.Size = New System.Drawing.Size(406, 20)
        Me.meNote.StyleController = Me.LayoutControl1
        Me.meNote.TabIndex = 15
        '
        'seOther
        '
        Me.seOther.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seOther.EnterMoveNextControl = True
        Me.seOther.Location = New System.Drawing.Point(607, 155)
        Me.seOther.Name = "seOther"
        Me.seOther.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seOther.Properties.DisplayFormat.FormatString = "F2"
        Me.seOther.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seOther.Properties.EditFormat.FormatString = "F2"
        Me.seOther.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seOther.Size = New System.Drawing.Size(406, 20)
        Me.seOther.StyleController = Me.LayoutControl1
        Me.seOther.TabIndex = 11
        '
        'teAddress3
        '
        Me.teAddress3.EnterMoveNextControl = True
        Me.teAddress3.Location = New System.Drawing.Point(130, 186)
        Me.teAddress3.Name = "teAddress3"
        Me.teAddress3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAddress3.Size = New System.Drawing.Size(343, 20)
        Me.teAddress3.StyleController = Me.LayoutControl1
        Me.teAddress3.TabIndex = 4
        '
        'tePrescription
        '
        Me.tePrescription.EnterMoveNextControl = True
        Me.tePrescription.Location = New System.Drawing.Point(607, 248)
        Me.tePrescription.Name = "tePrescription"
        Me.tePrescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tePrescription.Size = New System.Drawing.Size(406, 20)
        Me.tePrescription.StyleController = Me.LayoutControl1
        Me.tePrescription.TabIndex = 14
        '
        'teAddress2
        '
        Me.teAddress2.EnterMoveNextControl = True
        Me.teAddress2.Location = New System.Drawing.Point(130, 124)
        Me.teAddress2.Name = "teAddress2"
        Me.teAddress2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAddress2.Size = New System.Drawing.Size(343, 20)
        Me.teAddress2.StyleController = Me.LayoutControl1
        Me.teAddress2.TabIndex = 2
        '
        'teAddress1
        '
        Me.teAddress1.EnterMoveNextControl = True
        Me.teAddress1.Location = New System.Drawing.Point(130, 155)
        Me.teAddress1.Name = "teAddress1"
        Me.teAddress1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teAddress1.Size = New System.Drawing.Size(343, 20)
        Me.teAddress1.StyleController = Me.LayoutControl1
        Me.teAddress1.TabIndex = 3
        '
        'teOccupation
        '
        Me.teOccupation.EnterMoveNextControl = True
        Me.teOccupation.Location = New System.Drawing.Point(130, 279)
        Me.teOccupation.Name = "teOccupation"
        Me.teOccupation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teOccupation.Size = New System.Drawing.Size(343, 20)
        Me.teOccupation.StyleController = Me.LayoutControl1
        Me.teOccupation.TabIndex = 7
        '
        'seTotalAmount
        '
        Me.seTotalAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTotalAmount.EnterMoveNextControl = True
        Me.seTotalAmount.Location = New System.Drawing.Point(607, 186)
        Me.seTotalAmount.Name = "seTotalAmount"
        Me.seTotalAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTotalAmount.Properties.DisplayFormat.FormatString = "F2"
        Me.seTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalAmount.Properties.EditFormat.FormatString = "F2"
        Me.seTotalAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seTotalAmount.Size = New System.Drawing.Size(406, 20)
        Me.seTotalAmount.StyleController = Me.LayoutControl1
        Me.seTotalAmount.TabIndex = 12
        '
        'seAge
        '
        Me.seAge.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAge.EnterMoveNextControl = True
        Me.seAge.Location = New System.Drawing.Point(130, 217)
        Me.seAge.Name = "seAge"
        Me.seAge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAge.Size = New System.Drawing.Size(343, 20)
        Me.seAge.StyleController = Me.LayoutControl1
        Me.seAge.TabIndex = 5
        '
        'deQuotationDate
        '
        Me.deQuotationDate.EditValue = Nothing
        Me.deQuotationDate.EnterMoveNextControl = True
        Me.deQuotationDate.Location = New System.Drawing.Point(130, 248)
        Me.deQuotationDate.Name = "deQuotationDate"
        Me.deQuotationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deQuotationDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.deQuotationDate.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.deQuotationDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deQuotationDate.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.deQuotationDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deQuotationDate.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.deQuotationDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deQuotationDate.Size = New System.Drawing.Size(343, 20)
        Me.deQuotationDate.StyleController = Me.LayoutControl1
        Me.deQuotationDate.TabIndex = 6
        '
        'teFirm
        '
        Me.teFirm.EnterMoveNextControl = True
        Me.teFirm.Location = New System.Drawing.Point(607, 62)
        Me.teFirm.Name = "teFirm"
        Me.teFirm.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teFirm.Size = New System.Drawing.Size(406, 20)
        Me.teFirm.StyleController = Me.LayoutControl1
        Me.teFirm.TabIndex = 8
        '
        'seFrame
        '
        Me.seFrame.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seFrame.EnterMoveNextControl = True
        Me.seFrame.Location = New System.Drawing.Point(607, 93)
        Me.seFrame.Name = "seFrame"
        Me.seFrame.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seFrame.Properties.DisplayFormat.FormatString = "F2"
        Me.seFrame.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seFrame.Properties.EditFormat.FormatString = "F2"
        Me.seFrame.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seFrame.Size = New System.Drawing.Size(406, 20)
        Me.seFrame.StyleController = Me.LayoutControl1
        Me.seFrame.TabIndex = 9
        '
        'seLense
        '
        Me.seLense.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seLense.EnterMoveNextControl = True
        Me.seLense.Location = New System.Drawing.Point(607, 124)
        Me.seLense.Name = "seLense"
        Me.seLense.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seLense.Properties.DisplayFormat.FormatString = "F2"
        Me.seLense.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seLense.Properties.EditFormat.FormatString = "F2"
        Me.seLense.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seLense.Size = New System.Drawing.Size(406, 20)
        Me.seLense.StyleController = Me.LayoutControl1
        Me.seLense.TabIndex = 10
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem5, Me.LayoutControlItem17, Me.EmptySpaceItem4, Me.LayoutControlItem18})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1019, 505)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.teName
        Me.LayoutControlItem1.CustomizationFormText = "Customer Name"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem1.Text = "Customer Name"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.teAddress2
        Me.LayoutControlItem3.CustomizationFormText = "Address"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem3.Text = "Address"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.teAddress1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(123, 148)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(354, 31)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.teAddress3
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(123, 179)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(354, 31)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.deQuotationDate
        Me.LayoutControlItem8.CustomizationFormText = "Date"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 241)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem8.Text = "Date"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.teOccupation
        Me.LayoutControlItem6.CustomizationFormText = "Occupation"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 272)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem6.Text = "Occupation"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.seAge
        Me.LayoutControlItem7.CustomizationFormText = "Age"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem7.Text = "Age"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.teFirm
        Me.LayoutControlItem9.CustomizationFormText = "Firm Or Institute"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(477, 55)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem9.Text = "Firm Or Institute"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.seFrame
        Me.LayoutControlItem10.CustomizationFormText = "Price of Spectacle Frame"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(477, 86)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem10.Text = "Price of Spectacle Frame"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.seLense
        Me.LayoutControlItem11.CustomizationFormText = "Price of Paire of Lense"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(477, 117)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem11.Text = "Price of Paire of Lense"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.seOther
        Me.LayoutControlItem12.CustomizationFormText = "Others"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(477, 148)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem12.Text = "Others"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.seTotalAmount
        Me.LayoutControlItem13.CustomizationFormText = "Total Amount"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(477, 179)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem13.Text = "Total Amount"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.tePrescription
        Me.LayoutControlItem15.CustomizationFormText = "Prescription"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(477, 241)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem15.Text = "Prescription"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.meNote
        Me.LayoutControlItem16.CustomizationFormText = "Note"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(477, 272)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem16.Text = "Note"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(118, 20)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 303)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1017, 200)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 148)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(123, 0)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(123, 10)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(123, 31)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 179)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(123, 0)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(123, 10)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(123, 31)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.teQuotationNo
        Me.LayoutControlItem5.CustomizationFormText = "Quotation No"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(477, 31)
        Me.LayoutControlItem5.Text = "Quotation No"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(118, 20)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.lblID
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(1017, 24)
        Me.LayoutControlItem17.Text = "LayoutControlItem17"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextToControlDistance = 0
        Me.LayoutControlItem17.TextVisible = False
        Me.LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(0, 31)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(10, 31)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1017, 31)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.teValidDays
        Me.LayoutControlItem18.CustomizationFormText = "Valid Days"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(477, 210)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(540, 31)
        Me.LayoutControlItem18.Text = "Valid Days"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(118, 20)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcQuotations)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1019, 505)
        Me.XtraTabPage2.Text = "History Data"
        '
        'gcQuotations
        '
        Me.gcQuotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQuotations.Location = New System.Drawing.Point(0, 0)
        Me.gcQuotations.MainView = Me.gvQuotations
        Me.gcQuotations.Name = "gcQuotations"
        Me.gcQuotations.Size = New System.Drawing.Size(1019, 505)
        Me.gcQuotations.TabIndex = 1
        Me.gcQuotations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQuotations})
        '
        'gvQuotations
        '
        Me.gvQuotations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.gvQuotations.GridControl = Me.gcQuotations
        Me.gvQuotations.Name = "gvQuotations"
        Me.gvQuotations.OptionsBehavior.Editable = False
        Me.gvQuotations.OptionsView.ColumnAutoWidth = False
        Me.gvQuotations.OptionsView.EnableAppearanceOddRow = True
        Me.gvQuotations.OptionsView.ShowAutoFilterRow = True
        Me.gvQuotations.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "QuotationID"
        Me.GridColumn1.FieldName = "QuotationID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "QuotationNo"
        Me.GridColumn2.FieldName = "QuotationNo"
        Me.GridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 85
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "CustomerName"
        Me.GridColumn3.FieldName = "CustomerName"
        Me.GridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 216
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Address1"
        Me.GridColumn4.FieldName = "Address1"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 223
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Address2"
        Me.GridColumn5.FieldName = "Address2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 85
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Address3"
        Me.GridColumn6.FieldName = "Address3"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 85
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Age"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Age"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Date"
        Me.GridColumn8.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "Date"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Occupation"
        Me.GridColumn9.FieldName = "Occupation"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 85
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Firm"
        Me.GridColumn10.FieldName = "Firm"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 100
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Frame"
        Me.GridColumn11.DisplayFormat.FormatString = "F2"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Frame"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Lense"
        Me.GridColumn12.DisplayFormat.FormatString = "F2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Lense"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Others"
        Me.GridColumn13.DisplayFormat.FormatString = "F2"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "Others"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 11
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Total"
        Me.GridColumn14.DisplayFormat.FormatString = "F2"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "Total"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Valid Days"
        Me.GridColumn15.FieldName = "Valid Days"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 13
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Prescription"
        Me.GridColumn16.FieldName = "Prescription"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 14
        Me.GridColumn16.Width = 100
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Remarks"
        Me.GridColumn17.FieldName = "Remarks"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 15
        Me.GridColumn17.Width = 100
        '
        'frmQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 560)
        Me.Controls.Add(Me.xTab1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Name = "frmQuotation"
        Me.Text = "Quotation"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTab1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.teValidDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teQuotationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seOther.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAddress3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePrescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAddress2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teOccupation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTotalAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deQuotationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deQuotationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFirm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seFrame.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLense.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.gcQuotations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQuotations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxvpQuotations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbShowAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDisplaySelected As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents xTab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents teName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents meNote As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents seOther As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents teAddress3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePrescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teAddress2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teAddress1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teOccupation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents seTotalAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seAge As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents deQuotationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teFirm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents seFrame As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seLense As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcQuotations As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQuotations As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teQuotationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dxvpQuotations As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bbPrint1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents teValidDays As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
End Class
