using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_projesi
{
    public partial class frm_girisler : Form
    {
        public frm_girisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_doktorgiris frm_doktorgiris = new frm_doktorgiris();
            frm_doktorgiris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_hastagiris frm_hastagiris = new frm_hastagiris();
            frm_hastagiris.Show();
            
        }

        private void btn_sekreter_Click(object sender, EventArgs e)
        {
            frm_sekretergiris frm_sekretergiris = new frm_sekretergiris();
            frm_sekretergiris.Show();
        }
    }
}
