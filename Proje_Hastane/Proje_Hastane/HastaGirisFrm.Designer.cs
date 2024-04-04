namespace Proje_Hastane
{
    partial class HastaGirisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TCTxt = new System.Windows.Forms.MaskedTextBox();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.UyeOlLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // TCTxt
            // 
            this.TCTxt.Location = new System.Drawing.Point(140, 98);
            this.TCTxt.Mask = "00000000000";
            this.TCTxt.Name = "TCTxt";
            this.TCTxt.Size = new System.Drawing.Size(162, 31);
            this.TCTxt.TabIndex = 1;
            this.TCTxt.ValidatingType = typeof(int);
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(140, 135);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(162, 31);
            this.SifreTxt.TabIndex = 2;
            this.SifreTxt.UseSystemPasswordChar = true;
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.Location = new System.Drawing.Point(213, 172);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(89, 36);
            this.GirisYapBtn.TabIndex = 4;
            this.GirisYapBtn.Text = "Giriş Yap";
            this.GirisYapBtn.UseVisualStyleBackColor = true;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // UyeOlLbl
            // 
            this.UyeOlLbl.AutoSize = true;
            this.UyeOlLbl.Location = new System.Drawing.Point(318, 138);
            this.UyeOlLbl.Name = "UyeOlLbl";
            this.UyeOlLbl.Size = new System.Drawing.Size(62, 23);
            this.UyeOlLbl.TabIndex = 3;
            this.UyeOlLbl.TabStop = true;
            this.UyeOlLbl.Text = "Üye Ol";
            this.UyeOlLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UyeOlLbl_LinkClicked);
            // 
            // HastaGirisFrm
            // 
            this.AcceptButton = this.GirisYapBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(412, 236);
            this.Controls.Add(this.UyeOlLbl);
            this.Controls.Add(this.GirisYapBtn);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.TCTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HastaGirisFrm";
            this.Text = "Hasta Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaGirisFrm_FormClosed);
            this.Load += new System.EventHandler(this.HastaGirisFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TCTxt;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.LinkLabel UyeOlLbl;
    }
}