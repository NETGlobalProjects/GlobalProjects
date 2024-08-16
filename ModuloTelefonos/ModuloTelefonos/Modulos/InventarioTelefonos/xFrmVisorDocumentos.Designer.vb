<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xFrmVisorDocumentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xFrmVisorDocumentos))
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.FichasTableAdapter = New ModuloTelefonos.dtsInventarioTelefonosTableAdapters.FichasTableAdapter()
        Me.DocumentViewerBarManager1 = New DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PreviewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
        Me.PreviewBar2 = New DevExpress.XtraPrinting.Preview.PreviewBar()
        Me.PreviewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
        Me.PrintPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.ProgressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
        Me.PrintPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.PrintPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
        Me.RepositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
        Me.ZoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
        Me.bbiDocumentMap = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiParameters = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiThumbnails = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFind = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHighlightEditingFields = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiCustomize = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiOpen = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSave = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrint = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPrintDirect = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiPageSetup = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiEditPageHF = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiScale = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiHandTool = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMagnifier = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoomOut = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiZoom = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
        Me.PrintPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
        Me.bbiZoomIn = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowFirstPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowPrevPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowNextPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiShowLastPage = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiMultiplePages = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiFillBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiWatermark = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiExportFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiSendFile = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.bbiClosePreview = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miFile = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miView = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miBackground = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayout = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
        Me.miPageLayoutFacing = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miPageLayoutContinuous = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
        Me.miToolbars = New DevExpress.XtraBars.BarToolbarsListItem()
        Me.PrintPreviewBarCheckItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        Me.PrintPreviewBarCheckItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.IsMetric = True
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 53)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(800, 371)
        Me.DocumentViewer1.TabIndex = 0
        '
        'FichasTableAdapter
        '
        Me.FichasTableAdapter.ClearBeforeFill = True
        '
        'DocumentViewerBarManager1
        '
        Me.DocumentViewerBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.PreviewBar1, Me.PreviewBar2, Me.PreviewBar3})
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.DocumentViewerBarManager1.DockControls.Add(Me.barDockControlRight)
        Me.DocumentViewerBarManager1.DocumentViewer = Me.DocumentViewer1
        Me.DocumentViewerBarManager1.Form = Me
        Me.DocumentViewerBarManager1.ImageStream = CType(resources.GetObject("DocumentViewerBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.DocumentViewerBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PrintPreviewStaticItem1, Me.ProgressBarEditItem1, Me.PrintPreviewBarItem1, Me.PrintPreviewStaticItem2, Me.ZoomTrackBarEditItem1, Me.bbiDocumentMap, Me.bbiParameters, Me.bbiThumbnails, Me.bbiFind, Me.bbiHighlightEditingFields, Me.bbiCustomize, Me.bbiOpen, Me.bbiSave, Me.bbiPrint, Me.bbiPrintDirect, Me.bbiPageSetup, Me.bbiEditPageHF, Me.bbiScale, Me.bbiHandTool, Me.bbiMagnifier, Me.bbiZoomOut, Me.bbiZoom, Me.bbiZoomIn, Me.bbiShowFirstPage, Me.bbiShowPrevPage, Me.bbiShowNextPage, Me.bbiShowLastPage, Me.bbiMultiplePages, Me.bbiFillBackground, Me.bbiWatermark, Me.bbiExportFile, Me.bbiSendFile, Me.bbiClosePreview, Me.miFile, Me.miView, Me.miBackground, Me.miPageLayout, Me.miPageLayoutFacing, Me.miPageLayoutContinuous, Me.miToolbars, Me.PrintPreviewBarCheckItem1, Me.PrintPreviewBarCheckItem2, Me.PrintPreviewBarCheckItem3, Me.PrintPreviewBarCheckItem4, Me.PrintPreviewBarCheckItem5, Me.PrintPreviewBarCheckItem6, Me.PrintPreviewBarCheckItem7, Me.PrintPreviewBarCheckItem8, Me.PrintPreviewBarCheckItem9, Me.PrintPreviewBarCheckItem10, Me.PrintPreviewBarCheckItem11, Me.PrintPreviewBarCheckItem12, Me.PrintPreviewBarCheckItem13, Me.PrintPreviewBarCheckItem14, Me.PrintPreviewBarCheckItem15, Me.PrintPreviewBarCheckItem16, Me.PrintPreviewBarCheckItem17, Me.PrintPreviewBarCheckItem18, Me.PrintPreviewBarCheckItem19})
        Me.DocumentViewerBarManager1.MainMenu = Me.PreviewBar3
        Me.DocumentViewerBarManager1.MaxItemId = 59
        Me.DocumentViewerBarManager1.PreviewBar = Me.PreviewBar1
        Me.DocumentViewerBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1, Me.RepositoryItemZoomTrackBar1, Me.PrintPreviewRepositoryItemComboBox1})
        Me.DocumentViewerBarManager1.StatusBar = Me.PreviewBar2
        Me.DocumentViewerBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 53)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 424)
        Me.barDockControlBottom.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
        Me.barDockControlLeft.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 371)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 53)
        Me.barDockControlRight.Manager = Me.DocumentViewerBarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 371)
        '
        'PreviewBar1
        '
        Me.PreviewBar1.BarName = "Toolbar"
        Me.PreviewBar1.DockCol = 0
        Me.PreviewBar1.DockRow = 1
        Me.PreviewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PreviewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDocumentMap), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiParameters), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiThumbnails), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFind), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHighlightEditingFields), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiCustomize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiOpen, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSave), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrintDirect), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPageSetup), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiEditPageHF), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiScale), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiHandTool, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMagnifier), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomOut, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoom), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiZoomIn), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowFirstPage, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowPrevPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowNextPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiShowLastPage), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiMultiplePages, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFillBackground), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiWatermark), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendFile), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiClosePreview, True)})
        Me.PreviewBar1.Text = "Barra de herramientas"
        '
        'PreviewBar2
        '
        Me.PreviewBar2.BarName = "Status Bar"
        Me.PreviewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.PreviewBar2.DockCol = 0
        Me.PreviewBar2.DockRow = 0
        Me.PreviewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.PreviewBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ProgressBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.ZoomTrackBarEditItem1)})
        Me.PreviewBar2.OptionsBar.AllowQuickCustomization = False
        Me.PreviewBar2.OptionsBar.DrawDragBorder = False
        Me.PreviewBar2.OptionsBar.UseWholeRow = True
        Me.PreviewBar2.Text = "Barra de Estado"
        '
        'PreviewBar3
        '
        Me.PreviewBar3.BarName = "Main Menu"
        Me.PreviewBar3.DockCol = 0
        Me.PreviewBar3.DockRow = 0
        Me.PreviewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PreviewBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miFile), New DevExpress.XtraBars.LinkPersistInfo(Me.miView), New DevExpress.XtraBars.LinkPersistInfo(Me.miBackground)})
        Me.PreviewBar3.OptionsBar.MultiLine = True
        Me.PreviewBar3.OptionsBar.UseWholeRow = True
        Me.PreviewBar3.Text = "Menú principal"
        '
        'PrintPreviewStaticItem1
        '
        Me.PrintPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PrintPreviewStaticItem1.Caption = "ninguno"
        Me.PrintPreviewStaticItem1.Id = 0
        Me.PrintPreviewStaticItem1.LeftIndent = 1
        Me.PrintPreviewStaticItem1.Name = "PrintPreviewStaticItem1"
        Me.PrintPreviewStaticItem1.RightIndent = 1
        Me.PrintPreviewStaticItem1.Type = "PageOfPages"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'ProgressBarEditItem1
        '
        Me.ProgressBarEditItem1.Edit = Me.RepositoryItemProgressBar1
        Me.ProgressBarEditItem1.EditHeight = 12
        Me.ProgressBarEditItem1.EditWidth = 150
        Me.ProgressBarEditItem1.Id = 1
        Me.ProgressBarEditItem1.Name = "ProgressBarEditItem1"
        Me.ProgressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PrintPreviewBarItem1
        '
        Me.PrintPreviewBarItem1.Caption = "Interrumpir"
        Me.PrintPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
        Me.PrintPreviewBarItem1.Enabled = False
        Me.PrintPreviewBarItem1.Hint = "Interrumpir"
        Me.PrintPreviewBarItem1.Id = 2
        Me.PrintPreviewBarItem1.Name = "PrintPreviewBarItem1"
        Me.PrintPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'PrintPreviewStaticItem2
        '
        Me.PrintPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.PrintPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PrintPreviewStaticItem2.Caption = "100%"
        Me.PrintPreviewStaticItem2.Id = 3
        Me.PrintPreviewStaticItem2.Name = "PrintPreviewStaticItem2"
        Me.PrintPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far
        Me.PrintPreviewStaticItem2.Type = "ZoomFactor"
        '
        'RepositoryItemZoomTrackBar1
        '
        Me.RepositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemZoomTrackBar1.AllowFocused = False
        Me.RepositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemZoomTrackBar1.Maximum = 180
        Me.RepositoryItemZoomTrackBar1.Name = "RepositoryItemZoomTrackBar1"
        '
        'ZoomTrackBarEditItem1
        '
        Me.ZoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.ZoomTrackBarEditItem1.Edit = Me.RepositoryItemZoomTrackBar1
        Me.ZoomTrackBarEditItem1.EditValue = 90
        Me.ZoomTrackBarEditItem1.EditWidth = 140
        Me.ZoomTrackBarEditItem1.Enabled = False
        Me.ZoomTrackBarEditItem1.Id = 4
        Me.ZoomTrackBarEditItem1.Name = "ZoomTrackBarEditItem1"
        Me.ZoomTrackBarEditItem1.Range = New Integer() {10, 500}
        '
        'bbiDocumentMap
        '
        Me.bbiDocumentMap.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiDocumentMap.Caption = "Mapa del Documento"
        Me.bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
        Me.bbiDocumentMap.Enabled = False
        Me.bbiDocumentMap.Hint = "Mapa del Documento"
        Me.bbiDocumentMap.Id = 5
        Me.bbiDocumentMap.Name = "bbiDocumentMap"
        '
        'bbiParameters
        '
        Me.bbiParameters.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiParameters.Caption = "Parámetros"
        Me.bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
        Me.bbiParameters.Enabled = False
        Me.bbiParameters.Hint = "Parámetros"
        Me.bbiParameters.Id = 6
        Me.bbiParameters.Name = "bbiParameters"
        '
        'bbiThumbnails
        '
        Me.bbiThumbnails.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiThumbnails.Caption = "Vistas en miniatura"
        Me.bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails
        Me.bbiThumbnails.Enabled = False
        Me.bbiThumbnails.Hint = "Vistas en miniatura"
        Me.bbiThumbnails.Id = 7
        Me.bbiThumbnails.Name = "bbiThumbnails"
        '
        'bbiFind
        '
        Me.bbiFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiFind.Caption = "Buscar"
        Me.bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
        Me.bbiFind.Enabled = False
        Me.bbiFind.Hint = "Buscar"
        Me.bbiFind.Id = 8
        Me.bbiFind.Name = "bbiFind"
        '
        'bbiHighlightEditingFields
        '
        Me.bbiHighlightEditingFields.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHighlightEditingFields.Caption = "Edición de campos"
        Me.bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields
        Me.bbiHighlightEditingFields.Enabled = False
        Me.bbiHighlightEditingFields.Hint = "Resaltado de campos de edición"
        Me.bbiHighlightEditingFields.Id = 9
        Me.bbiHighlightEditingFields.Name = "bbiHighlightEditingFields"
        '
        'bbiCustomize
        '
        Me.bbiCustomize.Caption = "Personalizar"
        Me.bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
        Me.bbiCustomize.Enabled = False
        Me.bbiCustomize.Hint = "Personalizar"
        Me.bbiCustomize.Id = 10
        Me.bbiCustomize.Name = "bbiCustomize"
        '
        'bbiOpen
        '
        Me.bbiOpen.Caption = "Abrir"
        Me.bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
        Me.bbiOpen.Enabled = False
        Me.bbiOpen.Hint = "Abrir un documento"
        Me.bbiOpen.Id = 11
        Me.bbiOpen.Name = "bbiOpen"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Guardar"
        Me.bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
        Me.bbiSave.Enabled = False
        Me.bbiSave.Hint = "Guardar el documento"
        Me.bbiSave.Id = 12
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "&Imprimir..."
        Me.bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
        Me.bbiPrint.Enabled = False
        Me.bbiPrint.Hint = "Imprimir"
        Me.bbiPrint.Id = 13
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiPrintDirect
        '
        Me.bbiPrintDirect.Caption = "I&mpresión rápida"
        Me.bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
        Me.bbiPrintDirect.Enabled = False
        Me.bbiPrintDirect.Hint = "Impresión Rápida"
        Me.bbiPrintDirect.Id = 14
        Me.bbiPrintDirect.Name = "bbiPrintDirect"
        '
        'bbiPageSetup
        '
        Me.bbiPageSetup.Caption = "Configurar &página..."
        Me.bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
        Me.bbiPageSetup.Enabled = False
        Me.bbiPageSetup.Hint = "Configurar Página"
        Me.bbiPageSetup.Id = 15
        Me.bbiPageSetup.Name = "bbiPageSetup"
        '
        'bbiEditPageHF
        '
        Me.bbiEditPageHF.Caption = "Editar cabecera y pie"
        Me.bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
        Me.bbiEditPageHF.Enabled = False
        Me.bbiEditPageHF.Hint = "Editar cabecera y pie"
        Me.bbiEditPageHF.Id = 16
        Me.bbiEditPageHF.Name = "bbiEditPageHF"
        '
        'bbiScale
        '
        Me.bbiScale.ActAsDropDown = True
        Me.bbiScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiScale.Caption = "Escala"
        Me.bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
        Me.bbiScale.Enabled = False
        Me.bbiScale.Hint = "Escala"
        Me.bbiScale.Id = 17
        Me.bbiScale.Name = "bbiScale"
        '
        'bbiHandTool
        '
        Me.bbiHandTool.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHandTool.Caption = "Herramienta de mano"
        Me.bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
        Me.bbiHandTool.Enabled = False
        Me.bbiHandTool.Hint = "Herramienta de mano"
        Me.bbiHandTool.Id = 18
        Me.bbiHandTool.Name = "bbiHandTool"
        '
        'bbiMagnifier
        '
        Me.bbiMagnifier.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMagnifier.Caption = "Lupa"
        Me.bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
        Me.bbiMagnifier.Enabled = False
        Me.bbiMagnifier.Hint = "Lupa"
        Me.bbiMagnifier.Id = 19
        Me.bbiMagnifier.Name = "bbiMagnifier"
        '
        'bbiZoomOut
        '
        Me.bbiZoomOut.Caption = "Alejar"
        Me.bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
        Me.bbiZoomOut.Enabled = False
        Me.bbiZoomOut.Hint = "Alejar"
        Me.bbiZoomOut.Id = 20
        Me.bbiZoomOut.Name = "bbiZoomOut"
        '
        'bbiZoom
        '
        Me.bbiZoom.Caption = "Ampliación"
        Me.bbiZoom.Edit = Me.PrintPreviewRepositoryItemComboBox1
        Me.bbiZoom.EditValue = "100%"
        Me.bbiZoom.EditWidth = 70
        Me.bbiZoom.Enabled = False
        Me.bbiZoom.Hint = "Ampliación"
        Me.bbiZoom.Id = 21
        Me.bbiZoom.Name = "bbiZoom"
        '
        'PrintPreviewRepositoryItemComboBox1
        '
        Me.PrintPreviewRepositoryItemComboBox1.AutoComplete = False
        Me.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11
        Me.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1"
        '
        'bbiZoomIn
        '
        Me.bbiZoomIn.Caption = "Acercar"
        Me.bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
        Me.bbiZoomIn.Enabled = False
        Me.bbiZoomIn.Hint = "Acercar"
        Me.bbiZoomIn.Id = 22
        Me.bbiZoomIn.Name = "bbiZoomIn"
        '
        'bbiShowFirstPage
        '
        Me.bbiShowFirstPage.Caption = "Primera Página"
        Me.bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
        Me.bbiShowFirstPage.Enabled = False
        Me.bbiShowFirstPage.Hint = "Primera Página"
        Me.bbiShowFirstPage.Id = 23
        Me.bbiShowFirstPage.Name = "bbiShowFirstPage"
        '
        'bbiShowPrevPage
        '
        Me.bbiShowPrevPage.Caption = "Página Anterior"
        Me.bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
        Me.bbiShowPrevPage.Enabled = False
        Me.bbiShowPrevPage.Hint = "Página Anterior"
        Me.bbiShowPrevPage.Id = 24
        Me.bbiShowPrevPage.Name = "bbiShowPrevPage"
        '
        'bbiShowNextPage
        '
        Me.bbiShowNextPage.Caption = "Página Siguiente"
        Me.bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
        Me.bbiShowNextPage.Enabled = False
        Me.bbiShowNextPage.Hint = "Página Siguiente"
        Me.bbiShowNextPage.Id = 25
        Me.bbiShowNextPage.Name = "bbiShowNextPage"
        '
        'bbiShowLastPage
        '
        Me.bbiShowLastPage.Caption = "Última Página"
        Me.bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
        Me.bbiShowLastPage.Enabled = False
        Me.bbiShowLastPage.Hint = "Última Página"
        Me.bbiShowLastPage.Id = 26
        Me.bbiShowLastPage.Name = "bbiShowLastPage"
        '
        'bbiMultiplePages
        '
        Me.bbiMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiMultiplePages.Caption = "Múltiples Páginas"
        Me.bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
        Me.bbiMultiplePages.Enabled = False
        Me.bbiMultiplePages.Hint = "Múltiples Páginas"
        Me.bbiMultiplePages.Id = 27
        Me.bbiMultiplePages.Name = "bbiMultiplePages"
        '
        'bbiFillBackground
        '
        Me.bbiFillBackground.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiFillBackground.Caption = "&Color de página..."
        Me.bbiFillBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
        Me.bbiFillBackground.Enabled = False
        Me.bbiFillBackground.Hint = "Fondo"
        Me.bbiFillBackground.Id = 28
        Me.bbiFillBackground.Name = "bbiFillBackground"
        '
        'bbiWatermark
        '
        Me.bbiWatermark.Caption = "&Filigrana..."
        Me.bbiWatermark.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
        Me.bbiWatermark.Enabled = False
        Me.bbiWatermark.Hint = "Filigrana"
        Me.bbiWatermark.Id = 29
        Me.bbiWatermark.Name = "bbiWatermark"
        '
        'bbiExportFile
        '
        Me.bbiExportFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiExportFile.Caption = "Exportar Documento..."
        Me.bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
        Me.bbiExportFile.Enabled = False
        Me.bbiExportFile.Hint = "Exportar Documento..."
        Me.bbiExportFile.Id = 30
        Me.bbiExportFile.Name = "bbiExportFile"
        '
        'bbiSendFile
        '
        Me.bbiSendFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiSendFile.Caption = "Enviar el documento por correo electrónico..."
        Me.bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
        Me.bbiSendFile.Enabled = False
        Me.bbiSendFile.Hint = "Enviar el documento por correo electrónico..."
        Me.bbiSendFile.Id = 31
        Me.bbiSendFile.Name = "bbiSendFile"
        '
        'bbiClosePreview
        '
        Me.bbiClosePreview.Caption = "&Salir"
        Me.bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
        Me.bbiClosePreview.Enabled = False
        Me.bbiClosePreview.Hint = "Cerrar Vista Preliminar"
        Me.bbiClosePreview.Id = 32
        Me.bbiClosePreview.Name = "bbiClosePreview"
        '
        'miFile
        '
        Me.miFile.Caption = "&Archivo"
        Me.miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
        Me.miFile.Id = 33
        Me.miFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPageSetup), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrintDirect), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiExportFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSendFile), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiClosePreview, True)})
        Me.miFile.Name = "miFile"
        '
        'miView
        '
        Me.miView.Caption = "&Vista"
        Me.miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
        Me.miView.Id = 34
        Me.miView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayout, True), New DevExpress.XtraBars.LinkPersistInfo(Me.miToolbars, True)})
        Me.miView.Name = "miView"
        '
        'miBackground
        '
        Me.miBackground.Caption = "&Fondo de página"
        Me.miBackground.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
        Me.miBackground.Id = 35
        Me.miBackground.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiFillBackground), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiWatermark)})
        Me.miBackground.Name = "miBackground"
        '
        'miPageLayout
        '
        Me.miPageLayout.Caption = "Distribución &Página"
        Me.miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
        Me.miPageLayout.Id = 36
        Me.miPageLayout.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutFacing), New DevExpress.XtraBars.LinkPersistInfo(Me.miPageLayoutContinuous)})
        Me.miPageLayout.Name = "miPageLayout"
        '
        'miPageLayoutFacing
        '
        Me.miPageLayoutFacing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutFacing.Caption = "&Paralelo"
        Me.miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
        Me.miPageLayoutFacing.Enabled = False
        Me.miPageLayoutFacing.GroupIndex = 100
        Me.miPageLayoutFacing.Id = 37
        Me.miPageLayoutFacing.Name = "miPageLayoutFacing"
        '
        'miPageLayoutContinuous
        '
        Me.miPageLayoutContinuous.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.miPageLayoutContinuous.Caption = "&Continuo"
        Me.miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
        Me.miPageLayoutContinuous.Enabled = False
        Me.miPageLayoutContinuous.GroupIndex = 100
        Me.miPageLayoutContinuous.Id = 38
        Me.miPageLayoutContinuous.Name = "miPageLayoutContinuous"
        '
        'miToolbars
        '
        Me.miToolbars.Caption = "Bars"
        Me.miToolbars.Id = 39
        Me.miToolbars.Name = "miToolbars"
        '
        'PrintPreviewBarCheckItem1
        '
        Me.PrintPreviewBarCheckItem1.BindableChecked = True
        Me.PrintPreviewBarCheckItem1.Caption = "Documento PDF"
        Me.PrintPreviewBarCheckItem1.Checked = True
        Me.PrintPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
        Me.PrintPreviewBarCheckItem1.Enabled = False
        Me.PrintPreviewBarCheckItem1.GroupIndex = 2
        Me.PrintPreviewBarCheckItem1.Hint = "Documento PDF"
        Me.PrintPreviewBarCheckItem1.Id = 40
        Me.PrintPreviewBarCheckItem1.Name = "PrintPreviewBarCheckItem1"
        '
        'PrintPreviewBarCheckItem2
        '
        Me.PrintPreviewBarCheckItem2.Caption = "Documento HTML"
        Me.PrintPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
        Me.PrintPreviewBarCheckItem2.Enabled = False
        Me.PrintPreviewBarCheckItem2.GroupIndex = 2
        Me.PrintPreviewBarCheckItem2.Hint = "Documento HTML"
        Me.PrintPreviewBarCheckItem2.Id = 41
        Me.PrintPreviewBarCheckItem2.Name = "PrintPreviewBarCheckItem2"
        '
        'PrintPreviewBarCheckItem3
        '
        Me.PrintPreviewBarCheckItem3.Caption = "Documento MHT"
        Me.PrintPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
        Me.PrintPreviewBarCheckItem3.Enabled = False
        Me.PrintPreviewBarCheckItem3.GroupIndex = 2
        Me.PrintPreviewBarCheckItem3.Hint = "Documento MHT"
        Me.PrintPreviewBarCheckItem3.Id = 42
        Me.PrintPreviewBarCheckItem3.Name = "PrintPreviewBarCheckItem3"
        '
        'PrintPreviewBarCheckItem4
        '
        Me.PrintPreviewBarCheckItem4.Caption = "Documento RTF"
        Me.PrintPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
        Me.PrintPreviewBarCheckItem4.Enabled = False
        Me.PrintPreviewBarCheckItem4.GroupIndex = 2
        Me.PrintPreviewBarCheckItem4.Hint = "Documento RTF"
        Me.PrintPreviewBarCheckItem4.Id = 43
        Me.PrintPreviewBarCheckItem4.Name = "PrintPreviewBarCheckItem4"
        '
        'PrintPreviewBarCheckItem5
        '
        Me.PrintPreviewBarCheckItem5.Caption = "Archivo DOCX"
        Me.PrintPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx
        Me.PrintPreviewBarCheckItem5.Enabled = False
        Me.PrintPreviewBarCheckItem5.GroupIndex = 2
        Me.PrintPreviewBarCheckItem5.Hint = "Archivo DOCX"
        Me.PrintPreviewBarCheckItem5.Id = 44
        Me.PrintPreviewBarCheckItem5.Name = "PrintPreviewBarCheckItem5"
        '
        'PrintPreviewBarCheckItem6
        '
        Me.PrintPreviewBarCheckItem6.Caption = "Documento XLS"
        Me.PrintPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
        Me.PrintPreviewBarCheckItem6.Enabled = False
        Me.PrintPreviewBarCheckItem6.GroupIndex = 2
        Me.PrintPreviewBarCheckItem6.Hint = "Documento XLS"
        Me.PrintPreviewBarCheckItem6.Id = 45
        Me.PrintPreviewBarCheckItem6.Name = "PrintPreviewBarCheckItem6"
        '
        'PrintPreviewBarCheckItem7
        '
        Me.PrintPreviewBarCheckItem7.Caption = "Documento XLSX"
        Me.PrintPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
        Me.PrintPreviewBarCheckItem7.Enabled = False
        Me.PrintPreviewBarCheckItem7.GroupIndex = 2
        Me.PrintPreviewBarCheckItem7.Hint = "Documento XLSX"
        Me.PrintPreviewBarCheckItem7.Id = 46
        Me.PrintPreviewBarCheckItem7.Name = "PrintPreviewBarCheckItem7"
        '
        'PrintPreviewBarCheckItem8
        '
        Me.PrintPreviewBarCheckItem8.Caption = "Documento CSV"
        Me.PrintPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
        Me.PrintPreviewBarCheckItem8.Enabled = False
        Me.PrintPreviewBarCheckItem8.GroupIndex = 2
        Me.PrintPreviewBarCheckItem8.Hint = "Documento CSV"
        Me.PrintPreviewBarCheckItem8.Id = 47
        Me.PrintPreviewBarCheckItem8.Name = "PrintPreviewBarCheckItem8"
        '
        'PrintPreviewBarCheckItem9
        '
        Me.PrintPreviewBarCheckItem9.Caption = "Documento de Texto"
        Me.PrintPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
        Me.PrintPreviewBarCheckItem9.Enabled = False
        Me.PrintPreviewBarCheckItem9.GroupIndex = 2
        Me.PrintPreviewBarCheckItem9.Hint = "Documento de Texto"
        Me.PrintPreviewBarCheckItem9.Id = 48
        Me.PrintPreviewBarCheckItem9.Name = "PrintPreviewBarCheckItem9"
        '
        'PrintPreviewBarCheckItem10
        '
        Me.PrintPreviewBarCheckItem10.Caption = "Documento de Imagen"
        Me.PrintPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
        Me.PrintPreviewBarCheckItem10.Enabled = False
        Me.PrintPreviewBarCheckItem10.GroupIndex = 2
        Me.PrintPreviewBarCheckItem10.Hint = "Documento de Imagen"
        Me.PrintPreviewBarCheckItem10.Id = 49
        Me.PrintPreviewBarCheckItem10.Name = "PrintPreviewBarCheckItem10"
        '
        'PrintPreviewBarCheckItem11
        '
        Me.PrintPreviewBarCheckItem11.BindableChecked = True
        Me.PrintPreviewBarCheckItem11.Caption = "Documento PDF"
        Me.PrintPreviewBarCheckItem11.Checked = True
        Me.PrintPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
        Me.PrintPreviewBarCheckItem11.Enabled = False
        Me.PrintPreviewBarCheckItem11.GroupIndex = 1
        Me.PrintPreviewBarCheckItem11.Hint = "Documento PDF"
        Me.PrintPreviewBarCheckItem11.Id = 50
        Me.PrintPreviewBarCheckItem11.Name = "PrintPreviewBarCheckItem11"
        '
        'PrintPreviewBarCheckItem12
        '
        Me.PrintPreviewBarCheckItem12.Caption = "Documento MHT"
        Me.PrintPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
        Me.PrintPreviewBarCheckItem12.Enabled = False
        Me.PrintPreviewBarCheckItem12.GroupIndex = 1
        Me.PrintPreviewBarCheckItem12.Hint = "Documento MHT"
        Me.PrintPreviewBarCheckItem12.Id = 51
        Me.PrintPreviewBarCheckItem12.Name = "PrintPreviewBarCheckItem12"
        '
        'PrintPreviewBarCheckItem13
        '
        Me.PrintPreviewBarCheckItem13.Caption = "Documento RTF"
        Me.PrintPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
        Me.PrintPreviewBarCheckItem13.Enabled = False
        Me.PrintPreviewBarCheckItem13.GroupIndex = 1
        Me.PrintPreviewBarCheckItem13.Hint = "Documento RTF"
        Me.PrintPreviewBarCheckItem13.Id = 52
        Me.PrintPreviewBarCheckItem13.Name = "PrintPreviewBarCheckItem13"
        '
        'PrintPreviewBarCheckItem14
        '
        Me.PrintPreviewBarCheckItem14.Caption = "Archivo DOCX"
        Me.PrintPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendDocx
        Me.PrintPreviewBarCheckItem14.Enabled = False
        Me.PrintPreviewBarCheckItem14.GroupIndex = 1
        Me.PrintPreviewBarCheckItem14.Hint = "Archivo DOCX"
        Me.PrintPreviewBarCheckItem14.Id = 53
        Me.PrintPreviewBarCheckItem14.Name = "PrintPreviewBarCheckItem14"
        '
        'PrintPreviewBarCheckItem15
        '
        Me.PrintPreviewBarCheckItem15.Caption = "Documento XLS"
        Me.PrintPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
        Me.PrintPreviewBarCheckItem15.Enabled = False
        Me.PrintPreviewBarCheckItem15.GroupIndex = 1
        Me.PrintPreviewBarCheckItem15.Hint = "Documento XLS"
        Me.PrintPreviewBarCheckItem15.Id = 54
        Me.PrintPreviewBarCheckItem15.Name = "PrintPreviewBarCheckItem15"
        '
        'PrintPreviewBarCheckItem16
        '
        Me.PrintPreviewBarCheckItem16.Caption = "Documento XLSX"
        Me.PrintPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
        Me.PrintPreviewBarCheckItem16.Enabled = False
        Me.PrintPreviewBarCheckItem16.GroupIndex = 1
        Me.PrintPreviewBarCheckItem16.Hint = "Documento XLSX"
        Me.PrintPreviewBarCheckItem16.Id = 55
        Me.PrintPreviewBarCheckItem16.Name = "PrintPreviewBarCheckItem16"
        '
        'PrintPreviewBarCheckItem17
        '
        Me.PrintPreviewBarCheckItem17.Caption = "Documento CSV"
        Me.PrintPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
        Me.PrintPreviewBarCheckItem17.Enabled = False
        Me.PrintPreviewBarCheckItem17.GroupIndex = 1
        Me.PrintPreviewBarCheckItem17.Hint = "Documento CSV"
        Me.PrintPreviewBarCheckItem17.Id = 56
        Me.PrintPreviewBarCheckItem17.Name = "PrintPreviewBarCheckItem17"
        '
        'PrintPreviewBarCheckItem18
        '
        Me.PrintPreviewBarCheckItem18.Caption = "Documento de Texto"
        Me.PrintPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
        Me.PrintPreviewBarCheckItem18.Enabled = False
        Me.PrintPreviewBarCheckItem18.GroupIndex = 1
        Me.PrintPreviewBarCheckItem18.Hint = "Documento de Texto"
        Me.PrintPreviewBarCheckItem18.Id = 57
        Me.PrintPreviewBarCheckItem18.Name = "PrintPreviewBarCheckItem18"
        '
        'PrintPreviewBarCheckItem19
        '
        Me.PrintPreviewBarCheckItem19.Caption = "Documento de Imagen"
        Me.PrintPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
        Me.PrintPreviewBarCheckItem19.Enabled = False
        Me.PrintPreviewBarCheckItem19.GroupIndex = 1
        Me.PrintPreviewBarCheckItem19.Hint = "Documento de Imagen"
        Me.PrintPreviewBarCheckItem19.Id = 58
        Me.PrintPreviewBarCheckItem19.Name = "PrintPreviewBarCheckItem19"
        '
        'xFrmVisorDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "xFrmVisorDocumentos"
        Me.Text = "Visor de Documentos X"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DocumentViewerBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents FichasTableAdapter As dtsInventarioTelefonosTableAdapters.FichasTableAdapter
    Friend WithEvents DocumentViewerBarManager1 As DevExpress.XtraPrinting.Preview.DocumentViewerBarManager
    Friend WithEvents PreviewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
    Friend WithEvents bbiDocumentMap As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiParameters As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiThumbnails As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFind As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHighlightEditingFields As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiCustomize As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiOpen As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSave As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrint As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPrintDirect As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiPageSetup As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiEditPageHF As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiScale As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiHandTool As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMagnifier As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoomOut As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiZoom As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
    Friend WithEvents PrintPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
    Friend WithEvents bbiZoomIn As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowFirstPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowPrevPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowNextPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiShowLastPage As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiMultiplePages As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiFillBackground As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiWatermark As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiExportFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiSendFile As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents bbiClosePreview As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents PreviewBar2 As DevExpress.XtraPrinting.Preview.PreviewBar
    Friend WithEvents PrintPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
    Friend WithEvents ProgressBarEditItem1 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents PrintPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents PrintPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
    Friend WithEvents ZoomTrackBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem
    Friend WithEvents RepositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
    Friend WithEvents PreviewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
    Friend WithEvents miFile As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miView As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayout As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents miPageLayoutFacing As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miPageLayoutContinuous As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
    Friend WithEvents miToolbars As DevExpress.XtraBars.BarToolbarsListItem
    Friend WithEvents miBackground As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PrintPreviewBarCheckItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
    Friend WithEvents PrintPreviewBarCheckItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
End Class
