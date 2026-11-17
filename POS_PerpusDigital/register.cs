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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_PerpusDigital;Integrated Security=True");

        public bool emptyFields()
        {
            if (txt_Username.Text == "" || txtPassword.Text == "" || txt_confirmPassword.Text == "" || txt_NamaMember.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void tbl_MembersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_MembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PerpusDigitalDataSet);

        }

        private void register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PerpusDigitalDataSet.Tbl_Members' table. You can move, or remove it, as needed.
            this.tbl_MembersTableAdapter.Fill(this.dB_PerpusDigitalDataSet.Tbl_Members);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void namaMemberLabel_Click(object sender, EventArgs e)
        {

        }

        private void txt_NamaMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
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
                        string selectusername = "select * From Tbl_Members Where Username =@usern";
                        using (SqlCommand chekusername = new SqlCommand(selectusername,connect))
                        {
                            chekusername.Parameters.AddWithValue("@usern",txt_Username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(chekusername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);   
                            if(table.Rows.Count >= 1)
                            {
                                string usern =txt_Username.Text.Substring(0, 1).ToUpper() +txt_Username.Text.Substring(1);
                                MessageBox.Show(usern + "sudah di ambil", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPassword.Text !=  txt_confirmPassword.Text)
                            {
                                MessageBox.Show("Kata sandi tidak cocok.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPassword.Text.Length < 8)
                            {
                                MessageBox.Show("Kata sandi tidak valid, minimal diperlukan 8 karakter.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertdata = ("insert into Tbl_Members (NamaMember,Username,Password,Role)" + "values (@member,@usern,@pass,@role)");
                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@member",txt_NamaMember.Text.Trim());
                                    cmd.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass",txtPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", "Member");
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }

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
    }
}
