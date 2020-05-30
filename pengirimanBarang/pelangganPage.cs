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
    public partial class pelangganPage : UserControl
    {
        private string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=root; Database=ekspedisi";
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int idKota;

        public pelangganPage()
        {
            InitializeComponent();
        }

        private void pelangganPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            retrieveProvinsi();
            showPelanggan();
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

        private int idAlamat()
        {
            Int32 id_alamat = 100;
            sql = "SELECT MAX(id_alamat) AS current_id FROM alamat";
            cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            try
            {
                conn.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_alamat = Int32.Parse(reader["current_id"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id_alamat;
        }

        private void showPelanggan()
        {
            try
            {
                conn.Open();
                sql = "SELECT pelanggan.id_pelanggan AS id, pelanggan.nama_depan, pelanggan.nama_belakang, alamat.alamat, kota.nama_kota AS kota " +
                    "FROM pelanggan " +
                    "INNER JOIN alamat " +
                    "ON pelanggan.id_alamat = alamat.id_alamat " +
                    "INNER JOIN kota " +
                    "ON alamat.id_kota = kota.id_kota";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                pelanggan_dgv.DataSource = null;
                pelanggan_dgv.DataSource = dt;
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            insertAlamat();

            int id_alamat = idAlamat();

            try
            {
                conn.Open();
                sql = "INSERT INTO pelanggan (id_alamat, nama_depan, nama_belakang) " +
                    "VALUES (:id_alamat, :nama_depan, :nama_belakang)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("id_alamat", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters.Add(new NpgsqlParameter("nama_depan", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("nama_belakang", NpgsqlTypes.NpgsqlDbType.Varchar));

                cmd.Prepare();

                cmd.Parameters[0].Value = id_alamat;
                cmd.Parameters[1].Value = fname_textBox.Text;
                cmd.Parameters[2].Value = lname_textBox.Text;

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pelanggan baru berhasil ditambahkan");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            showPelanggan();
        }
    }
}
