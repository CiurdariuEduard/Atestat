namespace Magazin_Virtual
{
    partial class TabelaStoc
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
            this.dgvStoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStoc
            // 
            this.dgvStoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoc.Location = new System.Drawing.Point(45, 39);
            this.dgvStoc.Name = "dgvStoc";
            this.dgvStoc.Size = new System.Drawing.Size(620, 450);
            this.dgvStoc.TabIndex = 0;
            // 
            // TabelaStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvStoc);
            this.Name = "TabelaStoc";
            this.Size = new System.Drawing.Size(715, 536);
            this.Load += new System.EventHandler(this.TabelaStoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStoc;
    }
}
