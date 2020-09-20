namespace PdfProdigy
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnOpenFolderDialog = new MetroFramework.Controls.MetroButton();
            this.lblImagesPath = new MetroFramework.Controls.MetroLabel();
            this.lblPdfName = new MetroFramework.Controls.MetroLabel();
            this.btnConvertPdf = new MetroFramework.Controls.MetroButton();
            this.imagesFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPdfName = new MetroFramework.Controls.MetroTextBox();
            this.txtImagesDirectory = new MetroFramework.Controls.MetroTextBox();
            this.lnkAbout = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(534, 86);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolderDialog.TabIndex = 1;
            this.btnOpenFolderDialog.Text = "...";
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // lblImagesPath
            // 
            this.lblImagesPath.AutoSize = true;
            this.lblImagesPath.Location = new System.Drawing.Point(40, 67);
            this.lblImagesPath.Name = "lblImagesPath";
            this.lblImagesPath.Size = new System.Drawing.Size(166, 19);
            this.lblImagesPath.TabIndex = 2;
            this.lblImagesPath.Text = "Select Image(s) folder path";
            // 
            // lblPdfName
            // 
            this.lblPdfName.AutoSize = true;
            this.lblPdfName.Location = new System.Drawing.Point(43, 130);
            this.lblPdfName.Name = "lblPdfName";
            this.lblPdfName.Size = new System.Drawing.Size(64, 19);
            this.lblPdfName.TabIndex = 3;
            this.lblPdfName.Text = "PdfName";
            // 
            // btnConvertPdf
            // 
            this.btnConvertPdf.Location = new System.Drawing.Point(251, 217);
            this.btnConvertPdf.Name = "btnConvertPdf";
            this.btnConvertPdf.Size = new System.Drawing.Size(172, 55);
            this.btnConvertPdf.TabIndex = 5;
            this.btnConvertPdf.Text = "Go";
            this.btnConvertPdf.Click += new System.EventHandler(this.btnConvertPdf_Click);
            // 
            // txtPdfName
            // 
            this.txtPdfName.Location = new System.Drawing.Point(40, 152);
            this.txtPdfName.Name = "txtPdfName";
            this.txtPdfName.Size = new System.Drawing.Size(473, 23);
            this.txtPdfName.TabIndex = 6;
            // 
            // txtImagesDirectory
            // 
            this.txtImagesDirectory.Location = new System.Drawing.Point(40, 89);
            this.txtImagesDirectory.Name = "txtImagesDirectory";
            this.txtImagesDirectory.Size = new System.Drawing.Size(473, 23);
            this.txtImagesDirectory.TabIndex = 7;
            // 
            // lnkAbout
            // 
            this.lnkAbout.Location = new System.Drawing.Point(533, 39);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(75, 23);
            this.lnkAbout.TabIndex = 8;
            this.lnkAbout.Text = "About";
            this.lnkAbout.Click += new System.EventHandler(this.lnkAbout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 292);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.txtImagesDirectory);
            this.Controls.Add(this.txtPdfName);
            this.Controls.Add(this.btnConvertPdf);
            this.Controls.Add(this.lblPdfName);
            this.Controls.Add(this.lblImagesPath);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Pdf prodigy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog imagesFolderBrowser;
        private MetroFramework.Controls.MetroTextBox txtPdfName;
        private MetroFramework.Controls.MetroTextBox txtImagesDirectory;
        private MetroFramework.Controls.MetroButton btnOpenFolderDialog;
        private MetroFramework.Controls.MetroLabel lblImagesPath;
        private MetroFramework.Controls.MetroLabel lblPdfName;
        private MetroFramework.Controls.MetroButton btnConvertPdf;
        private MetroFramework.Controls.MetroLink lnkAbout;
    }
}

