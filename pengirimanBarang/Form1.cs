using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pengirimanBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(home);
            page_title.Text = "";
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            pelangganPage pelanggan = new pelangganPage();
            pelanggan.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(pelanggan);
            panelContainer.Controls["pelangganPage"].BringToFront();
            page_title.Text = "PELANGGAN";
            btnPelanggan.BackColor = Color.CornflowerBlue;
            btnPaket.BackColor = Color.RoyalBlue;
            daftarPaket.BackColor = Color.RoyalBlue;
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            paketPage paket = new paketPage();
            paket.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(paket);
            panelContainer.Controls["paketPage"].BringToFront();
            page_title.Text = "KIRIM PAKET";
            btnPelanggan.BackColor = Color.RoyalBlue;
            btnPaket.BackColor = Color.CornflowerBlue;
            daftarPaket.BackColor = Color.RoyalBlue;
        }

        private void daftarPaket_Click(object sender, EventArgs e)
        {
            daftarPaket paket = new daftarPaket();
            paket.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(paket);
            panelContainer.Controls["daftarPaket"].BringToFront();
            page_title.Text = "CARI PAKET";
            btnPelanggan.BackColor = Color.RoyalBlue;
            btnPaket.BackColor = Color.RoyalBlue;
            daftarPaket.BackColor = Color.CornflowerBlue;
        }
    }
}
