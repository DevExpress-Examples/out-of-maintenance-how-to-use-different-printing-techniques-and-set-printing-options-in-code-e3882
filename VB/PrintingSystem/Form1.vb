Imports System
Imports System.Windows.Forms
'#Region "#usings"
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

'#End Region  ' #usings
Namespace RichEdit_PrintingSystem

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("test.docx", DocumentFormat.OpenXml)
        End Sub

        Private Sub btn_PrintControlWithOptions_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginUpdate()
            SetPrintOptions(richEditControl1)
            richEditControl1.EndUpdate()
            richEditControl1.Print()
        End Sub

        Private Sub btn_PrintControlViaPrintingLink_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginUpdate()
            SetPrintOptions(richEditControl1)
            richEditControl1.EndUpdate()
            PrintViaLink(richEditControl1)
        End Sub

'#Region "#setprintoptions"
        Private Shared Sub SetPrintOptions(ByVal richedit As IRichEditDocumentServer)
            For Each _section As Section In richedit.Document.Sections
                _section.Page.PaperKind = System.Drawing.Printing.PaperKind.A4
                _section.Page.Landscape = True
                _section.Margins.Left = 500F
                _section.Margins.Right = 500F
                _section.Margins.Top = 200F
                _section.Margins.Bottom = 200F
                _section.PageNumbering.NumberingFormat = NumberingFormat.CardinalText
                _section.PageNumbering.FirstPageNumber = 0
            Next
        End Sub

'#End Region  ' #setprintoptions
'#Region "#printvialink"
        Private Shared Sub PrintViaLink(ByVal srv As IPrintable)
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = srv
            ' Disable warnings.
            link.PrintingSystem.ShowMarginsWarning = False
            link.PrintingSystem.ShowPrintStatusDialog = False
            ' Find a printer containing Canon in its name
            Dim settings As PrinterSettings = New PrinterSettings()
            Dim printerName As String = String.Empty
            For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
                Dim pName As String = PrinterSettings.InstalledPrinters(i)
                If pName.Contains("Canon") Then
                    printerName = pName
                    Exit For
                End If
            Next

            ' Print to the specified printer.
            link.Print(printerName)
        End Sub
'#End Region  ' #printvialink
    End Class
End Namespace
