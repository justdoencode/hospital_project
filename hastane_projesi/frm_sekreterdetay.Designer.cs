namespace hastane_projesi
{
    partial class frm_sekreterdetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sekreterdetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.txt_duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.check_durum = new System.Windows.Forms.CheckBox();
            this.txt_hastatc = new System.Windows.Forms.MaskedTextBox();
            this.combo_randevudoktor = new System.Windows.Forms.ComboBox();
            this.combo_randevubrans = new System.Windows.Forms.ComboBox();
            this.txt_randevusaati = new System.Windows.Forms.MaskedTextBox();
            this.txt_randevutarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_randevuid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_doktorpaneli = new System.Windows.Forms.Button();
            this.btn_branspaneli = new System.Windows.Forms.Button();
            this.btn_randevuliste = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(163, 61);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(10, 13);
            this.lbl_adsoyad.TabIndex = 4;
            this.lbl_adsoyad.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad ve Soyad :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(163, 35);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(10, 13);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_olustur);
            this.groupBox2.Controls.Add(this.txt_duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(9, 121);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(271, 23);
            this.btn_olustur.TabIndex = 1;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // txt_duyuru
            // 
            this.txt_duyuru.Location = new System.Drawing.Point(9, 19);
            this.txt_duyuru.Name = "txt_duyuru";
            this.txt_duyuru.Size = new System.Drawing.Size(271, 96);
            this.txt_duyuru.TabIndex = 0;
            this.txt_duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.check_durum);
            this.groupBox3.Controls.Add(this.txt_hastatc);
            this.groupBox3.Controls.Add(this.combo_randevudoktor);
            this.groupBox3.Controls.Add(this.combo_randevubrans);
            this.groupBox3.Controls.Add(this.txt_randevusaati);
            this.groupBox3.Controls.Add(this.txt_randevutarih);
            this.groupBox3.Controls.Add(this.txt_randevuid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(304, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 238);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(180, 209);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // check_durum
            // 
            this.check_durum.AutoSize = true;
            this.check_durum.Location = new System.Drawing.Point(180, 186);
            this.check_durum.Name = "check_durum";
            this.check_durum.Size = new System.Drawing.Size(48, 17);
            this.check_durum.TabIndex = 13;
            this.check_durum.Text = "Dolu";
            this.check_durum.UseVisualStyleBackColor = true;
            // 
            // txt_hastatc
            // 
            this.txt_hastatc.Location = new System.Drawing.Point(180, 160);
            this.txt_hastatc.Mask = "00000000000";
            this.txt_hastatc.Name = "txt_hastatc";
            this.txt_hastatc.Size = new System.Drawing.Size(100, 20);
            this.txt_hastatc.TabIndex = 12;
            this.txt_hastatc.ValidatingType = typeof(int);
            // 
            // combo_randevudoktor
            // 
            this.combo_randevudoktor.FormattingEnabled = true;
            this.combo_randevudoktor.Location = new System.Drawing.Point(180, 136);
            this.combo_randevudoktor.Name = "combo_randevudoktor";
            this.combo_randevudoktor.Size = new System.Drawing.Size(121, 21);
            this.combo_randevudoktor.TabIndex = 11;
            // 
            // combo_randevubrans
            // 
            this.combo_randevubrans.FormattingEnabled = true;
            this.combo_randevubrans.Location = new System.Drawing.Point(180, 109);
            this.combo_randevubrans.Name = "combo_randevubrans";
            this.combo_randevubrans.Size = new System.Drawing.Size(121, 21);
            this.combo_randevubrans.TabIndex = 10;
            this.combo_randevubrans.SelectedIndexChanged += new System.EventHandler(this.combo_randevubrans_SelectedIndexChanged);
            // 
            // txt_randevusaati
            // 
            this.txt_randevusaati.Location = new System.Drawing.Point(180, 83);
            this.txt_randevusaati.Mask = "00:00";
            this.txt_randevusaati.Name = "txt_randevusaati";
            this.txt_randevusaati.Size = new System.Drawing.Size(100, 20);
            this.txt_randevusaati.TabIndex = 9;
            this.txt_randevusaati.ValidatingType = typeof(System.DateTime);
            // 
            // txt_randevutarih
            // 
            this.txt_randevutarih.Location = new System.Drawing.Point(180, 57);
            this.txt_randevutarih.Mask = "00/00/0000";
            this.txt_randevutarih.Name = "txt_randevutarih";
            this.txt_randevutarih.Size = new System.Drawing.Size(100, 20);
            this.txt_randevutarih.TabIndex = 8;
            this.txt_randevutarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_randevuid
            // 
            this.txt_randevuid.Location = new System.Drawing.Point(180, 31);
            this.txt_randevuid.Name = "txt_randevuid";
            this.txt_randevuid.Size = new System.Drawing.Size(100, 20);
            this.txt_randevuid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(61, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Randevu Durumu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hasta TC Kimlik Numarası :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Randevu Doktoru :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Randevu Branşı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Randevu Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Randevu Saati :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Randevu ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(624, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 127);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(624, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 127);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 108);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_doktorpaneli
            // 
            this.btn_doktorpaneli.Location = new System.Drawing.Point(108, 19);
            this.btn_doktorpaneli.Name = "btn_doktorpaneli";
            this.btn_doktorpaneli.Size = new System.Drawing.Size(96, 23);
            this.btn_doktorpaneli.TabIndex = 5;
            this.btn_doktorpaneli.Text = "Doktor Paneli";
            this.btn_doktorpaneli.UseVisualStyleBackColor = true;
            this.btn_doktorpaneli.Click += new System.EventHandler(this.btn_doktorpaneli_Click);
            // 
            // btn_branspaneli
            // 
            this.btn_branspaneli.Location = new System.Drawing.Point(6, 19);
            this.btn_branspaneli.Name = "btn_branspaneli";
            this.btn_branspaneli.Size = new System.Drawing.Size(96, 23);
            this.btn_branspaneli.TabIndex = 6;
            this.btn_branspaneli.Text = "Branş Paneli";
            this.btn_branspaneli.UseVisualStyleBackColor = true;
            this.btn_branspaneli.Click += new System.EventHandler(this.btn_branspaneli_Click);
            // 
            // btn_randevuliste
            // 
            this.btn_randevuliste.Location = new System.Drawing.Point(108, 48);
            this.btn_randevuliste.Name = "btn_randevuliste";
            this.btn_randevuliste.Size = new System.Drawing.Size(96, 23);
            this.btn_randevuliste.TabIndex = 7;
            this.btn_randevuliste.Text = "Randevu Listesi";
            this.btn_randevuliste.UseVisualStyleBackColor = true;
            this.btn_randevuliste.Click += new System.EventHandler(this.btn_randevuliste_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_duyurular);
            this.groupBox6.Controls.Add(this.btn_randevuliste);
            this.groupBox6.Controls.Add(this.btn_doktorpaneli);
            this.groupBox6.Controls.Add(this.btn_branspaneli);
            this.groupBox6.Location = new System.Drawing.Point(357, 256);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 87);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Location = new System.Drawing.Point(6, 48);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(96, 23);
            this.btn_duyurular.TabIndex = 8;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(627, 304);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_sekreterdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 343);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_sekreterdetay";
            this.Text = "SEKRETER PANELİ";
            this.Load += new System.EventHandler(this.frm_sekreterdetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.RichTextBox txt_duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox check_durum;
        private System.Windows.Forms.MaskedTextBox txt_hastatc;
        private System.Windows.Forms.ComboBox combo_randevudoktor;
        private System.Windows.Forms.ComboBox combo_randevubrans;
        private System.Windows.Forms.MaskedTextBox txt_randevusaati;
        private System.Windows.Forms.MaskedTextBox txt_randevutarih;
        private System.Windows.Forms.TextBox txt_randevuid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_doktorpaneli;
        private System.Windows.Forms.Button btn_branspaneli;
        private System.Windows.Forms.Button btn_randevuliste;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_duyurular;
        private System.Windows.Forms.Button btn_cikis;
    }
}