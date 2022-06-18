using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAuthentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frm = new FormSignUp();
            frm.Show();
        }
        SqlConnection baglatı = new SqlConnection("Data Source =DESKTOP-0AV1K5O\\SQLEXPRESS;Initial Catalog = DBArsivOdasi; Integrated Security = True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            baglatı.Open();
            SqlCommand command = new SqlCommand("(select * from tblKisi where FullName='" + txtFullName.Text  + "' and Email='" +txtEmail.Text + "')", baglatı);
            SqlDataReader da = command.ExecuteReader();
            if (da != null)
            {
                if (da.Read())
                {
                    this.Hide();
                    ArchiveProject.Form1 frm = new ArchiveProject.Form1();
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Please enter valid name or e-mail");
                    // You did not find your user. Do what you need to do here.
                }
            }
            else
            {
                MessageBox.Show("Please fill in the blanks");
            }
        }
    }
}
