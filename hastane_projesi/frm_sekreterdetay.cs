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
    
    public partial class frm_sekreterdetay : Form
    {
        
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_sekreterdetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void frm_sekreterdetay_Load(object sender, EventArgs e)
        {
            // TC VE AD SOYAD ÇEKME
            SqlCommand cmd = new SqlCommand("select sekreter_ad_soyad,sekreter_tc from tbl_sekreter where sekreter_tc=@tc",bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", tc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_tc.Text = dr[0].ToString();
                lbl_adsoyad.Text = dr[1].ToString();
            }
            bag.baglanti().Close();

            //BRANŞLARI ÇEKME
            SqlCommand cmd2 = new SqlCommand("select brans_ad from tbl_branslar", bag.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                combo_randevubrans.Items.Add(dr2[0]);
            }
            bag.baglanti().Close();

            //BRANŞLARI DATAGRİD'E AKTARMA

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_branslar", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //DOKTORLARI DATAGRİD'E AKTARMA

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktor_ad+' '+doktor_soyad) as 'Doktorlar',doktor_brans from tbl_doktorlar", bag.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void combo_randevubrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_randevudoktor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktorlar where doktor_brans='" + combo_randevubrans.Text + "'", bag.baglanti());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                combo_randevudoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            bag.baglanti().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("insert into tbl_randevular (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) values (@tarih,@saat,@brans,@doktor)",bag.baglanti());
            
            cmd4.Parameters.AddWithValue("@tarih", txt_randevutarih.Text);
            cmd4.Parameters.AddWithValue("@saat", txt_randevusaati.Text);
            cmd4.Parameters.AddWithValue("@brans", combo_randevubrans.Text);
            cmd4.Parameters.AddWithValue("@doktor", combo_randevudoktor.Text);
            cmd4.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
           
            
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("insert into tbl_duyurular (duyuru) values (@duyuru)",bag.baglanti());
            cmd5.Parameters.AddWithValue("@duyuru", txt_duyuru.Text);
            cmd5.ExecuteNonQuery();
            MessageBox.Show("Duyuru Eklendi");
            txt_duyuru.Clear();
        }

        private void btn_doktorpaneli_Click(object sender, EventArgs e)
        {
            frm_doktorpaneli frm_doktorpaneli = new frm_doktorpaneli();
            frm_doktorpaneli.Show();
        }

        private void btn_branspaneli_Click(object sender, EventArgs e)
        {
            frm_branspaneli frm_branspaneli = new frm_branspaneli();
            frm_branspaneli.Show();
        }

        private void btn_randevuliste_Click(object sender, EventArgs e)
        {
            frm_radevulistesi frm_randevulistesi = new frm_radevulistesi();
            frm_randevulistesi.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            frm_duyurular frm_duyurular = new frm_duyurular();
            frm_duyurular.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
