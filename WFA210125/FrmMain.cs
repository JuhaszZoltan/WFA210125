using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210125
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;

        public FrmMain()
        {
            conn = new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;" +
                "Initial Catalog=tura;");

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();

            var r = new SqlCommand("SELECT * FROM turazo", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvTurazok.Rows.Add(r[0], $"{r[1]} {r[2]}", r[3], r[4]);
            }

            conn.Close();
        }

        private void DgvTurazok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvTurazok[0, e.RowIndex].Value;

            var frm = new FrmUtvonalak(id, conn);
            frm.ShowDialog();
        }
    }
}
