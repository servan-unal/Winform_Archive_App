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

namespace ArchiveProject.Forms
{
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
            verilerigoster();
        }

        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");

        private void verilerigoster()
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from tblOda", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into TblOda (Oda_Ad) values (@Oda_Ad) ", baglatı);
            komut.Parameters.AddWithValue("@Oda_Ad", txtRoomName.Text);
           
            komut.ExecuteNonQuery();
            baglatı.Close();
            verilerigoster();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
