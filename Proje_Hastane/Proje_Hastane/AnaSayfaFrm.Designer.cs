namespace Proje_Hastane
{
    partial class AnaSayfaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaFrm));
            this.HastaBtn = new System.Windows.Forms.Button();
            this.DoktorBtn = new System.Windows.Forms.Button();
            this.SekreterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaBtn
            // 
            this.HastaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HastaBtn.BackgroundImage")));
            this.HastaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HastaBtn.Location = new System.Drawing.Point(12, 142);
            this.HastaBtn.Name = "HastaBtn";
            this.HastaBtn.Size = new System.Drawing.Size(188, 158);
            this.HastaBtn.TabIndex = 0;
            this.HastaBtn.UseVisualStyleBackColor = true;
            this.HastaBtn.Click += new System.EventHandler(this.HastaBtn_Click);
            // 
            // DoktorBtn
            // 
            this.DoktorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoktorBtn.BackgroundImage")));
            this.DoktorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DoktorBtn.Location = new System.Drawing.Point(259, 142);
            this.DoktorBtn.Name = "DoktorBtn";
            this.DoktorBtn.Size = new System.Drawing.Size(188, 158);
            this.DoktorBtn.TabIndex = 1;
            this.DoktorBtn.UseVisualStyleBackColor = true;
            this.DoktorBtn.Click += new System.EventHandler(this.DoktorBtn_Click);
            // 
            // SekreterBtn
            // 
            this.SekreterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SekreterBtn.BackgroundImage")));
            this.SekreterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SekreterBtn.Location = new System.Drawing.Point(506, 142);
            this.SekreterBtn.Name = "SekreterBtn";
            this.SekreterBtn.Size = new System.Drawing.Size(188, 158);
            this.SekreterBtn.TabIndex = 2;
            this.SekreterBtn.UseVisualStyleBackColor = true;
            this.SekreterBtn.Click += new System.EventHandler(this.SekreterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "SeaGreen Hospital\r\nHastane Yönetim Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(308, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(549, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(706, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SekreterBtn);
            this.Controls.Add(this.DoktorBtn);
            this.Controls.Add(this.HastaBtn);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "AnaSayfaFrm";
            this.Text = "SeaGreen Hospital Hastane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfaFrm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HastaBtn;
        private System.Windows.Forms.Button DoktorBtn;
        private System.Windows.Forms.Button SekreterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

