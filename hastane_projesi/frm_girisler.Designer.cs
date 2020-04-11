namespace hastane_projesi
{
    partial class frm_girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_girisler));
            this.btn_doktor = new System.Windows.Forms.Button();
            this.btn_hasta = new System.Windows.Forms.Button();
            this.btn_sekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_doktor
            // 
            this.btn_doktor.BackColor = System.Drawing.Color.Transparent;
            this.btn_doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor.BackgroundImage")));
            this.btn_doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor.Location = new System.Drawing.Point(20, 165);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(193, 165);
            this.btn_doktor.TabIndex = 0;
            this.btn_doktor.UseVisualStyleBackColor = false;
            this.btn_doktor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hasta
            // 
            this.btn_hasta.BackColor = System.Drawing.Color.Transparent;
            this.btn_hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta.BackgroundImage")));
            this.btn_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hasta.Location = new System.Drawing.Point(246, 165);
            this.btn_hasta.Name = "btn_hasta";
            this.btn_hasta.Size = new System.Drawing.Size(193, 165);
            this.btn_hasta.TabIndex = 1;
            this.btn_hasta.UseVisualStyleBackColor = false;
            this.btn_hasta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sekreter
            // 
            this.btn_sekreter.BackColor = System.Drawing.Color.Transparent;
            this.btn_sekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter.BackgroundImage")));
            this.btn_sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekreter.Location = new System.Drawing.Point(470, 165);
            this.btn_sekreter.Name = "btn_sekreter";
            this.btn_sekreter.Size = new System.Drawing.Size(193, 165);
            this.btn_sekreter.TabIndex = 2;
            this.btn_sekreter.UseVisualStyleBackColor = false;
            this.btn_sekreter.Click += new System.EventHandler(this.btn_sekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOKTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(317, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(533, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "POYRAZ HASTANESİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "ÖZEL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(216, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 102);
            this.panel1.TabIndex = 8;
            // 
            // frm_girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekreter);
            this.Controls.Add(this.btn_hasta);
            this.Controls.Add(this.btn_doktor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_girisler";
            this.Text = "ÖZEL POYRAZ HASTANESİ PERSONEL OTOMASYON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Button btn_hasta;
        private System.Windows.Forms.Button btn_sekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

