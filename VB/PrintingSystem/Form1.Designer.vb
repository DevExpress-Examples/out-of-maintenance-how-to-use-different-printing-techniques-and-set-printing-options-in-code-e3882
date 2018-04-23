Imports Microsoft.VisualBasic
Imports System
Namespace RichEdit_PrintingSystem
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btn_PrintFromServer = New DevExpress.XtraEditors.SimpleButton()
			Me.btn_PrintControlViaPrintingLink = New DevExpress.XtraEditors.SimpleButton()
			Me.btn_PrintControlWithOptions = New DevExpress.XtraEditors.SimpleButton()
			Me.barManager1 = New DevExpress.XtraBars.BarManager()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.pageSetupBar1 = New DevExpress.XtraRichEdit.UI.PageSetupBar()
			Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
			Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
			Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
			Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
			Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
			Me.showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
			Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
			Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
			Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
			Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
			Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
			Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
			Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
			Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
			Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
			Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
			Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
			Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
			Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
			Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
			Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
			Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
			Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
			Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
			Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
			Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
			Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
			Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
			Me.documentViewsBar1 = New DevExpress.XtraRichEdit.UI.DocumentViewsBar()
			Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
			Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
			Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
			Me.showBar1 = New DevExpress.XtraRichEdit.UI.ShowBar()
			Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
			Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
			Me.zoomBar1 = New DevExpress.XtraRichEdit.UI.ZoomBar()
			Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
			Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 86)
			Me.richEditControl1.MenuManager = Me.barManager1
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(897, 448)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
			Me.richEditBarController1.BarItems.Add(Me.showPageMarginsSetupFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
			Me.richEditBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
			Me.richEditBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
			Me.richEditBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertBreakItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertColumnBreakItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
			Me.richEditBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
			Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
			Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
			Me.richEditBarController1.BarItems.Add(Me.zoomOutItem1)
			Me.richEditBarController1.BarItems.Add(Me.zoomInItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl1
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btn_PrintFromServer)
			Me.panelControl1.Controls.Add(Me.btn_PrintControlViaPrintingLink)
			Me.panelControl1.Controls.Add(Me.btn_PrintControlWithOptions)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 31)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(897, 55)
			Me.panelControl1.TabIndex = 1
			' 
			' btn_PrintFromServer
			' 
			Me.btn_PrintFromServer.Location = New System.Drawing.Point(498, 12)
			Me.btn_PrintFromServer.Name = "btn_PrintFromServer"
			Me.btn_PrintFromServer.Size = New System.Drawing.Size(195, 23)
			Me.btn_PrintFromServer.TabIndex = 2
			Me.btn_PrintFromServer.Text = "Print from RichEditDocumentServer"
'			Me.btn_PrintFromServer.Click += New System.EventHandler(Me.btn_PrintFromServer_Click);
			' 
			' btn_PrintControlViaPrintingLink
			' 
			Me.btn_PrintControlViaPrintingLink.Location = New System.Drawing.Point(255, 12)
			Me.btn_PrintControlViaPrintingLink.Name = "btn_PrintControlViaPrintingLink"
			Me.btn_PrintControlViaPrintingLink.Size = New System.Drawing.Size(195, 23)
			Me.btn_PrintControlViaPrintingLink.TabIndex = 1
			Me.btn_PrintControlViaPrintingLink.Text = "Print Control Via Printing Link"
'			Me.btn_PrintControlViaPrintingLink.Click += New System.EventHandler(Me.btn_PrintControlViaPrintingLink_Click);
			' 
			' btn_PrintControlWithOptions
			' 
			Me.btn_PrintControlWithOptions.Location = New System.Drawing.Point(12, 12)
			Me.btn_PrintControlWithOptions.Name = "btn_PrintControlWithOptions"
			Me.btn_PrintControlWithOptions.Size = New System.Drawing.Size(195, 23)
			Me.btn_PrintControlWithOptions.TabIndex = 0
			Me.btn_PrintControlWithOptions.Text = "Set Print Options and Print"
'			Me.btn_PrintControlWithOptions.Click += New System.EventHandler(Me.btn_PrintControlWithOptions_Click);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar3, Me.pageSetupBar1, Me.documentViewsBar1, Me.showBar1, Me.zoomBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1})
			Me.barManager1.MaxItemId = 35
			Me.barManager1.StatusBar = Me.bar3
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(897, 31)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 534)
			Me.barDockControlBottom.Size = New System.Drawing.Size(897, 23)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 503)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(897, 31)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 503)
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' pageSetupBar1
			' 
			Me.pageSetupBar1.DockCol = 1
			Me.pageSetupBar1.DockRow = 0
			Me.pageSetupBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.pageSetupBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionPaperKindItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSectionLineNumberingItem1)})
			Me.pageSetupBar1.Offset = 132
			' 
			' changeSectionPageMarginsItem1
			' 
			Me.changeSectionPageMarginsItem1.Id = 0
			Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1)})
			Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
			' 
			' setNormalSectionPageMarginsItem1
			' 
			Me.setNormalSectionPageMarginsItem1.Id = 1
			Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
			' 
			' setNarrowSectionPageMarginsItem1
			' 
			Me.setNarrowSectionPageMarginsItem1.Id = 2
			Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
			' 
			' setModerateSectionPageMarginsItem1
			' 
			Me.setModerateSectionPageMarginsItem1.Id = 3
			Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
			' 
			' setWideSectionPageMarginsItem1
			' 
			Me.setWideSectionPageMarginsItem1.Id = 4
			Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
			' 
			' showPageMarginsSetupFormItem1
			' 
			Me.showPageMarginsSetupFormItem1.Id = 5
			Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
			' 
			' changeSectionPageOrientationItem1
			' 
			Me.changeSectionPageOrientationItem1.Id = 6
			Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1)})
			Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
			' 
			' setPortraitPageOrientationItem1
			' 
			Me.setPortraitPageOrientationItem1.Id = 7
			Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
			' 
			' setLandscapePageOrientationItem1
			' 
			Me.setLandscapePageOrientationItem1.Id = 8
			Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
			' 
			' changeSectionPaperKindItem1
			' 
			Me.changeSectionPaperKindItem1.Id = 9
			Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
			' 
			' changeSectionColumnsItem1
			' 
			Me.changeSectionColumnsItem1.Id = 10
			Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1)})
			Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
			' 
			' setSectionOneColumnItem1
			' 
			Me.setSectionOneColumnItem1.Id = 11
			Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
			' 
			' setSectionTwoColumnsItem1
			' 
			Me.setSectionTwoColumnsItem1.Id = 12
			Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
			' 
			' setSectionThreeColumnsItem1
			' 
			Me.setSectionThreeColumnsItem1.Id = 13
			Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
			' 
			' showColumnsSetupFormItem1
			' 
			Me.showColumnsSetupFormItem1.Id = 14
			Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
			' 
			' insertBreakItem1
			' 
			Me.insertBreakItem1.Id = 15
			Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1)})
			Me.insertBreakItem1.Name = "insertBreakItem1"
			' 
			' insertPageBreakItem1
			' 
			Me.insertPageBreakItem1.Id = 16
			Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
			' 
			' insertColumnBreakItem1
			' 
			Me.insertColumnBreakItem1.Id = 17
			Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
			' 
			' insertSectionBreakNextPageItem1
			' 
			Me.insertSectionBreakNextPageItem1.Id = 18
			Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
			' 
			' insertSectionBreakEvenPageItem1
			' 
			Me.insertSectionBreakEvenPageItem1.Id = 19
			Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
			' 
			' insertSectionBreakOddPageItem1
			' 
			Me.insertSectionBreakOddPageItem1.Id = 20
			Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
			' 
			' changeSectionLineNumberingItem1
			' 
			Me.changeSectionLineNumberingItem1.Id = 21
			Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1)})
			Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
			' 
			' setSectionLineNumberingNoneItem1
			' 
			Me.setSectionLineNumberingNoneItem1.Id = 22
			Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
			' 
			' setSectionLineNumberingContinuousItem1
			' 
			Me.setSectionLineNumberingContinuousItem1.Id = 23
			Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
			' 
			' setSectionLineNumberingRestartNewPageItem1
			' 
			Me.setSectionLineNumberingRestartNewPageItem1.Id = 24
			Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
			' 
			' setSectionLineNumberingRestartNewSectionItem1
			' 
			Me.setSectionLineNumberingRestartNewSectionItem1.Id = 25
			Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
			' 
			' toggleParagraphSuppressLineNumbersItem1
			' 
			Me.toggleParagraphSuppressLineNumbersItem1.Id = 26
			Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
			' 
			' showLineNumberingFormItem1
			' 
			Me.showLineNumberingFormItem1.Id = 27
			Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
			' 
			' documentViewsBar1
			' 
			Me.documentViewsBar1.DockCol = 0
			Me.documentViewsBar1.DockRow = 0
			Me.documentViewsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.documentViewsBar1.FloatLocation = New System.Drawing.Point(-1878, 158)
			Me.documentViewsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.switchToSimpleViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToDraftViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToPrintLayoutViewItem1)})
			' 
			' switchToSimpleViewItem1
			' 
			Me.switchToSimpleViewItem1.Id = 28
			Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
			' 
			' switchToDraftViewItem1
			' 
			Me.switchToDraftViewItem1.Id = 29
			Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
			' 
			' switchToPrintLayoutViewItem1
			' 
			Me.switchToPrintLayoutViewItem1.Id = 30
			Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
			' 
			' showBar1
			' 
			Me.showBar1.DockCol = 2
			Me.showBar1.DockRow = 0
			Me.showBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.showBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowHorizontalRulerItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowVerticalRulerItem1)})
			Me.showBar1.Offset = 551
			' 
			' toggleShowHorizontalRulerItem1
			' 
			Me.toggleShowHorizontalRulerItem1.Id = 31
			Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
			' 
			' toggleShowVerticalRulerItem1
			' 
			Me.toggleShowVerticalRulerItem1.Id = 32
			Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
			' 
			' zoomBar1
			' 
			Me.zoomBar1.DockCol = 3
			Me.zoomBar1.DockRow = 0
			Me.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.zoomBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.zoomOutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomInItem1)})
			Me.zoomBar1.Offset = 662
			' 
			' zoomOutItem1
			' 
			Me.zoomOutItem1.Id = 33
			Me.zoomOutItem1.Name = "zoomOutItem1"
			' 
			' zoomInItem1
			' 
			Me.zoomInItem1.Id = 34
			Me.zoomInItem1.Name = "zoomInItem1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(897, 557)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btn_PrintFromServer As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btn_PrintControlViaPrintingLink As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btn_PrintControlWithOptions As DevExpress.XtraEditors.SimpleButton
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar3 As DevExpress.XtraBars.Bar
		Private pageSetupBar1 As DevExpress.XtraRichEdit.UI.PageSetupBar
		Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
		Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
		Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
		Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
		Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
		Private showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
		Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
		Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
		Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
		Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
		Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
		Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
		Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
		Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
		Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
		Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
		Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
		Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
		Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
		Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
		Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
		Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
		Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
		Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
		Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
		Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
		Private documentViewsBar1 As DevExpress.XtraRichEdit.UI.DocumentViewsBar
		Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
		Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
		Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
		Private showBar1 As DevExpress.XtraRichEdit.UI.ShowBar
		Private toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
		Private toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
		Private zoomBar1 As DevExpress.XtraRichEdit.UI.ZoomBar
		Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
		Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
	End Class
End Namespace

