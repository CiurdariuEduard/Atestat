namespace Magazin_Virtual
{
    partial class AdaugareAngajat
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
            this.buttonConfirmareUtilizator = new System.Windows.Forms.Button();
            this.usernameAngajat = new System.Windows.Forms.Label();
            this.labelUserInvalid = new System.Windows.Forms.Label();
            this.textUtilizator = new System.Windows.Forms.TextBox();
            this.textParola = new System.Windows.Forms.TextBox();
            this.buttonShowPass = new System.Windows.Forms.Button();
            this.labelParolaAngajat = new System.Windows.Forms.Label();
            this.labelParolaInvalida = new System.Windows.Forms.Label();
            this.comboLocatie = new System.Windows.Forms.ComboBox();
            this.labelLocatieUser = new System.Windows.Forms.Label();
            this.labelLocInvalida = new System.Windows.Forms.Label();
            this.labelFunctieInvalida = new System.Windows.Forms.Label();
            this.functieAngajat = new System.Windows.Forms.Label();
            this.comboFunctie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonConfirmareUtilizator
            // 
            this.buttonConfirmareUtilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.buttonConfirmareUtilizator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.buttonConfirmareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmareUtilizator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmareUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmareUtilizator.Location = new System.Drawing.Point(96, 412);
            this.buttonConfirmareUtilizator.Name = "buttonConfirmareUtilizator";
            this.buttonConfirmareUtilizator.Size = new System.Drawing.Size(100, 50);
            this.buttonConfirmareUtilizator.TabIndex = 0;
            this.buttonConfirmareUtilizator.Text = "Confirmare";
            this.buttonConfirmareUtilizator.UseVisualStyleBackColor = false;
            this.buttonConfirmareUtilizator.Click += new System.EventHandler(this.buttonConfirmareUtilizator_Click);
            // 
            // usernameAngajat
            // 
            this.usernameAngajat.AutoSize = true;
            this.usernameAngajat.BackColor = System.Drawing.Color.White;
            this.usernameAngajat.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.usernameAngajat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.usernameAngajat.Location = new System.Drawing.Point(98, 63);
            this.usernameAngajat.Name = "usernameAngajat";
            this.usernameAngajat.Size = new System.Drawing.Size(97, 15);
            this.usernameAngajat.TabIndex = 1;
            this.usernameAngajat.Text = "Nume utilizator: ";
            // 
            // labelUserInvalid
            // 
            this.labelUserInvalid.AutoSize = true;
            this.labelUserInvalid.BackColor = System.Drawing.Color.White;
            this.labelUserInvalid.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelUserInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelUserInvalid.Location = new System.Drawing.Point(78, 109);
            this.labelUserInvalid.Name = "labelUserInvalid";
            this.labelUserInvalid.Size = new System.Drawing.Size(137, 15);
            this.labelUserInvalid.TabIndex = 2;
            this.labelUserInvalid.Text = "Nume utilizator invalid!";
            this.labelUserInvalid.Visible = false;
            // 
            // textUtilizator
            // 
            this.textUtilizator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textUtilizator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textUtilizator.Location = new System.Drawing.Point(42, 79);
            this.textUtilizator.Name = "textUtilizator";
            this.textUtilizator.Size = new System.Drawing.Size(208, 27);
            this.textUtilizator.TabIndex = 3;
            // 
            // textParola
            // 
            this.textParola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textParola.Location = new System.Drawing.Point(42, 229);
            this.textParola.Name = "textParola";
            this.textParola.PasswordChar = '*';
            this.textParola.Size = new System.Drawing.Size(208, 27);
            this.textParola.TabIndex = 4;
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.buttonShowPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.buttonShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowPass.ForeColor = System.Drawing.Color.White;
            this.buttonShowPass.Location = new System.Drawing.Point(96, 356);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(100, 50);
            this.buttonShowPass.TabIndex = 5;
            this.buttonShowPass.Text = "Arata parola";
            this.buttonShowPass.UseVisualStyleBackColor = false;
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // labelParolaAngajat
            // 
            this.labelParolaAngajat.AutoSize = true;
            this.labelParolaAngajat.BackColor = System.Drawing.Color.White;
            this.labelParolaAngajat.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelParolaAngajat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelParolaAngajat.Location = new System.Drawing.Point(95, 213);
            this.labelParolaAngajat.Name = "labelParolaAngajat";
            this.labelParolaAngajat.Size = new System.Drawing.Size(103, 15);
            this.labelParolaAngajat.TabIndex = 6;
            this.labelParolaAngajat.Text = "Parola utilizator: ";
            // 
            // labelParolaInvalida
            // 
            this.labelParolaInvalida.AutoSize = true;
            this.labelParolaInvalida.BackColor = System.Drawing.Color.White;
            this.labelParolaInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelParolaInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelParolaInvalida.Location = new System.Drawing.Point(98, 259);
            this.labelParolaInvalida.Name = "labelParolaInvalida";
            this.labelParolaInvalida.Size = new System.Drawing.Size(97, 15);
            this.labelParolaInvalida.TabIndex = 7;
            this.labelParolaInvalida.Text = "Parola invalida!";
            this.labelParolaInvalida.Visible = false;
            // 
            // comboLocatie
            // 
            this.comboLocatie.BackColor = System.Drawing.Color.White;
            this.comboLocatie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.comboLocatie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.comboLocatie.FormattingEnabled = true;
            this.comboLocatie.Location = new System.Drawing.Point(42, 308);
            this.comboLocatie.Name = "comboLocatie";
            this.comboLocatie.Size = new System.Drawing.Size(208, 27);
            this.comboLocatie.TabIndex = 8;
            // 
            // labelLocatieUser
            // 
            this.labelLocatieUser.AutoSize = true;
            this.labelLocatieUser.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLocatieUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.labelLocatieUser.Location = new System.Drawing.Point(97, 290);
            this.labelLocatieUser.Name = "labelLocatieUser";
            this.labelLocatieUser.Size = new System.Drawing.Size(98, 15);
            this.labelLocatieUser.TabIndex = 9;
            this.labelLocatieUser.Text = "Locatie utilizator";
            // 
            // labelLocInvalida
            // 
            this.labelLocInvalida.AutoSize = true;
            this.labelLocInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelLocInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelLocInvalida.Location = new System.Drawing.Point(97, 338);
            this.labelLocInvalida.Name = "labelLocInvalida";
            this.labelLocInvalida.Size = new System.Drawing.Size(98, 15);
            this.labelLocInvalida.TabIndex = 10;
            this.labelLocInvalida.Text = "Locatie invalida!";
            this.labelLocInvalida.Visible = false;
            // 
            // labelFunctieInvalida
            // 
            this.labelFunctieInvalida.AutoSize = true;
            this.labelFunctieInvalida.BackColor = System.Drawing.Color.White;
            this.labelFunctieInvalida.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.labelFunctieInvalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelFunctieInvalida.Location = new System.Drawing.Point(97, 188);
            this.labelFunctieInvalida.Name = "labelFunctieInvalida";
            this.labelFunctieInvalida.Size = new System.Drawing.Size(99, 15);
            this.labelFunctieInvalida.TabIndex = 13;
            this.labelFunctieInvalida.Text = "Functie invalida!";
            this.labelFunctieInvalida.Visible = false;
            // 
            // functieAngajat
            // 
            this.functieAngajat.AutoSize = true;
            this.functieAngajat.BackColor = System.Drawing.Color.White;
            this.functieAngajat.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.functieAngajat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.functieAngajat.Location = new System.Drawing.Point(94, 140);
            this.functieAngajat.Name = "functieAngajat";
            this.functieAngajat.Size = new System.Drawing.Size(105, 15);
            this.functieAngajat.TabIndex = 12;
            this.functieAngajat.Text = "Functie utilizator: ";
            // 
            // comboFunctie
            // 
            this.comboFunctie.BackColor = System.Drawing.Color.White;
            this.comboFunctie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.comboFunctie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.comboFunctie.FormattingEnabled = true;
            this.comboFunctie.Location = new System.Drawing.Point(42, 158);
            this.comboFunctie.Name = "comboFunctie";
            this.comboFunctie.Size = new System.Drawing.Size(208, 27);
            this.comboFunctie.TabIndex = 14;
            // 
            // AdaugareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboFunctie);
            this.Controls.Add(this.labelFunctieInvalida);
            this.Controls.Add(this.functieAngajat);
            this.Controls.Add(this.labelLocInvalida);
            this.Controls.Add(this.labelLocatieUser);
            this.Controls.Add(this.comboLocatie);
            this.Controls.Add(this.labelParolaInvalida);
            this.Controls.Add(this.labelParolaAngajat);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.textParola);
            this.Controls.Add(this.textUtilizator);
            this.Controls.Add(this.labelUserInvalid);
            this.Controls.Add(this.usernameAngajat);
            this.Controls.Add(this.buttonConfirmareUtilizator);
            this.Name = "AdaugareAngajat";
            this.Size = new System.Drawing.Size(311, 530);
            this.Load += new System.EventHandler(this.AdaugareAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmareUtilizator;
        private System.Windows.Forms.Label usernameAngajat;
        private System.Windows.Forms.Label labelUserInvalid;
        private System.Windows.Forms.TextBox textUtilizator;
        private System.Windows.Forms.TextBox textParola;
        private System.Windows.Forms.Button buttonShowPass;
        private System.Windows.Forms.Label labelParolaAngajat;
        private System.Windows.Forms.Label labelParolaInvalida;
        private System.Windows.Forms.ComboBox comboLocatie;
        private System.Windows.Forms.Label labelLocatieUser;
        private System.Windows.Forms.Label labelLocInvalida;
        private System.Windows.Forms.Label labelFunctieInvalida;
        private System.Windows.Forms.Label functieAngajat;
        private System.Windows.Forms.ComboBox comboFunctie;
    }
}
