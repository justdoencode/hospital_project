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
    public partial class frm_doktorbilgiduzenle : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_doktorbilgiduzenle()
        {
            InitializeComponent();
        }
        public string tc;
        private void frm_doktorbilgiduzenle_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select* from tbl_doktorlar where doktor_tc="+tc, bag.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                txt_tc.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                combo_brans.Text = dr[3].ToString();
            }
            SqlCommand cmd2 = new SqlCommand("select brans_ad from tbl_branslar", bag.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                combo_brans.Items.Add(dr2[0]);
            }
            bag.baglanti().Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("update tbl_doktorlar set doktor_ad=@ad,doktor_soyad=@soyad,doktor_tc=@tc,doktor_sifre=@sifre,doktor_brans=@brans where doktor_tc=@doktortc",bag.baglanti());
            cmd3.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd3.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd3.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd3.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd3.Parameters.AddWithValue("@brans", combo_brans.Text);
            cmd3.Parameters.AddWithValue("@doktortc", tc);
            cmd3.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
