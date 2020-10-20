namespace Magazin_Virtual
{
    partial class TabelaLocatii
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabelLocatii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelLocatii)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelLocatii
            // 
            this.dgvTabelLocatii.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelLocatii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelLocatii.Location = new System.Drawing.Point(45, 39);
            this.dgvTabelLocatii.Name = "dgvTabelLocatii";
            this.dgvTabelLocatii.Size = new System.Drawing.Size(620, 450);
            this.dgvTabelLocatii.TabIndex = 0;
            // 
            // TabelaLocatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTabelLocatii);
            this.Name = "TabelaLocatii";
            this.Size = new System.Drawing.Size(715, 536);
            this.Load += new System.EventHandler(this.TabelaLocatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelLocatii)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabelLocatii;
    }
}
