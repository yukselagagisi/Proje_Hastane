namespace Proje_Hastane
{
    partial class DoktorDetayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorDetayFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdSoyadLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TCLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RandevuDetayTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.DuyurularBtn = new System.Windows.Forms.Button();
            this.BilgiDuzenleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(287, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // AdSoyadLbl
            // 
            this.AdSoyadLbl.AutoSize = true;
            this.AdSoyadLbl.Location = new System.Drawing.Point(103, 82);
            this.AdSoyadLbl.Name = "AdSoyadLbl";
            this.AdSoyadLbl.Size = new System.Drawing.Size(76, 23);
            this.AdSoyadLbl.TabIndex = 7;
            this.AdSoyadLbl.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik No:";
            // 
            // TCLbl
            // 
            this.TCLbl.AutoSize = true;
            this.TCLbl.Location = new System.Drawing.Point(131, 49);
            this.TCLbl.Name = "TCLbl";
            this.TCLbl.Size = new System.Drawing.Size(120, 23);
            this.TCLbl.TabIndex = 5;
            this.TCLbl.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RandevuDetayTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detayları";
            // 
            // RandevuDetayTxt
            // 
            this.RandevuDetayTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandevuDetayTxt.Location = new System.Drawing.Point(3, 27);
            this.RandevuDetayTxt.Name = "RandevuDetayTxt";
            this.RandevuDetayTxt.Size = new System.Drawing.Size(281, 131);
            this.RandevuDetayTxt.TabIndex = 0;
            this.RandevuDetayTxt.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(305, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 432);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
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
            this.dataGridView1.Size = new System.Drawing.Size(732, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CikisBtn);
            this.groupBox4.Controls.Add(this.DuyurularBtn);
            this.groupBox4.Controls.Add(this.BilgiDuzenleBtn);
            this.groupBox4.Location = new System.Drawing.Point(15, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 127);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.CikisBtn.Location = new System.Drawing.Point(74, 83);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(132, 35);
            this.CikisBtn.TabIndex = 6;
            this.CikisBtn.Text = "Çıkış";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // DuyurularBtn
            // 
            this.DuyurularBtn.Location = new System.Drawing.Point(145, 30);
            this.DuyurularBtn.Name = "DuyurularBtn";
            this.DuyurularBtn.Size = new System.Drawing.Size(132, 35);
            this.DuyurularBtn.TabIndex = 4;
            this.DuyurularBtn.Text = "Duyurular";
            this.DuyurularBtn.UseVisualStyleBackColor = true;
            this.DuyurularBtn.Click += new System.EventHandler(this.DuyurularBtn_Click);
            // 
            // BilgiDuzenleBtn
            // 
            this.BilgiDuzenleBtn.Location = new System.Drawing.Point(7, 30);
            this.BilgiDuzenleBtn.Name = "BilgiDuzenleBtn";
            this.BilgiDuzenleBtn.Size = new System.Drawing.Size(132, 35);
            this.BilgiDuzenleBtn.TabIndex = 0;
            this.BilgiDuzenleBtn.Text = "Bilgi Düzenle";
            this.BilgiDuzenleBtn.UseVisualStyleBackColor = true;
            this.BilgiDuzenleBtn.Click += new System.EventHandler(this.BilgiDuzenleBtn_Click);
            // 
            // DoktorDetayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoktorDetayFrm";
            this.Text = "Doktor Detay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoktorDetayFrm_FormClosed);
            this.Load += new System.EventHandler(this.DoktorDetayFrm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AdSoyadLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TCLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RandevuDetayTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BilgiDuzenleBtn;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Button DuyurularBtn;
    }
}