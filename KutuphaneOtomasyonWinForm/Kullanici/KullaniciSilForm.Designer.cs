namespace KutuphaneOtomasyonWinForm.Kullanici
{
    partial class KullaniciSilForm
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
            this.dataGridSilView = new System.Windows.Forms.DataGridView();
            this.kullaniciSilKaydetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSilView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSilView
            // 
            this.dataGridSilView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSilView.Location = new System.Drawing.Point(12, 71);
            this.dataGridSilView.Name = "dataGridSilView";
            this.dataGridSilView.Size = new System.Drawing.Size(776, 367);
            this.dataGridSilView.TabIndex = 0;
            // 
            // kullaniciSilKaydetBtn
            // 
            this.kullaniciSilKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSilKaydetBtn.Location = new System.Drawing.Point(12, 12);
            this.kullaniciSilKaydetBtn.Name = "kullaniciSilKaydetBtn";
            this.kullaniciSilKaydetBtn.Size = new System.Drawing.Size(116, 53);
            this.kullaniciSilKaydetBtn.TabIndex = 1;
            this.kullaniciSilKaydetBtn.Text = "Sil";
            this.kullaniciSilKaydetBtn.UseVisualStyleBackColor = true;
            this.kullaniciSilKaydetBtn.Click += new System.EventHandler(this.kullaniciSilKaydetBtn_Click);
            // 
            // KullaniciSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kullaniciSilKaydetBtn);
            this.Controls.Add(this.dataGridSilView);
            this.Name = "KullaniciSilForm";
            this.Text = "KullaniciSilForm";
            this.Load += new System.EventHandler(this.KullaniciSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSilView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSilView;
        private System.Windows.Forms.Button kullaniciSilKaydetBtn;
    }
}