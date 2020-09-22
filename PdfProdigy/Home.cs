using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PdfProdigy
{
    public partial class Home : MetroForm
    {
        private About aboutForm;

        public Home()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = imagesFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtImagesDirectory.Text = imagesFolderBrowser.SelectedPath;
            }
        }

        private bool isDirectoryHasFiles(string directory, string searchPattern)
        {
            return Directory.GetFiles(directory, searchPattern).Any();
        }

        private void btnConvertPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImagesDirectory.Text) || string.IsNullOrWhiteSpace(txtPdfName.Text) || string.IsNullOrWhiteSpace(txtSearchPattern.Text))
            {
                MessageBox.Show("Fields are mandatory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isDirectoryHasFiles(txtImagesDirectory.Text, txtSearchPattern.Text))
            {
                MessageBox.Show("No files on specified directory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pdfName = txtPdfName.Text.Replace(".pdf", "");
            pdfName = System.IO.Path.Combine(txtImagesDirectory.Text, pdfName + ".pdf");

            var document = new Document();
            using (var stream = new FileStream(pdfName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();

                foreach (var imageFile in Directory.GetFiles(txtImagesDirectory.Text, txtSearchPattern.Text))
                {
                    using (var imageStream = new FileStream(imageFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = iTextSharp.text.Image.GetInstance(imageStream);
                        if (image.Height > PageSize.A4.Height - 25)
                        {
                            image.ScaleToFit(PageSize.A4.Width - 25, PageSize.A4.Height - 25);
                        }
                        else if (image.Width > PageSize.A4.Width - 25)
                        {
                            image.ScaleToFit(PageSize.A4.Width - 25, PageSize.A4.Height - 25);
                        }
                        image.Alignment = Element.ALIGN_MIDDLE;
                        document.Add(image);
                    }
                }

                document.Close();

                MessageBox.Show("Convertion is done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnkAbout_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show();
        }
    }
}