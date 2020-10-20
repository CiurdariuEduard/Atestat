using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Virtual
{
    public partial class Rapoarte : UserControl
    {
        public Rapoarte()
        {
            InitializeComponent();
        }

        private void Rapoarte_Load(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                var aprov = db.Aprovizionaris.ToList();
                comboAprovizionari1.DataSource = aprov;
                comboAprovizionari1.DisplayMember = "Data";
                comboAprovizionari1.ValueMember = "Id";
                var facturi = db.Facturis.ToList();
                comboVanzari1.DataSource = facturi;
                comboVanzari1.DisplayMember = "Data";
                comboVanzari1.ValueMember = "Id";

            }
        }

        private void comboVanzari1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                textVanzari1.Text =Convert.ToString(db.Facturis.Where(x => x.Id == (int)comboVanzari1.SelectedValue).FirstOrDefault().Total);
            }
        }

        private void comboVanzari2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboVanzari3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboAprovizionari1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboAprovizionari2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboAprovizionari3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTotal1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTotal2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTotal3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
