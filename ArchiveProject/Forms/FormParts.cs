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
    public partial class FormParts : Form
    {
        public FormParts()
        {
            InitializeComponent();
            SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
            SqlCommand sqlconn = new SqlCommand("select Oda_Id from TblOda", baglatı);
            baglatı.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlconn);
            DataSet dk = new DataSet();
            sda.Fill(dk);
            for (int i = 0; i < dk.Tables[0].Rows.Count; i++)
            {
                roomIdCombobox.Items.Add(dk.Tables[0].Rows[i][0]);
            }
            verilerigoster();
        }
        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
        private void verilerigoster()
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Bolum", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into Tbl_Bolum (Bolum_Ad, Oda_Id) values (@Bolum_Ad, @Oda_Id) ", baglatı);
            komut.Parameters.AddWithValue("@Bolum_Ad", txtPartName.Text);
            komut.Parameters.AddWithValue("@Oda_Id", roomIdCombobox.SelectedItem);
            komut.ExecuteNonQuery();
            baglatı.Close();
            verilerigoster();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
