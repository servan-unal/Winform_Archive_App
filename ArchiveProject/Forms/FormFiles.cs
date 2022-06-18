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
    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
            SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
            SqlCommand sqlconn = new SqlCommand("select Klasor_Id from Tbl_Klasor", baglatı);
            baglatı.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlconn);
            DataSet dk = new DataSet();
            sda.Fill(dk);
            for (int i = 0; i < dk.Tables[0].Rows.Count; i++)
            {
                FolderIdCombobox.Items.Add(dk.Tables[0].Rows[i][0]);
            }
            verilerigoster();
        }

        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
        private void verilerigoster()
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Dosya", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into Tbl_Dosya (Dosya_Ad, Klasor_Id) values (@Dosya_Ad, @Klasor_Id) ", baglatı);
            komut.Parameters.AddWithValue("@Dosya_Ad", txtFileName.Text);
            komut.Parameters.AddWithValue("@Klasor_Id", FolderIdCombobox.SelectedItem);
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
