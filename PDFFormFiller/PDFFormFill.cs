using System;
using System.Configuration;
using System.Windows.Forms;
using PDFFormFillerBC;

namespace PDFFormFiller
{
    public partial class PDFFormFiller : Form
    {
        public PDFFormFiller()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }
        string title = ConfigurationManager.AppSettings.Get("title");
        string initialBrowseLoc = ConfigurationManager.AppSettings.Get("initialBrowseLoc");
        string browseFilter = ConfigurationManager.AppSettings.Get("browseFilter");
        string newPDFFileNameKey = ConfigurationManager.AppSettings.Get("newPDFFileNameKey");
        string xmlDataDescendantsMain = ConfigurationManager.AppSettings.Get("xmlDataDescendantsMain");
        string xmlDataDescendantsField = ConfigurationManager.AppSettings.Get("xmlDataDescendantsField");
        private void BtnGenerateEditedPDF_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            string pdfTemplate = txtOriginalPDFFile.Text;
            string newFile = txtEditedPDFFolder.Text;
            string keyValueFile = ConfigurationManager.AppSettings.Get("keyValueFile");
            string xmlPDFDataFile = ConfigurationManager.AppSettings.Get("xmlPDFFormFile");

            PDFEditer pDFEditer = new PDFEditer();
            string message = pDFEditer.EditPDFFile(pdfTemplate, newFile, keyValueFile, xmlPDFDataFile, newPDFFileNameKey, xmlDataDescendantsMain, xmlDataDescendantsField);
            progressBar1.Value = 100;
            MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            txtEditedPDFFolder.Focus();
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.Title = title;
            openFileDialog.InitialDirectory = initialBrowseLoc;
            openFileDialog.Filter = browseFilter;
            //openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOriginalPDFFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditedPDFFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
