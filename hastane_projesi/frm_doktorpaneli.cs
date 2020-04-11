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
    public partial class frm_doktorpaneli : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_doktorpaneli()
        {
            InitializeComponent();
        }

        private void frm_doktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_doktorlar", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("select brans_ad from tbl_branslar", bag.baglanti());
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                combo_brans.Items.Add(dr[0]);
            }
            bag.baglanti().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_doktorlar (doktor_ad,doktor_soyad,doktor_brans,doktor_tc,doktor_sifre) values(@ad,@soyad,@brans,@tc,@sifre)",bag.baglanti());
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@brans", combo_brans.Text);
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşti");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combo_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("delete from tbl_doktorlar where doktor_tc=@tc",bag.baglanti());
            cmd1.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd1.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kişi Silindi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update tbl_doktorlar set doktor_ad=@ad,doktor_soyad=@soyad,doktor_brans=@brans,doktor_tc=@tc,doktor_sifre=@sifre where doktor_tc=@tc",bag.baglanti());
            cmd2.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd2.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd2.Parameters.AddWithValue("@brans", combo_brans.Text);
            cmd2.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd2.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd2.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
