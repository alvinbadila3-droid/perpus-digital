using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS_PerpusDigital
{
    public partial class peminjamann : Form
    {
        public peminjamann()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_PerpusDigital;Integrated Security=True";
        private void peminjamann_Load(object sender, EventArgs e)
        {
            SetupTanggalOtomatis();
            InitAutoCompleteJudulBuku();
        }
        
        private void CetakStrukPeminjaman(int loanId, string memberId, string judulBuku, string tglPinjam, string tglDueDate)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font fontHeader = new Font("Courier New", 12, FontStyle.Bold);
                Font fontTitle = new Font("Courier New", 10, FontStyle.Bold);
                Font fontBody = new Font("Courier New", 9, FontStyle.Regular);

                int x = 20, y = 20;
                g.DrawString("PERPUSTAKAAN DIGITAL LKS", fontHeader, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 15;
                g.DrawString("BUKTI PEMINJAMAN BUKU", fontTitle, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 20;
                g.DrawString($"ID Transaksi  : {loanId}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"ID Member     : {memberId}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"Judul Buku    : {judulBuku}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"Tgl Pinjam    : {tglPinjam}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"Batas Tempo   : {tglDueDate}", fontBody, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 20;
                g.DrawString("   Simpan struk ini sebagai bukti resmi", fontBody, Brushes.Black, x, y);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, Width = 200, Height = 300 };
            preview.ShowDialog();
        }


        
        private void SetupTanggalOtomatis()
        {
            dtpLoanDate.Value = DateTime.Now;
            dtpDueDate.Value = dtpLoanDate.Value.AddDays(7);
            dtpDueDate.Enabled = false; 
        }

        private void dtpLoanDate_ValueChanged_1(object sender, EventArgs e)
        {
            dtpDueDate.Value = dtpLoanDate.Value.AddDays(7);
        }
        private AutoCompleteStringCollection autoSuggestBuku = new AutoCompleteStringCollection();
        
        private void InitAutoCompleteJudulBuku()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT JudulBuku FROM Tbl_Books";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        autoSuggestBuku.Clear();
                        while (reader.Read())
                        {
                            autoSuggestBuku.Add(reader["JudulBuku"].ToString());
                        }
                    }
                }

                
                txt_judulbuku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_judulbuku.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_judulbuku.AutoCompleteCustomSource = autoSuggestBuku;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat auto complete judul buku: " + ex.Message, "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetBukuIdByJudul(string judulBuku, SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT BukuID FROM Tbl_Books WHERE JudulBuku = @JudulBuku";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@JudulBuku", judulBuku);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return -1; 
        }

        private void btnProsesPinjam_Click_1(object sender, EventArgs e)
        {
            // Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(txtMemberID.Text) || string.IsNullOrWhiteSpace(txt_judulbuku.Text))
            {
                MessageBox.Show("Member ID dan Judul Buku wajib diisi!", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberId;
            if (!int.TryParse(txtMemberID.Text, out memberId))
            {
                MessageBox.Show("Member ID harus angka!", "Validasi Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string judulInput = txt_judulbuku.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                
                string checkTanggunganQuery = @"SELECT COUNT(*) FROM Tbl_Loans 
                                               WHERE MemberID = @MemberID 
                                               AND ReturnDate IS NULL";

                using (SqlCommand cmdCheck = new SqlCommand(checkTanggunganQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@MemberID", memberId);
                    int tanggunganAktif = (int)cmdCheck.ExecuteScalar();

                    if (tanggunganAktif > 0)
                    {
                        MessageBox.Show("Peminjaman gagal! Member ini masih memiliki tanggungan buku yang belum dikembalikan.",
                                        "Validasi Tanggungan Aktif", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

               
                SqlTransaction transaction = conn.BeginTransaction();
                int newLoanId = 0;
                try
                {
                    
                    int bukuId = GetBukuIdByJudul(judulInput, conn, transaction);

                    if (bukuId == -1)
                    {
                        MessageBox.Show("Judul buku tidak valid atau tidak ditemukan dalam database!", "Error Judul Buku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    // Validasi Stok Buku
                    string checkStokQuery = "SELECT Stok FROM Tbl_Books WHERE BukuID = @BukuID";
                    int stokSaatIni = 0;

                    using (SqlCommand cmdStok = new SqlCommand(checkStokQuery, conn, transaction))
                    {
                        cmdStok.Parameters.AddWithValue("@BukuID", bukuId);
                        object result = cmdStok.ExecuteScalar();
                        stokSaatIni = Convert.ToInt32(result);
                    }

                    if (stokSaatIni <= 0)
                    {
                        MessageBox.Show("Stok buku habis! Peminjaman tidak dapat diproses.", "Stok Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    
                    string insertLoanQuery = @"INSERT INTO Tbl_Loans (MemberID, BukuID, LoanDate, DueDate, ReturnDate, FineAmount, Status) 
                                               VALUES (@MemberID, @BukuID, @LoanDate, @DueDate, NULL, 0.00, 'Dipinjam')";

                    using (SqlCommand cmdInsert = new SqlCommand(insertLoanQuery, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@MemberID", memberId);
                        cmdInsert.Parameters.AddWithValue("@BukuID", bukuId);
                        cmdInsert.Parameters.AddWithValue("@LoanDate", dtpLoanDate.Value);
                        cmdInsert.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                        cmdInsert.ExecuteNonQuery();
                    }

                   
                    string updateStokQuery = "UPDATE Tbl_Books SET Stok = Stok - 1 WHERE BukuID = @BukuID";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateStokQuery, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@BukuID", bukuId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                  
                    transaction.Commit();

                    MessageBox.Show("Transaksi peminjaman berhasil disimpan dan stok buku telah diperbarui!",
                                    "Peminjaman Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CetakStrukPeminjaman(newLoanId, txtMemberID.Text, txt_judulbuku.Text, dtpLoanDate.Value.ToString("yyyy-MM-dd"), dtpDueDate.Value.ToString("yyyy-MM-dd"));

                    
                    txtMemberID.Clear();
                    txt_judulbuku.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Terjadi kesalahan transaksi: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBukuID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
