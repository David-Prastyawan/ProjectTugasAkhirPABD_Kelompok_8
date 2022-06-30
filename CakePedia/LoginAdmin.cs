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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (AdminUsername.Text == "admin" && AdminPass.Text == "123")
            {
                new CRUD().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username dan Password salah, coba lagi");
                AdminUsername.Clear();
                AdminPass.Clear();
                AdminUsername.Focus();
            }
        }
    }
}
