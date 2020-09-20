using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

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

        private void btnConvertPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImagesDirectory.Text) || string.IsNullOrEmpty(txtPdfName.Text))
            {
                MessageBox.Show("Fields are mandatory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pdfName = txtPdfName.Text.Replace(".pdf", "");
            pdfName = System.IO.Path.Combine(txtImagesDirectory.Text, pdfName + ".pdf");

            var document = new Document();
            using (var stream = new FileStream(pdfName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();

                foreach (var imageFile in Directory.GetFiles(txtImagesDirectory.Text, "*.jpeg"))
                {
                    using (var imageStream = new FileStream(imageFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = Image.GetInstance(imageStream);
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