<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611370/13.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3882)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


