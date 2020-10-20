namespace Magazin_Virtual.OptiuniAdaugare
{
    partial class AdaugareProdus
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
            this.ConfirmareAdaugareProdus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumeProdus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPretProdus = new System.Windows.Forms.TextBox();
            this.pretIncorect = new System.Windows.Forms.Label();
            this.produsInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmareAdaugareProdus
            // 
            this.ConfirmareAdaugareProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.ConfirmareAdaugareProdus.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConfirmareAdaugareProdus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.ConfirmareAdaugareProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmareAdaugareProdus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmareAdaugareProdus.ForeColor = System.Drawing.Color.White;
            this.ConfirmareAdaugareProdus.Location = new System.Drawing.Point(119, 230);
            this.ConfirmareAdaugareProdus.Name = "ConfirmareAdaugareProdus";
            this.ConfirmareAdaugareProdus.Size = new System.Drawing.Size(100, 40);
            this.ConfirmareAdaugareProdus.TabIndex = 12;
            this.ConfirmareAdaugareProdus.Text = "Confirmare";
            this.ConfirmareAdaugareProdus.UseVisualStyleBackColor = false;
            this.ConfirmareAdaugareProdus.Click += new System.EventHandler(this.ConfirmareAdaugareProdus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(111, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Denumire Produs: ";
            // 
            // textNumeProdus
            // 
            this.textNumeProdus.BackColor = System.Drawing.Color.White;
            this.textNumeProdus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textNumeProdus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textNumeProdus.Location = new System.Drawing.Point(67, 104);
            this.textNumeProdus.Name = "textNumeProdus";
            this.textNumeProdus.Size = new System.Drawing.Size(196, 27);
            this.textNumeProdus.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(128, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pret Produs: ";
            // 
            // textPretProdus
            // 
            this.textPretProdus.BackColor = System.Drawing.Color.White;
            this.textPretProdus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textPretProdus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textPretProdus.Location = new System.Drawing.Point(97, 182);
            this.textPretProdus.Name = "textPretProdus";
            this.textPretProdus.Size = new System.Drawing.Size(138, 27);
            this.textPretProdus.TabIndex = 9;
            this.textPretProdus.Text = "0";
            this.textPretProdus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pretIncorect
            // 
            this.pretIncorect.AutoSize = true;
            this.pretIncorect.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.pretIncorect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pretIncorect.Location = new System.Drawing.Point(128, 212);
            this.pretIncorect.Name = "pretIncorect";
            this.pretIncorect.Size = new System.Drawing.Size(77, 15);
            this.pretIncorect.TabIndex = 13;
            this.pretIncorect.Text = "Pret Incorect";
            this.pretIncorect.Visible = false;
            // 
            // produsInvalid
            // 
            this.produsInvalid.AutoSize = true;
            this.produsInvalid.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.produsInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.produsInvalid.Location = new System.Drawing.Point(111, 134);
            this.produsInvalid.Name = "produsInvalid";
            this.produsInvalid.Size = new System.Drawing.Size(122, 15);
            this.produsInvalid.TabIndex = 14;
            this.produsInvalid.Text = "Nume produs invalid";
            this.produsInvalid.Visible = false;
            // 
            // AdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.produsInvalid);
            this.Controls.Add(this.pretIncorect);
            this.Controls.Add(this.ConfirmareAdaugareProdus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumeProdus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPretProdus);
            this.Name = "AdaugareProdus";
            this.Size = new System.Drawing.Size(350, 370);
            this.Load += new System.EventHandler(this.AdaugareProdus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmareAdaugareProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumeProdus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPretProdus;
        private System.Windows.Forms.Label pretIncorect;
        private System.Windows.Forms.Label produsInvalid;
    }
}
