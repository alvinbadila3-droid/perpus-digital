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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_PerpusDigital;Integrated Security=True");
        public bool emptyFields()
        {
            if (txt_Username.Text == "" || txt_password.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            register register = new register();
            register.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
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
                        string selectacount = "select count (*) from Tbl_Members where Username=@usern AND Password=@pass";
                        using (SqlCommand cmd = new SqlCommand(selectacount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                            int rowcount = (int)cmd.ExecuteScalar();
                            if (rowcount > 0)
                            {
                                string selectRole = "select Role From Tbl_Members where Username =@usern AND Password =@pass ";
                                using (SqlCommand getrole = new SqlCommand(selectRole, connect))
                                {
                                    getrole.Parameters.AddWithValue("@usern", txt_Username.Text.Trim());
                                    getrole.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                                    string userrole = getrole.ExecuteScalar() as string;
                                    MessageBox.Show("Login Berhasil", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (userrole == "Member")
                                    {
                                        Member_dasbord member = new Member_dasbord();
                                        member.Show();
                                        this.Hide();
                                    }
                                    else if (userrole == "Admin")
                                    {
                                        AdminDasbordcs admin = new AdminDasbordcs();
                                        admin.Show();
                                        this.Hide();

                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("username/password salah atau tidak ada persetujuan admin", "Error mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        
                    }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("connetion failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally { connect.Close(); }  

                }

            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
