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
    public partial class frm_doktorgiris : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_doktorgiris()
        {
            InitializeComponent();
        }
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from tbl_doktorlar where doktor_tc=@tc and doktor_sifre=@sifre",bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_doktordetay frm_doktordetay = new frm_doktordetay();
                frm_doktordetay.tc = txt_tc.Text;
                frm_doktordetay.Show();
            }
            else
            {
                MessageBox.Show("Girilen Kullanıcı Adı Veya Şifre Hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
