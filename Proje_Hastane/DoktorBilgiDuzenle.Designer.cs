namespace Proje_Hastane
{
    partial class DoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgiDuzenle));
            this.BilgiGuncelleBtn = new System.Windows.Forms.Button();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.TCTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BransCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BilgiGuncelleBtn
            // 
            this.BilgiGuncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BilgiGuncelleBtn.Location = new System.Drawing.Point(137, 209);
            this.BilgiGuncelleBtn.Name = "BilgiGuncelleBtn";
            this.BilgiGuncelleBtn.Size = new System.Drawing.Size(162, 35);
            this.BilgiGuncelleBtn.TabIndex = 42;
            this.BilgiGuncelleBtn.Text = "Güncelle";
            this.BilgiGuncelleBtn.UseVisualStyleBackColor = false;
            this.BilgiGuncelleBtn.Click += new System.EventHandler(this.BilgiGuncelleBtn_Click);
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(137, 24);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(162, 31);
            this.AdTxt.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ad:";
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.Location = new System.Drawing.Point(137, 61);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(162, 31);
            this.SoyadTxt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Soyad:";
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(137, 172);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(162, 31);
            this.SifreTxt.TabIndex = 37;
            // 
            // TCTxt
            // 
            this.TCTxt.Location = new System.Drawing.Point(137, 98);
            this.TCTxt.Mask = "00000000000";
            this.TCTxt.Name = "TCTxt";
            this.TCTxt.Size = new System.Drawing.Size(162, 31);
            this.TCTxt.TabIndex = 36;
            this.TCTxt.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Branş:";
            // 
            // BransCmb
            // 
            this.BransCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BransCmb.FormattingEnabled = true;
            this.BransCmb.Location = new System.Drawing.Point(137, 135);
            this.BransCmb.Name = "BransCmb";
            this.BransCmb.Size = new System.Drawing.Size(162, 31);
            this.BransCmb.TabIndex = 44;
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(333, 268);
            this.Controls.Add(this.BransCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BilgiGuncelleBtn);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoyadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.TCTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoktorBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoktorBilgiDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.DoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BilgiGuncelleBtn;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoyadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.MaskedTextBox TCTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BransCmb;
    }
}