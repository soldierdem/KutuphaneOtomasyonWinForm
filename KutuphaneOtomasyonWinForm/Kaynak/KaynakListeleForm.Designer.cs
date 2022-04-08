namespace KutuphaneOtomasyonWinForm.Kitap
{
    partial class KaynakListeleForm
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
            this.dataGridKaynaklarView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaynaklarView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKaynaklarView
            // 
            this.dataGridKaynaklarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKaynaklarView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKaynaklarView.Location = new System.Drawing.Point(0, 0);
            this.dataGridKaynaklarView.Name = "dataGridKaynaklarView";
            this.dataGridKaynaklarView.Size = new System.Drawing.Size(800, 450);
            this.dataGridKaynaklarView.TabIndex = 0;
            // 
            // KaynakListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridKaynaklarView);
            this.Name = "KaynakListeleForm";
            this.Text = "KaynakListeleForm";
            this.Load += new System.EventHandler(this.KaynakListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaynaklarView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKaynaklarView;
    }
}