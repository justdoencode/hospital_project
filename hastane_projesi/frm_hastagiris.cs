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
    
    public partial class frm_hastagiris : Form
    {
        
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_hastagiris()
        {
            InitializeComponent();
        }

        private void lbl_üyleol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hastaüyeol frm_üyeol = new frm_hastaüyeol();
            frm_üyeol.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            frm_hastadetay frm_hastadetay = new frm_hastadetay();
            SqlCommand cmd = new SqlCommand("select*from tbl_hastalar where hasta_tc=@tc and hasta_sifre=@sifre",bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_hastadetay.hasta_tc = txt_tc.Text;
                frm_hastadetay.Show();
                bag.baglanti().Close();
                
            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası veya Şifre Hatalı");
                bag.baglanti().Close();
            }
            txt_sifre.Clear();
            txt_tc.Clear();

        }
    }
}
