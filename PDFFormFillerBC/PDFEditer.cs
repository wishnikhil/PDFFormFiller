using System;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text.pdf;
using System.IO;
using System.Xml.Linq;

namespace PDFFormFillerBC
{
    public class PDFEditer
    {
        public string EditPDFFile(string originalPDF, string editedPDFFolderPath, string keyValuePairsFile, 
            string pdfFormDetailXML, string newPDFFileNameKey, string xmlDataDescendantsMain, string xmlDataDescendantsField)
        {
            string returnMessage = "";
            string editedPDFFilePath = editedPDFFolderPath;
            
            try
            {
                PdfStamper pdfStamper;
                PdfReader pdfReader;

                Dictionary<string, string> dict = null;
                XDocument xDoc = XDocument.Load(pdfFormDetailXML);

                //Read the text file which contains all Keys of pdf file
                string[] allKeyValues = File.ReadAllLines(keyValuePairsFile);

                foreach (XElement xEl in xDoc.Descendants(xmlDataDescendantsMain))
                {
                    //Take the original PDF File to read
                    pdfReader = new PdfReader(originalPDF);

                    //Since the PDF is having password to edit, I have to use unethicalreading property
                    PdfReader.unethicalreading = true;
                    
                    dict = new Dictionary<string, string>();
                    dict = xEl.Descendants(xmlDataDescendantsField).ToDictionary(
                    x => x.Attribute("key").Value,
                    x => x.Attribute("value").Value);
                    editedPDFFilePath = editedPDFFolderPath + "\\" + originalPDF.Split('\\').Last() + "_" + dict[newPDFFileNameKey] + ".pdf";

                    //Creating a new PDF File taking the duplicate copy of original file
                    pdfStamper = new PdfStamper(pdfReader, new FileStream(editedPDFFilePath, FileMode.Create));

                    //Assign acrofields to a variable to edit the fields
                    AcroFields acroFields = pdfStamper.AcroFields;

                    //Get Dictionary values of original fields
                    //Dictionary<string, string> dict = GetDictionaryPDFValues(pdfFormDetailXML);

                    foreach (string line in allKeyValues)
                    {
                        string[] eachKeyValue = line.Split('\t');
                        if (eachKeyValue.Length == 2)
                            acroFields.SetField(eachKeyValue[0], dict[eachKeyValue[1]], true);
                    }
                    //Make PDF Read only
                    pdfStamper.FormFlattening = true;
                    // close the pdf  
                    pdfStamper.Close();
                }
                returnMessage = "PDF Edited successfully";
            }
            catch (Exception ex)
            {
                returnMessage = ex.Message;
            }
            return returnMessage;
        }

    }
}

