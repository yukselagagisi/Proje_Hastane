namespace Proje_Hastane
{
    partial class SekreterDetayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterDetayFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdSoyadLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TCLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OlusturBtn = new System.Windows.Forms.Button();
            this.DuyuruOlusturTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PasifRb = new System.Windows.Forms.RadioButton();
            this.AktifRb = new System.Windows.Forms.RadioButton();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoktorCmb = new System.Windows.Forms.ComboBox();
            this.BransCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TarihDtp = new System.Windows.Forms.DateTimePicker();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DuyurularBtn = new System.Windows.Forms.Button();
            this.RandevuListesiBtn = new System.Windows.Forms.Button();
            this.BransPaneliBtn = new System.Windows.Forms.Button();
            this.DoktorPaneliBtn = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.AdSoyadLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TCLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // AdSoyadLbl
            // 
            this.AdSoyadLbl.AutoSize = true;
            this.AdSoyadLbl.Location = new System.Drawing.Point(107, 89);
            this.AdSoyadLbl.Name = "AdSoyadLbl";
            this.AdSoyadLbl.Size = new System.Drawing.Size(76, 23);
            this.AdSoyadLbl.TabIndex = 11;
            this.AdSoyadLbl.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No:";
            // 
            // TCLbl
            // 
            this.TCLbl.AutoSize = true;
            this.TCLbl.Location = new System.Drawing.Point(135, 55);
            this.TCLbl.Name = "TCLbl";
            this.TCLbl.Size = new System.Drawing.Size(120, 23);
            this.TCLbl.TabIndex = 9;
            this.TCLbl.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OlusturBtn);
            this.groupBox2.Controls.Add(this.DuyuruOlusturTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // OlusturBtn
            // 
            this.OlusturBtn.Location = new System.Drawing.Point(90, 141);
            this.OlusturBtn.Name = "OlusturBtn";
            this.OlusturBtn.Size = new System.Drawing.Size(80, 32);
            this.OlusturBtn.TabIndex = 1;
            this.OlusturBtn.Text = "Oluştur";
            this.OlusturBtn.UseVisualStyleBackColor = true;
            this.OlusturBtn.Click += new System.EventHandler(this.OlusturBtn_Click);
            // 
            // DuyuruOlusturTxt
            // 
            this.DuyuruOlusturTxt.Location = new System.Drawing.Point(6, 30);
            this.DuyuruOlusturTxt.Name = "DuyuruOlusturTxt";
            this.DuyuruOlusturTxt.Size = new System.Drawing.Size(253, 105);
            this.DuyuruOlusturTxt.TabIndex = 0;
            this.DuyuruOlusturTxt.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PasifRb);
            this.groupBox3.Controls.Add(this.AktifRb);
            this.groupBox3.Controls.Add(this.KaydetBtn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DoktorCmb);
            this.groupBox3.Controls.Add(this.BransCmb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TarihDtp);
            this.groupBox3.Controls.Add(this.IDTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(284, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 352);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // PasifRb
            // 
            this.PasifRb.AutoSize = true;
            this.PasifRb.Location = new System.Drawing.Point(200, 199);
            this.PasifRb.Name = "PasifRb";
            this.PasifRb.Size = new System.Drawing.Size(66, 27);
            this.PasifRb.TabIndex = 16;
            this.PasifRb.TabStop = true;
            this.PasifRb.Text = "Pasif";
            this.PasifRb.UseVisualStyleBackColor = true;
            // 
            // AktifRb
            // 
            this.AktifRb.AutoSize = true;
            this.AktifRb.Location = new System.Drawing.Point(81, 200);
            this.AktifRb.Name = "AktifRb";
            this.AktifRb.Size = new System.Drawing.Size(66, 27);
            this.AktifRb.TabIndex = 15;
            this.AktifRb.TabStop = true;
            this.AktifRb.Text = "Aktif";
            this.AktifRb.UseVisualStyleBackColor = true;
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Location = new System.Drawing.Point(91, 260);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(108, 48);
            this.KaydetBtn.TabIndex = 14;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Doktor:";
            // 
            // DoktorCmb
            // 
            this.DoktorCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoktorCmb.FormattingEnabled = true;
            this.DoktorCmb.Location = new System.Drawing.Point(81, 163);
            this.DoktorCmb.Name = "DoktorCmb";
            this.DoktorCmb.Size = new System.Drawing.Size(185, 31);
            this.DoktorCmb.TabIndex = 6;
            // 
            // BransCmb
            // 
            this.BransCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BransCmb.FormattingEnabled = true;
            this.BransCmb.Location = new System.Drawing.Point(81, 126);
            this.BransCmb.Name = "BransCmb";
            this.BransCmb.Size = new System.Drawing.Size(185, 31);
            this.BransCmb.TabIndex = 5;
            this.BransCmb.SelectedIndexChanged += new System.EventHandler(this.BransCmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih:";
            // 
            // TarihDtp
            // 
            this.TarihDtp.CustomFormat = "yyyy-MM-dd hh:mm";
            this.TarihDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TarihDtp.Location = new System.Drawing.Point(81, 89);
            this.TarihDtp.Name = "TarihDtp";
            this.TarihDtp.Size = new System.Drawing.Size(185, 31);
            this.TarihDtp.TabIndex = 2;
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(81, 52);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.ReadOnly = true;
            this.IDTxt.Size = new System.Drawing.Size(185, 31);
            this.IDTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(569, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 227);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(477, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(569, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(483, 218);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(477, 188);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DuyurularBtn);
            this.groupBox6.Controls.Add(this.RandevuListesiBtn);
            this.groupBox6.Controls.Add(this.BransPaneliBtn);
            this.groupBox6.Controls.Add(this.DoktorPaneliBtn);
            this.groupBox6.Location = new System.Drawing.Point(12, 370);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(554, 94);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // DuyurularBtn
            // 
            this.DuyurularBtn.Location = new System.Drawing.Point(442, 24);
            this.DuyurularBtn.Name = "DuyurularBtn";
            this.DuyurularBtn.Size = new System.Drawing.Size(103, 58);
            this.DuyurularBtn.TabIndex = 18;
            this.DuyurularBtn.Text = "Duyurular";
            this.DuyurularBtn.UseVisualStyleBackColor = true;
            this.DuyurularBtn.Click += new System.EventHandler(this.DuyurularBtn_Click);
            // 
            // RandevuListesiBtn
            // 
            this.RandevuListesiBtn.Location = new System.Drawing.Point(298, 24);
            this.RandevuListesiBtn.Name = "RandevuListesiBtn";
            this.RandevuListesiBtn.Size = new System.Drawing.Size(103, 58);
            this.RandevuListesiBtn.TabIndex = 17;
            this.RandevuListesiBtn.Text = "Randevu Listesi";
            this.RandevuListesiBtn.UseVisualStyleBackColor = true;
            this.RandevuListesiBtn.Click += new System.EventHandler(this.RandevuListesiBtn_Click);
            // 
            // BransPaneliBtn
            // 
            this.BransPaneliBtn.Location = new System.Drawing.Point(154, 24);
            this.BransPaneliBtn.Name = "BransPaneliBtn";
            this.BransPaneliBtn.Size = new System.Drawing.Size(103, 58);
            this.BransPaneliBtn.TabIndex = 16;
            this.BransPaneliBtn.Text = "Branş Paneli";
            this.BransPaneliBtn.UseVisualStyleBackColor = true;
            this.BransPaneliBtn.Click += new System.EventHandler(this.BransPaneliBtn_Click);
            // 
            // DoktorPaneliBtn
            // 
            this.DoktorPaneliBtn.Location = new System.Drawing.Point(10, 24);
            this.DoktorPaneliBtn.Name = "DoktorPaneliBtn";
            this.DoktorPaneliBtn.Size = new System.Drawing.Size(103, 58);
            this.DoktorPaneliBtn.TabIndex = 15;
            this.DoktorPaneliBtn.Text = "Doktor Paneli";
            this.DoktorPaneliBtn.UseVisualStyleBackColor = true;
            this.DoktorPaneliBtn.Click += new System.EventHandler(this.DoktorPaneliBtn_Click);
            // 
            // SekreterDetayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1065, 476);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SekreterDetayFrm";
            this.Text = "Sekreter Detay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SekreterDetayFrm_FormClosed);
            this.Load += new System.EventHandler(this.SekreterDetayFrm_Load);
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
        private System.Windows.Forms.Label AdSoyadLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TCLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OlusturBtn;
        private System.Windows.Forms.RichTextBox DuyuruOlusturTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TarihDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DoktorCmb;
        private System.Windows.Forms.ComboBox BransCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button DoktorPaneliBtn;
        private System.Windows.Forms.Button RandevuListesiBtn;
        private System.Windows.Forms.Button BransPaneliBtn;
        private System.Windows.Forms.RadioButton AktifRb;
        private System.Windows.Forms.RadioButton PasifRb;
        private System.Windows.Forms.Button DuyurularBtn;
    }
}