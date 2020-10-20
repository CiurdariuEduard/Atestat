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
    public partial class TabelaAprovizionari : UserControl
    {
        public TabelaAprovizionari()
        {
            InitializeComponent();
        }

        private void TabelaAprovizionari_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Total");
            dt.Columns.Add("Data");
            var db = new Virtual_StoreEntities();
            foreach (Aprovizionari p in db.Aprovizionaris)
            {
                dt.Rows.Add(p.Id, p.Total, p.Data);
            }
            dgvAprovizionari.DataSource = dt;
            dgvAprovizionari.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAprovizionari.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvAprovizionari.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
