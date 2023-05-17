using System;
using System.Windows.Forms;
#region #usings
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings

namespace RichEdit_PrintingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("test.docx", DocumentFormat.OpenXml);
        }


        private void btn_PrintControlWithOptions_Click(object sender, EventArgs e)
        {
            richEditControl1.BeginUpdate();
            SetPrintOptions(richEditControl1);
            richEditControl1.EndUpdate();
            richEditControl1.Print();
        }

        private void btn_PrintControlViaPrintingLink_Click(object sender, EventArgs e)
        {
            richEditControl1.BeginUpdate();
            SetPrintOptions(richEditControl1);
            richEditControl1.EndUpdate();
            PrintViaLink(richEditControl1);
        }

        #region #setprintoptions
        private static void SetPrintOptions(IRichEditDocumentServer richedit)
        {
            foreach (Section _section in richedit.Document.Sections) {
                _section.Page.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4; 
                _section.Page.Landscape = true;
                _section.Margins.Left = 500f;
                _section.Margins.Right = 500f;
                _section.Margins.Top = 200f;
                _section.Margins.Bottom = 200f;
                _section.PageNumbering.NumberingFormat = NumberingFormat.CardinalText;
                _section.PageNumbering.FirstPageNumber = 0;
            }
        }
        #endregion #setprintoptions

        #region #printvialink
        private static void PrintViaLink(IPrintable srv)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = srv;
            // Disable warnings.
            link.PrintingSystem.ShowMarginsWarning = false;
            link.PrintingSystem.ShowPrintStatusDialog = false;
            // Find a printer containing Canon in its name
            PrinterSettings settings = new PrinterSettings();
            string printerName = String.Empty;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++) {
                string pName = PrinterSettings.InstalledPrinters[i];
                if (pName.Contains("Canon")) {
                    printerName = pName;
                    break;
                }
            }
            // Print to the specified printer.
            link.Print(printerName);
        }
        #endregion #printvialink

    }
}
