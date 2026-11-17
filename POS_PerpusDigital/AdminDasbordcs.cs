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
    public partial class AdminDasbordcs : Form
    {
        public AdminDasbordcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buku frombuku = new Buku();
            frombuku.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pengembalian formpengembalian = new pengembalian();
            formpengembalian.Show();
            this.Hide();

        }
    }
}
