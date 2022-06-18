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
    public partial class FormDocuments : Form
    {
        public FormDocuments()
        {
            InitializeComponent();
            SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
            SqlCommand folderid = new SqlCommand("select Dosya_Id from Tbl_Dosya", baglatı);
            SqlDataAdapter sdafolder = new SqlDataAdapter(folderid);
            DataSet dkfoldr = new DataSet();
            sdafolder.Fill(dkfoldr);
            for (int i = 0; i < dkfoldr.Tables[0].Rows.Count; i++)
            {
                folderIdCombo.Items.Add(dkfoldr.Tables[0].Rows[i][0]);
            }
            SqlConnection baglatık = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
            SqlCommand folderids = new SqlCommand("select Dosya_Id from Tbl_Dosya", baglatık);
            SqlDataAdapter sdafoldedr = new SqlDataAdapter(folderids);
            DataSet dkfoldrs = new DataSet();
            sdafoldedr.Fill(dkfoldrs);
            for (int k = 0; k < dkfoldrs.Tables[0].Rows.Count; k++)
            {
                FfolderIdCombobox.Items.Add(dkfoldrs.Tables[0].Rows[k][0]);
            }
        }
        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (typeCheckBox.CheckState == CheckState.Checked)
            {
                typeCheckBox.Text = "Gelen";
            }
            else if (typeCheckBox.CheckState == CheckState.Unchecked)
            {
                typeCheckBox.Text = "Giden";
            }
            else
            {
                typeCheckBox.Text = "?";
            }
        }
        private void btnSelectDoc_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Evrak where Dosya_Id = '" + folderIdCombo.Text + "'", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into Tbl_Evrak (Evrak_Ad, Dosya_Id, Evrak_Konu, Evral_Tip, Evrak_Gidis_Tarihi," +
                "Evrak_Gelis_Tarihi) values (@Evrak_Ad, @Dosya_Id,@Evrak_Konu,@Evral_Tip,@Evrak_Gidis_Tarihi,@Evrak_Gelis_Tarihi) ", baglatı);

            komut.Parameters.AddWithValue("@Evrak_Ad", txtDocName.Text);
            komut.Parameters.AddWithValue("@Dosya_Id", FfolderIdCombobox.SelectedItem);
            komut.Parameters.AddWithValue("@Evrak_Konu", txtSubject.Text);
            komut.Parameters.AddWithValue("@Evral_Tip", typeCheckBox.Text);
            komut.Parameters.AddWithValue("@Evrak_Gidis_Tarihi",Convert.ToDateTime( dataTimeExpanse.Text));
            komut.Parameters.AddWithValue("@Evrak_Gelis_Tarihi",Convert.ToDateTime( dateTimeIncome.Text));

            komut.ExecuteNonQuery();
            baglatı.Close();

           
        }
    }
}
