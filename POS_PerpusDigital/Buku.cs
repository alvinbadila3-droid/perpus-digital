using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_PerpusDigital
{
    public partial class Buku : Form
    {
        public Buku()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_PerpusDigital;Integrated Security=True");

        public bool emptyFields()
        {
            if (txt_judulbuku.Text == "" || txt_namapengarang.Text == "" || txt_kategory.Text == "" || txt_stok.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        private void tbl_BooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_BooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PerpusDigitalDataSet);

        }


        private void Buku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PerpusDigitalDataSet.Tbl_Books' table. You can move, or remove it, as needed.
            this.tbl_BooksTableAdapter.Fill(this.dB_PerpusDigitalDataSet.Tbl_Books);

        }

        private void txt_kategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_namapengarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_judulbuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua Kolom Harus Di Isi", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string insertdata = ("insert into Tbl_Books (JudulBuku,NamaPengarang,Kategory,Stok)" + "values (@Judul,@Pengarang,@Kategory,@Stok)");
                        using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                        {
                            cmd.Parameters.AddWithValue("@Judul", txt_judulbuku.Text.Trim());
                            cmd.Parameters.AddWithValue("@Pengarang", txt_namapengarang.Text.Trim());
                            cmd.Parameters.AddWithValue("@Kategory", txt_kategory.Text.Trim());
                            cmd.Parameters.AddWithValue("@Stok", txt_stok.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("menambahkan product Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txt_stok.Text.Trim(), out int stock))
            {
                MessageBox.Show("Stock harus berupa angka.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult check = MessageBox.Show(
              "Apakah anda yakin untuk memperbarui buku ini: " + txt_judulbuku.Text.Trim() + "?",
              "Confirmation Message",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );
            if (check != DialogResult.Yes)
                return;
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string updatedata = ("update Tbl_Books set JudulBuku =@JB, NamaPengarang =@NP , Kategory =@KT ,Stok =@ST");
                    using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                    {
                        cmd.Parameters.AddWithValue("@JB", txt_judulbuku.Text.Trim());
                        cmd.Parameters.AddWithValue("@NP", txt_namapengarang.Text.Trim());
                        cmd.Parameters.AddWithValue("@KT", txt_kategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@ST", stock);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("memperbarui product Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally { connect.Close(); }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            string judulbuku = txt_judulbuku.Text.Trim();

            // Validasi jika textbox kosong
            if (string.IsNullOrEmpty(judulbuku))
            {
                MessageBox.Show("Silakan masukkan Kode Produk yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan pesan konfirmasi
            DialogResult dialogResult = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus produk dengan Kode Produk: {judulbuku}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {

                string query = "DELETE FROM [dbo].[Tbl_Books] WHERE [JudulBuku] = @judul";
                try
                {

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@judul", judulbuku);

                        connect.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            txt_judulbuku.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan. Pastikan Kode Produk yang dimasukkan benar.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan pada database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
