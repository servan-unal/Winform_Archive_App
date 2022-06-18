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
    public partial class FormShelf : Form
    {
        public FormShelf()
        {
            InitializeComponent();
            SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
            SqlCommand sqlconn = new SqlCommand("select Bolum_Id from Tbl_Bolum", baglatı);
            baglatı.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlconn);
            DataSet dk = new DataSet();
            sda.Fill(dk);
            for (int i = 0; i < dk.Tables[0].Rows.Count; i++)
            {
                PartIdCombobox.Items.Add(dk.Tables[0].Rows[i][0]);
            }
            verilerigoster();
        }
        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");

        private void verilerigoster()
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Raf", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into Tbl_Raf (Raf_Ad, Bolum_Id) values (@Raf_Ad, @Bolum_Id) ", baglatı);
            komut.Parameters.AddWithValue("@Raf_Ad", txtShelfName.Text);
            komut.Parameters.AddWithValue("@Bolum_Id", PartIdCombobox.SelectedItem);
            komut.ExecuteNonQuery();
            baglatı.Close();
            verilerigoster();
        }
        private void btnDeleteShelf_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }
    }
}
