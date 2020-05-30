namespace pengirimanBarang
{
    partial class daftarPaket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cari_paket = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.id_paket_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paket_dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.total_pengiriman_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_terkirim_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total_paket_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paket_dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cari_paket);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.id_paket_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 72);
            this.panel1.TabIndex = 0;
            // 
            // btn_cari_paket
            // 
            this.btn_cari_paket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cari_paket.FlatAppearance.BorderSize = 0;
            this.btn_cari_paket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari_paket.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari_paket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cari_paket.Location = new System.Drawing.Point(317, 26);
            this.btn_cari_paket.Name = "btn_cari_paket";
            this.btn_cari_paket.Size = new System.Drawing.Size(87, 27);
            this.btn_cari_paket.TabIndex = 35;
            this.btn_cari_paket.Text = "Cari";
            this.btn_cari_paket.UseVisualStyleBackColor = false;
            this.btn_cari_paket.Click += new System.EventHandler(this.btn_cari_paket_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(410, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 49);
            this.panel5.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(316, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 27);
            this.button2.TabIndex = 36;
            this.button2.Text = "SImpan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 23);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tgl Penerimaan";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(101, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 34;
            // 
            // id_paket_textBox
            // 
            this.id_paket_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.id_paket_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_paket_textBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_paket_textBox.Location = new System.Drawing.Point(101, 28);
            this.id_paket_textBox.Name = "id_paket_textBox";
            this.id_paket_textBox.Size = new System.Drawing.Size(200, 20);
            this.id_paket_textBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Paket";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paket_dgv);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 383);
            this.panel2.TabIndex = 1;
            // 
            // paket_dgv
            // 
            this.paket_dgv.AllowUserToAddRows = false;
            this.paket_dgv.AllowUserToDeleteRows = false;
            this.paket_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paket_dgv.Location = new System.Drawing.Point(23, 6);
            this.paket_dgv.MultiSelect = false;
            this.paket_dgv.Name = "paket_dgv";
            this.paket_dgv.ReadOnly = true;
            this.paket_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paket_dgv.Size = new System.Drawing.Size(824, 324);
            this.paket_dgv.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.total_pengiriman_label);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.total_terkirim_label);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.total_paket_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 47);
            this.panel3.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(637, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Dalam Pengiriman:";
            // 
            // total_pengiriman_label
            // 
            this.total_pengiriman_label.AutoSize = true;
            this.total_pengiriman_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_pengiriman_label.Location = new System.Drawing.Point(800, 11);
            this.total_pengiriman_label.Name = "total_pengiriman_label";
            this.total_pengiriman_label.Size = new System.Drawing.Size(49, 21);
            this.total_pengiriman_label.TabIndex = 41;
            this.total_pengiriman_label.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Terkirim :";
            // 
            // total_terkirim_label
            // 
            this.total_terkirim_label.AutoSize = true;
            this.total_terkirim_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_terkirim_label.Location = new System.Drawing.Point(562, 11);
            this.total_terkirim_label.Name = "total_terkirim_label";
            this.total_terkirim_label.Size = new System.Drawing.Size(49, 21);
            this.total_terkirim_label.TabIndex = 39;
            this.total_terkirim_label.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total :";
            // 
            // total_paket_label
            // 
            this.total_paket_label.AutoSize = true;
            this.total_paket_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_paket_label.Location = new System.Drawing.Point(79, 11);
            this.total_paket_label.Name = "total_paket_label";
            this.total_paket_label.Size = new System.Drawing.Size(49, 21);
            this.total_paket_label.TabIndex = 37;
            this.total_paket_label.Text = "Total";
            // 
            // daftarPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "daftarPaket";
            this.Size = new System.Drawing.Size(869, 455);
            this.Load += new System.EventHandler(this.daftarPaket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paket_dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox id_paket_textBox;
        private System.Windows.Forms.Button btn_cari_paket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_terkirim_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_paket_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_pengiriman_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView paket_dgv;
        private System.Windows.Forms.Button button2;
    }
}
