using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Magazin_Virtual
{
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Exit_Login_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string myUsername = textBox1.Text;
            string myPassword = textBox2.Text;
            using (var db = new Virtual_StoreEntities())
            {
                var userFound = db.Users.Where(entry => entry.Username == myUsername && entry.Password == myPassword && entry.UserTypeId<3).Count() > 0;
                if (userFound == true)
                {
                    this.Hide();
                    Magazin ss = new Magazin();
                    ss.Show();
                }
                else
                {
                    incorrectPassword.Show();
                }
            }
        }

        private void Login_Window_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_Button_Click(sender, null);
            }
        }
    }
}
