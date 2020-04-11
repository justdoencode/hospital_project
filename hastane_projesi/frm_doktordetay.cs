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
    public partial class frm_doktordetay : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();

        public string tc;
        public frm_doktordetay()
        {
            InitializeComponent();
        }

        private void frm_doktordetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            
            SqlCommand cmd = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktorlar where doktor_tc=@tc", bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", tc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            bag.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_randevular where randevu_doktor='" + lbl_adsoyad.Text + "' and randevu_durum=1", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void lbl_bilgiguncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_doktorbilgiduzenle frm_doktorbilgiduzenle = new frm_doktorbilgiduzenle();
            frm_doktorbilgiduzenle.tc = lbl_tc.Text;
            frm_doktorbilgiduzenle.Show();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            txt_sikayet.Text = dataGridView1.Rows[secili].Cells[7].Value.ToString();
        }
    }
}
