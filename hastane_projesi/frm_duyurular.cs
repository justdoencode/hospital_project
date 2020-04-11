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
    public partial class frm_duyurular : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_duyurular()
        {
            InitializeComponent();
        }

        private void frm_duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_duyurular", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string duyuru = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MessageBox.Show(duyuru,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
