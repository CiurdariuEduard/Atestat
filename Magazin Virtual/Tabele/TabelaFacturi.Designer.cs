namespace Magazin_Virtual
{
    partial class TabelaFacturi
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
            this.dgvFacturi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturi
            // 
            this.dgvFacturi.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturi.Location = new System.Drawing.Point(45, 39);
            this.dgvFacturi.Name = "dgvFacturi";
            this.dgvFacturi.Size = new System.Drawing.Size(620, 450);
            this.dgvFacturi.TabIndex = 0;
            // 
            // TabelaFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvFacturi);
            this.Name = "TabelaFacturi";
            this.Size = new System.Drawing.Size(715, 536);
            this.Load += new System.EventHandler(this.TabelaFacturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturi;
    }
}
