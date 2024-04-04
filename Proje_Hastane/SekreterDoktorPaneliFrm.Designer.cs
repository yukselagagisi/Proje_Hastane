namespace Proje_Hastane
{
    partial class SekreterDoktorPaneliFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterDoktorPaneliFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.SoyadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BransCmb = new System.Windows.Forms.ComboBox();
            this.TCNOTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(78, 37);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(144, 31);
            this.AdTxt.TabIndex = 1;
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.Location = new System.Drawing.Point(78, 74);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(144, 31);
            this.SoyadTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Branş:";
            // 
            // BransCmb
            // 
            this.BransCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BransCmb.FormattingEnabled = true;
            this.BransCmb.Location = new System.Drawing.Point(78, 111);
            this.BransCmb.Name = "BransCmb";
            this.BransCmb.Size = new System.Drawing.Size(144, 31);
            this.BransCmb.TabIndex = 3;
            // 
            // TCNOTxt
            // 
            this.TCNOTxt.Location = new System.Drawing.Point(78, 148);
            this.TCNOTxt.Mask = "00000000000";
            this.TCNOTxt.Name = "TCNOTxt";
            this.TCNOTxt.Size = new System.Drawing.Size(144, 31);
            this.TCNOTxt.TabIndex = 4;
            this.TCNOTxt.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC No:";
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(78, 185);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(144, 31);
            this.SifreTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 299);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EkleBtn.Location = new System.Drawing.Point(19, 247);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(98, 34);
            this.EkleBtn.TabIndex = 6;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SilBtn.Location = new System.Drawing.Point(123, 247);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(98, 34);
            this.SilBtn.TabIndex = 7;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.Lime;
            this.GuncelleBtn.Location = new System.Drawing.Point(75, 287);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(98, 34);
            this.GuncelleBtn.TabIndex = 8;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // SekreterDoktorPaneliFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(816, 334);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCNOTxt);
            this.Controls.Add(this.BransCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoyadTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SekreterDoktorPaneliFrm";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.SekreterDoktorPaneliFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.TextBox SoyadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BransCmb;
        private System.Windows.Forms.MaskedTextBox TCNOTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GuncelleBtn;
    }
}