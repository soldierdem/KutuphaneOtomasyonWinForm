﻿namespace KutuphaneOtomasyonWinForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personelAdGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelSifreGiristxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personelAdGiristxt
            // 
            this.personelAdGiristxt.Location = new System.Drawing.Point(146, 229);
            this.personelAdGiristxt.Name = "personelAdGiristxt";
            this.personelAdGiristxt.Size = new System.Drawing.Size(118, 20);
            this.personelAdGiristxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // personelSifreGiristxt
            // 
            this.personelSifreGiristxt.Location = new System.Drawing.Point(146, 283);
            this.personelSifreGiristxt.Name = "personelSifreGiristxt";
            this.personelSifreGiristxt.Size = new System.Drawing.Size(118, 20);
            this.personelSifreGiristxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(46, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Şifre:";
            // 
            // personelGirisBtn
            // 
            this.personelGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.personelGirisBtn.FlatAppearance.BorderSize = 0;
            this.personelGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelGirisBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personelGirisBtn.Location = new System.Drawing.Point(146, 329);
            this.personelGirisBtn.Name = "personelGirisBtn";
            this.personelGirisBtn.Size = new System.Drawing.Size(96, 37);
            this.personelGirisBtn.TabIndex = 4;
            this.personelGirisBtn.Text = "Giriş";
            this.personelGirisBtn.UseVisualStyleBackColor = false;
            this.personelGirisBtn.Click += new System.EventHandler(this.personelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(344, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personelGirisBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personelSifreGiristxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personelAdGiristxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Ekrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personelAdGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personelSifreGiristxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button personelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

