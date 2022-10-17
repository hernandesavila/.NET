using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ExtractDataFromPDF
{
    class PDFHandler
    {
        private string strFilePath;
        private bool bolHasImageInFile;

        public PDFHandler(string strFilePath, bool bolHasImageInFile)
        {
            this.strFilePath = strFilePath;
            this.bolHasImageInFile = bolHasImageInFile;
        }

        public string FilePath 
        {
            get { return this.strFilePath; }  
            set { this.strFilePath = value; } 
        }

        public bool HasImageInFile
        {
            get { return this.bolHasImageInFile; }
            set { this.bolHasImageInFile = value; }
        }

        public string ProcessPDFFile()
        {
            string strResultText = string.Empty;                       

            if(this.HasImageInFile)
            {
                PdfSharp.Pdf.PdfDocument objPdfDocument = PdfSharp.Pdf.IO.PdfReader.Open(this.FilePath);

                foreach (PdfSharp.Pdf.PdfPage objPdfPage in objPdfDocument.Pages)
                {
                    PdfSharp.Pdf.PdfDictionary objPdfPageResources = objPdfPage.Elements.GetDictionary("/Resources");

                    if (objPdfPageResources != null)
                    {
                        PdfSharp.Pdf.PdfDictionary objPdfPageResourcesObjects = objPdfPageResources.Elements.GetDictionary("/XObject");

                        if (objPdfPageResourcesObjects != null)
                        {
                            ICollection<PdfSharp.Pdf.PdfItem> objPdfItems = objPdfPageResourcesObjects.Elements.Values;

                            foreach (PdfSharp.Pdf.PdfItem objPdfItem in objPdfItems)
                            {
                                PdfSharp.Pdf.Advanced.PdfReference objPdfReference = objPdfItem as PdfSharp.Pdf.Advanced.PdfReference;

                                if (objPdfReference != null)
                                {
                                    PdfSharp.Pdf.PdfDictionary objPdfItemObject = objPdfReference.Value as PdfSharp.Pdf.PdfDictionary;

                                    if (objPdfItemObject != null && objPdfItemObject.Elements.GetString("/Subtype") == "/Image")
                                    {
                                        using (var api = OcrApi.Create())
                                        {
                                            api.Init(Languages.Portuguese);
                                            strResultText += api.GetTextFromImage(ExportImage(objPdfItemObject));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                PdfReader objPDFReader = new PdfReader(this.FilePath);
                StringBuilder objStrResult = new StringBuilder();

                for (int i = 1; i <= objPDFReader.NumberOfPages; i++)
                    objStrResult.AppendLine(PdfTextExtractor.GetTextFromPage(objPDFReader, i, new SimpleTextExtractionStrategy()));

                objPDFReader.Close();
                objPDFReader.Dispose();

                strResultText = objStrResult.ToString();
                //strResultText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(strResultText)));

                objPDFReader = null;
                objStrResult = null;
            }

            return strResultText;

        }

        private Bitmap ExportImage(PdfSharp.Pdf.PdfDictionary image)
        {
            string filter = image.Elements.GetName("/Filter");
            switch (filter)
            {
                case "/DCTDecode":
                    byte[] stream = image.Stream.Value;
                    MemoryStream ms = new MemoryStream(stream, 0, stream.Length);
                    ms.Seek(0, SeekOrigin.Begin);

                    Bitmap bmp = new Bitmap(ms);
                    return bmp;
                case "/FlateDecode":
                    return null;
            }

            return null;
        }

    }
}
