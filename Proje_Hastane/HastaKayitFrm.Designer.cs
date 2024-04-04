namespace Proje_Hastane
{
    partial class HastaKayitFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitFrm));
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.TCTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ErkekChk = new System.Windows.Forms.CheckBox();
            this.KadınChk = new System.Windows.Forms.CheckBox();
            this.KayıtYapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(135, 181);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(162, 31);
            this.SifreTxt.TabIndex = 5;
            // 
            // TCTxt
            // 
            this.TCTxt.Location = new System.Drawing.Point(135, 107);
            this.TCTxt.Mask = "00000000000";
            this.TCTxt.Name = "TCTxt";
            this.TCTxt.Size = new System.Drawing.Size(162, 31);
            this.TCTxt.TabIndex = 3;
            this.TCTxt.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cinsiyet:";
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.Location = new System.Drawing.Point(135, 70);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(162, 31);
            this.SoyadTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(135, 33);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(162, 31);
            this.AdTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ad:";
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Location = new System.Drawing.Point(135, 144);
            this.TelefonTxt.Mask = "(999) 000-0000";
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(162, 31);
            this.TelefonTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefon:";
            // 
            // ErkekChk
            // 
            this.ErkekChk.AutoSize = true;
            this.ErkekChk.Location = new System.Drawing.Point(135, 218);
            this.ErkekChk.Name = "ErkekChk";
            this.ErkekChk.Size = new System.Drawing.Size(72, 27);
            this.ErkekChk.TabIndex = 6;
            this.ErkekChk.Text = "Erkek";
            this.ErkekChk.UseVisualStyleBackColor = true;
            // 
            // KadınChk
            // 
            this.KadınChk.AutoSize = true;
            this.KadınChk.Location = new System.Drawing.Point(225, 218);
            this.KadınChk.Name = "KadınChk";
            this.KadınChk.Size = new System.Drawing.Size(74, 27);
            this.KadınChk.TabIndex = 7;
            this.KadınChk.Text = "Kadın";
            this.KadınChk.UseVisualStyleBackColor = true;
            // 
            // KayıtYapBtn
            // 
            this.KayıtYapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.KayıtYapBtn.Location = new System.Drawing.Point(135, 251);
            this.KayıtYapBtn.Name = "KayıtYapBtn";
            this.KayıtYapBtn.Size = new System.Drawing.Size(162, 35);
            this.KayıtYapBtn.TabIndex = 8;
            this.KayıtYapBtn.Text = "Kayıt Yap";
            this.KayıtYapBtn.UseVisualStyleBackColor = false;
            this.KayıtYapBtn.Click += new System.EventHandler(this.KayıtYapBtn_Click);
            // 
            // HastaKayitFrm
            // 
            this.AcceptButton = this.KayıtYapBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(315, 316);
            this.Controls.Add(this.KayıtYapBtn);
            this.Controls.Add(this.KadınChk);
            this.Controls.Add(this.ErkekChk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelefonTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoyadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.TCTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HastaKayitFrm";
            this.Text = "Hasta Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaKayitFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.MaskedTextBox TCTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoyadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TelefonTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ErkekChk;
        private System.Windows.Forms.CheckBox KadınChk;
        private System.Windows.Forms.Button KayıtYapBtn;
    }
}