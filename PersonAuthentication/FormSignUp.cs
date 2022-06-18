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

namespace PersonAuthentication
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            verilerigoster();
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
            {
                genderCheckBox.Text = "Male";
            }
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";
            }
            else
            {
                genderCheckBox.Text = "?";
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");
        private void verilerigoster()
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand("select * from tblKisi", baglatı);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglatı.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand komut = new SqlCommand(" insert into tblKisi (FullName,Email,Phone,Gender) values (@FullName,@Email,@Phone,@Gender) ", baglatı);
            komut.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            komut.Parameters.AddWithValue("@Email", emailTextBox.Text);
            komut.Parameters.AddWithValue("@Phone", phoneTextBox.Text);
            komut.Parameters.AddWithValue("@Gender", genderCheckBox.Text);
            komut.ExecuteNonQuery();
            baglatı.Close();
            verilerigoster();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
