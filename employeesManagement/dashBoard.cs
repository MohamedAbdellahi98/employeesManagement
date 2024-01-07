using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeesManagement
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateCountLabel();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error loading data grid view");
            }
        }

        private void empdash_Click(object sender, EventArgs e)
        {
            new EmpDashBoard().Show();
            this.Hide();
        }

        private void perdash_Click(object sender, EventArgs e)
        {
            new PerInfoDashboard().Show();
            this.Hide();

        }

        private void depdash_Click(object sender, EventArgs e)
        {
            new DepDashboard().Show();
            this.Hide();

        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Exit application
                Application.Exit();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error exiting the application");
            }
        }

        private void taskdash_Click(object sender, EventArgs e)
        {
            new TasksDashboard().Show();
            this.Hide();

        }

        // Modify UpdateCountLabel method
        private void UpdateCountLabel()
        {
            try
            {
                con.Open();

                // Count employees
                string countEmployeesQuery = "SELECT COUNT(*) FROM tbl_employees";
                using (cmd = new OleDbCommand(countEmployeesQuery, con))
                {
                    int employeeCount = Convert.ToInt32(cmd.ExecuteScalar());
                    EmployeeCountLab.Text = $"Employees: {employeeCount}";
                }

                // Count tasks
                string countProjectsQuery = "SELECT COUNT(*) FROM tbl_tasks";
                using (cmd = new OleDbCommand(countProjectsQuery, con))
                {
                    int tasksCount = Convert.ToInt32(cmd.ExecuteScalar());
                    TasksCountLab.Text = $"Tasks: {tasksCount}";
                }

                // Count departments
                string countDepartmentsQuery = "SELECT COUNT(*) FROM tbl_departments";
                using (cmd = new OleDbCommand(countDepartmentsQuery, con))
                {
                    int departmentCount = Convert.ToInt32(cmd.ExecuteScalar());
                    DepCountLab.Text = $"Departments: {departmentCount}";
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error updating counts label");
            }
            finally
            {
                DisposeDatabaseResources();
            }
        }

        private void DisposeDatabaseResources()
        {
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }

            if (da != null)
            {
                da.Dispose();
                da = null;
            }

            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                con = null;
            }
        }
    }
}
