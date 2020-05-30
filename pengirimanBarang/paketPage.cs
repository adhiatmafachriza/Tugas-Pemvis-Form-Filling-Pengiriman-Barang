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
    public partial class paketPage : UserControl
    {
        private string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=root; Database=ekspedisi";
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int idKota;
        private int rowIndex = -1;

        public paketPage()
        {
            InitializeComponent();
        }

        private void paketPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            retrieveProvinsi();
            retrieveLayanan();
            //showBarang();
        }

        private void retrieveProvinsi()
        {
            provinsi_comboBox.Items.Clear();
            conn.Open();
            sql = "SELECT nama_provinsi FROM provinsi";
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                provinsi_comboBox.Items.Add(dr["nama_provinsi"].ToString());
            }

            conn.Close();
        }

        private void retrieveLayanan()
        {
            layanan_comboBox.Items.Clear();

            try
            {
                conn.Open();
                sql = "SELECT nama_layanan FROM layanan";
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    layanan_comboBox.Items.Add(dr["nama_layanan"].ToString());
                }

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void provinsi_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_provinsi = provinsi_comboBox.SelectedIndex + 1;
            string str_id_provinsi = id_provinsi.ToString();
            kota_comboBox.Items.Clear();
            conn.Open();
            sql = "SELECT kota.nama_kota " +
                "FROM kota " +
                "INNER JOIN provinsi " +
                "ON kota.id_provinsi = provinsi.id_provinsi " +
                "WHERE kota.id_provinsi = " + str_id_provinsi;
            cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                kota_comboBox.Items.Add(dr["nama_kota"].ToString());
            }

            conn.Close();
        }

        private void insertAlamat()
        {
            if (provinsi_comboBox.SelectedIndex == 0)
            {
                idKota = kota_comboBox.SelectedIndex + 1;
            }
            else if (provinsi_comboBox.SelectedIndex == 1)
            {
                idKota = kota_comboBox.SelectedIndex + 39;
            }
            else if (provinsi_comboBox.SelectedIndex == 2)
            {
                idKota = kota_comboBox.SelectedIndex + 74;
            }

            try
            {
                conn.Open();
                sql = "INSERT INTO alamat (id_kota, alamat, nomor_telepon, kode_pos) " +
                    "VALUES (:id_kota, :alamat, :nomor_telepon, :kode_pos)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("id_kota", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("alamat", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("nomor_telepon", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("kode_pos", NpgsqlTypes.NpgsqlDbType.Varchar));

                cmd.Prepare();

                cmd.Parameters[0].Value = idKota;
                cmd.Parameters[1].Value = alamat_textBox.Text;
                cmd.Parameters[2].Value = noTelp_textBox.Text;
                cmd.Parameters[3].Value = kodePos_textBox.Text;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int idAlamat()
        {
            Int32 id_alamat = 0;

            try
            {
                conn.Open();

                sql = "SELECT MAX(id_alamat) AS current_id FROM alamat";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_alamat = Int32.Parse(reader["current_id"].ToString());
                }

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id_alamat;
        }

        private int idPaket()
        {
            Int32 id_paket = 0;

            try
            {
                conn.Open();

                sql = "SELECT MAX(id_paket) AS current_id FROM paket";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_paket = Int32.Parse(reader["current_id"].ToString());
                }

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id_paket;
        }

        private void showBarang()
        {
            try
            {
                conn.Open();

                sql = "SELECT barang.id_barang, barang.deskripsi, barang.berat " +
                    "FROM barang " +
                    "INNER JOIN paket ON barang.id_paket = paket.id_paket " +
                    "WHERE paket.id_paket = (SELECT MAX(id_paket) FROM paket)";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                barang_dgv.DataSource = null;
                barang_dgv.DataSource = dt;

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String getPengirim()
        {
            Int32 id_pelanggan = Int32.Parse(pelanggan_id_textBox.Text);
            String nama = "";

            try
            {
                conn.Open();

                sql = "SELECT nama_depan, nama_belakang FROM pelanggan WHERE id_pelanggan = " + id_pelanggan;
                cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    nama = reader[0].ToString() + " " + reader[1].ToString();
                }
                else
                {
                    return "pelanggan tidak ditemukan";
                }

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return nama;
        }

        private void btn_insert_paket_Click(object sender, EventArgs e)
        {
            insertAlamat();
            int id_alamat = idAlamat();
            int id_pelanggan = Int32.Parse(pelanggan_id_textBox.Text);

            try
            {
                conn.Open();

                sql = "INSERT INTO paket (id_layanan, id_alamat_tujuan, nama_penerima, tanggal_pengiriman, id_pelanggan) " +
                    "VALUES (:id_layanan, :id_alamat_tujuan, :nama_penerima, :tanggal_pengiriman, :id_pelanggan)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("id_layanan", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("id_alamat_tujuan", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("nama_penerima", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("tanggal_pengiriman", NpgsqlTypes.NpgsqlDbType.Date));
                cmd.Parameters.Add(new NpgsqlParameter("id_pelanggan", NpgsqlTypes.NpgsqlDbType.Integer));

                cmd.Prepare();

                cmd.Parameters[0].Value = layanan_comboBox.SelectedIndex + 1;
                cmd.Parameters[1].Value = id_alamat;
                cmd.Parameters[2].Value = penerima_textBox.Text;
                cmd.Parameters[3].Value = dateTimePicker1.Value;
                cmd.Parameters[4].Value = id_pelanggan;

                cmd.ExecuteNonQuery();
                barang_dgv.DataSource = null;

                conn.Close();
                MessageBox.Show("Paket baru berhasil dibuat, silahkan masukkan daftar barang yang akan dimuat");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            pengirim_label.Text = getPengirim();
        }

        private void btn_insert_barang_Click(object sender, EventArgs e)
        {
            int id_paket = idPaket();

            try
            {
                conn.Open();

                sql = "INSERT INTO barang (id_paket, deskripsi, berat) " +
                    "VALUES (:id_paket, :deskripsi, :berat)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("id_paket", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("deskripsi", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("berat", NpgsqlTypes.NpgsqlDbType.Integer));

                cmd.Prepare();

                cmd.Parameters[0].Value = id_paket;
                cmd.Parameters[1].Value = deskripsi_textBox.Text;
                cmd.Parameters[2].Value = Int32.Parse(berat_textBox.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showBarang();
        }

        private void barang_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
            }
        }

        private void btn_hapus_barang_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "DELETE FROM barang WHERE id_barang = :id_barang";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("id_barang", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Prepare();
                cmd.Parameters[0].Value = Int32.Parse(barang_dgv.Rows[rowIndex].Cells["id_barang"].Value.ToString());
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Barang berhasil dihapus");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showBarang();
        }
    }
}
