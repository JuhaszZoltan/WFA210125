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
    public partial class FrmUtvonalak : Form
    {
        private SqlConnection conn;
        private int id;
        public FrmUtvonalak(int id, SqlConnection conn)
        {
            this.conn = conn;
            this.id = id;

            InitializeComponent();
        }

        private void FrmUtvonalak_Load(object sender, EventArgs e)
        {
            conn.Open();

            var r = new SqlCommand(
                "SELECT honnan, hova, km FROM utvonal " +
                $"WHERE turazoId = {id}", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvUtvonalak.Rows.Add(r[0], r[1], r[2]);
            }

            conn.Close();

            int sum = 0;
            foreach (DataGridViewRow row in dgvUtvonalak.Rows)
                sum += (int)row.Cells[2].Value;

            txtOsszKM.Text = $"{sum}";
            txtPont.Text = $"{sum / 20}";


        }
    }
}
