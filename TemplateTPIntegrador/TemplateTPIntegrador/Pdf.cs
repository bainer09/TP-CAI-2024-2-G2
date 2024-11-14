using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentacion
{
    public class Pdf : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            var fontHeader = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
            var fontFooter = new Font(Font.FontFamily.HELVETICA, 10, Font.ITALIC);

            PdfPTable header = new PdfPTable(1)
            {
                TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin
            };
            header.DefaultCell.Border = Rectangle.NO_BORDER;
            header.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            header.AddCell(new Phrase(new Chunk("ElectroHogar", fontHeader)));

            PdfPTable footer = new PdfPTable(1)
            {
                TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin
            };
            footer.DefaultCell.Border = Rectangle.NO_BORDER;
            footer.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            footer.AddCell(new Phrase(new Chunk("Comprobante no válido como Factura", fontFooter)));

            header.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.Height - document.TopMargin + 10, writer.DirectContent);
            footer.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin - 10, writer.DirectContent);
        }
    }
}
