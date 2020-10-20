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
    public partial class AdaugareAprovizionare : UserControl
    {
        int aprovId;
        DataTable dt = new DataTable();

        public AdaugareAprovizionare()
        {
            InitializeComponent();
        }

        private void AdaugareAprovizionare_Load_1(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                dt.Clear();
                textCant.Text = "0";
                combNume.Text = "";
                comboLocatie.Text = "";
                var produse = db.Products.ToList();
                var locatii = db.Locations.ToList();
                comboLocatie.DataSource = locatii;
                comboLocatie.DisplayMember = "Name";
                comboLocatie.ValueMember = "Id";
                combNume.DataSource = produse;
                combNume.DisplayMember = "Name";
                combNume.ValueMember = "Id";
            }
            dt.Columns.Add("Nume");
            dt.Columns.Add("Cantitate");
            dt.Columns.Add("Pret / Bucata");
            dt.Columns.Add("Pret Total");
            dt.Columns.Add("Locatie");
            dgvAprovizionari.DataSource = dt;
            dgvAprovizionari.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void buttonConfirmareFactura_Click_1(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                Aprovizionari aprovCurenta = db.Aprovizionaris.Where(f => f.Id == aprovId).FirstOrDefault();
                if (db.PozitiiAprovizionaris.Where(g => g.AprovizionareId == aprovId).Count() <= 0)
                    labelnvalid.Show();
                else
                {
                    aprovCurenta.Total = db.PozitiiAprovizionaris.Where(g => g.AprovizionareId == aprovId).Sum(f => f.PretTotal);
                    db.SaveChanges();
                    this.Hide();
                }
            }
        }

        private void buttonAddProdus_Click(object sender, EventArgs e)
        {

            using (var db = new Virtual_StoreEntities())
            {
                if (aprovId == 0)
                {
                    Aprovizionari x = new Aprovizionari();
                    x.Total = 0;
                    x.Data = DateTime.Now;
                    x.LocationId = (int)comboLocatie.SelectedValue;
                    x.Cantitate = Convert.ToInt32(textCant.Text);
                    x.ProductId = (int)combNume.SelectedValue;
                    db.Aprovizionaris.Add(x);
                    db.SaveChanges();
                    aprovId = x.Id;
                }
                PozitiiAprovizionari pozitieNoua = new PozitiiAprovizionari();
                Product produsVandut = db.Products.Where(x => x.Id == (int)combNume.SelectedValue).FirstOrDefault();
                pozitieNoua.AprovizionareId = aprovId;
                pozitieNoua.ProdusId = produsVandut.Id;
                pozitieNoua.Cantitate = Convert.ToInt32(textCant.Text);
                pozitieNoua.PretPerBuc = produsVandut.Pret.Value;
                pozitieNoua.PretTotal = produsVandut.Pret.Value * pozitieNoua.Cantitate.Value;
                pozitieNoua.LocationId = (int)comboLocatie.SelectedValue;
                db.Inventories.Where(x => x.ProductId == pozitieNoua.ProdusId && x.LocationId == pozitieNoua.LocationId).FirstOrDefault().Items = db.Inventories.Where(x => x.ProductId == pozitieNoua.ProdusId && x.LocationId == pozitieNoua.LocationId).FirstOrDefault().Items + (int)pozitieNoua.Cantitate;
                db.PozitiiAprovizionaris.Add(pozitieNoua);
                db.SaveChanges();
                dt.Rows.Add(produsVandut.Name, pozitieNoua.Cantitate.Value, pozitieNoua.PretPerBuc, pozitieNoua.PretTotal,comboLocatie.Text);
            }
        }

    }
}
