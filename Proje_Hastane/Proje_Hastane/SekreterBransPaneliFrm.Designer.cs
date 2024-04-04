namespace Proje_Hastane
{
    partial class SekreterBransPaneliFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterBransPaneliFrm));
            this.EkleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AktifRb = new System.Windows.Forms.RadioButton();
            this.PasifRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EkleBtn.Location = new System.Drawing.Point(33, 141);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(98, 34);
            this.EkleBtn.TabIndex = 25;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 178);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(86, 34);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(144, 31);
            this.IDTxt.TabIndex = 17;
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(86, 71);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(144, 31);
            this.AdTxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // AktifRb
            // 
            this.AktifRb.AutoSize = true;
            this.AktifRb.Location = new System.Drawing.Point(86, 108);
            this.AktifRb.Name = "AktifRb";
            this.AktifRb.Size = new System.Drawing.Size(66, 27);
            this.AktifRb.TabIndex = 26;
            this.AktifRb.TabStop = true;
            this.AktifRb.Text = "Aktif";
            this.AktifRb.UseVisualStyleBackColor = true;
            // 
            // PasifRb
            // 
            this.PasifRb.AutoSize = true;
            this.PasifRb.Location = new System.Drawing.Point(164, 108);
            this.PasifRb.Name = "PasifRb";
            this.PasifRb.Size = new System.Drawing.Size(66, 27);
            this.PasifRb.TabIndex = 27;
            this.PasifRb.TabStop = true;
            this.PasifRb.Text = "Pasif";
            this.PasifRb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Durum:";
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.Lime;
            this.GuncelleBtn.Location = new System.Drawing.Point(137, 141);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(98, 34);
            this.GuncelleBtn.TabIndex = 29;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // SekreterBransPaneliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(716, 202);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasifRb);
            this.Controls.Add(this.AktifRb);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SekreterBransPaneliFrm";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.SekreterBransPaneliFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AktifRb;
        private System.Windows.Forms.RadioButton PasifRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GuncelleBtn;
    }
}