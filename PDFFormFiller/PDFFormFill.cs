using System;
using System.Configuration;
using System.Resources;
using System.Windows.Forms;
using PDFFormFiller.Properties;
using PDFFormFillerBC;

namespace PDFFormFiller
{
    public partial class PDFFormFiller : Form
    {
        public PDFFormFiller()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            SetText();
        }

        //Set display text for all controller
        private void SetText()
        {
            lblInputPDF.Text = Resources.InputLabel;
            lblEditedPath.Text = Resources.OutputDirectory;
            btnInputFile.Text = Resources.btnBrowseInput;
            btnOutputFolder.Text = Resources.btnBrowseOutput;
            btnGenerateEditedPDF.Text = Resources.btnGenerateEditPDF;
        }

        //Take values from App config file
        string title = ConfigurationManager.AppSettings.Get("title");
        string initialBrowseLoc = ConfigurationManager.AppSettings.Get("initialBrowseLoc");
        string browseFilter = ConfigurationManager.AppSettings.Get("browseFilter");
        string newPDFFileNameKey = ConfigurationManager.AppSettings.Get("newPDFFileNameKey");
        string xmlDataDescendantsMain = ConfigurationManager.AppSettings.Get("xmlDataDescendantsMain");
        string xmlDataDescendantsField = ConfigurationManager.AppSettings.Get("xmlDataDescendantsField");
        
        //On Button Click
        private void BtnGenerateEditedPDF_Click(object sender, EventArgs e)
        {
            //Check if fields are empty
            if(String.IsNullOrEmpty(txtOriginalPDFFile.Text) || String.IsNullOrEmpty(txtEditedPDFFolder.Text))
            {
                MessageBox.Show(Resources.ErrorMessage1, title,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            string pdfTemplate = txtOriginalPDFFile.Text;
            string newFile = txtEditedPDFFolder.Text;
            string keyValueFile = ConfigurationManager.AppSettings.Get("keyValueFile");
            string xmlPDFDataFile = ConfigurationManager.AppSettings.Get("xmlPDFFormFile");

            PDFEditer pDFEditer = new PDFEditer();

            // Call method from business class
            string message = pDFEditer.EditPDFFile(pdfTemplate, newFile, keyValueFile, xmlPDFDataFile, newPDFFileNameKey, xmlDataDescendantsMain, xmlDataDescendantsField);
            progressBar1.Value = 100;
            MessageBox.Show(message,title,MessageBoxButtons.OK,MessageBoxIcon.Information);
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            txtEditedPDFFolder.Focus();
        }

        // Get file from local
        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = title;
            openFileDialog.InitialDirectory = initialBrowseLoc;
            openFileDialog.Filter = browseFilter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOriginalPDFFile.Text = openFileDialog.FileName;
            }
        }

        // set output directory
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
