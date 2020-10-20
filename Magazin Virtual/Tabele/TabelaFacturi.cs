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
    public partial class TabelaFacturi : UserControl
    {
        public TabelaFacturi()
        {
            InitializeComponent();
        }

        private void TabelaFacturi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Total");
            dt.Columns.Add("Data");
            var db = new Virtual_StoreEntities();
            foreach (Facturi p in db.Facturis)
            {
                dt.Rows.Add(p.Id, p.Total,p.Data);
            }
            dgvFacturi.DataSource = dt;
            dgvFacturi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFacturi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFacturi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFacturi.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvFacturi.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
