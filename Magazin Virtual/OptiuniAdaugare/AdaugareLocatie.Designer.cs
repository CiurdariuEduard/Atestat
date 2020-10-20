namespace Magazin_Virtual.OptiuniAdaugare
{
    partial class AdaugareLocatie
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
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmLocation = new System.Windows.Forms.Button();
            this.locatieInvalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLocation
            // 
            this.textLocation.BackColor = System.Drawing.Color.White;
            this.textLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textLocation.Location = new System.Drawing.Point(70, 81);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(327, 27);
            this.textLocation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(180, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Denumire Locatie: ";
            // 
            // ConfirmLocation
            // 
            this.ConfirmLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.ConfirmLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.ConfirmLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmLocation.ForeColor = System.Drawing.Color.White;
            this.ConfirmLocation.Location = new System.Drawing.Point(183, 156);
            this.ConfirmLocation.Name = "ConfirmLocation";
            this.ConfirmLocation.Size = new System.Drawing.Size(100, 40);
            this.ConfirmLocation.TabIndex = 4;
            this.ConfirmLocation.Text = "Confirmare";
            this.ConfirmLocation.UseVisualStyleBackColor = false;
            this.ConfirmLocation.Click += new System.EventHandler(this.ConfirmLocation_Click);
            // 
            // locatieInvalida
            // 
            this.locatieInvalida.AutoSize = true;
            this.locatieInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.locatieInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.locatieInvalida.Location = new System.Drawing.Point(184, 111);
            this.locatieInvalida.Name = "locatieInvalida";
            this.locatieInvalida.Size = new System.Drawing.Size(98, 15);
            this.locatieInvalida.TabIndex = 7;
            this.locatieInvalida.Text = "Locatie invalida!";
            this.locatieInvalida.Visible = false;
            // 
            // AdaugareLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.locatieInvalida);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmLocation);
            this.Name = "AdaugareLocatie";
            this.Size = new System.Drawing.Size(463, 241);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmLocation;
        private System.Windows.Forms.Label locatieInvalida;
    }
}
