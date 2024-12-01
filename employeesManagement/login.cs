using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace employeesManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection("Data Source=db_users.db;Version=3;");

        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtusername.Text + "' and password= '" + txtPassword.Text + "'";
            cmd = new SQLiteCommand(login, con);
            con.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();

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
