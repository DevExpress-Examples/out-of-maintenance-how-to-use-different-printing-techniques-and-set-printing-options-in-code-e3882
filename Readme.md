<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PrintingSystem/Form1.cs) (VB: [Form1.vb](./VB/PrintingSystem/Form1.vb))
* [Program.cs](./CS/PrintingSystem/Program.cs) (VB: [Program.vb](./VB/PrintingSystem/Program.vb))
<!-- default file list end -->
# How to use different printing techniques and set printing options in code


<p>This example demonstrates three techniques that can be utilized to print a document loaded in the RichEditControl. The first technique uses the direct <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_Printtopic"><u>Print</u></a> method, the second instantiates a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraPrintingPrintableComponentLinktopic"><u>PrintableComponentLink</u></a>, the last technique creates a new instance of the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic"><u>RichEditDocumentServer</u></a> with a copy of a source document.<br />
Various print options, such as page size, orientation and margins are set via code.</p>


<h3>Description</h3>

<p>Starting from v2013 vol.1.6 the RichEditDocumentServer is available in the DevExpress Universal or the Document Server (Document Automation) subscription. <br> Refer to the <a data-ticket="E4846">E4846</a> example for printing from RichEditDocumentServer.</p>

<br/>


