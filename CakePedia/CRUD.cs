using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CakePedia
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LENOVO\\MSSQLSERVER1;Initial Catalog=CAKEPEDIA_DB;Integrated Security=True");
        public string imglocation = "";

        private void Binsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_insert '" + Ckodekue.Text + "','" + Cnamakue.Text + "','" + Tharga.Text + "','" + Tjumlah.Text + "','" + Tnamapembeli.Text + "','" + Talamat.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Ditambahkan");
            LoadAllRecords();
        }

        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_view", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAKEPEDIA_DBDataSet.Cakepedia_Table' table. You can move, or remove it, as needed.
            this.cakepedia_TableTableAdapter.Fill(this.cAKEPEDIA_DBDataSet.Cakepedia_Table);
            LoadAllRecords();
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_update '" + Ckodekue.Text + "','" + Cnamakue.Text + "','" + Tharga.Text + "','" + Tjumlah.Text + "','" + Tnamapembeli.Text + "','" + Talamat.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Diupdate");
            LoadAllRecords();
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Untuk Menghapus?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.SP_delete '" + Ckodekue.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Berhasil Dihapus");
                LoadAllRecords();
            }
        }

        private void Bsearch_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_search '" + Ckodekue.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            Ckodekue.Text = "";
            Cnamakue.Text = "";
            Tharga.Text = "";
            Tjumlah.Text = "";
            Tnamapembeli.Text = "";
            Talamat.Text = "";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }
    }
}
