using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace PDFReport
{
    public class CreateReportPDF
    {
        public Document CreateReport(PdfPTable table , string FileName)
        {
            iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();

            //PDF dosyamızı temsil edecek nesnemizi oluşturuyoruz

            //PdfWriter.GetInstance(pdfDosya, new FileStream(FileName, FileMode.CreateNew));

            //PDF dosyamızın yolu ” C:CSharpPDF.pdf” ve dosyanın açılış biçimi ‘Yeni yarat’

            pdfDosya.Open();

            Uri yol = new Uri(@"C:\Users\emreh\source\repos\Emrehan-Aydin\Borsa-projesi\logo.jpg");

            //Eklenecek resmimizin yolunun Uri tipinde nesne şeklinde elde edilmesi
            Jpeg resim = new Jpeg(yol);
            pdfDosya.Add(resim);

            pdfDosya.AddTitle("Borsa Projesi Rapor Dosyası");
            pdfDosya.Add(new Paragraph("Hello World"));
            pdfDosya.Add(table);
            return pdfDosya;



        }

    }
}
