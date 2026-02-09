using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using (var doc = WordprocessingDocument.Create("example.excel", WordprocessingDocumentType.Document))
{
    var mainPart = doc.AddMainDocumentPart();
    mainPart.Document =
        new Document(new Body(new Paragraph(new Run(new Text("Hello, Open XML!")))));
}

Console.WriteLine("Word-filen skapades!");
