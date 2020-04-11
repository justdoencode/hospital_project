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

namespace hastane_projesi
{
    public partial class frm_branspaneli : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_branspaneli()
        {
            InitializeComponent();
        }

        private void frm_branspaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_branslar", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_branslar (brans_ad) values (@ad)",bag.baglanti());
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
            txt_ad.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("delete from tbl_branslar where brans_id=@id",bag.baglanti());
            cmd1.Parameters.AddWithValue("@id", txt_id.Text);
            cmd1.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            txt_ad.Clear();
            txt_id.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update tbl_branslar set brans_ad=@ad where brans_id=@id",bag.baglanti());
            cmd2.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd2.Parameters.AddWithValue("@id", txt_id.Text);
            cmd2.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
