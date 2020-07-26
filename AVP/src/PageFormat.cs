using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using iTextSharp.text;
namespace AVP.src
{
    public class PageFormat
    {

        public string SavePage(string appid)
        {
            DBConnection dBConnection = new DBConnection();
            string[] str = new string[5];
            str = dBConnection.getNewData(appid);
            string pdfLocation = ConfigurationManager.AppSettings["SavePdfLocation"];
            string fontBase = ConfigurationManager.AppSettings["rootPath"];
            string fontLocation = ConfigurationManager.AppSettings["fontsLocation"];

            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            BaseFont marathi;
            BaseFont english;
            try
            {
                marathi = iTextSharp.text.pdf.BaseFont.CreateFont(fontBase + fontLocation + "aarti_0.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // --> CHANGED
                english = iTextSharp.text.pdf.BaseFont.CreateFont(fontBase + fontLocation + "times_1.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // --> CHANGED
                iTextSharp.text.Font fontenglish = new iTextSharp.text.Font(english, 14, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font marathiContent = new iTextSharp.text.Font(marathi, 23, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font englishContent = new iTextSharp.text.Font(english, 14, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(marathi, 30, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontNormaladd = new iTextSharp.text.Font(marathi, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontNormalemail = new iTextSharp.text.Font(marathi, 14, iTextSharp.text.Font.NORMAL);
                string str1 = appid;
                Regex reg = new Regex("[*'-/\",_&#^@]");
                str1 = reg.Replace(str1, string.Empty);

                Regex reg1 = new Regex("[ ]");
                str1 = reg.Replace(str1, "-");
                Console.WriteLine(str1);
                bool exists = Directory.Exists(pdfLocation);
                if (!exists)
                {
                    Directory.CreateDirectory(pdfLocation);
                }

                PdfWriter wri;
                try
                {
                    wri = PdfWriter.GetInstance(doc, new FileStream(pdfLocation + "Application-" + str1 + ".pdf", FileMode.Create));
                    //Open Document to write
                    try
                    {
                        doc.Open();
                        PdfPTable table = new PdfPTable(5);
                        PdfPCell cell;

                        string logoLocation = ConfigurationManager.AppSettings["logoLocation"];
                        string imageURL = fontBase + logoLocation;
                        Image jpg;
                        try
                        {
                            jpg = Image.GetInstance(imageURL);
                            jpg.ScaleToFit(140f, 120f);
                            jpg.Alignment = Element.ALIGN_CENTER;
                            cell = new PdfPCell(jpg);
                            cell.Rowspan = 3;
                            cell.Colspan = 1;
                            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                        catch (Exception)
                        {

                        }


                        string bline = "" + Chunk.NEWLINE;
                        iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph(bline, fontNormal); // --->> CHANGED Specify the font to use
                        Phrase head = new Phrase();
                        head.Add(new Chunk("AaidvaasaI ivacaar pa`itaYzana" + Chunk.NEWLINE, fontNormal));
                        head.Add(new Chunk("(rija.k` . maha. óf ó34054)" + Chunk.NEWLINE + Chunk.NEWLINE, fontNormaladd));
                        cell = new PdfPCell(new Phrase(head));
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        cell.Colspan = 5;
                        cell.Rowspan = 2;
                        table.AddCell(cell);

                        iTextSharp.text.Paragraph addrPara = new iTextSharp.text.Paragraph(bline, fontNormaladd); // --->> CHANGED Specify the font to use
                        string address = "pattaa: maataaoEa`I nagar, 3Aó105, ivamk ao naa@yaajavaL, gaavadovaI raoD, AMbarnaaqa(pa), ijalha zaNao 421505";
                        string eid = "adivasivicharmanch@gmail.com";
                        string email = "[-maola : ";
                        string sampark = "saMpak-  : 9833176150ó9766676150";
                        Phrase head_addr = new Phrase();
                        head_addr.Add(new Chunk(address + Chunk.NEWLINE, fontNormaladd));
                        head_addr.Add(new Chunk(email, fontNormalemail));
                        head_addr.Add(new Chunk(eid + Chunk.NEWLINE, fontenglish));
                        head_addr.Add(new Chunk(sampark + Chunk.NEWLINE, fontNormalemail));
                        cell = new PdfPCell(new Phrase(head_addr));
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        cell.Colspan = 5;
                        cell.Rowspan = 1;
                        table.AddCell(cell);

                        string pavti = "paavataI k` .";
                        string srNo = appid + Chunk.NEWLINE;
                        iTextSharp.text.Paragraph receiptno = new iTextSharp.text.Paragraph(); // --->> CHANGED Specify the font to use
                        Phrase appNo = new Phrase();
                        appNo.Add(new Chunk(pavti, marathiContent));
                        appNo.Add(new Chunk(srNo + Chunk.NEWLINE, fontenglish));
                        cell = new PdfPCell(new Phrase(appNo));
                        cell.Colspan = 5;
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(cell);



                        string message1 = "Ea`IósaaO ……………… ";
                        string fullName = str[0] + " " + str[1] + ".";
                        string message2 = " rhaNaar…………. ";
                        string custAddr = str[2];
                        string message3 = "  …………………yaaMjak DUna AaidvaasaI ivacaar ";
                        string message4 = "pa`itaYzana saMsqaolaa Aaiqa-k  doNagaI mhNaUna ";
                        string message5 = "r]  ";
                        string amount = str[3];
                        string message6 = "   (AXarI…………………......................................)";
                        string message7 = "raoKa r@k ma imaLalaI." + Chunk.NEWLINE;
                        string message8 = "Aaiqa-k  madtaIba_la Qanyavaad…." + Chunk.NEWLINE;
                        string message9 = "idnaaMk  : ";
                        string date = str[4];


                        iTextSharp.text.Paragraph namefield = new iTextSharp.text.Paragraph(); // --->> CHANGED Specify the font to use
                        Phrase myContent = new Phrase();
                        myContent.Add(new Chunk(bline, fontNormal));
                        myContent.Add(new Chunk(message1, marathiContent));
                        myContent.Add(new Chunk(fullName, englishContent));
                        myContent.Add(new Chunk(message2, marathiContent));
                        myContent.Add(new Chunk(custAddr, englishContent));
                        myContent.Add(new Chunk(message3, marathiContent));
                        myContent.Add(new Chunk(message4, marathiContent));
                        myContent.Add(new Chunk(message5, marathiContent));
                        myContent.Add(new Chunk(amount, englishContent));
                        myContent.Add(new Chunk(message6, marathiContent));
                        myContent.Add(new Chunk(message7, marathiContent));
                        myContent.Add(new Chunk(message8, marathiContent));
                        myContent.Add(new Chunk(message9, marathiContent));
                        myContent.Add(new Chunk(date, englishContent));
                        myContent.Add(new Chunk(bline, fontNormal));
                        cell = new PdfPCell(new Phrase(myContent));
                        cell.Colspan = 5;
                        cell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                        table.AddCell(cell);


                        string message10 = "sahI       " + Chunk.NEWLINE;
                        string message11 = "(AQyaXaóKaijanadar)";
                        iTextSharp.text.Paragraph signPara = new iTextSharp.text.Paragraph(); // --->> CHANGED Specify the font to use
                        Phrase sign = new Phrase();
                        sign.Add(new Chunk(bline, fontNormal));
                        sign.Add(new Chunk(message10, marathiContent));
                        sign.Add(new Chunk(message11, marathiContent));
                        sign.Add(new Chunk(bline, fontNormal));
                        cell = new PdfPCell(new Phrase(sign));
                        cell.Colspan = 5;
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(cell);

                        string message12 = "This is Computer generated receipt hence does not require signature";
                        iTextSharp.text.Paragraph signNotRequirePara = new iTextSharp.text.Paragraph(); // --->> CHANGED Specify the font to use
                        Phrase signnotReq = new Phrase();
                        signnotReq.Add(new Chunk(message12, englishContent));
                        cell = new PdfPCell(new Phrase(signnotReq));
                        cell.Colspan = 5;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);

                        doc.Add(table);
                        doc.Close(); //Close document
                        return "";
                    }
                    catch (Exception e) {
                        return "Document cannot be Created";
                    }
                }
                catch (Exception e)
                {
                    return "File not found.Check path,font path,image path";
                }
            }
            catch (Exception e)
            {
                return "File not found.Check path,font path,image path";
            }
            //  BaseFont marathi = iTextSharp.text.pdf.BaseFont.CreateFont("E:\\AVP-payment\\Avp-Payment\\Avp-Payment\\Font\\aarti_0.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // --> CHANGED
            // BaseFont english = iTextSharp.text.pdf.BaseFont.CreateFont("E:\\AVP-payment\\Avp-Payment\\Avp-Payment\\Font\\times_1.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // --> CHANGED

        }

    }
}
