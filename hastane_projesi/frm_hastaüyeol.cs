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
    public partial class frm_hastaüyeol : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_hastaüyeol()
        {
            InitializeComponent();
        }

        private void frm_üyeol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand("insert into tbl_hastalar (hasta_ad,hasta_soyad,hasta_tc,hasta_telefon,hasta_sifre,hasta_cinsiyet) values(@ad,@soyad,@tc,@telefon,@sifre,@cinsiyet)",bag.baglanti());
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@telefon", txt_telefon.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", combo_cinsiyet.Text);

            cmd.ExecuteNonQuery();
            bag.baglanti().Close();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            txt_telefon.Clear();
            txt_sifre.Clear();
            
            MessageBox.Show("Yeni Kayıt Eklendi");
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
