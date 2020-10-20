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
    public partial class TabelaLocatii : UserControl
    {
        public TabelaLocatii()
        {
            InitializeComponent();
        }

        private void TabelaLocatii_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nume");
            var db = new Virtual_StoreEntities();
            foreach (Magazin_Virtual.Location p in db.Locations)
            {
                dt.Rows.Add(p.Id, p.Name);
            }
            dgvTabelLocatii.DataSource = dt;
            dgvTabelLocatii.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTabelLocatii.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTabelLocatii.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvTabelLocatii.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
