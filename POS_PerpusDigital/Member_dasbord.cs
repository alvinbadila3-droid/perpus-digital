using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_PerpusDigital
{
    public partial class Member_dasbord : Form
    {
        public Member_dasbord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peminjamann fomtpinjam = new peminjamann();
            fomtpinjam.Show();
            this.Hide();    
        }
    }
}
