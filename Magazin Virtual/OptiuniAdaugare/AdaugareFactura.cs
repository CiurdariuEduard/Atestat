using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magazin_Virtual
{
    public partial class AdaugareFactura : UserControl
    {
        int facturaId;
        DataTable dt = new DataTable();

        public AdaugareFactura()
        {
            InitializeComponent();
        }

        private void buttonConfirmareFactura_Click(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                Facturi facturaCurenta = db.Facturis.Where(f => f.Id == facturaId).FirstOrDefault();
                if (db.PozitiiFacturis.Where(g => g.FacturaId == facturaId).Count() <= 0)
                    labelInvalid.Show();
                else
                {
                    facturaCurenta.Total = db.PozitiiFacturis.Where(g => g.FacturaId == facturaId).Sum(f => f.PretTotal);
                    db.SaveChanges();
                    this.Hide();
                }
            }
        }

        private void AdaugareFactura_Load(object sender, EventArgs e)
        {
            using (var db = new Virtual_StoreEntities())
            {
                dt.Clear();
                textCant.Text = "0";
                comboNume.Text = "";
                comboLocatie.Text = "";
                var produse = db.Products.ToList();
                var locatii = db.Locations.ToList();
                comboNume.DataSource = produse;
                comboNume.DisplayMember = "Name";
                comboNume.ValueMember = "Id";
                comboLocatie.DataSource = locatii;
                comboLocatie.DisplayMember = "Name";
                comboLocatie.ValueMember = "Id";
            }
            dt.Columns.Add("Nume");
            dt.Columns.Add("Cantitate");
            dt.Columns.Add("Pret / Bucata");
            dt.Columns.Add("Pret Total");
            dt.Columns.Add("Locatie");
            dgvSelectareProdus.DataSource = dt;
            dgvSelectareProdus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSelectareProdus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSelectareProdus.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSelectareProdus.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSelectareProdus.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void buttonAddProdus_Click(object sender, EventArgs e)
        {

            using (var db = new Virtual_StoreEntities())
            {
                if (db.Inventories.Where(x => x.Id == (int)comboLocatie.SelectedValue).FirstOrDefault().Items >= Convert.ToInt32(textCant.Text))
                {
                    if (facturaId == 0)
                    {
                        Facturi x = new Facturi();
                        x.Total = 0;
                        x.Data = DateTime.Now;
                        x.LocationId = (int)comboLocatie.SelectedValue;
                        x.Cantitate = Convert.ToInt32(textCant.Text);
                        x.ProductId = (int)comboNume.SelectedValue;
                        db.Facturis.Add(x);
                        db.SaveChanges();
                        facturaId = x.Id;
                    }
                    PozitiiFacturi pozitieNoua = new PozitiiFacturi();
                    Product produsVandut = db.Products.Where(x => x.Id == (int)comboNume.SelectedValue).FirstOrDefault();
                    pozitieNoua.FacturaId = facturaId;
                    pozitieNoua.ProdusId = produsVandut.Id;
                    pozitieNoua.Cantitate = Convert.ToInt32(textCant.Text);
                    pozitieNoua.PretPerBuc = produsVandut.Pret.Value;
                    pozitieNoua.PretTotal = produsVandut.Pret.Value * pozitieNoua.Cantitate.Value;
                    pozitieNoua.LocationId = (int)comboLocatie.SelectedValue;
                    db.PozitiiFacturis.Add(pozitieNoua);
                    db.Inventories.Where(x => x.ProductId == pozitieNoua.ProdusId && x.LocationId == pozitieNoua.LocationId).FirstOrDefault().Items = db.Inventories.Where(x => x.ProductId == pozitieNoua.ProdusId && x.LocationId == pozitieNoua.LocationId).FirstOrDefault().Items - (int)pozitieNoua.Cantitate;
                    db.SaveChanges();
                    dt.Rows.Add(produsVandut.Name, pozitieNoua.Cantitate.Value, pozitieNoua.PretPerBuc, pozitieNoua.PretTotal, comboLocatie.Text);
                }
                else
                    labelInvalid2.Show();
            }
        }
    }
}
