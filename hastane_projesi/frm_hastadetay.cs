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
    public partial class frm_hastadetay : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public string hasta_tc;
        public frm_hastadetay()
        {
            InitializeComponent();
        }

        private void frm_hastadetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = hasta_tc;

            //AD-SOYAD ÇEKME
            SqlCommand cmd = new SqlCommand("select hasta_ad,hasta_soyad from tbl_hastalar where hasta_tc=@tc",bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", hasta_tc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0].ToString() +" "+ dr[1].ToString();
            }
            bag.baglanti().Close();

            //RANDEVU GEÇMİŞ
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_randevular where hasta_tc=" + hasta_tc, bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme

            SqlCommand cmd2 = new SqlCommand("select brans_ad from tbl_branslar", bag.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                combo_brans.Items.Add (dr2[0]);
            }
            bag.baglanti().Close();
        }

        private void combo_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_doktorlar.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktorlar where doktor_brans=@brans",bag.baglanti());
            cmd3.Parameters.AddWithValue("@brans", combo_brans.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                combo_doktorlar.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bag.baglanti().Close();
        }

        private void combo_doktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            //dataGridView2
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_randevular where randevu_brans='" + combo_brans.Text + "'"+" and randevu_doktor='"+combo_doktorlar.Text+"'and randevu_durum=0", bag.baglanti());
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void lbl_bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frm_hastabilgiduzenle frm_hastabilgiduzenle = new frm_hastabilgiduzenle();
            frm_hastabilgiduzenle.tc = hasta_tc;
            frm_hastabilgiduzenle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView2.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView2.Rows[secili].Cells[0].Value.ToString();
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_randevular set hasta_tc=@tc,hasta_sikayet=@sikayet,randevu_durum=1 where randevu_id=@id",bag.baglanti());
            cmd.Parameters.AddWithValue("@sikayet", rich_sikayet.Text);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@tc", lbl_tc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Randevu Alındı");
            rich_sikayet.Clear();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
