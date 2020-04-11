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
    public partial class frm_sekretergiris : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        frm_sekreterdetay frm_sekreterdetay = new frm_sekreterdetay();
        public frm_sekretergiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from tbl_sekreter where sekreter_tc=@tc and sekreter_sifre=@sifre",bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_sekreterdetay.tc = txt_tc.Text;
                frm_sekreterdetay.Show();
            }
            else
            {
                MessageBox.Show("Kullanucı Adı veya Şifre Hatalı");
            }
            bag.baglanti().Close();
            txt_tc.Clear();
            txt_sifre.Clear();
        }
    }
}
