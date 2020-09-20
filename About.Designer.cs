namespace PdfProdigy
{
    partial class About
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
            this.lblAuthorName = new MetroFramework.Controls.MetroLabel();
            this.lblAuthorMail = new MetroFramework.Controls.MetroLink();
            this.lblAuthorSite = new MetroFramework.Controls.MetroLink();
            this.lblAuthorTwt = new MetroFramework.Controls.MetroLink();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(24, 85);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(169, 19);
            this.lblAuthorName.TabIndex = 1;
            this.lblAuthorName.Text = "karthikkumar subramaniam";
            // 
            // lblAuthorMail
            // 
            this.lblAuthorMail.Location = new System.Drawing.Point(24, 121);
            this.lblAuthorMail.Name = "lblAuthorMail";
            this.lblAuthorMail.Size = new System.Drawing.Size(239, 23);
            this.lblAuthorMail.TabIndex = 2;
            this.lblAuthorMail.Text = "Mail: karthiksubramaniam@live.com";
            this.lblAuthorMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAuthorMail.Click += new System.EventHandler(this.lblAuthorMail_Click);
            // 
            // lblAuthorSite
            // 
            this.lblAuthorSite.Location = new System.Drawing.Point(24, 161);
            this.lblAuthorSite.Name = "lblAuthorSite";
            this.lblAuthorSite.Size = new System.Drawing.Size(239, 23);
            this.lblAuthorSite.TabIndex = 3;
            this.lblAuthorSite.Text = "http://beingdotnetgeeks.wordpress.com";
            this.lblAuthorSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAuthorSite.Click += new System.EventHandler(this.lblAuthorSite_Click);
            // 
            // lblAuthorTwt
            // 
            this.lblAuthorTwt.Location = new System.Drawing.Point(24, 202);
            this.lblAuthorTwt.Name = "lblAuthorTwt";
            this.lblAuthorTwt.Size = new System.Drawing.Size(239, 23);
            this.lblAuthorTwt.TabIndex = 4;
            this.lblAuthorTwt.Text = "twitter.com/hash_karthick";
            this.lblAuthorTwt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAuthorTwt.Click += new System.EventHandler(this.lblAuthorTwt_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(114, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Grrr!";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAuthorTwt);
            this.Controls.Add(this.lblAuthorSite);
            this.Controls.Add(this.lblAuthorMail);
            this.Controls.Add(this.lblAuthorName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "About";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblAuthorName;
        private MetroFramework.Controls.MetroLink lblAuthorMail;
        private MetroFramework.Controls.MetroLink lblAuthorSite;
        private MetroFramework.Controls.MetroLink lblAuthorTwt;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}