using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_PerpusDigital
{
    public partial class pengembalian : Form
    {

        private string connectionString = "Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_PerpusDigital;Integrated Security=True";
        private DateTime selectedDueDate;
        private int selectedBukuId;
        public pengembalian()
        {
            InitializeComponent();
        }
        // Method Tambahan Khusus Cetak Struk Pengembalian
        private void CetakStrukPengembalian(string loanId, string memberId, string judulBuku, string tglKembali, decimal denda, string metodeBayar)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font fontHeader = new Font("Courier New", 12, FontStyle.Bold);
                Font fontTitle = new Font("Courier New", 10, FontStyle.Bold);
                Font fontBody = new Font("Courier New", 9, FontStyle.Regular);
                Font fontBold = new Font("Courier New", 9, FontStyle.Bold);

                int x = 20, y = 20;
                g.DrawString("PERPUSTAKAAN DIGITAL LKS", fontHeader, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 15;
                g.DrawString("BUKTI PENGEMBALIAN BUKU", fontTitle, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 20;
                g.DrawString($"ID Transaksi  : {loanId}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"ID Member     : {memberId}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"Judul Buku    : {judulBuku}", fontBody, Brushes.Black, x, y); y += 18;
                g.DrawString($"Tgl Kembali   : {tglKembali}", fontBody, Brushes.Black, x, y); y += 20;
                g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 20;

                if (denda > 0)
                {
                    g.DrawString($"DENDA TERBAYAR: Rp {denda:N0}", fontBold, Brushes.Black, x, y); y += 18;
                    g.DrawString($"Metode Bayar  : {metodeBayar}", fontBody, Brushes.Black, x, y); y += 18;
                    g.DrawString("---------------------------------------", fontBody, Brushes.Black, x, y); y += 20;
                }

                g.DrawString("        Terima Kasih & Selamat Membaca", fontBody, Brushes.Black, x, y);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog { Document = pd, Width = 200, Height = 300 };
            preview.ShowDialog();
        }
        private void pengembalian_Load(object sender, EventArgs e)
        {
            // Set tanggal pengembalian otomatis ke hari ini & kunci komponennya
            dtpReturnDate.Value = DateTime.Now;
            dtpReturnDate.Enabled = false;

            // Isi pilihan metode pembayaran
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("QRIS");
            cmbPaymentMethod.Items.Add("Transfer");
            cmbPaymentMethod.SelectedIndex = 0;
        }

        // 1. Cari Data Peminjaman Aktif
        private void btnCariLoan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoanID.Text))
            {
                MessageBox.Show("Masukkan Loan ID terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int loanId;
            if (!int.TryParse(txtLoanID.Text, out loanId))
            {
                MessageBox.Show("Loan ID harus berupa angka!", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT L.LoanID, L.MemberID, L.BukuID, L.DueDate, B.JudulBuku 
                                     FROM Tbl_Loans L 
                                     JOIN Tbl_Books B ON L.BukuID = B.BukuID 
                                     WHERE L.LoanID = @LoanID AND L.ReturnDate IS NULL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LoanID", loanId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                selectedDueDate = Convert.ToDateTime(reader["DueDate"]);
                                selectedBukuId = Convert.ToInt32(reader["BukuID"]);

                                txtJudulBuku.Text = reader["JudulBuku"].ToString();
                                txtMemberID.Text = reader["MemberID"].ToString();
                                lblDueDate.Text = selectedDueDate.ToString("yyyy-MM-dd");

                                HitungDendaOtomatis();
                            }
                            else
                            {
                                MessageBox.Show("Data peminjaman tidak ditemukan atau buku sudah dikembalikan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetForm();
                            }
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membaca data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. Hitung Denda Otomatis Berdasarkan Hari Ini (Rp 1.000 / Hari)
        private void HitungDendaOtomatis()
        {
            DateTime tglHariIni = DateTime.Now.Date;
            DateTime tglDueDate = selectedDueDate.Date;

            if (tglHariIni > tglDueDate)
            {
                int selisihHari = (tglHariIni - tglDueDate).Days;
                decimal totalDenda = selisihHari * 1000m;

                lblSelisihHari.Text = selisihHari.ToString() + " Hari Late";
                lblFineAmount.Text = totalDenda.ToString("0");
            }
            else
            {
                lblSelisihHari.Text = "0 Hari";
                lblFineAmount.Text = "0";
            }
        }

        // 3. Simpan Pengembalian & Catat Denda ke Tbl_FinePayments
        private void btnProsesPengembalian_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoanID.Text) || selectedBukuId == 0)
            {
                MessageBox.Show("Cari transaksi peminjaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int loanId = Convert.ToInt32(txtLoanID.Text);
            DateTime tglHariIni = DateTime.Now;
            string metodeBayar = cmbPaymentMethod.SelectedItem.ToString();

            // Hitung denda berdasarkan hari ini
            decimal fineAmount = 0;
            if (tglHariIni.Date > selectedDueDate.Date)
            {
                int selisihHari = (tglHariIni.Date - selectedDueDate.Date).Days;
                fineAmount = selisihHari * 1000m;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // A. Update status & ReturnDate di tabel Loans
                    string updateLoanQuery = @"UPDATE Tbl_Loans 
                                               SET ReturnDate = @ReturnDate, 
                                                   FineAmount = @FineAmount, 
                                                   Status = 'Dikembalikan' 
                                               WHERE LoanID = @LoanID";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateLoanQuery, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@ReturnDate", tglHariIni);
                        cmdUpdate.Parameters.AddWithValue("@FineAmount", fineAmount);
                        cmdUpdate.Parameters.AddWithValue("@LoanID", loanId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // B. Jika ada denda (fineAmount > 0), simpan ke tabel Tbl_FinePayments
                    if (fineAmount > 0)
                    {
                        string insertFineQuery = @"INSERT INTO Tbl_FinePayments (LoanID, PaymentDate, AmountPaid, PaymentMetod) 
                                                   VALUES (@LoanID, @PaymentDate, @AmountPaid, @PaymentMetod)";

                        using (SqlCommand cmdFine = new SqlCommand(insertFineQuery, conn, transaction))
                        {
                            cmdFine.Parameters.AddWithValue("@LoanID", loanId);
                            cmdFine.Parameters.AddWithValue("@PaymentDate", tglHariIni);
                            cmdFine.Parameters.AddWithValue("@AmountPaid", fineAmount);
                            cmdFine.Parameters.AddWithValue("@PaymentMetod", metodeBayar);
                            cmdFine.ExecuteNonQuery();
                        }
                    }

                    // C. Tambah stok buku (+1 ke tabel Buku)
                    string updateStokQuery = "UPDATE Tbl_Books SET Stok = Stok + 1 WHERE BukuID = @BukuID";

                    using (SqlCommand cmdStok = new SqlCommand(updateStokQuery, conn, transaction))
                    {
                        cmdStok.Parameters.AddWithValue("@BukuID", selectedBukuId);
                        cmdStok.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    string pesan = fineAmount > 0
                        ? $"Pengembalian Berhasil!\nDenda sebesar Rp {fineAmount:N0} tercatat di Tbl_FinePayments."
                        : "Pengembalian Berhasil! Tidak ada denda keterlambatan.";
                    CetakStrukPengembalian(txtLoanID.Text, txtMemberID.Text, txtJudulBuku.Text, DateTime.Now.ToString("yyyy-MM-dd"), fineAmount, cmbPaymentMethod.SelectedItem.ToString());

                    MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Terjadi kesalahan transaksi: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            txtLoanID.Clear();
            txtJudulBuku.Clear();
            txtMemberID.Clear();
            lblDueDate.Text = "-";
            lblSelisihHari.Text = "0 Hari";
            lblFineAmount.Text = "0";
            selectedBukuId = 0;
            dtpReturnDate.Value = DateTime.Now; // Reset ke waktu sekarang
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFineAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblSelisihHari_Click(object sender, EventArgs e)
        {

        }

      

        private void lblDueDate_Click(object sender, EventArgs e)
        {

        }

        private void txtJudulBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
