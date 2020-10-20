using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazin_Virtual.Properties;

namespace Magazin_Virtual
{
    public partial class AdaugareAngajat : UserControl
    {
        public AdaugareAngajat()
        {
            InitializeComponent();
        }

        private void buttonConfirmareUtilizator_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textParola.Text) && !string.IsNullOrEmpty(textUtilizator.Text) && !string.IsNullOrEmpty(comboLocatie.Text) && !string.IsNullOrEmpty(comboFunctie.Text))
            {
                using (var db = new Virtual_StoreEntities())
                {
                    User u = new User();
                    u.LocationId = (int)comboLocatie.SelectedValue;
                    u.UserTypeId = (int)comboFunctie.SelectedValue;
                    u.Username = textUtilizator.Text;
                    u.Password = textParola.Text;
                    db.Users.Add(u);
                    textUtilizator.Text = "";
                    textParola.Text = "";
                    db.SaveChanges();
                    labelParolaInvalida.Hide();
                    labelUserInvalid.Hide();
                    labelLocInvalida.Hide();
                    labelFunctieInvalida.Hide();
                    this.Hide();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textParola.Text))
                {
                    labelParolaInvalida.Show();
                }
                if (string.IsNullOrEmpty(textUtilizator.Text))
                {
                    labelUserInvalid.Show();
                }
                if (string.IsNullOrEmpty(comboLocatie.Text))
                {
                    labelLocInvalida.Show();
                }
                if(string.IsNullOrEmpty(comboFunctie.Text))
                {
                    labelFunctieInvalida.Show();
                }
            }
        }

        private void AdaugareAngajat_Load(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                var locations = db.Locations.ToList();
                comboLocatie.DataSource = locations;
                comboLocatie.DisplayMember = "Name";
                comboLocatie.ValueMember = "Id";
                var functii = db.UserTypes.ToList();
                comboFunctie.DataSource = functii;
                comboFunctie.DisplayMember = "Description";
                comboFunctie.ValueMember = "Id";
            }
        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if (textParola.PasswordChar == '\0')
                textParola.PasswordChar = '*';
            else
                textParola.PasswordChar = '\0';
        }
    }
}