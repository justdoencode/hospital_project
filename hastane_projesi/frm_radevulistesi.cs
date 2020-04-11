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
    public partial class frm_radevulistesi : Form
    {
        sqlbaglantisi bag = new sqlbaglantisi();
        public frm_radevulistesi()
        {
            InitializeComponent();
        }

        private void frm_radevulistesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_randevular", bag.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
