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
    public partial class TabelaStoc : UserControl
    {
        public TabelaStoc()
        {
            InitializeComponent();
        }

        private void TabelaStoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nume");
            dt.Columns.Add("Cantitate");
            dt.Columns.Add("Locatie");
            var db = new Virtual_StoreEntities();
            foreach (Inventory p in db.Inventories)
            {
                dt.Rows.Add(p.Id, db.Products.Where(x=> x.Id==p.ProductId).FirstOrDefault().Name, p.Items, db.Locations.Where(x => x.Id == p.LocationId).FirstOrDefault().Name);
            }
            dgvStoc.DataSource = dt;
            dgvStoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvStoc.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvStoc.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
