using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pengirimanBarang
{
    public partial class daftarPaket : UserControl
    {
        private string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=root; Database=ekspedisi";
        private NpgsqlCommand cmd;
        private String sql;
        private NpgsqlConnection conn;

        public daftarPaket()
        {
            InitializeComponent();
        }

        private void daftarPaket_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            panel5.Visible = false;
            retrievePaket(0);
            total_paket_label.Text = countTotal();
            total_pengiriman_label.Text = countDalamPengiriman();
            total_terkirim_label.Text = countTerkirim();
        }

        private void retrievePaket(int id)
        {
            if(id == 0)
            {
                try
                {
                    conn.Open();

                    sql = "SELECT " +
                            "paket.id_paket, " +
                            "paket.id_pelanggan AS id_pengirim, " +
                            "pelanggan.nama_depan AS pengirim, " +
                            "paket.nama_penerima AS penerima, " +
                            "alamat.alamat AS tujuan, " +
                            "kota.nama_kota AS kota, " +
                            "layanan.nama_layanan AS servis, " +
                            "paket.tanggal_pengiriman AS dikirim," +
                            "paket.tanggal_penerimaan AS diterima," +
                            "paket.ongkir AS ongkir " +
                           "FROM paket " +
                           "INNER JOIN pelanggan ON paket.id_pelanggan = pelanggan.id_pelanggan " +
                           "INNER JOIN alamat ON paket.id_alamat_tujuan = alamat.id_alamat " +
                           "INNER JOIN layanan ON paket.id_layanan = layanan.id_layanan " +
                           "INNER JOIN kota ON alamat.id_kota = kota.id_kota";

                    cmd = new NpgsqlCommand(sql, conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    paket_dgv.DataSource = null;
                    paket_dgv.DataSource = dt;

                    conn.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    conn.Open();

                    sql = "SELECT " +
                            "paket.id_paket, " +
                            "paket.id_pelanggan AS id_pengirim, " +
                            "pelanggan.nama_depan AS pengirim, " +
                            "paket.nama_penerima AS penerima, " +
                            "alamat.alamat AS tujuan, " +
                            "kota.nama_kota AS kota, " +
                            "layanan.nama_layanan AS servis, " +
                            "paket.tanggal_pengiriman AS dikirim," +
                            "paket.tanggal_penerimaan AS diterima," +
                            "paket.ongkir AS ongkir " +
                           "FROM paket " +
                           "INNER JOIN pelanggan ON paket.id_pelanggan = pelanggan.id_pelanggan " +
                           "INNER JOIN alamat ON paket.id_alamat_tujuan = alamat.id_alamat " +
                           "INNER JOIN layanan ON paket.id_layanan = layanan.id_layanan " +
                           "INNER JOIN kota ON alamat.id_kota = kota.id_kota " +
                           "WHERE paket.id_paket = " + id;

                    cmd = new NpgsqlCommand(sql, conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    paket_dgv.DataSource = null;
                    paket_dgv.DataSource = dt;

                    conn.Close();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private String countTotal()
        {
            String total = "";

            try
            {
                conn.Open();
                sql = "SELECT COUNT(id_paket) FROM paket";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                    total = reader[0].ToString();
                else
                    return "0";

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            return total;
        }

        private String countDalamPengiriman()
        {
            String total = "";

            try
            {
                conn.Open();
                sql = "SELECT COUNT(id_paket) FROM paket WHERE tanggal_penerimaan IS NULL";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                    total = reader[0].ToString();
                else
                    return "0";

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return total;
        }

        private String countTerkirim()
        {
            String total = "";

            try
            {
                conn.Open();
                sql = "SELECT COUNT(id_paket) FROM paket WHERE tanggal_penerimaan IS NOT NULL";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                    total = reader[0].ToString();
                else
                    return "0";

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return total;
        }

        private void updatePaket()
        {
            try
            {
                conn.Open();
                sql = "UPDATE paket SET tanggal_penerimaan = :tanggal_penerimaan WHERE id_paket = :id_paket";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("tanggal_penerimaan", NpgsqlTypes.NpgsqlDbType.Date));
                cmd.Parameters.Add(new NpgsqlParameter("id_paket", NpgsqlTypes.NpgsqlDbType.Integer));

                cmd.Prepare();

                cmd.Parameters[0].Value = dateTimePicker1.Value;
                cmd.Parameters[1].Value = Int32.Parse(id_paket_textBox.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cari_paket_Click(object sender, EventArgs e)
        {
            if(id_paket_textBox.Text == "")
            {
                panel5.Visible = false;
                retrievePaket(0);
                total_paket_label.Text = countTotal();
                total_pengiriman_label.Text = countDalamPengiriman();
                total_terkirim_label.Text = countTerkirim();
                total_paket_label.Visible = true;
                total_pengiriman_label.Visible = true;
                total_terkirim_label.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
            }
            else
            {
                panel5.Visible = true;
                int id_paket = Int32.Parse(id_paket_textBox.Text);
                retrievePaket(id_paket);
                total_paket_label.Visible = false;
                total_pengiriman_label.Visible = false;
                total_terkirim_label.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_paket;

            if (id_paket_textBox.Text == "")
                MessageBox.Show("Mohon isi id paket terlebih dahulu");
            else
            {
                id_paket = Int32.Parse(id_paket_textBox.Text);
                updatePaket();
                retrievePaket(id_paket);
                total_paket_label.Visible = false;
                total_pengiriman_label.Visible = false;
                total_terkirim_label.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                MessageBox.Show("Tanggal penerimaan baru berhasil ditambahkan");
            }
        }
    }
}
