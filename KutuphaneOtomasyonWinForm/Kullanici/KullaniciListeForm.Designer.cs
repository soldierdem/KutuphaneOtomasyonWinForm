﻿namespace KutuphaneOtomasyonWinForm
{
    partial class KullaniciListeForm
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
            this.dataGridKullanicilarView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanicilarView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKullanicilarView
            // 
            this.dataGridKullanicilarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKullanicilarView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKullanicilarView.Location = new System.Drawing.Point(0, 0);
            this.dataGridKullanicilarView.Name = "dataGridKullanicilarView";
            this.dataGridKullanicilarView.Size = new System.Drawing.Size(800, 450);
            this.dataGridKullanicilarView.TabIndex = 0;
            // 
            // KullaniciListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridKullanicilarView);
            this.Name = "KullaniciListeForm";
            this.Text = "KullaniciListeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanicilarView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKullanicilarView;
    }
}