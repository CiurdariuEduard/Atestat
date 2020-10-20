using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Virtual.OptiuniAdaugare
{
    public partial class AdaugareLocatie : UserControl
    {
        public AdaugareLocatie()
        {
            InitializeComponent();
        }

        private void ConfirmLocation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textLocation.Text))
            {
                using (var db = new Virtual_StoreEntities())
                {
                    Magazin_Virtual.Location l = new Magazin_Virtual.Location();
                    l.Name = textLocation.Text;
                    db.Locations.Add(l);
                    foreach (Product p in db.Products)
                    {
                        Inventory i = new Inventory();
                        i.LocationId = l.Id; ;
                        i.Items = 0;
                        i.ProductId = p.Id;
                        db.Inventories.Add(i);
                    }
                    db.SaveChanges();
                    textLocation.Text = "";
                    locatieInvalida.Hide();
                    this.Hide();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textLocation.Text))
                    locatieInvalida.Show();
            }
        }
    }
}
