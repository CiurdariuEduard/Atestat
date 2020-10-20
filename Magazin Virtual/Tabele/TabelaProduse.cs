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
    public partial class TabelaProduse : UserControl
    {
        public TabelaProduse()
        {
            InitializeComponent();
        }

        private void TabelaProduse_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nume");
            dt.Columns.Add("Pret / Bucata");
            var db = new Virtual_StoreEntities();
            foreach (Product p in db.Products)
            {
                dt.Rows.Add(p.Id, p.Name, p.Pret);
            }
            dgvProduse.DataSource = dt;
            dgvProduse.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduse.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduse.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProduse.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvProduse.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
