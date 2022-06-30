using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakePedia
{
    public partial class CustLogin : Form
    {
        public CustLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new KetCheckout().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new IsiDataDiri().Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (txUsername.Text == "cakepedia" && txPass.Text == "123")
            {
                new IsiDataDiri().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username dan Password salah, coba lagi");
                txUsername.Clear();
                txPass.Clear();
                txUsername.Focus();
            }
        }
    }
}
