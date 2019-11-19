namespace PDFFormFiller
{
    partial class PDFFormFiller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFFormFiller));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOriginalPDFFile = new System.Windows.Forms.TextBox();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.txtEditedPDFFolder = new System.Windows.Forms.TextBox();
            this.btnGenerateEditedPDF = new System.Windows.Forms.Button();
            this.lblInputPDF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDFFormFiller.Properties.Resources.vanhack;
            this.pictureBox1.Location = new System.Drawing.Point(609, 203);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtOriginalPDFFile
            // 
            this.txtOriginalPDFFile.Location = new System.Drawing.Point(126, 24);
            this.txtOriginalPDFFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOriginalPDFFile.Name = "txtOriginalPDFFile";
            this.txtOriginalPDFFile.Size = new System.Drawing.Size(469, 21);
            this.txtOriginalPDFFile.TabIndex = 1;
            // 
            // btnInputFile
            // 
            this.btnInputFile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInputFile.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnInputFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnInputFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputFile.Location = new System.Drawing.Point(609, 24);
            this.btnInputFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(107, 23);
            this.btnInputFile.TabIndex = 2;
            this.btnInputFile.Text = "Browse";
            this.btnInputFile.UseVisualStyleBackColor = false;
            this.btnInputFile.Click += new System.EventHandler(this.BtnInputFile_Click);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOutputFolder.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnOutputFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputFolder.Location = new System.Drawing.Point(609, 65);
            this.btnOutputFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(107, 23);
            this.btnOutputFolder.TabIndex = 4;
            this.btnOutputFolder.Text = "Browse Folder";
            this.btnOutputFolder.UseVisualStyleBackColor = false;
            this.btnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // txtEditedPDFFolder
            // 
            this.txtEditedPDFFolder.Location = new System.Drawing.Point(126, 65);
            this.txtEditedPDFFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEditedPDFFolder.Name = "txtEditedPDFFolder";
            this.txtEditedPDFFolder.Size = new System.Drawing.Size(469, 21);
            this.txtEditedPDFFolder.TabIndex = 3;
            // 
            // btnGenerateEditedPDF
            // 
            this.btnGenerateEditedPDF.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGenerateEditedPDF.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnGenerateEditedPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnGenerateEditedPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateEditedPDF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateEditedPDF.Location = new System.Drawing.Point(126, 149);
            this.btnGenerateEditedPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateEditedPDF.Name = "btnGenerateEditedPDF";
            this.btnGenerateEditedPDF.Size = new System.Drawing.Size(469, 23);
            this.btnGenerateEditedPDF.TabIndex = 5;
            this.btnGenerateEditedPDF.Text = "Generate Edited PDF";
            this.btnGenerateEditedPDF.UseVisualStyleBackColor = false;
            this.btnGenerateEditedPDF.Click += new System.EventHandler(this.BtnGenerateEditedPDF_Click);
            // 
            // lblInputPDF
            // 
            this.lblInputPDF.AutoSize = true;
            this.lblInputPDF.Location = new System.Drawing.Point(19, 27);
            this.lblInputPDF.Name = "lblInputPDF";
            this.lblInputPDF.Size = new System.Drawing.Size(77, 13);
            this.lblInputPDF.TabIndex = 6;
            this.lblInputPDF.Text = "Original PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edited PDF Path";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // PDFFormFiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 270);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInputPDF);
            this.Controls.Add(this.btnGenerateEditedPDF);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.txtEditedPDFFolder);
            this.Controls.Add(this.btnInputFile);
            this.Controls.Add(this.txtOriginalPDFFile);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PDFFormFiller";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "PDF Form Filler";
            this.Text = "PDF Form Filler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOriginalPDFFile;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.TextBox txtEditedPDFFolder;
        private System.Windows.Forms.Button btnGenerateEditedPDF;
        private System.Windows.Forms.Label lblInputPDF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

