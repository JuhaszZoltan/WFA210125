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
    public partial class FrmUjTurazo : Form
    {
        SqlConnection conn;

        public FrmUjTurazo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void BtnUj_Click(object sender, EventArgs e)
        {
            conn.Open();


            new SqlCommand(
                "INSERT INTO turazo VALUES " +
                $"('{tbVez.Text}', '{tbKer.Text}', '{tbVaros.Text}', '{tbTel.Text}');",
                conn).ExecuteNonQuery();


            conn.Close();

            this.Dispose();
        }
    }
}
