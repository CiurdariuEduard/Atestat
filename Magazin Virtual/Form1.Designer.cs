namespace Magazin_Virtual
{
    partial class Login_Window
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
            this.Username_Login = new System.Windows.Forms.Label();
            this.Passowrd_Login = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Exit_Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.incorrectPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Login
            // 
            this.Username_Login.AutoSize = true;
            this.Username_Login.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Username_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.Username_Login.Location = new System.Drawing.Point(404, 236);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(68, 15);
            this.Username_Login.TabIndex = 0;
            this.Username_Login.Text = "Username :";
            // 
            // Passowrd_Login
            // 
            this.Passowrd_Login.AutoSize = true;
            this.Passowrd_Login.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passowrd_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.Passowrd_Login.Location = new System.Drawing.Point(405, 313);
            this.Passowrd_Login.Name = "Passowrd_Login";
            this.Passowrd_Login.Size = new System.Drawing.Size(67, 15);
            this.Passowrd_Login.TabIndex = 1;
            this.Passowrd_Login.Text = "Password :";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(119)))));
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Location = new System.Drawing.Point(333, 395);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(143, 40);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Exit_Login
            // 
            this.Exit_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Exit_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Exit_Login.ForeColor = System.Drawing.Color.White;
            this.Exit_Login.Location = new System.Drawing.Point(482, 395);
            this.Exit_Login.Name = "Exit_Login";
            this.Exit_Login.Size = new System.Drawing.Size(61, 40);
            this.Exit_Login.TabIndex = 3;
            this.Exit_Login.Text = "Exit";
            this.Exit_Login.UseVisualStyleBackColor = false;
            this.Exit_Login.Click += new System.EventHandler(this.Exit_Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textBox1.Location = new System.Drawing.Point(333, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.textBox2.Location = new System.Drawing.Point(333, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(210, 27);
            this.textBox2.TabIndex = 5;
            // 
            // incorrectPassword
            // 
            this.incorrectPassword.AutoSize = true;
            this.incorrectPassword.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.incorrectPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.incorrectPassword.Location = new System.Drawing.Point(342, 361);
            this.incorrectPassword.Name = "incorrectPassword";
            this.incorrectPassword.Size = new System.Drawing.Size(186, 15);
            this.incorrectPassword.TabIndex = 6;
            this.incorrectPassword.Text = "Incorrect username or password";
            this.incorrectPassword.Visible = false;
            // 
            // Login_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.incorrectPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit_Login);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Passowrd_Login);
            this.Controls.Add(this.Username_Login);
            this.Name = "Login_Window";
            this.Text = "Login Window";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_Window_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Login;
        private System.Windows.Forms.Label Passowrd_Login;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Exit_Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label incorrectPassword;
    }
}

