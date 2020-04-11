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
    public partial class frm_hastabilgiduzenle : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_hastabilgiduzenle()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public string tc;
        private void frm_hastabilgiduzenle_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select *from tbl_hastalar where hasta_tc="+tc, bag.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                txt_tc.Text = dr[3].ToString();
                txt_telefon.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                combo_cinsiyet.Text = dr[6].ToString();
            }
            bag.baglanti().Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update tbl_hastalar set hasta_ad=@ad,hasta_soyad=@soyad,hasta_tc=@tc,hasta_telefon=@telefon,hasta_sifre=@sifre,hasta_cinsiyet=@cinsiyet where hasta_tc=@kosultc",bag.baglanti());
            cmd2.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd2.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd2.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd2.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd2.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd2.Parameters.AddWithValue("@cinsiyet", combo_cinsiyet.Text);
            cmd2.Parameters.AddWithValue("@kosultc", tc);
            cmd2.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");
            txt_ad.Clear();
            txt_sifre.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            txt_telefon.Clear();

        }
    }
}
