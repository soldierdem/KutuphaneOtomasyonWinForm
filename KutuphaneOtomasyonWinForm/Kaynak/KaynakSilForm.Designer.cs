namespace KutuphaneOtomasyonWinForm.Kitap
{
    partial class KaynakSilForm
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
            this.kaynakSilKaydetBtn = new System.Windows.Forms.Button();
            this.dataGridKaynakSilView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaynakSilView)).BeginInit();
            this.SuspendLayout();
            // 
            // kaynakSilKaydetBtn
            // 
            this.kaynakSilKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakSilKaydetBtn.Location = new System.Drawing.Point(12, 12);
            this.kaynakSilKaydetBtn.Name = "kaynakSilKaydetBtn";
            this.kaynakSilKaydetBtn.Size = new System.Drawing.Size(116, 53);
            this.kaynakSilKaydetBtn.TabIndex = 2;
            this.kaynakSilKaydetBtn.Text = "Sil";
            this.kaynakSilKaydetBtn.UseVisualStyleBackColor = true;
            this.kaynakSilKaydetBtn.Click += new System.EventHandler(this.kaynakSilKaydetBtn_Click);
            // 
            // dataGridKaynakSilView
            // 
            this.dataGridKaynakSilView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKaynakSilView.Location = new System.Drawing.Point(12, 71);
            this.dataGridKaynakSilView.Name = "dataGridKaynakSilView";
            this.dataGridKaynakSilView.Size = new System.Drawing.Size(776, 367);
            this.dataGridKaynakSilView.TabIndex = 3;
            // 
            // KaynakSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridKaynakSilView);
            this.Controls.Add(this.kaynakSilKaydetBtn);
            this.Name = "KaynakSilForm";
            this.Text = "KaynakSilForm";
            this.Load += new System.EventHandler(this.KaynakSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaynakSilView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kaynakSilKaydetBtn;
        private System.Windows.Forms.DataGridView dataGridKaynakSilView;
    }
}