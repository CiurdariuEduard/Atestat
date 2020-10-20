namespace Magazin_Virtual
{
    partial class AdaugareAprovizionare
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
            this.dgvAprovizionari = new System.Windows.Forms.DataGridView();
            this.buttonAddProdus = new System.Windows.Forms.Button();
            this.combNume = new System.Windows.Forms.ComboBox();
            this.labelNumeInvalid = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.Cantitatea = new System.Windows.Forms.Label();
            this.textCant = new System.Windows.Forms.TextBox();
            this.labelCantInvalida = new System.Windows.Forms.Label();
            this.buttonConfirmareAprovizionare = new System.Windows.Forms.Button();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelLocInvalida = new System.Windows.Forms.Label();
            this.comboLocatie = new System.Windows.Forms.ComboBox();
            this.labelnvalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovizionari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAprovizionari
            // 
            this.dgvAprovizionari.AllowUserToAddRows = false;
            this.dgvAprovizionari.AllowUserToDeleteRows = false;
            this.dgvAprovizionari.AllowUserToResizeColumns = false;
            this.dgvAprovizionari.AllowUserToResizeRows = false;
            this.dgvAprovizionari.BackgroundColor = System.Drawing.Color.White;
            this.dgvAprovizionari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprovizionari.Location = new System.Drawing.Point(39, 22);
            this.dgvAprovizionari.Name = "dgvAprovizionari";
            this.dgvAprovizionari.ReadOnly = true;
            this.dgvAprovizionari.Size = new System.Drawing.Size(515, 195);
            this.dgvAprovizionari.TabIndex = 20;
            // 
            // buttonAddProdus
            // 
            this.buttonAddProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonAddProdus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonAddProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProdus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddProdus.ForeColor = System.Drawing.Color.White;
            this.buttonAddProdus.Location = new System.Drawing.Point(163, 490);
            this.buttonAddProdus.Name = "buttonAddProdus";
            this.buttonAddProdus.Size = new System.Drawing.Size(156, 51);
            this.buttonAddProdus.TabIndex = 28;
            this.buttonAddProdus.Text = "Adaugare produs";
            this.buttonAddProdus.UseVisualStyleBackColor = false;
            this.buttonAddProdus.Click += new System.EventHandler(this.buttonAddProdus_Click);
            // 
            // combNume
            // 
            this.combNume.BackColor = System.Drawing.Color.White;
            this.combNume.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.combNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.combNume.FormattingEnabled = true;
            this.combNume.Location = new System.Drawing.Point(163, 263);
            this.combNume.Name = "combNume";
            this.combNume.Size = new System.Drawing.Size(267, 27);
            this.combNume.TabIndex = 27;
            // 
            // labelNumeInvalid
            // 
            this.labelNumeInvalid.AutoSize = true;
            this.labelNumeInvalid.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelNumeInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelNumeInvalid.Location = new System.Drawing.Point(254, 293);
            this.labelNumeInvalid.Name = "labelNumeInvalid";
            this.labelNumeInvalid.Size = new System.Drawing.Size(84, 15);
            this.labelNumeInvalid.TabIndex = 26;
            this.labelNumeInvalid.Text = "Nume invalid!";
            this.labelNumeInvalid.Visible = false;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelNume.Location = new System.Drawing.Point(255, 246);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(83, 15);
            this.labelNume.TabIndex = 25;
            this.labelNume.Text = "Nume produs:";
            // 
            // Cantitatea
            // 
            this.Cantitatea.AutoSize = true;
            this.Cantitatea.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Cantitatea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.Cantitatea.Location = new System.Drawing.Point(267, 330);
            this.Cantitatea.Name = "Cantitatea";
            this.Cantitatea.Size = new System.Drawing.Size(59, 15);
            this.Cantitatea.TabIndex = 24;
            this.Cantitatea.Text = "Cantitate:";
            // 
            // textCant
            // 
            this.textCant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textCant.Location = new System.Drawing.Point(163, 348);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(267, 27);
            this.textCant.TabIndex = 23;
            // 
            // labelCantInvalida
            // 
            this.labelCantInvalida.AutoSize = true;
            this.labelCantInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelCantInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelCantInvalida.Location = new System.Drawing.Point(242, 378);
            this.labelCantInvalida.Name = "labelCantInvalida";
            this.labelCantInvalida.Size = new System.Drawing.Size(109, 15);
            this.labelCantInvalida.TabIndex = 22;
            this.labelCantInvalida.Text = "Cantitate invalida!";
            this.labelCantInvalida.Visible = false;
            // 
            // buttonConfirmareAprovizionare
            // 
            this.buttonConfirmareAprovizionare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonConfirmareAprovizionare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.buttonConfirmareAprovizionare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmareAprovizionare.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmareAprovizionare.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmareAprovizionare.Location = new System.Drawing.Point(325, 490);
            this.buttonConfirmareAprovizionare.Name = "buttonConfirmareAprovizionare";
            this.buttonConfirmareAprovizionare.Size = new System.Drawing.Size(105, 51);
            this.buttonConfirmareAprovizionare.TabIndex = 21;
            this.buttonConfirmareAprovizionare.Text = "Confirmare";
            this.buttonConfirmareAprovizionare.UseVisualStyleBackColor = false;
            this.buttonConfirmareAprovizionare.Click += new System.EventHandler(this.buttonConfirmareFactura_Click_1);
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelLoc.Location = new System.Drawing.Point(272, 414);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(48, 15);
            this.labelLoc.TabIndex = 30;
            this.labelLoc.Text = "Locatie:";
            // 
            // labelLocInvalida
            // 
            this.labelLocInvalida.AutoSize = true;
            this.labelLocInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLocInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelLocInvalida.Location = new System.Drawing.Point(247, 462);
            this.labelLocInvalida.Name = "labelLocInvalida";
            this.labelLocInvalida.Size = new System.Drawing.Size(98, 15);
            this.labelLocInvalida.TabIndex = 31;
            this.labelLocInvalida.Text = "Locatie invalida!";
            this.labelLocInvalida.Visible = false;
            // 
            // comboLocatie
            // 
            this.comboLocatie.BackColor = System.Drawing.Color.White;
            this.comboLocatie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.comboLocatie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.comboLocatie.FormattingEnabled = true;
            this.comboLocatie.Location = new System.Drawing.Point(163, 432);
            this.comboLocatie.Name = "comboLocatie";
            this.comboLocatie.Size = new System.Drawing.Size(267, 27);
            this.comboLocatie.TabIndex = 32;
            // 
            // labelnvalid
            // 
            this.labelnvalid.AutoSize = true;
            this.labelnvalid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelnvalid.Location = new System.Drawing.Point(190, 220);
            this.labelnvalid.Name = "labelnvalid";
            this.labelnvalid.Size = new System.Drawing.Size(213, 19);
            this.labelnvalid.TabIndex = 33;
            this.labelnvalid.Text = "Nu au fost introduse informatii!";
            this.labelnvalid.Visible = false;
            // 
            // AdaugareAprovizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelnvalid);
            this.Controls.Add(this.comboLocatie);
            this.Controls.Add(this.labelLocInvalida);
            this.Controls.Add(this.labelLoc);
            this.Controls.Add(this.buttonAddProdus);
            this.Controls.Add(this.combNume);
            this.Controls.Add(this.labelNumeInvalid);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.Cantitatea);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.labelCantInvalida);
            this.Controls.Add(this.buttonConfirmareAprovizionare);
            this.Controls.Add(this.dgvAprovizionari);
            this.Name = "AdaugareAprovizionare";
            this.Size = new System.Drawing.Size(592, 553);
            this.Load += new System.EventHandler(this.AdaugareAprovizionare_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovizionari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAprovizionari;
        private System.Windows.Forms.Button buttonAddProdus;
        private System.Windows.Forms.ComboBox combNume;
        private System.Windows.Forms.Label labelNumeInvalid;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label Cantitatea;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label labelCantInvalida;
        private System.Windows.Forms.Button buttonConfirmareAprovizionare;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelLocInvalida;
        private System.Windows.Forms.ComboBox comboLocatie;
        private System.Windows.Forms.Label labelnvalid;
    }
}
