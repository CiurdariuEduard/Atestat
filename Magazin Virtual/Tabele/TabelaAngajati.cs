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
    public partial class TabelaAngajati : UserControl
    {
        public TabelaAngajati()
        {
            InitializeComponent();
        }

        private void TabelaAngajati_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nume");
            dt.Columns.Add("Functie utilizator");
            dt.Columns.Add("Locatie utilizator");
            var db = new Virtual_StoreEntities();
            foreach (User p in db.Users)
            {
                
                dt.Rows.Add(p.Id, p.Username, db.UserTypes.Where(x=> x.Id == p.UserTypeId).FirstOrDefault().Description, db.Locations.Where(x=> x.Id==p.LocationId).FirstOrDefault().Name);
            }
            dgvAngajati.DataSource = dt;
            dgvAngajati.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAngajati.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAngajati.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAngajati.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAngajati.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvAngajati.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 43, 73);
        }
    }
}
