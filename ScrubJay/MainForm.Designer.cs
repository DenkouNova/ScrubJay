namespace ScrubJay
{
    partial class MainForm
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnGoToUrl = new System.Windows.Forms.Button();
            this.btnScrub = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tlpMain.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlp1, 0, 0);
            this.tlpMain.Controls.Add(this.webBrowser1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(816, 543);
            this.tlpMain.TabIndex = 0;
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 3;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp1.Controls.Add(this.tbUrl, 0, 0);
            this.tlp1.Controls.Add(this.btnGoToUrl, 1, 0);
            this.tlp1.Controls.Add(this.btnScrub, 2, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(3, 3);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Size = new System.Drawing.Size(810, 54);
            this.tlp1.TabIndex = 0;
            // 
            // tbUrl
            // 
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUrl.Location = new System.Drawing.Point(3, 15);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(644, 20);
            this.tbUrl.TabIndex = 0;
            // 
            // btnGoToUrl
            // 
            this.btnGoToUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToUrl.Location = new System.Drawing.Point(653, 3);
            this.btnGoToUrl.Name = "btnGoToUrl";
            this.btnGoToUrl.Size = new System.Drawing.Size(74, 48);
            this.btnGoToUrl.TabIndex = 1;
            this.btnGoToUrl.Text = "Go to URL";
            this.btnGoToUrl.UseVisualStyleBackColor = true;
            this.btnGoToUrl.Click += new System.EventHandler(this.btnGoToUrl_Click);
            // 
            // btnScrub
            // 
            this.btnScrub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScrub.Location = new System.Drawing.Point(733, 3);
            this.btnScrub.Name = "btnScrub";
            this.btnScrub.Size = new System.Drawing.Size(74, 48);
            this.btnScrub.TabIndex = 2;
            this.btnScrub.Text = "Scrub!";
            this.btnScrub.UseVisualStyleBackColor = true;
            this.btnScrub.Click += new System.EventHandler(this.btnScrub_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(810, 477);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tlpMain.ResumeLayout(false);
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnGoToUrl;
        private System.Windows.Forms.Button btnScrub;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

