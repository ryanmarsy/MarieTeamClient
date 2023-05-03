using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MariateamClient
{
    public class PDF
    {
        private PdfDocument document;

        public PDF(string nomDocument)
        {
            this.document = new PdfDocument();
            this.document.Info.Title = nomDocument;
        }

        public void ecrireTexte(string leTexte)
        {
            PdfPage page = this.document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12, XFontStyle.Bold);
            gfx.DrawString(leTexte, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
        }

        public void chargerImage(string chemin)
        {
            PdfPage page = this.document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XImage image = XImage.FromFile(chemin);
            gfx.DrawImage(image, 0, 0, page.Width, page.Height);
        }

        public void fermer()
        {
            this.document.Save("C:\\Users\\Ryan\\Documents\\Visual Studio 2022\\Projets\\" + this.document.Info.Title + ".pdf");
        }
    }
}
