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
    public partial class AdaugareProdus : UserControl
    {
        public AdaugareProdus()
        {
            InitializeComponent();
        }
        
        private void AdaugareProdus_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmareAdaugareProdus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textNumeProdus.Text) && !string.IsNullOrEmpty(textPretProdus.Text) && Convert.ToDecimal(textPretProdus.Text) != 0)
            {
                using (var db = new Virtual_StoreEntities())
                {
                    Product v = new Product();
                    v.Name = textNumeProdus.Text;
                    v.Pret = Convert.ToDecimal(textPretProdus.Text);
                    db.Products.Add(v);
                    textNumeProdus.Text = "";
                    textPretProdus.Text = "0";
                    foreach(Magazin_Virtual.Location l in db.Locations)
                    {
                        Inventory i = new Inventory();
                        i.ProductId = v.Id;
                        i.LocationId = l.Id;
                        i.Items = 0;
                        db.Inventories.Add(i);
                    }

                    db.SaveChanges();
                    produsInvalid.Hide();
                    pretIncorect.Hide();
                    this.Hide();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textNumeProdus.Text))
                {
                    produsInvalid.Show();
                }
                if (string.IsNullOrEmpty(textPretProdus.Text) || Convert.ToInt32(textPretProdus.Text) == 0)
                {
                    pretIncorect.Show();
                }
            }
            

        }
    }
}
