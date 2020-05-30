namespace pengirimanBarang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.daftarPaket = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnPaket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.page_title = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.daftarPaket);
            this.panel1.Controls.Add(this.btnPelanggan);
            this.panel1.Controls.Add(this.btnPaket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 498);
            this.panel1.TabIndex = 0;
            // 
            // daftarPaket
            // 
            this.daftarPaket.BackColor = System.Drawing.Color.RoyalBlue;
            this.daftarPaket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("daftarPaket.BackgroundImage")));
            this.daftarPaket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.daftarPaket.FlatAppearance.BorderSize = 0;
            this.daftarPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daftarPaket.Location = new System.Drawing.Point(0, 243);
            this.daftarPaket.Name = "daftarPaket";
            this.daftarPaket.Size = new System.Drawing.Size(85, 67);
            this.daftarPaket.TabIndex = 19;
            this.daftarPaket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.daftarPaket.UseVisualStyleBackColor = false;
            this.daftarPaket.Click += new System.EventHandler(this.daftarPaket_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPelanggan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPelanggan.BackgroundImage")));
            this.btnPelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPelanggan.FlatAppearance.BorderSize = 0;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.Location = new System.Drawing.Point(0, 97);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(85, 67);
            this.btnPelanggan.TabIndex = 18;
            this.btnPelanggan.UseVisualStyleBackColor = false;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // btnPaket
            // 
            this.btnPaket.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPaket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaket.BackgroundImage")));
            this.btnPaket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPaket.FlatAppearance.BorderSize = 0;
            this.btnPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaket.Location = new System.Drawing.Point(0, 170);
            this.btnPaket.Name = "btnPaket";
            this.btnPaket.Size = new System.Drawing.Size(85, 67);
            this.btnPaket.TabIndex = 17;
            this.btnPaket.UseVisualStyleBackColor = false;
            this.btnPaket.Click += new System.EventHandler(this.btnPaket_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.page_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(85, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 43);
            this.panel2.TabIndex = 1;
            // 
            // page_title
            // 
            this.page_title.AutoSize = true;
            this.page_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_title.Location = new System.Drawing.Point(8, 12);
            this.page_title.Name = "page_title";
            this.page_title.Size = new System.Drawing.Size(42, 19);
            this.page_title.TabIndex = 0;
            this.page_title.Text = "TITLE";
            // 
            // panelContainer
            // 
            this.panelContainer.AccessibleName = "";
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(85, 43);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(869, 455);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 498);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button daftarPaket;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnPaket;
        private System.Windows.Forms.Label page_title;
    }
}

