namespace Magazin_Virtual
{
    partial class AdaugareFactura
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
            this.buttonConfirmareFactura = new System.Windows.Forms.Button();
            this.labelCantInvalida = new System.Windows.Forms.Label();
            this.dgvSelectareProdus = new System.Windows.Forms.DataGridView();
            this.textCant = new System.Windows.Forms.TextBox();
            this.Cantitatea = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelNumeInvalid = new System.Windows.Forms.Label();
            this.comboNume = new System.Windows.Forms.ComboBox();
            this.buttonAddProdus = new System.Windows.Forms.Button();
            this.comboLocatie = new System.Windows.Forms.ComboBox();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelLocInvalida = new System.Windows.Forms.Label();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.labelInvalid2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectareProdus)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmareFactura
            // 
            this.buttonConfirmareFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonConfirmareFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonConfirmareFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmareFactura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmareFactura.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmareFactura.Location = new System.Drawing.Point(323, 469);
            this.buttonConfirmareFactura.Name = "buttonConfirmareFactura";
            this.buttonConfirmareFactura.Size = new System.Drawing.Size(105, 51);
            this.buttonConfirmareFactura.TabIndex = 2;
            this.buttonConfirmareFactura.Text = "Confirmare";
            this.buttonConfirmareFactura.UseVisualStyleBackColor = false;
            this.buttonConfirmareFactura.Click += new System.EventHandler(this.buttonConfirmareFactura_Click);
            // 
            // labelCantInvalida
            // 
            this.labelCantInvalida.AutoSize = true;
            this.labelCantInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelCantInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelCantInvalida.Location = new System.Drawing.Point(240, 368);
            this.labelCantInvalida.Name = "labelCantInvalida";
            this.labelCantInvalida.Size = new System.Drawing.Size(109, 15);
            this.labelCantInvalida.TabIndex = 6;
            this.labelCantInvalida.Text = "Cantitate invalida!";
            this.labelCantInvalida.Visible = false;
            // 
            // dgvSelectareProdus
            // 
            this.dgvSelectareProdus.AllowUserToAddRows = false;
            this.dgvSelectareProdus.AllowUserToDeleteRows = false;
            this.dgvSelectareProdus.AllowUserToResizeColumns = false;
            this.dgvSelectareProdus.AllowUserToResizeRows = false;
            this.dgvSelectareProdus.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectareProdus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectareProdus.Location = new System.Drawing.Point(37, 15);
            this.dgvSelectareProdus.Name = "dgvSelectareProdus";
            this.dgvSelectareProdus.ReadOnly = true;
            this.dgvSelectareProdus.Size = new System.Drawing.Size(515, 195);
            this.dgvSelectareProdus.TabIndex = 13;
            // 
            // textCant
            // 
            this.textCant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textCant.Location = new System.Drawing.Point(161, 338);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(267, 27);
            this.textCant.TabIndex = 14;
            // 
            // Cantitatea
            // 
            this.Cantitatea.AutoSize = true;
            this.Cantitatea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Cantitatea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.Cantitatea.Location = new System.Drawing.Point(265, 320);
            this.Cantitatea.Name = "Cantitatea";
            this.Cantitatea.Size = new System.Drawing.Size(59, 15);
            this.Cantitatea.TabIndex = 15;
            this.Cantitatea.Text = "Cantitate:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelNume.Location = new System.Drawing.Point(253, 246);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(83, 15);
            this.labelNume.TabIndex = 16;
            this.labelNume.Text = "Nume produs:";
            // 
            // labelNumeInvalid
            // 
            this.labelNumeInvalid.AutoSize = true;
            this.labelNumeInvalid.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelNumeInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelNumeInvalid.Location = new System.Drawing.Point(249, 293);
            this.labelNumeInvalid.Name = "labelNumeInvalid";
            this.labelNumeInvalid.Size = new System.Drawing.Size(91, 15);
            this.labelNumeInvalid.TabIndex = 17;
            this.labelNumeInvalid.Text = "Nume invalida!";
            this.labelNumeInvalid.Visible = false;
            // 
            // comboNume
            // 
            this.comboNume.BackColor = System.Drawing.Color.White;
            this.comboNume.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.comboNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.comboNume.FormattingEnabled = true;
            this.comboNume.Location = new System.Drawing.Point(161, 263);
            this.comboNume.Name = "comboNume";
            this.comboNume.Size = new System.Drawing.Size(267, 27);
            this.comboNume.TabIndex = 18;
            // 
            // buttonAddProdus
            // 
            this.buttonAddProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonAddProdus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonAddProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProdus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddProdus.ForeColor = System.Drawing.Color.White;
            this.buttonAddProdus.Location = new System.Drawing.Point(161, 469);
            this.buttonAddProdus.Name = "buttonAddProdus";
            this.buttonAddProdus.Size = new System.Drawing.Size(156, 51);
            this.buttonAddProdus.TabIndex = 19;
            this.buttonAddProdus.Text = "Adaugare produs";
            this.buttonAddProdus.UseVisualStyleBackColor = false;
            this.buttonAddProdus.Click += new System.EventHandler(this.buttonAddProdus_Click);
            // 
            // comboLocatie
            // 
            this.comboLocatie.BackColor = System.Drawing.Color.White;
            this.comboLocatie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.comboLocatie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.comboLocatie.FormattingEnabled = true;
            this.comboLocatie.Location = new System.Drawing.Point(161, 421);
            this.comboLocatie.Name = "comboLocatie";
            this.comboLocatie.Size = new System.Drawing.Size(267, 27);
            this.comboLocatie.TabIndex = 20;
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelLoc.Location = new System.Drawing.Point(270, 403);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(48, 15);
            this.labelLoc.TabIndex = 21;
            this.labelLoc.Text = "Locatie:";
            // 
            // labelLocInvalida
            // 
            this.labelLocInvalida.AutoSize = true;
            this.labelLocInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLocInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelLocInvalida.Location = new System.Drawing.Point(245, 451);
            this.labelLocInvalida.Name = "labelLocInvalida";
            this.labelLocInvalida.Size = new System.Drawing.Size(98, 15);
            this.labelLocInvalida.TabIndex = 22;
            this.labelLocInvalida.Text = "Locatie invalida!";
            this.labelLocInvalida.Visible = false;
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelInvalid.Location = new System.Drawing.Point(188, 213);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(213, 19);
            this.labelInvalid.TabIndex = 23;
            this.labelInvalid.Text = "Nu au fost introduse informatii!";
            this.labelInvalid.Visible = false;
            // 
            // labelInvalid2
            // 
            this.labelInvalid2.AutoSize = true;
            this.labelInvalid2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelInvalid2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelInvalid2.Location = new System.Drawing.Point(216, 368);
            this.labelInvalid2.Name = "labelInvalid2";
            this.labelInvalid2.Size = new System.Drawing.Size(157, 15);
            this.labelInvalid2.TabIndex = 24;
            this.labelInvalid2.Text = "Produsul nu se afla in stoc!";
            this.labelInvalid2.Visible = false;
            // 
            // AdaugareFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelInvalid2);
            this.Controls.Add(this.labelInvalid);
            this.Controls.Add(this.labelLocInvalida);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.comboLocatie);
            this.Controls.Add(this.buttonAddProdus);
            this.Controls.Add(this.comboNume);
            this.Controls.Add(this.labelNumeInvalid);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.Cantitatea);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.dgvSelectareProdus);
            this.Controls.Add(this.labelCantInvalida);
            this.Controls.Add(this.buttonConfirmareFactura);
            this.Name = "AdaugareFactura";
            this.Size = new System.Drawing.Size(584, 539);
            this.Load += new System.EventHandler(this.AdaugareFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectareProdus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirmareFactura;
        private System.Windows.Forms.Label labelCantInvalida;
        private System.Windows.Forms.DataGridView dgvSelectareProdus;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label Cantitatea;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelNumeInvalid;
        private System.Windows.Forms.ComboBox comboNume;
        private System.Windows.Forms.Button buttonAddProdus;
        private System.Windows.Forms.ComboBox comboLocatie;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelLocInvalida;
        private System.Windows.Forms.Label labelInvalid;
        private System.Windows.Forms.Label labelInvalid2;
    }
}
