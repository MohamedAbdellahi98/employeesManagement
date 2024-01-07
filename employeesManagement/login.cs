using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace employeesManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtusername.Text + "' and password= '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                new dashBoard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

    }
}
